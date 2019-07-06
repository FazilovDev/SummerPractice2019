namespace LeapMotionApplication.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butShow = new System.Windows.Forms.Button();
            this.butFE = new System.Windows.Forms.Button();
            this.butSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(295, 150);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(206, 37);
            this.butShow.TabIndex = 0;
            this.butShow.Text = "ShowFrames";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butFE
            // 
            this.butFE.Location = new System.Drawing.Point(295, 220);
            this.butFE.Name = "butFE";
            this.butFE.Size = new System.Drawing.Size(206, 37);
            this.butFE.TabIndex = 1;
            this.butFE.Text = "First experiment";
            this.butFE.UseVisualStyleBackColor = true;
            this.butFE.Click += new System.EventHandler(this.butFE_Click);
            // 
            // butSE
            // 
            this.butSE.Location = new System.Drawing.Point(295, 290);
            this.butSE.Name = "butSE";
            this.butSE.Size = new System.Drawing.Size(206, 37);
            this.butSE.TabIndex = 2;
            this.butSE.Text = "Second experiment";
            this.butSE.UseVisualStyleBackColor = true;
            this.butSE.Click += new System.EventHandler(this.butSE_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.butSE);
            this.Controls.Add(this.butFE);
            this.Controls.Add(this.butShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeapMotionExperiments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butFE;
        private System.Windows.Forms.Button butSE;
    }
}

