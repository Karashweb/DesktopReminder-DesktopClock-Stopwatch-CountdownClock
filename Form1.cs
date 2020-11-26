using NAudio.SoundFont;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Karash_s_Reminder
{
    public partial class Form1 : Form
    {
        string reminderTime;
        string reminderText;

        string reminderTime2;
        string reminderText2;

        string CurrentTime;

        DialogForm1 dialog = new DialogForm1();

        SoundPlayer player = new SoundPlayer();

        //создание класса для чтения формы, которая будет всплывать со считанным текстом уведомления
        FormNotifText frm = new FormNotifText();
        FormNotifText2 frm2 = new FormNotifText2();

        //функция, передающая набор команд к выполнению при нажатии кнопки
        public void Button1Activate()
        {
            //выдать ошибку, если ввели одно и то же время для обоих уведомлений
            if (reminderTimeMaskedTextBox.Text == reminderTimeMaskedTextBox2.Text)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Please set your notifications to different times, or disable the unwanted notification.",
                "ERROR: same value in both time fields");
            }
            else
            {
                //вводимый текст времени  и текст напоминания идут в строковые переменные (необязательно)
                reminderTime = reminderTimeMaskedTextBox.Text;
                reminderText = reminderTextTextBox.Text;
                reminderTime2 = reminderTimeMaskedTextBox2.Text;
                reminderText2 = reminderTextTextBox2.Text;

                underReminderTime.Text = reminderTime; //отображение введенной инфы(на всякий случай)
                underReminderText.Text = reminderText;
                underReminderTime2.Text = reminderTime2;
                underReminderText2.Text = reminderText2;

                underText.Text = "Reminder #1 set:";
                underText2.Text = "Reminder #2 set:";

                reminderTimer.Start(); //включаем таймер
                reminderTimer2.Start();


                frm.Value = underReminderText.Text;
                frm.Value11 = underReminderTime.Text;

                frm2.Value2 = underReminderText2.Text;
                frm2.Value222 = underReminderTime2.Text;

                SystemSounds.Hand.Play();
                this.Alert("Reminder is active", DialogForm1.enmType.NotificationDone);

            }
         
        }

        public void Button1ActivateVersion2()
        {
            reminderTime = reminderTimeMaskedTextBox.Text;
            reminderText = reminderTextTextBox.Text;
            reminderTime2 = reminderTimeMaskedTextBox2.Text;
            reminderText2 = reminderTextTextBox2.Text;

            underReminderTime.Text = reminderTime;
            underReminderText.Text = reminderText;
            underReminderTime2.Text = reminderTime2;
            underReminderText2.Text = reminderText2;

            underText.Text = "Reminder #1 set:";
            underText2.Text = "Reminder #2 set:";

            reminderTimer.Start(); //включаем таймер
            reminderTimer2.Start();


            frm.Value = underReminderText.Text;
            frm.Value11 = underReminderTime.Text;

            frm2.Value2 = underReminderText2.Text;
            frm2.Value222 = underReminderTime2.Text;

            SystemSounds.Hand.Play();
            this.Alert("Reminder is active", DialogForm1.enmType.NotificationDone);
        }

        public void CleanAllText()
        {
            underReminderTime.Text = "";
            underReminderText.Text = "";
            reminderTextTextBox.Text = "";
            reminderTimeMaskedTextBox.Text = "";
            underText.Text = "";
        }

        //очистка текста дублирующего напоминалку 1, в случае отключения полей первой напоминалки 1
        public void Clean1ForCheckBox1()
        {
            underReminderTime.Text = "";
            underReminderText.Text = "";
            underText.Text = "";
        }

        public void CleanAllText2()
        {
            underReminderTime2.Text = "";
            underReminderText2.Text = "";
            reminderTextTextBox2.Text = "";
            reminderTimeMaskedTextBox2.Text = "";
            underText2.Text = "";
        }

        //очистка текста дублирующего напоминалку 2, в случае отключения полей первой напоминалки 2      
        public void Clean1ForCheckBox2()
        {
            underReminderTime2.Text = "";
            underReminderText2.Text = "";
            underText2.Text = "";
        }

        public Form1()
        {
            InitializeComponent();

            txtTimer.Text = "00:00"; //таймер
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            realTimeLabel.Text = CurrentTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {

                if (reminderTextTextBox.Text.Length == 0 || reminderTextTextBox2.Text.Length == 0)
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Please type your text into the boxes of both notifications, or disable the unwanted notification.",
                    "ERROR: one or both notification boxes are empty");
                }
                else
                {
                    if (reminderTimeMaskedTextBox.Text == reminderTimeMaskedTextBox2.Text)
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Please set your notifications to different times, or disable the unwanted notification.",
                        "ERROR: same value in both time fields");
                    }
                    else
                    {
                        reminderTime = reminderTimeMaskedTextBox.Text;
                        reminderText = reminderTextTextBox.Text;
                        reminderTime2 = reminderTimeMaskedTextBox2.Text;
                        reminderText2 = reminderTextTextBox2.Text;

                        underReminderTime.Text = reminderTime;
                        underReminderText.Text = reminderText;
                        underReminderTime2.Text = reminderTime2;
                        underReminderText2.Text = reminderText2;

                        underText.Text = "Reminder #1 set:";
                        underText2.Text = "Reminder #2 set:";

                        reminderTimer.Start(); //включаем таймер
                        reminderTimer2.Start();

                        frm.Value = underReminderText.Text;
                        frm.Value11 = underReminderTime.Text;

                        frm2.Value2 = underReminderText2.Text;
                        frm2.Value222 = underReminderTime2.Text;

                        SystemSounds.Hand.Play();
                        this.Alert("Reminder is active", DialogForm1.enmType.NotificationDone);
                                              
                        lblNone1.Visible = false;
                        lblNone2.Visible = false;

                        frm.Value = underReminderText.Text;
                        frm.Value11 = underReminderTime.Text;
                    }
                }
            }
            if (checkBox1.Checked == true & checkBox2.Checked == false)
            {

                if (reminderTextTextBox.Text.Length == 0)
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Please enter your notification text.", "ERROR: notification box is empty");
                }
                else
                {

                    if (reminderTimeMaskedTextBox.Text == reminderTimeMaskedTextBox2.Text)
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Notification time is not specified, or it is the same for both notifications",
                        "ERROR: time stamp is in incorrect format.");
                    }
                    else
                    {
                        lblNone1.Visible = false;

                        Button1ActivateVersion2();

                        //указание на то, текст с первого либо второго текстбокса нужно переносить в всплывающее окно
                        frm.Value = underReminderText.Text;
                        frm.Value11 = underReminderTime.Text;

                        Clean1ForCheckBox2();
                    }
                }
            }

            if (checkBox1.Checked == false & checkBox2.Checked == true)
            {

                if (reminderTextTextBox2.Text.Length == 0)
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Please enter your notification text.", "ERROR: notification box is empty");
                }
                else
                {

                    if (reminderTimeMaskedTextBox.Text == reminderTimeMaskedTextBox2.Text)
                    {
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("Notification time is not specified, or it is the same for both notifications",
                        "ERROR: time stamp is in incorrect format.");
                    }
                    else
                    {
                        lblNone2.Visible = false;

                        Button1ActivateVersion2();

                        //указание на то, текст с первого либо второго текстбокса нужно переносить в всплывающее окно
                        frm.Value = underReminderText2.Text;
                        frm.Value11 = underReminderTime.Text;

                        Clean1ForCheckBox1();
                    }
                }
            }
        }

        //для первой напоминалки
        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            if (CurrentTime == reminderTime)
            {
                reminderTimer.Stop();

                player.Stream = Properties.Resources.moonless_5912;
                player.Play(); //проиграть звук, лежащий в настройках проекта               

                frm.TopMost = true;
                frm.ShowDialog();              

                CleanAllText();

                lblNone1.Visible = true;
            }
        }

        //для второй напоминалки
        private void reminderTimer2_Tick(object sender, EventArgs e)
        {
            if (CurrentTime == reminderTime2)
            {
                reminderTimer2.Stop();

                player.Stream = Properties.Resources.moonless_5912;
                player.Play(); //проиграть звук, лежащий в настройках проекта               

                frm2.TopMost = true;
                frm2.ShowDialog();
                

                CleanAllText2();

                lblNone2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reminderTimer.Stop(); //отмена и очистка всей информации
            reminderTimer2.Stop();
            CleanAllText();
            CleanAllText2();
            lblNone1.Visible = true;
            lblNone2.Visible = true;
        }

        //прога разворачивается при двойном клике по значку трея
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            this.TopMost = true;
            //this.BringToFront();

            this.Show();
            
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) //если окно свернуто - значок трея виден
            {
                this.Hide();
                
                this.Alert("Minimized in tray", DialogForm1.enmType.Minimized);

                SystemSounds.Hand.Play();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState) //если окно развернуто - значок трея не виден
            {
                notifyIcon1.Visible = false;
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e) //клик по всплываюшей иконке в трее закрывает программу
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.reminderTimeMaskedTextBox.Enabled = false;
            this.reminderTextTextBox.Enabled = false;
        }

        //заведение переменных для секундомера 
        int timeCs;
        int timeSec;
        int timeMin;
        bool isActive;

        private void Form1_Load(object sender, EventArgs e)
        {
            // поместить числа в comboBox для таймера
            for (int i = 0; i <= 59; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 60; i++)
            {
                this.comboBox2.Items.Add(i.ToString());
            }
            //this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //завод переменных для секундомера 
            ResetTime(); //использование функции обнуления времени
            isActive = false;
            timerSW.Enabled = false; //чтобы счетчик секундомера стоял на месте

            //при загрузке приложения кнопки должны стоять во включенном положении
            checkBox1.Checked = true;
            checkBox2.Checked = true;

            //отключить способность вписывать что-либо в окно чисел таймера
            txtTimer.ReadOnly = true;

            //включить/выключить экранные часы
            if (checkBox3.Checked == true)
            {
                clockShow.Show();
            }
            if (checkBox3.Checked == false)
            {
                clockShow.Hide();
            }
        }

        //предотвращает прямой ввод чисел в комбобоксы с клавиатуры (в противном случае программа бы вылетела)
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        int timeLeft;

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Convert text to seconds as int for timer
            string[] totalSeconds = txtTimer.Text.Split(':');

            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Please specify the minutes and seconds for the countdown clock.",
                    "ERROR: No numbers are given");
            }
            else
            {
                int minutes = int.Parse(this.comboBox1.SelectedItem.ToString());
                int seconds = int.Parse(this.comboBox2.SelectedItem.ToString());

                timeLeft = (minutes * 60) + seconds;

                // Lock Start and Clear buttons and text box
                btnStart.Enabled = false;
                btnReset.Enabled = false;

                // start timer
                timerCC.Start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            txtTimer.Text = "00:00";
        }

        private void timerX_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

                // Display time remaining as mm:ss
                var timespan = TimeSpan.FromSeconds(timeLeft);

                txtTimer.Text = timespan.ToString(@"mm\:ss");
            }
            else
            {
                timerCC.Stop();
                this.Alert("Countdown is over", DialogForm1.enmType.CoundownClockDone);
                SystemSounds.Hand.Play();


                btnStart.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void BtnStoP_Click(object sender, EventArgs e)
        {
            timeLeft = 0;
            timerCC.Stop();

            btnStart.Enabled = false;
            btnReset.Enabled = true;
        }

        private void buttonStartSW_Click(object sender, EventArgs e)
        {
            timerSW.Enabled = true;
            buttonStartSW.Enabled = false;
            buttonResetSW.Enabled = false;
        }

        private void buttonResetSW_Click(object sender, EventArgs e)
        {
            timerSW.Enabled = false;
            ResetTime();

            //обнуление отображаемых цифр
            lbMin.Text = "00";
            lbSec.Text = "00";
            //lbSc.Text = "00";
        }

        private void buttonStopSW_Click(object sender, EventArgs e)
        {
            timerSW.Enabled = false;
            buttonStartSW.Enabled = true;
            buttonResetSW.Enabled = true;
        }

        private void ResetTime() //функция, содержащая в себе обнуление времени
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timerSW_Tick(object sender, EventArgs e)
        {
            if (timerSW.Enabled == true)
            {                                              
                    timeSec++;
                    //timeCs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }               
            }
            DrawTime();
        }

        public void DrawTime()
        {
            //lbSc.Text = String.Format("{0:00}", timeCs);
            lbSec.Text = String.Format("{0:00}", timeSec);
            lbMin.Text = String.Format("{0:00}", timeMin);
        }

        //код для кнопок включения и выключения окон задавания уведомлений 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                reminderTextTextBox.Enabled = true;
                reminderTimeMaskedTextBox.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                reminderTextTextBox.Enabled = false;
                reminderTimeMaskedTextBox.Enabled = false;

                reminderTimer.Stop(); //выключаем таймер времени, если он включен
                Clean1ForCheckBox1(); //убираем надписи дублирующие напоминалку
            }

            //код выключает кнопки, если оба окна задавания уведомлений отключены + отменяет таймер
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                button1.Enabled = false;
                button2.Enabled = false;

                reminderTimer.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                reminderTextTextBox2.Enabled = true;
                reminderTimeMaskedTextBox2.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                reminderTextTextBox2.Enabled = false;
                reminderTimeMaskedTextBox2.Enabled = false;

                reminderTimer.Stop(); //выключаем таймер времени, если он включен
                Clean1ForCheckBox2(); //убираем надписи дублирующие напоминалку
            }

            //код выключает кнопки, если оба окна задавания уведомлений отключены
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                button1.Enabled = false;
                button2.Enabled = false;

                reminderTimer.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }

        //если отсутствуют активные запросы на уведомление при хотя бы одном включенном окне
        //будет выскакивать уведомление раз в 30мин о том, что не стоит ни одно уведомление
        private void absenceTimer_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked != false || checkBox2.Checked != false)
            {
                if (checkBox1.Checked != false & underText.Text.Length == 0 || checkBox2.Checked != false & underText2.Text.Length == 0)
                {
                    this.Alert("No active notifications", DialogForm1.enmType.NotifAbsent);
                    SystemSounds.Exclamation.Play();
                }

            }
        }

        public void Alert(string msg, DialogForm1.enmType type)
        {
            DialogForm1 frm = new DialogForm1();
            frm.showAlert(msg, type);
        }

        ClockDT clockShow = new ClockDT();

        //включить/выключить экранные часы
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                clockShow.Show();
                
                //убрать иконку этого окна с панели "пуск"
                
            }
            if (checkBox3.Checked == false)
            {
                clockShow.Hide();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}


