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
    public partial class FormNotifText : Form
    {
        public FormNotifText()
        {
            InitializeComponent();           
        }
        public FormNotifText(string value, string value11)
        {
            InitializeComponent();
            
            this.Value = value;
            //выделение для второй надписи
            this.Value11 = value11;
        }
      
        public string Value { get; set; }
        public string Value11 { get; set; }

        private void FormNotifText_Load(object sender, EventArgs e)
        {
            lblValue.Text = Value;
            lblValueTime.Text = Value11;
            
            int x = Screen.PrimaryScreen.Bounds.Width - Width - 10;
            int y = Screen.PrimaryScreen.WorkingArea.Top + 10;                
            this.Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
