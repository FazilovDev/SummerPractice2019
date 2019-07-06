namespace LeapMotionApplication.Forms
{
    partial class Frames
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
            try
            {
                if (disposing)
                {
                    if (components != null)
                    {
                        components.Dispose();
                    }
                    this.controller.RemoveListener(this.listener);
                    this.controller.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayID = new System.Windows.Forms.TextBox();
            this.displayTimestamp = new System.Windows.Forms.TextBox();
            this.displayFPS = new System.Windows.Forms.TextBox();
            this.displayGestureCount = new System.Windows.Forms.TextBox();
            this.displayIsValid = new System.Windows.Forms.TextBox();
            this.displayImageCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.Location = new System.Drawing.Point(16, 58);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(205, 20);
            this.displayID.TabIndex = 1;
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.Location = new System.Drawing.Point(16, 97);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(205, 20);
            this.displayTimestamp.TabIndex = 2;
            // 
            // displayFPS
            // 
            this.displayFPS.Location = new System.Drawing.Point(16, 136);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(205, 20);
            this.displayFPS.TabIndex = 3;
            // 
            // displayGestureCount
            // 
            this.displayGestureCount.Location = new System.Drawing.Point(16, 214);
            this.displayGestureCount.Name = "displayGestureCount";
            this.displayGestureCount.Size = new System.Drawing.Size(205, 20);
            this.displayGestureCount.TabIndex = 4;
            // 
            // displayIsValid
            // 
            this.displayIsValid.Location = new System.Drawing.Point(16, 175);
            this.displayIsValid.Name = "displayIsValid";
            this.displayIsValid.Size = new System.Drawing.Size(205, 20);
            this.displayIsValid.TabIndex = 5;
            // 
            // displayImageCount
            // 
            this.displayImageCount.Location = new System.Drawing.Point(16, 253);
            this.displayImageCount.Name = "displayImageCount";
            this.displayImageCount.Size = new System.Drawing.Size(205, 20);
            this.displayImageCount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FrameID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Timestamp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IsValid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "GestureCount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ImageCount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data of frame";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(16, 301);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(99, 23);
            this.butStart.TabIndex = 14;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.Enabled = false;
            this.butStop.Location = new System.Drawing.Point(122, 301);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(99, 23);
            this.butStop.TabIndex = 15;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // Frames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayImageCount);
            this.Controls.Add(this.displayIsValid);
            this.Controls.Add(this.displayGestureCount);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frames";
            this.Text = "LeapMotionExperiments";
            this.Load += new System.EventHandler(this.Frames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox displayID;
        private System.Windows.Forms.TextBox displayTimestamp;
        private System.Windows.Forms.TextBox displayFPS;
        private System.Windows.Forms.TextBox displayGestureCount;
        private System.Windows.Forms.TextBox displayIsValid;
        private System.Windows.Forms.TextBox displayImageCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butStop;
    }
}