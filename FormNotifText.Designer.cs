namespace Karash_s_Reminder
{
    partial class FormNotifText
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblValueTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblValue.Location = new System.Drawing.Point(44, 55);
            this.lblValue.Name = "lblValue";
            this.lblValue.Padding = new System.Windows.Forms.Padding(0, 0, 100, 40);
            this.lblValue.Size = new System.Drawing.Size(399, 276);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "sample text";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValueTime
            // 
            this.lblValueTime.AutoSize = true;
            this.lblValueTime.BackColor = System.Drawing.Color.Transparent;
            this.lblValueTime.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueTime.ForeColor = System.Drawing.Color.Azure;
            this.lblValueTime.Location = new System.Drawing.Point(138, 14);
            this.lblValueTime.Name = "lblValueTime";
            this.lblValueTime.Size = new System.Drawing.Size(96, 28);
            this.lblValueTime.TabIndex = 2;
            this.lblValueTime.Text = "13:56:55";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Karash_s_Reminder.Properties.Resources._4280527_24;
            this.pictureBox1.Location = new System.Drawing.Point(354, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormNotifText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 154);
            this.Controls.Add(this.lblValueTime);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotifText";
            this.Text = "FormNotifText";
            this.Load += new System.EventHandler(this.FormNotifText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblValueTime;
    }
}