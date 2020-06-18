namespace Motion_Detection
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.camerasComboBox = new System.Windows.Forms.ComboBox();
            this.videoShowPicBox = new System.Windows.Forms.PictureBox();
            this.startCamBtn = new System.Windows.Forms.Button();
            this.stopCamBtn = new System.Windows.Forms.Button();
            this.MotionLog = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.updateLogBtn = new System.Windows.Forms.Button();
            this.clearLogBtn = new System.Windows.Forms.Button();
            this.motionLogLbl = new System.Windows.Forms.Label();
            this.recordingLbl = new System.Windows.Forms.Label();
            this.recordingTmr = new System.Windows.Forms.Timer(this.components);
            this.blobAreaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfBlobsTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateParametersBtn = new System.Windows.Forms.Button();
            this.ShowMotionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoShowPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // camerasComboBox
            // 
            this.camerasComboBox.FormattingEnabled = true;
            this.camerasComboBox.Location = new System.Drawing.Point(140, 25);
            this.camerasComboBox.Name = "camerasComboBox";
            this.camerasComboBox.Size = new System.Drawing.Size(186, 21);
            this.camerasComboBox.TabIndex = 0;
            // 
            // videoShowPicBox
            // 
            this.videoShowPicBox.BackColor = System.Drawing.Color.White;
            this.videoShowPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoShowPicBox.Location = new System.Drawing.Point(34, 66);
            this.videoShowPicBox.Name = "videoShowPicBox";
            this.videoShowPicBox.Size = new System.Drawing.Size(398, 342);
            this.videoShowPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoShowPicBox.TabIndex = 1;
            this.videoShowPicBox.TabStop = false;
            // 
            // startCamBtn
            // 
            this.startCamBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.startCamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCamBtn.ForeColor = System.Drawing.Color.Azure;
            this.startCamBtn.Location = new System.Drawing.Point(34, 20);
            this.startCamBtn.Name = "startCamBtn";
            this.startCamBtn.Size = new System.Drawing.Size(100, 31);
            this.startCamBtn.TabIndex = 2;
            this.startCamBtn.Text = "Start";
            this.startCamBtn.UseVisualStyleBackColor = false;
            this.startCamBtn.Click += new System.EventHandler(this.StartCamera);
            // 
            // stopCamBtn
            // 
            this.stopCamBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.stopCamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCamBtn.ForeColor = System.Drawing.Color.Azure;
            this.stopCamBtn.Location = new System.Drawing.Point(333, 20);
            this.stopCamBtn.Name = "stopCamBtn";
            this.stopCamBtn.Size = new System.Drawing.Size(99, 31);
            this.stopCamBtn.TabIndex = 2;
            this.stopCamBtn.Text = "Stop";
            this.stopCamBtn.UseVisualStyleBackColor = false;
            this.stopCamBtn.Click += new System.EventHandler(this.stopCam_Click);
            // 
            // MotionLog
            // 
            this.MotionLog.FormattingEnabled = true;
            this.MotionLog.Location = new System.Drawing.Point(465, 66);
            this.MotionLog.Name = "MotionLog";
            this.MotionLog.Size = new System.Drawing.Size(227, 342);
            this.MotionLog.TabIndex = 3;
            this.MotionLog.SelectedValueChanged += new System.EventHandler(this.MotionLog_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(362, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 316);
            this.listBox1.TabIndex = 3;
            // 
            // updateLogBtn
            // 
            this.updateLogBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLogBtn.ForeColor = System.Drawing.Color.Azure;
            this.updateLogBtn.Location = new System.Drawing.Point(465, 419);
            this.updateLogBtn.Name = "updateLogBtn";
            this.updateLogBtn.Size = new System.Drawing.Size(227, 41);
            this.updateLogBtn.TabIndex = 4;
            this.updateLogBtn.Text = "Update Log";
            this.updateLogBtn.UseVisualStyleBackColor = false;
            this.updateLogBtn.Click += new System.EventHandler(this.updateLog_Click);
            // 
            // clearLogBtn
            // 
            this.clearLogBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLogBtn.ForeColor = System.Drawing.Color.Azure;
            this.clearLogBtn.Location = new System.Drawing.Point(465, 466);
            this.clearLogBtn.Name = "clearLogBtn";
            this.clearLogBtn.Size = new System.Drawing.Size(227, 41);
            this.clearLogBtn.TabIndex = 5;
            this.clearLogBtn.Text = "Clear Log";
            this.clearLogBtn.UseVisualStyleBackColor = false;
            this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
            // 
            // motionLogLbl
            // 
            this.motionLogLbl.AutoSize = true;
            this.motionLogLbl.BackColor = System.Drawing.Color.SteelBlue;
            this.motionLogLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motionLogLbl.ForeColor = System.Drawing.Color.Azure;
            this.motionLogLbl.Location = new System.Drawing.Point(464, 23);
            this.motionLogLbl.Name = "motionLogLbl";
            this.motionLogLbl.Size = new System.Drawing.Size(157, 31);
            this.motionLogLbl.TabIndex = 6;
            this.motionLogLbl.Text = "Motion Log";
            // 
            // recordingLbl
            // 
            this.recordingLbl.AutoSize = true;
            this.recordingLbl.BackColor = System.Drawing.Color.White;
            this.recordingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordingLbl.ForeColor = System.Drawing.Color.Red;
            this.recordingLbl.Location = new System.Drawing.Point(40, 69);
            this.recordingLbl.Name = "recordingLbl";
            this.recordingLbl.Size = new System.Drawing.Size(0, 15);
            this.recordingLbl.TabIndex = 7;
            // 
            // recordingTmr
            // 
            this.recordingTmr.Interval = 1000;
            this.recordingTmr.Tick += new System.EventHandler(this.recordingTmr_Tick);
            // 
            // blobAreaTxt
            // 
            this.blobAreaTxt.Location = new System.Drawing.Point(110, 431);
            this.blobAreaTxt.Name = "blobAreaTxt";
            this.blobAreaTxt.Size = new System.Drawing.Size(95, 20);
            this.blobAreaTxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(31, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Blob Area";
            // 
            // numOfBlobsTxt
            // 
            this.numOfBlobsTxt.Location = new System.Drawing.Point(346, 431);
            this.numOfBlobsTxt.Name = "numOfBlobsTxt";
            this.numOfBlobsTxt.Size = new System.Drawing.Size(86, 20);
            this.numOfBlobsTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(215, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number Of Blobs";
            // 
            // updateParametersBtn
            // 
            this.updateParametersBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateParametersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateParametersBtn.ForeColor = System.Drawing.Color.Azure;
            this.updateParametersBtn.Location = new System.Drawing.Point(60, 467);
            this.updateParametersBtn.Name = "updateParametersBtn";
            this.updateParametersBtn.Size = new System.Drawing.Size(183, 38);
            this.updateParametersBtn.TabIndex = 11;
            this.updateParametersBtn.Text = "Update Parameters";
            this.updateParametersBtn.UseVisualStyleBackColor = false;
            this.updateParametersBtn.Click += new System.EventHandler(this.updateParametersBtn_Click);
            // 
            // ShowMotionCheckBox
            // 
            this.ShowMotionCheckBox.AutoSize = true;
            this.ShowMotionCheckBox.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowMotionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMotionCheckBox.ForeColor = System.Drawing.Color.Azure;
            this.ShowMotionCheckBox.Location = new System.Drawing.Point(280, 478);
            this.ShowMotionCheckBox.Name = "ShowMotionCheckBox";
            this.ShowMotionCheckBox.Size = new System.Drawing.Size(118, 21);
            this.ShowMotionCheckBox.TabIndex = 12;
            this.ShowMotionCheckBox.Text = "Show Motion";
            this.ShowMotionCheckBox.UseVisualStyleBackColor = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(728, 523);
            this.Controls.Add(this.ShowMotionCheckBox);
            this.Controls.Add(this.updateParametersBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfBlobsTxt);
            this.Controls.Add(this.blobAreaTxt);
            this.Controls.Add(this.recordingLbl);
            this.Controls.Add(this.motionLogLbl);
            this.Controls.Add(this.clearLogBtn);
            this.Controls.Add(this.updateLogBtn);
            this.Controls.Add(this.MotionLog);
            this.Controls.Add(this.stopCamBtn);
            this.Controls.Add(this.startCamBtn);
            this.Controls.Add(this.videoShowPicBox);
            this.Controls.Add(this.camerasComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Motion Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.videoShowPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox camerasComboBox;
        private System.Windows.Forms.PictureBox videoShowPicBox;
        private System.Windows.Forms.Button startCamBtn;
        private System.Windows.Forms.Button stopCamBtn;
        private System.Windows.Forms.ListBox MotionLog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button updateLogBtn;
        private System.Windows.Forms.Button clearLogBtn;
        private System.Windows.Forms.Label motionLogLbl;
        private System.Windows.Forms.Label recordingLbl;
        private System.Windows.Forms.Timer recordingTmr;
        private System.Windows.Forms.TextBox blobAreaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numOfBlobsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateParametersBtn;
        private System.Windows.Forms.CheckBox ShowMotionCheckBox;
    }
}

