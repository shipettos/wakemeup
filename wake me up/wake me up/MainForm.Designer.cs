namespace wake_me_up
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.cmdalarm = new System.Windows.Forms.Button();
            this.cmdtimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.AlarmTab = new System.Windows.Forms.TabPage();
            this.hoursnow = new System.Windows.Forms.Label();
            this.minsnow = new System.Windows.Forms.Label();
            this.alarmMin = new System.Windows.Forms.ComboBox();
            this.alarmHour = new System.Windows.Forms.ComboBox();
            this.TimerTab = new System.Windows.Forms.TabPage();
            this.timerMin = new System.Windows.Forms.ComboBox();
            this.timerHour = new System.Windows.Forms.ComboBox();
            this.FileChoser = new System.Windows.Forms.Button();
            this.txtfileInput = new System.Windows.Forms.TextBox();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pageLink = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timesUsedTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesUsedAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.AlarmList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AlarmSound = new System.Windows.Forms.GroupBox();
            this.Sound = new System.Windows.Forms.GroupBox();
            this.RBYoutube = new System.Windows.Forms.RadioButton();
            this.RBDefaltSound = new System.Windows.Forms.RadioButton();
            this.RBLocalSound = new System.Windows.Forms.RadioButton();
            this.MoreOptions = new System.Windows.Forms.GroupBox();
            this.CBComment = new System.Windows.Forms.CheckBox();
            this.CBWmp = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.WMPControl = new AxWMPLib.AxWindowsMediaPlayer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LoopTimer = new System.Windows.Forms.Timer(this.components);
            this.lblYoutube = new System.Windows.Forms.Label();
            this.txtYoutube = new System.Windows.Forms.TextBox();
            this.cmdcheck = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GBUrl = new System.Windows.Forms.GroupBox();
            this.txtcomment2 = new System.Windows.Forms.TextBox();
            this.MainTab.SuspendLayout();
            this.AlarmTab.SuspendLayout();
            this.TimerTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.AlarmSound.SuspendLayout();
            this.Sound.SuspendLayout();
            this.MoreOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMPControl)).BeginInit();
            this.GBUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdalarm
            // 
            this.cmdalarm.Location = new System.Drawing.Point(33, 119);
            this.cmdalarm.Name = "cmdalarm";
            this.cmdalarm.Size = new System.Drawing.Size(75, 23);
            this.cmdalarm.TabIndex = 2;
            this.cmdalarm.Text = "&Start Alarm";
            this.cmdalarm.UseVisualStyleBackColor = true;
            this.cmdalarm.Click += new System.EventHandler(this.cmdalarm_Click);
            // 
            // cmdtimer
            // 
            this.cmdtimer.Location = new System.Drawing.Point(33, 119);
            this.cmdtimer.Name = "cmdtimer";
            this.cmdtimer.Size = new System.Drawing.Size(75, 23);
            this.cmdtimer.TabIndex = 3;
            this.cmdtimer.Text = "&Start Timer";
            this.cmdtimer.UseVisualStyleBackColor = true;
            this.cmdtimer.Click += new System.EventHandler(this.cmdtimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(223, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alarm - Timer Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Time (hh/mm) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Time (hh/mm) :";
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.AlarmTab);
            this.MainTab.Controls.Add(this.TimerTab);
            this.MainTab.Location = new System.Drawing.Point(0, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(222, 172);
            this.MainTab.TabIndex = 7;
            this.MainTab.Click += new System.EventHandler(this.MainTab_Click);
            // 
            // AlarmTab
            // 
            this.AlarmTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AlarmTab.Controls.Add(this.hoursnow);
            this.AlarmTab.Controls.Add(this.minsnow);
            this.AlarmTab.Controls.Add(this.alarmMin);
            this.AlarmTab.Controls.Add(this.alarmHour);
            this.AlarmTab.Controls.Add(this.cmdalarm);
            this.AlarmTab.Controls.Add(this.label3);
            this.AlarmTab.Location = new System.Drawing.Point(4, 22);
            this.AlarmTab.Name = "AlarmTab";
            this.AlarmTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlarmTab.Size = new System.Drawing.Size(214, 146);
            this.AlarmTab.TabIndex = 0;
            this.AlarmTab.Text = "Alarm";
            // 
            // hoursnow
            // 
            this.hoursnow.AutoSize = true;
            this.hoursnow.Location = new System.Drawing.Point(376, 73);
            this.hoursnow.Name = "hoursnow";
            this.hoursnow.Size = new System.Drawing.Size(0, 13);
            this.hoursnow.TabIndex = 10;
            // 
            // minsnow
            // 
            this.minsnow.AutoSize = true;
            this.minsnow.Location = new System.Drawing.Point(417, 73);
            this.minsnow.Name = "minsnow";
            this.minsnow.Size = new System.Drawing.Size(0, 13);
            this.minsnow.TabIndex = 9;
            // 
            // alarmMin
            // 
            this.alarmMin.FormattingEnabled = true;
            this.alarmMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.alarmMin.Location = new System.Drawing.Point(164, 35);
            this.alarmMin.Name = "alarmMin";
            this.alarmMin.Size = new System.Drawing.Size(40, 21);
            this.alarmMin.TabIndex = 8;
            this.alarmMin.Text = "1";
            // 
            // alarmHour
            // 
            this.alarmHour.FormattingEnabled = true;
            this.alarmHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.alarmHour.Location = new System.Drawing.Point(118, 35);
            this.alarmHour.Name = "alarmHour";
            this.alarmHour.Size = new System.Drawing.Size(40, 21);
            this.alarmHour.TabIndex = 7;
            this.alarmHour.Text = "1";
            // 
            // TimerTab
            // 
            this.TimerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimerTab.Controls.Add(this.timerMin);
            this.TimerTab.Controls.Add(this.timerHour);
            this.TimerTab.Controls.Add(this.label2);
            this.TimerTab.Controls.Add(this.cmdtimer);
            this.TimerTab.Location = new System.Drawing.Point(4, 22);
            this.TimerTab.Name = "TimerTab";
            this.TimerTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimerTab.Size = new System.Drawing.Size(214, 146);
            this.TimerTab.TabIndex = 1;
            this.TimerTab.Text = "Timer";
            // 
            // timerMin
            // 
            this.timerMin.FormattingEnabled = true;
            this.timerMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.timerMin.Location = new System.Drawing.Point(164, 35);
            this.timerMin.Name = "timerMin";
            this.timerMin.Size = new System.Drawing.Size(40, 21);
            this.timerMin.TabIndex = 9;
            this.timerMin.Text = "1";
            // 
            // timerHour
            // 
            this.timerHour.FormattingEnabled = true;
            this.timerHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.timerHour.Location = new System.Drawing.Point(118, 35);
            this.timerHour.Name = "timerHour";
            this.timerHour.Size = new System.Drawing.Size(40, 21);
            this.timerHour.TabIndex = 8;
            this.timerHour.Text = "1";
            // 
            // FileChoser
            // 
            this.FileChoser.Location = new System.Drawing.Point(6, 106);
            this.FileChoser.Name = "FileChoser";
            this.FileChoser.Size = new System.Drawing.Size(75, 23);
            this.FileChoser.TabIndex = 8;
            this.FileChoser.Text = "&Choose File";
            this.toolTip1.SetToolTip(this.FileChoser, "Select a local sound file (AAC, MP3)");
            this.FileChoser.UseVisualStyleBackColor = true;
            this.FileChoser.Click += new System.EventHandler(this.FileChoser_Click);
            // 
            // txtfileInput
            // 
            this.txtfileInput.Enabled = false;
            this.txtfileInput.Location = new System.Drawing.Point(85, 106);
            this.txtfileInput.Name = "txtfileInput";
            this.txtfileInput.Size = new System.Drawing.Size(168, 20);
            this.txtfileInput.TabIndex = 9;
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Interval = 5000;
            this.AlarmTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pageLink
            // 
            this.pageLink.AutoSize = true;
            this.pageLink.Location = new System.Drawing.Point(524, 327);
            this.pageLink.Name = "pageLink";
            this.pageLink.Size = new System.Drawing.Size(119, 13);
            this.pageLink.TabIndex = 11;
            this.pageLink.TabStop = true;
            this.pageLink.Text = "A + C Potami - Products";
            this.toolTip1.SetToolTip(this.pageLink, "Link to our Facebook Webpage");
            this.pageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pageLink_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAlarmToolStripMenuItem,
            this.startTimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.timesUsedTToolStripMenuItem,
            this.timesUsedAToolStripMenuItem,
            this.totalUsageToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // startAlarmToolStripMenuItem
            // 
            this.startAlarmToolStripMenuItem.Name = "startAlarmToolStripMenuItem";
            this.startAlarmToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.startAlarmToolStripMenuItem.Text = "&Start Alarm";
            this.startAlarmToolStripMenuItem.Click += new System.EventHandler(this.cmdalarm_Click);
            // 
            // startTimerToolStripMenuItem
            // 
            this.startTimerToolStripMenuItem.Name = "startTimerToolStripMenuItem";
            this.startTimerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.startTimerToolStripMenuItem.Text = "&Start Timer";
            this.startTimerToolStripMenuItem.Click += new System.EventHandler(this.cmdtimer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // timesUsedTToolStripMenuItem
            // 
            this.timesUsedTToolStripMenuItem.Name = "timesUsedTToolStripMenuItem";
            this.timesUsedTToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.timesUsedTToolStripMenuItem.Text = "&Times used (T)";
            this.timesUsedTToolStripMenuItem.Click += new System.EventHandler(this.timesUsedTToolStripMenuItem_Click);
            // 
            // timesUsedAToolStripMenuItem
            // 
            this.timesUsedAToolStripMenuItem.Name = "timesUsedAToolStripMenuItem";
            this.timesUsedAToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.timesUsedAToolStripMenuItem.Text = "&Times used (A)";
            this.timesUsedAToolStripMenuItem.Click += new System.EventHandler(this.timesUsedAToolStripMenuItem_Click);
            // 
            // totalUsageToolStripMenuItem
            // 
            this.totalUsageToolStripMenuItem.Name = "totalUsageToolStripMenuItem";
            this.totalUsageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.totalUsageToolStripMenuItem.Text = "&Total Usage";
            this.totalUsageToolStripMenuItem.Click += new System.EventHandler(this.totalUsageToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem,
            this.backColorToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.changeFontToolStripMenuItem.Text = "&Change Font";
            this.changeFontToolStripMenuItem.ToolTipText = "Change the font of the program";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabsToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.backColorToolStripMenuItem.Text = "&BackColor of...";
            this.backColorToolStripMenuItem.ToolTipText = "Change the color of your desire object";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tabsToolStripMenuItem.Text = "&Tabs";
            this.tabsToolStripMenuItem.Click += new System.EventHandler(this.tabsToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "&Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // AlarmList
            // 
            this.AlarmList.FormattingEnabled = true;
            this.AlarmList.Items.AddRange(new object[] {
            "Minions - Banana",
            "Minions - Fire Alarm",
            "Rock Alarm",
            "Classic Alarm"});
            this.AlarmList.Location = new System.Drawing.Point(6, 42);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(103, 82);
            this.AlarmList.TabIndex = 13;
            this.toolTip1.SetToolTip(this.AlarmList, "Some default sounds");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Default Sounds";
            // 
            // AlarmSound
            // 
            this.AlarmSound.Controls.Add(this.AlarmList);
            this.AlarmSound.Controls.Add(this.label4);
            this.AlarmSound.Location = new System.Drawing.Point(228, 49);
            this.AlarmSound.Name = "AlarmSound";
            this.AlarmSound.Size = new System.Drawing.Size(122, 150);
            this.AlarmSound.TabIndex = 17;
            this.AlarmSound.TabStop = false;
            this.AlarmSound.Text = "Alarm Sound";
            // 
            // Sound
            // 
            this.Sound.Controls.Add(this.RBYoutube);
            this.Sound.Controls.Add(this.RBDefaltSound);
            this.Sound.Controls.Add(this.RBLocalSound);
            this.Sound.Location = new System.Drawing.Point(356, 49);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(131, 95);
            this.Sound.TabIndex = 18;
            this.Sound.TabStop = false;
            this.Sound.Text = "Sound";
            // 
            // RBYoutube
            // 
            this.RBYoutube.AutoSize = true;
            this.RBYoutube.Location = new System.Drawing.Point(7, 68);
            this.RBYoutube.Name = "RBYoutube";
            this.RBYoutube.Size = new System.Drawing.Size(110, 17);
            this.RBYoutube.TabIndex = 2;
            this.RBYoutube.TabStop = true;
            this.RBYoutube.Text = "Use Youtube Link";
            this.toolTip1.SetToolTip(this.RBYoutube, "You can use a youtube link");
            this.RBYoutube.UseVisualStyleBackColor = true;
            this.RBYoutube.CheckedChanged += new System.EventHandler(this.RBYoutube_CheckedChanged);
            // 
            // RBDefaltSound
            // 
            this.RBDefaltSound.AutoSize = true;
            this.RBDefaltSound.Checked = true;
            this.RBDefaltSound.Location = new System.Drawing.Point(6, 19);
            this.RBDefaltSound.Name = "RBDefaltSound";
            this.RBDefaltSound.Size = new System.Drawing.Size(120, 17);
            this.RBDefaltSound.TabIndex = 1;
            this.RBDefaltSound.TabStop = true;
            this.RBDefaltSound.Text = "Use Default Sounds";
            this.toolTip1.SetToolTip(this.RBDefaltSound, "You can use the default sounds");
            this.RBDefaltSound.UseVisualStyleBackColor = true;
            this.RBDefaltSound.CheckedChanged += new System.EventHandler(this.RBTab_CheckedChanged);
            // 
            // RBLocalSound
            // 
            this.RBLocalSound.AutoSize = true;
            this.RBLocalSound.Location = new System.Drawing.Point(7, 42);
            this.RBLocalSound.Name = "RBLocalSound";
            this.RBLocalSound.Size = new System.Drawing.Size(118, 17);
            this.RBLocalSound.TabIndex = 0;
            this.RBLocalSound.TabStop = true;
            this.RBLocalSound.Text = "Select Local Sound";
            this.toolTip1.SetToolTip(this.RBLocalSound, "You can use a local song");
            this.RBLocalSound.UseVisualStyleBackColor = true;
            this.RBLocalSound.CheckedChanged += new System.EventHandler(this.RBRec_CheckedChanged);
            // 
            // MoreOptions
            // 
            this.MoreOptions.Controls.Add(this.CBComment);
            this.MoreOptions.Controls.Add(this.CBWmp);
            this.MoreOptions.Location = new System.Drawing.Point(493, 52);
            this.MoreOptions.Name = "MoreOptions";
            this.MoreOptions.Size = new System.Drawing.Size(150, 92);
            this.MoreOptions.TabIndex = 19;
            this.MoreOptions.TabStop = false;
            this.MoreOptions.Text = "More Options";
            // 
            // CBComment
            // 
            this.CBComment.AutoSize = true;
            this.CBComment.Location = new System.Drawing.Point(7, 44);
            this.CBComment.Name = "CBComment";
            this.CBComment.Size = new System.Drawing.Size(142, 17);
            this.CBComment.TabIndex = 1;
            this.CBComment.Text = "Show Comment TextBox";
            this.toolTip1.SetToolTip(this.CBComment, "Shows the comment text box, useful for reminders");
            this.CBComment.UseVisualStyleBackColor = true;
            this.CBComment.CheckedChanged += new System.EventHandler(this.CBComment_CheckedChanged);
            // 
            // CBWmp
            // 
            this.CBWmp.AutoSize = true;
            this.CBWmp.Location = new System.Drawing.Point(7, 20);
            this.CBWmp.Name = "CBWmp";
            this.CBWmp.Size = new System.Drawing.Size(124, 17);
            this.CBWmp.TabIndex = 0;
            this.CBWmp.Text = "Show WMP Controls";
            this.toolTip1.SetToolTip(this.CBWmp, "Showing the Windows Media Player Controls");
            this.CBWmp.UseVisualStyleBackColor = true;
            this.CBWmp.CheckedChanged += new System.EventHandler(this.CBWmp_CheckedChanged);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(85, 45);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(168, 20);
            this.txtComment.TabIndex = 20;
            this.txtComment.Text = "(eg. Morning, Gaming Break etc..)";
            this.txtComment.Visible = false;
            this.txtComment.Click += new System.EventHandler(this.txtComment_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(11, 48);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(57, 13);
            this.lblComment.TabIndex = 21;
            this.lblComment.Text = "Comment :";
            this.lblComment.Visible = false;
            // 
            // WMPControl
            // 
            this.WMPControl.Enabled = true;
            this.WMPControl.Location = new System.Drawing.Point(356, 205);
            this.WMPControl.Name = "WMPControl";
            this.WMPControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPControl.OcxState")));
            this.WMPControl.Size = new System.Drawing.Size(231, 91);
            this.WMPControl.TabIndex = 22;
            this.toolTip1.SetToolTip(this.WMPControl, "Windows Media Pleyer Control");
            this.WMPControl.Visible = false;
            // 
            // lblYoutube
            // 
            this.lblYoutube.AutoSize = true;
            this.lblYoutube.Location = new System.Drawing.Point(11, 22);
            this.lblYoutube.Name = "lblYoutube";
            this.lblYoutube.Size = new System.Drawing.Size(74, 13);
            this.lblYoutube.TabIndex = 23;
            this.lblYoutube.Text = "Paste the Url :";
            this.lblYoutube.Visible = false;
            // 
            // txtYoutube
            // 
            this.txtYoutube.Location = new System.Drawing.Point(85, 19);
            this.txtYoutube.Name = "txtYoutube";
            this.txtYoutube.Size = new System.Drawing.Size(168, 20);
            this.txtYoutube.TabIndex = 24;
            this.txtYoutube.Visible = false;
            // 
            // cmdcheck
            // 
            this.cmdcheck.Location = new System.Drawing.Point(259, 16);
            this.cmdcheck.Name = "cmdcheck";
            this.cmdcheck.Size = new System.Drawing.Size(75, 23);
            this.cmdcheck.TabIndex = 25;
            this.cmdcheck.Text = "&Check URL";
            this.toolTip1.SetToolTip(this.cmdcheck, "Check if URL is valid");
            this.cmdcheck.UseVisualStyleBackColor = true;
            this.cmdcheck.Visible = false;
            this.cmdcheck.Click += new System.EventHandler(this.cmdcheck_Click);
            // 
            // GBUrl
            // 
            this.GBUrl.Controls.Add(this.txtcomment2);
            this.GBUrl.Controls.Add(this.cmdcheck);
            this.GBUrl.Controls.Add(this.lblYoutube);
            this.GBUrl.Controls.Add(this.lblComment);
            this.GBUrl.Controls.Add(this.txtYoutube);
            this.GBUrl.Controls.Add(this.txtComment);
            this.GBUrl.Controls.Add(this.FileChoser);
            this.GBUrl.Controls.Add(this.txtfileInput);
            this.GBUrl.Location = new System.Drawing.Point(4, 205);
            this.GBUrl.Name = "GBUrl";
            this.GBUrl.Size = new System.Drawing.Size(346, 135);
            this.GBUrl.TabIndex = 26;
            this.GBUrl.TabStop = false;
            this.GBUrl.Text = "URL Controls";
            // 
            // txtcomment2
            // 
            this.txtcomment2.Location = new System.Drawing.Point(85, 71);
            this.txtcomment2.Name = "txtcomment2";
            this.txtcomment2.Size = new System.Drawing.Size(168, 20);
            this.txtcomment2.TabIndex = 26;
            this.txtcomment2.Text = "(cnt)";
            this.txtcomment2.Visible = false;
            this.txtcomment2.Click += new System.EventHandler(this.txtcomment2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 349);
            this.Controls.Add(this.GBUrl);
            this.Controls.Add(this.WMPControl);
            this.Controls.Add(this.MoreOptions);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.AlarmSound);
            this.Controls.Add(this.pageLink);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Wake me Up";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.AlarmTab.ResumeLayout(false);
            this.AlarmTab.PerformLayout();
            this.TimerTab.ResumeLayout(false);
            this.TimerTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AlarmSound.ResumeLayout(false);
            this.AlarmSound.PerformLayout();
            this.Sound.ResumeLayout(false);
            this.Sound.PerformLayout();
            this.MoreOptions.ResumeLayout(false);
            this.MoreOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMPControl)).EndInit();
            this.GBUrl.ResumeLayout(false);
            this.GBUrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdalarm;
        private System.Windows.Forms.Button cmdtimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage AlarmTab;
        private System.Windows.Forms.TabPage TimerTab;
        private System.Windows.Forms.Button FileChoser;
        private System.Windows.Forms.TextBox txtfileInput;
        private System.Windows.Forms.ComboBox alarmMin;
        private System.Windows.Forms.ComboBox alarmHour;
        private System.Windows.Forms.ComboBox timerMin;
        private System.Windows.Forms.ComboBox timerHour;
        private System.Windows.Forms.Label hoursnow;
        private System.Windows.Forms.Label minsnow;
        private System.Windows.Forms.Timer AlarmTimer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.LinkLabel pageLink;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ListBox AlarmList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox AlarmSound;
        private System.Windows.Forms.GroupBox Sound;
        private System.Windows.Forms.RadioButton RBDefaltSound;
        private System.Windows.Forms.RadioButton RBLocalSound;
        private System.Windows.Forms.GroupBox MoreOptions;
        private System.Windows.Forms.CheckBox CBComment;
        private System.Windows.Forms.CheckBox CBWmp;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private AxWMPLib.AxWindowsMediaPlayer WMPControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton RBYoutube;
        private System.Windows.Forms.Timer LoopTimer;
        private System.Windows.Forms.Label lblYoutube;
        private System.Windows.Forms.TextBox txtYoutube;
        private System.Windows.Forms.ToolStripMenuItem timesUsedTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesUsedAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button cmdcheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox GBUrl;
        private System.Windows.Forms.TextBox txtcomment2;
    }
}

