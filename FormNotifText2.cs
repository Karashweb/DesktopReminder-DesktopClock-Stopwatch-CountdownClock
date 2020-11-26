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
    public partial class FormNotifText2 : Form
    {
        public FormNotifText2()
        {
            InitializeComponent();
        }
        public FormNotifText2(string value2, string value222)
        {
            InitializeComponent();           
            this.Value2 = value2;
            this.Value222 = value222;
        }
        
        public string Value2 { get; set; }
        public string Value222 { get; set; }

        private void FormNotifText2_Load(object sender, EventArgs e)
        {
            lblValue2.Text = Value2;
            lblValueTime2.Text = Value222;

            int x = Screen.PrimaryScreen.WorkingArea.Left + 10;
            int y = Screen.PrimaryScreen.WorkingArea.Top + 10;
            this.Location = new Point(x, y);

        }
      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


  