namespace LeapMotionApplication.Forms
{
    partial class FirstExperiment
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
            this.startPanel = new System.Windows.Forms.Panel();
            this.butStart = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.timeText = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.textFingers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtext5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtext4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtext3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtext2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtext1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ltext5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ltext4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ltext3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ltext2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ltext1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.butStart);
            this.startPanel.Controls.Add(this.description);
            this.startPanel.Location = new System.Drawing.Point(388, 3);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(369, 157);
            this.startPanel.TabIndex = 0;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(120, 75);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(100, 38);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Начать";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(37, 10);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(281, 52);
            this.description.TabIndex = 0;
            this.description.Text = "Первый эксперимент.\r\nОписание: программа генерирует число пальцев,\r\nкоторое долже" +
    "н показать пользователь, и проверяет\r\nправильно ли он это делает.\r\n";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.timeText);
            this.MainPanel.Controls.Add(this.resultText);
            this.MainPanel.Controls.Add(this.textFingers);
            this.MainPanel.Controls.Add(this.startPanel);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.rtext5);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.rtext4);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.rtext3);
            this.MainPanel.Controls.Add(this.label11);
            this.MainPanel.Controls.Add(this.rtext2);
            this.MainPanel.Controls.Add(this.label13);
            this.MainPanel.Controls.Add(this.rtext1);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.ltext5);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.ltext4);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.ltext3);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.ltext2);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.ltext1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(760, 417);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Location = new System.Drawing.Point(3, 390);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(0, 13);
            this.timeText.TabIndex = 38;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.resultText.Location = new System.Drawing.Point(281, 205);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 20);
            this.resultText.TabIndex = 37;
            this.resultText.Visible = false;
            // 
            // textFingers
            // 
            this.textFingers.AutoSize = true;
            this.textFingers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textFingers.Location = new System.Drawing.Point(22, 289);
            this.textFingers.Name = "textFingers";
            this.textFingers.Size = new System.Drawing.Size(0, 20);
            this.textFingers.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(145, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Мизинец";
            // 
            // rtext5
            // 
            this.rtext5.Location = new System.Drawing.Point(148, 251);
            this.rtext5.Name = "rtext5";
            this.rtext5.Size = new System.Drawing.Size(100, 20);
            this.rtext5.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(145, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Безымянный";
            // 
            // rtext4
            // 
            this.rtext4.Location = new System.Drawing.Point(148, 207);
            this.rtext4.Name = "rtext4";
            this.rtext4.Size = new System.Drawing.Size(100, 20);
            this.rtext4.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(145, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Средний";
            // 
            // rtext3
            // 
            this.rtext3.Location = new System.Drawing.Point(148, 166);
            this.rtext3.Name = "rtext3";
            this.rtext3.Size = new System.Drawing.Size(100, 20);
            this.rtext3.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(145, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Указательный";
            // 
            // rtext2
            // 
            this.rtext2.Location = new System.Drawing.Point(148, 122);
            this.rtext2.Name = "rtext2";
            this.rtext2.Size = new System.Drawing.Size(100, 20);
            this.rtext2.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(145, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Большой";
            // 
            // rtext1
            // 
            this.rtext1.Location = new System.Drawing.Point(148, 81);
            this.rtext1.Name = "rtext1";
            this.rtext1.Size = new System.Drawing.Size(100, 20);
            this.rtext1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.Location = new System.Drawing.Point(144, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Правая рука";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(22, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Мизинец";
            // 
            // ltext5
            // 
            this.ltext5.Location = new System.Drawing.Point(25, 251);
            this.ltext5.Name = "ltext5";
            this.ltext5.Size = new System.Drawing.Size(100, 20);
            this.ltext5.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(22, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Безымянный";
            // 
            // ltext4
            // 
            this.ltext4.Location = new System.Drawing.Point(25, 207);
            this.ltext4.Name = "ltext4";
            this.ltext4.Size = new System.Drawing.Size(100, 20);
            this.ltext4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(22, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Средний";
            // 
            // ltext3
            // 
            this.ltext3.Location = new System.Drawing.Point(25, 166);
            this.ltext3.Name = "ltext3";
            this.ltext3.Size = new System.Drawing.Size(100, 20);
            this.ltext3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(22, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Указательный";
            // 
            // ltext2
            // 
            this.ltext2.Location = new System.Drawing.Point(25, 122);
            this.ltext2.Name = "ltext2";
            this.ltext2.Size = new System.Drawing.Size(100, 20);
            this.ltext2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Большой";
            // 
            // ltext1
            // 
            this.ltext1.Location = new System.Drawing.Point(25, 81);
            this.ltext1.Name = "ltext1";
            this.ltext1.Size = new System.Drawing.Size(100, 20);
            this.ltext1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Левая рука";
            // 
            // FirstExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FirstExperiment";
            this.Text = "FirstExperiment";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rtext5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rtext4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rtext3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rtext2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rtext1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ltext5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ltext4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ltext3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ltext2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ltext1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textFingers;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label timeText;
    }
}