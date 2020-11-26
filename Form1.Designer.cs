namespace Karash_s_Reminder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.realTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reminderTimer = new System.Windows.Forms.Timer(this.components);
            this.underReminderTime = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.underText = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerSW = new System.Windows.Forms.Timer(this.components);
            this.timerCC = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.MaskedTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reminderTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.reminderTextTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reminderTimeMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.reminderTextTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.buttonResetSW = new System.Windows.Forms.Button();
            this.buttonStopSW = new System.Windows.Forms.Button();
            this.buttonStartSW = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.underText2 = new System.Windows.Forms.Label();
            this.underReminderText2 = new System.Windows.Forms.Label();
            this.underReminderTime2 = new System.Windows.Forms.Label();
            this.reminderTimer2 = new System.Windows.Forms.Timer(this.components);
            this.absenceTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNone1 = new System.Windows.Forms.Label();
            this.underReminderText = new System.Windows.Forms.Label();
            this.lblNone2 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // realTimeLabel
            // 
            this.realTimeLabel.AutoSize = true;
            this.realTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.realTimeLabel.Font = new System.Drawing.Font("Calibri", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realTimeLabel.ForeColor = System.Drawing.Color.Teal;
            this.realTimeLabel.Location = new System.Drawing.Point(263, 6);
            this.realTimeLabel.Name = "realTimeLabel";
            this.realTimeLabel.Size = new System.Drawing.Size(179, 54);
            this.realTimeLabel.TabIndex = 0;
            this.realTimeLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(24, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 55);
            this.button1.TabIndex = 35;
            this.button1.Text = "Enable";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(230, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Disable";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reminderTimer
            // 
            this.reminderTimer.Interval = 500;
            this.reminderTimer.Tick += new System.EventHandler(this.reminderTimer_Tick);
            // 
            // underReminderTime
            // 
            this.underReminderTime.AutoSize = true;
            this.underReminderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underReminderTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.underReminderTime.Location = new System.Drawing.Point(399, 573);
            this.underReminderTime.Name = "underReminderTime";
            this.underReminderTime.Size = new System.Drawing.Size(0, 25);
            this.underReminderTime.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Easy Reminder";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 30);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::Karash_s_Reminder.Properties.Resources.close_window_xxl;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(95, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reminders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(405, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Countdown clock";
            // 
            // underText
            // 
            this.underText.AutoSize = true;
            this.underText.Font = new System.Drawing.Font("Rockwell", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underText.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.underText.Location = new System.Drawing.Point(365, 546);
            this.underText.Name = "underText";
            this.underText.Size = new System.Drawing.Size(0, 22);
            this.underText.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(178, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(39, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(192, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seconds";
            // 
            // timerSW
            // 
            this.timerSW.Enabled = true;
            this.timerSW.Interval = 1000;
            this.timerSW.Tick += new System.EventHandler(this.timerSW_Tick);
            // 
            // timerCC
            // 
            this.timerCC.Interval = 1000;
            this.timerCC.Tick += new System.EventHandler(this.timerX_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.ForeColor = System.Drawing.Color.Teal;
            this.btnStart.Location = new System.Drawing.Point(42, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 27);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.ForeColor = System.Drawing.Color.Teal;
            this.btnStop.Location = new System.Drawing.Point(202, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 27);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStoP_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.AllowPromptAsInput = false;
            this.txtTimer.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimer.Font = new System.Drawing.Font("Tahoma", 18.78261F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTimer.ForeColor = System.Drawing.Color.Teal;
            this.txtTimer.Location = new System.Drawing.Point(104, 21);
            this.txtTimer.Mask = "00:00";
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(98, 38);
            this.txtTimer.TabIndex = 25;
            this.txtTimer.Text = "0000";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(123, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 27);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "remind me:";
            // 
            // reminderTimeMaskedTextBox
            // 
            this.reminderTimeMaskedTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.reminderTimeMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reminderTimeMaskedTextBox.Font = new System.Drawing.Font("Calibri Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderTimeMaskedTextBox.ForeColor = System.Drawing.Color.Teal;
            this.reminderTimeMaskedTextBox.Location = new System.Drawing.Point(77, 22);
            this.reminderTimeMaskedTextBox.Mask = "00:00:00";
            this.reminderTimeMaskedTextBox.Name = "reminderTimeMaskedTextBox";
            this.reminderTimeMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reminderTimeMaskedTextBox.Size = new System.Drawing.Size(158, 46);
            this.reminderTimeMaskedTextBox.TabIndex = 1;
            this.reminderTimeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reminderTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // reminderTextTextBox
            // 
            this.reminderTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderTextTextBox.ForeColor = System.Drawing.Color.Teal;
            this.reminderTextTextBox.Location = new System.Drawing.Point(70, 104);
            this.reminderTextTextBox.MaxLength = 28;
            this.reminderTextTextBox.Multiline = true;
            this.reminderTextTextBox.Name = "reminderTextTextBox";
            this.reminderTextTextBox.Size = new System.Drawing.Size(180, 81);
            this.reminderTextTextBox.TabIndex = 3;
            this.reminderTextTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(105, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "remind me:";
            // 
            // reminderTimeMaskedTextBox2
            // 
            this.reminderTimeMaskedTextBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.reminderTimeMaskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reminderTimeMaskedTextBox2.Font = new System.Drawing.Font("Calibri Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderTimeMaskedTextBox2.ForeColor = System.Drawing.Color.Teal;
            this.reminderTimeMaskedTextBox2.Location = new System.Drawing.Point(77, 220);
            this.reminderTimeMaskedTextBox2.Mask = "00:00:00";
            this.reminderTimeMaskedTextBox2.Name = "reminderTimeMaskedTextBox2";
            this.reminderTimeMaskedTextBox2.Size = new System.Drawing.Size(158, 46);
            this.reminderTimeMaskedTextBox2.TabIndex = 12;
            this.reminderTimeMaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reminderTimeMaskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // reminderTextTextBox2
            // 
            this.reminderTextTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderTextTextBox2.ForeColor = System.Drawing.Color.Teal;
            this.reminderTextTextBox2.Location = new System.Drawing.Point(70, 300);
            this.reminderTextTextBox2.MaxLength = 28;
            this.reminderTextTextBox2.Multiline = true;
            this.reminderTextTextBox2.Name = "reminderTextTextBox2";
            this.reminderTextTextBox2.Size = new System.Drawing.Size(180, 81);
            this.reminderTextTextBox2.TabIndex = 3;
            this.reminderTextTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.reminderTextTextBox2);
            this.groupBox1.Controls.Add(this.reminderTimeMaskedTextBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.reminderTextTextBox);
            this.groupBox1.Controls.Add(this.reminderTimeMaskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 406);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 267);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 21);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "#2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 21);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "#1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMin.ForeColor = System.Drawing.Color.Teal;
            this.lbMin.Location = new System.Drawing.Point(111, 18);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(47, 37);
            this.lbMin.TabIndex = 28;
            this.lbMin.Text = "00";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(150, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = ":";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSec.ForeColor = System.Drawing.Color.Teal;
            this.lbSec.Location = new System.Drawing.Point(166, 18);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(47, 37);
            this.lbSec.TabIndex = 30;
            this.lbSec.Text = "00";
            // 
            // buttonResetSW
            // 
            this.buttonResetSW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResetSW.ForeColor = System.Drawing.Color.Teal;
            this.buttonResetSW.Location = new System.Drawing.Point(121, 97);
            this.buttonResetSW.Name = "buttonResetSW";
            this.buttonResetSW.Size = new System.Drawing.Size(80, 27);
            this.buttonResetSW.TabIndex = 37;
            this.buttonResetSW.Text = "Reset";
            this.buttonResetSW.UseVisualStyleBackColor = false;
            this.buttonResetSW.Click += new System.EventHandler(this.buttonResetSW_Click);
            // 
            // buttonStopSW
            // 
            this.buttonStopSW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStopSW.ForeColor = System.Drawing.Color.Teal;
            this.buttonStopSW.Location = new System.Drawing.Point(202, 60);
            this.buttonStopSW.Name = "buttonStopSW";
            this.buttonStopSW.Size = new System.Drawing.Size(80, 27);
            this.buttonStopSW.TabIndex = 36;
            this.buttonStopSW.Text = "Stop";
            this.buttonStopSW.UseVisualStyleBackColor = false;
            this.buttonStopSW.Click += new System.EventHandler(this.buttonStopSW_Click);
            // 
            // buttonStartSW
            // 
            this.buttonStartSW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStartSW.ForeColor = System.Drawing.Color.Teal;
            this.buttonStartSW.Location = new System.Drawing.Point(41, 60);
            this.buttonStartSW.Name = "buttonStartSW";
            this.buttonStartSW.Size = new System.Drawing.Size(80, 27);
            this.buttonStartSW.TabIndex = 35;
            this.buttonStartSW.Text = "Start";
            this.buttonStartSW.UseVisualStyleBackColor = false;
            this.buttonStartSW.Click += new System.EventHandler(this.buttonStartSW_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label14.Location = new System.Drawing.Point(455, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 35);
            this.label14.TabIndex = 38;
            this.label14.Text = "Stopwatch";
            // 
            // underText2
            // 
            this.underText2.AutoSize = true;
            this.underText2.Font = new System.Drawing.Font("Rockwell", 11.89565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underText2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.underText2.Location = new System.Drawing.Point(553, 546);
            this.underText2.Name = "underText2";
            this.underText2.Size = new System.Drawing.Size(0, 22);
            this.underText2.TabIndex = 41;
            // 
            // underReminderText2
            // 
            this.underReminderText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underReminderText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.underReminderText2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.underReminderText2.Location = new System.Drawing.Point(557, 601);
            this.underReminderText2.Name = "underReminderText2";
            this.underReminderText2.Size = new System.Drawing.Size(161, 63);
            this.underReminderText2.TabIndex = 7;
            this.underReminderText2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // underReminderTime2
            // 
            this.underReminderTime2.AutoSize = true;
            this.underReminderTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underReminderTime2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.underReminderTime2.Location = new System.Drawing.Point(586, 573);
            this.underReminderTime2.Name = "underReminderTime2";
            this.underReminderTime2.Size = new System.Drawing.Size(0, 25);
            this.underReminderTime2.TabIndex = 39;
            // 
            // reminderTimer2
            // 
            this.reminderTimer2.Interval = 500;
            this.reminderTimer2.Tick += new System.EventHandler(this.reminderTimer2_Tick);
            // 
            // absenceTimer
            // 
            this.absenceTimer.Enabled = true;
            this.absenceTimer.Interval = 1800000;
            this.absenceTimer.Tick += new System.EventHandler(this.absenceTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.txtTimer);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.groupBox2.Location = new System.Drawing.Point(379, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 224);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStopSW);
            this.groupBox3.Controls.Add(this.buttonStartSW);
            this.groupBox3.Controls.Add(this.buttonResetSW);
            this.groupBox3.Controls.Add(this.lbSec);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbMin);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.groupBox3.Location = new System.Drawing.Point(379, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 141);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(421, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 38);
            this.label3.TabIndex = 51;
            this.label3.Text = "Active reminders";
            // 
            // lblNone1
            // 
            this.lblNone1.AutoSize = true;
            this.lblNone1.Font = new System.Drawing.Font("Calibri Light", 16.27826F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNone1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.lblNone1.Location = new System.Drawing.Point(401, 567);
            this.lblNone1.Name = "lblNone1";
            this.lblNone1.Size = new System.Drawing.Size(83, 35);
            this.lblNone1.TabIndex = 52;
            this.lblNone1.Text = "NONE";
            // 
            // underReminderText
            // 
            this.underReminderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underReminderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.underReminderText.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.underReminderText.Location = new System.Drawing.Point(369, 601);
            this.underReminderText.Name = "underReminderText";
            this.underReminderText.Size = new System.Drawing.Size(161, 63);
            this.underReminderText.TabIndex = 7;
            this.underReminderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNone2
            // 
            this.lblNone2.AutoSize = true;
            this.lblNone2.Font = new System.Drawing.Font("Calibri Light", 16.27826F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.lblNone2.Location = new System.Drawing.Point(592, 567);
            this.lblNone2.Name = "lblNone2";
            this.lblNone2.Size = new System.Drawing.Size(83, 35);
            this.lblNone2.TabIndex = 53;
            this.lblNone2.Text = "NONE";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.ForeColor = System.Drawing.Color.Teal;
            this.checkBox3.Location = new System.Drawing.Point(12, 6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(149, 28);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.Text = "Desktop clock";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(730, 673);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.lblNone2);
            this.Controls.Add(this.lblNone1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.underText2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.underReminderText2);
            this.Controls.Add(this.underReminderTime2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.underText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.underReminderText);
            this.Controls.Add(this.underReminderTime);
            this.Controls.Add(this.realTimeLabel);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label realTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer reminderTimer;
        private System.Windows.Forms.Label underReminderTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label underText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerSW;
        private System.Windows.Forms.Timer timerCC;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.MaskedTextBox txtTimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox reminderTimeMaskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox reminderTimeMaskedTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Button buttonResetSW;
        private System.Windows.Forms.Button buttonStopSW;
        private System.Windows.Forms.Button buttonStartSW;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label underText2;
        private System.Windows.Forms.Label underReminderText2;
        private System.Windows.Forms.Label underReminderTime2;
        private System.Windows.Forms.Timer reminderTimer2;
        private System.Windows.Forms.Timer absenceTimer;
        public System.Windows.Forms.TextBox reminderTextTextBox;
        public System.Windows.Forms.TextBox reminderTextTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNone1;
        private System.Windows.Forms.Label underReminderText;
        private System.Windows.Forms.Label lblNone2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

