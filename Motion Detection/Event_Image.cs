using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motion_Detection
{
    public partial class Event_Image : Form
    {
        int id;
        public List<Bitmap> list;
        public Event_Image()
        {
            InitializeComponent();
            id = 0;
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(id >= list.Count)
            {
                timer1.Stop();
                return;
            }
            pictureBox1.Image = new Bitmap(list[id++], 398, 342);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            id = 0;
            timer1.Start();
        }

    }
}
