using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Media;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading.Tasks;

namespace Motion_Detection
{
    public partial class Main_Form : Form
    {
        FilterInfoCollection Sources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice Camera = new VideoCaptureDevice();
        Bitmap PreFrame;
        GrayscaleY GrayFilter = new GrayscaleY();
        Difference DiffFilter = new Difference();
        Threshold ThreFilter = new Threshold(10);
        Pixellate PixFilter = new Pixellate();
        BlobCounter BlobsFilter = new BlobCounter();
        MoveTowards MoveTowardsFilter = new MoveTowards();

        List<DateTime> events = new List<DateTime>();
        List<Bitmap> eventimages = new List<Bitmap>();
        List<int> ids = new List<int>();

        DateTime last = DateTime.Now;
        long lastPlaying;
        private int blobArea;
        private int numOfBlobs;

        SoundPlayer player;


        public Main_Form()
        {
            InitializeComponent();
            foreach (FilterInfo source in Sources)
            {
                camerasComboBox.Items.Add(source.Name);
            }
            if (camerasComboBox.Items.Count != 0)
            {
                camerasComboBox.SelectedIndex = 0;
            }
            char c = (char)7;
            recordingLbl.Visible = false;
            recordingLbl.Text = c + " Recording";
            blobArea = 0;
            numOfBlobs = 1;
            player = new SoundPlayer("Alert.wav");
            lastPlaying = timeOfYear(DateTime.Now)-2000;
        }

        private void StartCamera(object sender, EventArgs e)
        {
            StopCamera();
            int ind = camerasComboBox.SelectedIndex;
            string ID = Sources[ind].MonikerString;
            Camera = new VideoCaptureDevice(ID);
            Camera.NewFrame += GetFrame;
            Camera.Start();
            recordingTmr.Start();
        }

        void StopCamera()
        {
            if (Camera != null && Camera.IsRunning)
            {
                Camera.Stop();
                Camera = null;
            }
            recordingTmr.Stop();
            recordingLbl.Visible = false;
        }

        void GetFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap frame = new Bitmap(e.Frame, videoShowPicBox.Width, videoShowPicBox.Height);
            Graphics graph = Graphics.FromImage(frame);
            Pen pen = new Pen(Color.Yellow, 2);
            graph.DrawRectangle(pen, new Rectangle(3, 3, 50, 50));
        
            videoShowPicBox.Image = frame;
            /*
            if (MotionDetection(frame) >= numOfBlobs)
            {
                StartPlayer();
                events.Add(DateTime.Now);
                eventimages.Add(frame);
            }
            */
        }

        void StartPlayer()
        {
            if (timeOfYear(DateTime.Now)-lastPlaying < 2000)
                return;
            lastPlaying = timeOfYear(DateTime.Now);
            player.Play();
        }

        int MotionDetection(Bitmap CurrentFrame)
        {
            if (PreFrame == null)
            {
                PreFrame = GrayFilter.Apply(CurrentFrame);
                PixFilter.ApplyInPlace(PreFrame);
                return 0;
            }

            Bitmap ProcFrame = GrayFilter.Apply(CurrentFrame);
            PixFilter.ApplyInPlace(ProcFrame);

            MoveTowardsFilter.StepSize = 1;
            MoveTowardsFilter.OverlayImage = ProcFrame;
            MoveTowardsFilter.ApplyInPlace(PreFrame);

            DiffFilter.OverlayImage = PreFrame;
            Bitmap DiffImage = DiffFilter.Apply(ProcFrame);
            ThreFilter.ApplyInPlace(DiffImage);

            BlobsFilter.ProcessImage(DiffImage);
            Blob[] Blobs = BlobsFilter.GetObjectsInformation();

            int ret = 0;

            if (Blobs.Length != 0)
            {
                Graphics graph = Graphics.FromImage(CurrentFrame);
                Pen pen = new Pen(Color.Yellow, 2);
                graph.DrawRectangle(pen, new Rectangle(3,3,10,10));
                foreach (Blob item in Blobs)
                {
                    if (item.Area > blobArea)
                    {
                        if (ShowMotionCheckBox.Checked)
                        {
                            graph.DrawRectangle(pen, item.Rectangle);
                        }
                        ++ret;
                    }
                }
            }

            videoShowPicBox.Image = CurrentFrame;

            PreFrame = ProcFrame;

            return ret;
        }

        private void stopCam_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void updateLog_Click(object sender, EventArgs e)
        {
            MotionLog.Items.Clear();
            ids.Clear();
            long last = -300;
            int id = 0;
            foreach (DateTime item in events)
            {
                if (timeOfYear(item) - last > 200)
                {
                    MotionLog.Items.Add(item.ToString());
                    ids.Add(id);
                }
                last = timeOfYear(item);
                ++id;
            }
        }

        private void MotionLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MotionLog.SelectedIndex < 0 || MotionLog.SelectedIndex >= MotionLog.Items.Count)
                return;
            Event_Image frm = new Event_Image();
            int st = ids[MotionLog.SelectedIndex];
            int en;
            if (ids.Count > MotionLog.SelectedIndex + 1)
                en = ids[MotionLog.SelectedIndex + 1];
            else
                en = 100000000;
            frm.list = eventimages.GetRange(st, Math.Max(Math.Min(en,eventimages.Count) - st,0));
            frm.Show();
        }

        private void clearLogBtn_Click(object sender, EventArgs e)
        {
            events.Clear();
            eventimages.Clear();
            MotionLog.Items.Clear();
            ids.Clear();
        }

        private void recordingTmr_Tick(object sender, EventArgs e)
        {
            recordingLbl.Visible = !recordingLbl.Visible;
        }

        private long timeOfYear(DateTime x)
        {
            long f, tmp;
            f = 0;
            tmp = 1;
            f += tmp * x.Millisecond;
            tmp *= 1000;
            f += tmp * x.Second;
            tmp *= 60;
            f += tmp * x.Minute;
            tmp *= 60;
            f += tmp * x.Hour;
            tmp *= 24;
            f += tmp * x.DayOfYear;
            tmp *= 366;
            f += tmp * x.Year;
            return f;
        }

        private void updateParametersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                numOfBlobs = int.Parse(numOfBlobsTxt.Text.ToString());
                blobArea = int.Parse(blobAreaTxt.Text.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter Integer Numbers only !!");
            }
        }

    }
}


/*
References :

http://www.aforgenet.com/framework/docs/html/d7196dc6-8176-4344-a505-e7ade35c1741.htm
http://www.aforgenet.com/framework/docs/html/f7f4ad2c-fb50-a76b-38fc-26355e0eafcf.htm
http://www.aforgenet.com/framework/docs/html/b0c68216-a91a-5d40-b551-fa45674a77fb.htm
http://www.aforgenet.com/framework/docs/html/503a43b9-d98b-a19f-b74e-44767916ad65.htm
http://www.aforgenet.com/framework/docs/html/d7d5c028-7a23-e27d-ffd0-5df57cbd31a6.htm

*/