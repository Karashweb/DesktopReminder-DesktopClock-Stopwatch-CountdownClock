namespace Karash_s_Reminder
{
    partial class FormNotifText2
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
            this.lblValueTime2 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValueTime2
            // 
            this.lblValueTime2.AutoSize = true;
            this.lblValueTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblValueTime2.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTime2.ForeColor = System.Drawing.Color.Azure;
            this.lblValueTime2.Location = new System.Drawing.Point(138, 14);
            this.lblValueTime2.Name = "lblValueTime2";
            this.lblValueTime2.Size = new System.Drawing.Size(96, 28);
            this.lblValueTime2.TabIndex = 3;
            this.lblValueTime2.Text = "13:56:55";
            // 
            // lblValue2
            // 
            this.lblValue2.BackColor = System.Drawing.Color.Transparent;
            this.lblValue2.Font = new System.Drawing.Font("Century Gothic", 16.27826F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue2.ForeColor = System.Drawing.Color.White;
            this.lblValue2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblValue2.Location = new System.Drawing.Point(44, 55);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Padding = new System.Windows.Forms.Padding(0, 0, 100, 40);
            this.lblValue2.Size = new System.Drawing.Size(399, 276);
            this.lblValue2.TabIndex = 4;
            this.lblValue2.Text = "sample text";
            this.lblValue2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Karash_s_Reminder.Properties.Resources._4280527_24;
            this.pictureBox2.Location = new System.Drawing.Point(354, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 36);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormNotifText2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 154);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValueTime2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotifText2";
            this.Text = "FormNotifText2";
            this.Load += new System.EventHandler(this.FormNotifText2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblValueTime2;
        private System.Windows.Forms.Label lblValue2;
    }
}