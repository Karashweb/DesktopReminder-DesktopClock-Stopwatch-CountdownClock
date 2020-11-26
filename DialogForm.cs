using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karash_s_Reminder
{
    public partial class DialogForm1 : Form
    {
        public DialogForm1()
        {
            InitializeComponent();
        }

        //убирает окно из поля видимости меню Alt + Tab
        protected override CreateParams CreateParams
        {
            get
            {
                var Params = base.CreateParams;
                Params.ExStyle |= 0x80;

                return Params;
            }
        }

        private void DialogForm_Load(object sender, EventArgs e) //позиция окна указывается в коде самого окна 
        {       
            this.TopMost = true;          
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
          
        public enum enmAction
        {
            wait,
            start,
            close
        }       
       
        public enum enmType
        {
            NotificationDone,
            CoundownClockDone,           
            NotifAbsent,
            Minimized
        }      
                
        private DialogForm1.enmAction action;

        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
       
        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alarm" + i.ToString();
                DialogForm1 frm = (DialogForm1)Application.OpenForms[fname];
                if (frm == null)
                { 
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
           
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.lbMsg.Text = msg;

            this.Show();
            
            this.action = enmAction.start;
            
            this.timer1.Interval = 1;
            
            timer1.Start();
                      
            switch (type)
            {
                case enmType.NotificationDone:
                    this.pictureBox1.Image = Properties.Resources.OK64;
                    pictureBox1.BackColor = Color.Transparent;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.CoundownClockDone:
                    this.pictureBox1.Image = Properties.Resources.ClockImage;
                    this.BackColor = Color.RoyalBlue;
                    pictureBox1.BackColor = Color.Transparent;
                    break;               
                case enmType.NotifAbsent:
                    this.pictureBox1.Image = Properties.Resources.WarningAbsence;
                    pictureBox1.BackColor = Color.Transparent;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Minimized:
                    this.pictureBox1.Image = Properties.Resources.minimize;
                    pictureBox1.BackColor = Color.Transparent;
                    this.BackColor = Color.LightSeaGreen;
                    break;

            }                
        }
    }
}
