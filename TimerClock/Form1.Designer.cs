namespace TimerClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Program_Alarm_Abort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Program_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Program_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Program_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Alarm_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Alarm_Abort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Alarm_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.TextBox();
            this.LocalTime = new System.Windows.Forms.TextBox();
            this.LocalPointTime = new System.Windows.Forms.Label();
            this.PointTime = new System.Windows.Forms.Label();
            this.AlarmHour = new System.Windows.Forms.DomainUpDown();
            this.AlarmMinutes = new System.Windows.Forms.DomainUpDown();
            this.ProgramAlarm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora Local:";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.alarmToolStripMenuItem,
            this.Menu_Info});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(623, 24);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alarmToolStripMenuItem1,
            this.toolStripSeparator2,
            this.Menu_Program_Info,
            this.Menu_Program_Help,
            this.toolStripSeparator3,
            this.Menu_Program_Exit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // alarmToolStripMenuItem1
            // 
            this.alarmToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.Menu_Program_Alarm_Abort});
            this.alarmToolStripMenuItem1.Name = "alarmToolStripMenuItem1";
            this.alarmToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.alarmToolStripMenuItem1.Text = "Alarm";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Menu_Program_Alarm_Abort
            // 
            this.Menu_Program_Alarm_Abort.Name = "Menu_Program_Alarm_Abort";
            this.Menu_Program_Alarm_Abort.Size = new System.Drawing.Size(104, 22);
            this.Menu_Program_Alarm_Abort.Text = "Abort";
            this.Menu_Program_Alarm_Abort.Click += new System.EventHandler(this.Menu_Program_Alarm_Abort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(103, 6);
            // 
            // Menu_Program_Info
            // 
            this.Menu_Program_Info.Name = "Menu_Program_Info";
            this.Menu_Program_Info.Size = new System.Drawing.Size(106, 22);
            this.Menu_Program_Info.Text = "Info";
            this.Menu_Program_Info.Click += new System.EventHandler(this.Menu_Program_Info_Click);
            // 
            // Menu_Program_Help
            // 
            this.Menu_Program_Help.Name = "Menu_Program_Help";
            this.Menu_Program_Help.Size = new System.Drawing.Size(106, 22);
            this.Menu_Program_Help.Text = "Help";
            this.Menu_Program_Help.Click += new System.EventHandler(this.Menu_Program_Help_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(103, 6);
            // 
            // Menu_Program_Exit
            // 
            this.Menu_Program_Exit.Name = "Menu_Program_Exit";
            this.Menu_Program_Exit.Size = new System.Drawing.Size(106, 22);
            this.Menu_Program_Exit.Text = "Exit";
            this.Menu_Program_Exit.Click += new System.EventHandler(this.Menu_Program_Exit_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Alarm_New,
            this.Menu_Alarm_Abort,
            this.toolStripSeparator1,
            this.Menu_Alarm_Help});
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alarmToolStripMenuItem.Text = "Alarm";
            // 
            // Menu_Alarm_New
            // 
            this.Menu_Alarm_New.Name = "Menu_Alarm_New";
            this.Menu_Alarm_New.Size = new System.Drawing.Size(180, 22);
            this.Menu_Alarm_New.Text = "New";
            this.Menu_Alarm_New.Click += new System.EventHandler(this.Menu_Alarm_New_Click);
            // 
            // Menu_Alarm_Abort
            // 
            this.Menu_Alarm_Abort.Name = "Menu_Alarm_Abort";
            this.Menu_Alarm_Abort.Size = new System.Drawing.Size(180, 22);
            this.Menu_Alarm_Abort.Text = "Abort";
            this.Menu_Alarm_Abort.Click += new System.EventHandler(this.Menu_Alarm_Abort_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_Alarm_Help
            // 
            this.Menu_Alarm_Help.Name = "Menu_Alarm_Help";
            this.Menu_Alarm_Help.Size = new System.Drawing.Size(180, 22);
            this.Menu_Alarm_Help.Text = "Help";
            this.Menu_Alarm_Help.Click += new System.EventHandler(this.Menu_Alarm_Help_Click);
            // 
            // Menu_Info
            // 
            this.Menu_Info.Name = "Menu_Info";
            this.Menu_Info.Size = new System.Drawing.Size(43, 20);
            this.Menu_Info.Text = "Info.";
            this.Menu_Info.Click += new System.EventHandler(this.Menu_Info_Click);
            // 
            // Time
            // 
            this.Time.Enabled = false;
            this.Time.Font = new System.Drawing.Font("SimSun", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(12, 217);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(156, 46);
            this.Time.TabIndex = 7;
            this.Time.Text = "00:00:00";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocalTime
            // 
            this.LocalTime.Enabled = false;
            this.LocalTime.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocalTime.Location = new System.Drawing.Point(117, 496);
            this.LocalTime.Name = "LocalTime";
            this.LocalTime.Size = new System.Drawing.Size(83, 23);
            this.LocalTime.TabIndex = 8;
            this.LocalTime.Text = "00:00:00";
            this.LocalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocalPointTime
            // 
            this.LocalPointTime.AutoSize = true;
            this.LocalPointTime.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalPointTime.Location = new System.Drawing.Point(206, 495);
            this.LocalPointTime.Name = "LocalPointTime";
            this.LocalPointTime.Size = new System.Drawing.Size(30, 19);
            this.LocalPointTime.TabIndex = 9;
            this.LocalPointTime.Text = "Cm";
            // 
            // PointTime
            // 
            this.PointTime.AutoSize = true;
            this.PointTime.Font = new System.Drawing.Font("Sitka Small", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointTime.Location = new System.Drawing.Point(174, 217);
            this.PointTime.Name = "PointTime";
            this.PointTime.Size = new System.Drawing.Size(78, 50);
            this.PointTime.TabIndex = 10;
            this.PointTime.Text = "Cm";
            // 
            // AlarmHour
            // 
            this.AlarmHour.Enabled = false;
            this.AlarmHour.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlarmHour.Location = new System.Drawing.Point(44, 298);
            this.AlarmHour.Name = "AlarmHour";
            this.AlarmHour.Size = new System.Drawing.Size(67, 30);
            this.AlarmHour.TabIndex = 11;
            this.AlarmHour.Text = "Hour";
            // 
            // AlarmMinutes
            // 
            this.AlarmMinutes.Enabled = false;
            this.AlarmMinutes.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AlarmMinutes.Location = new System.Drawing.Point(117, 298);
            this.AlarmMinutes.Name = "AlarmMinutes";
            this.AlarmMinutes.Size = new System.Drawing.Size(96, 30);
            this.AlarmMinutes.TabIndex = 12;
            this.AlarmMinutes.Text = "Minutes";
            // 
            // ProgramAlarm
            // 
            this.ProgramAlarm.Enabled = false;
            this.ProgramAlarm.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgramAlarm.Location = new System.Drawing.Point(44, 334);
            this.ProgramAlarm.Name = "ProgramAlarm";
            this.ProgramAlarm.Size = new System.Drawing.Size(169, 30);
            this.ProgramAlarm.TabIndex = 13;
            this.ProgramAlarm.Text = "Program Alarm";
            this.ProgramAlarm.UseVisualStyleBackColor = true;
            this.ProgramAlarm.Click += new System.EventHandler(this.ProgramAlarm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.ImageLocation = "System.Drawing.Bitmap";
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 477);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 539);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ProgramAlarm);
            this.Controls.Add(this.AlarmMinutes);
            this.Controls.Add(this.AlarmHour);
            this.Controls.Add(this.PointTime);
            this.Controls.Add(this.LocalPointTime);
            this.Controls.Add(this.LocalTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Alarm     -     2023 ©Cristopher Sic";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Label label1;
        private Label label2;
        private MenuStrip Menu;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem alarmToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem Menu_Program_Alarm_Abort;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem Menu_Program_Info;
        private ToolStripMenuItem Menu_Program_Help;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem Menu_Program_Exit;
        private ToolStripMenuItem alarmToolStripMenuItem;
        private ToolStripMenuItem Menu_Alarm_New;
        private ToolStripMenuItem Menu_Alarm_Abort;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Menu_Alarm_Help;
        private ToolStripMenuItem Menu_Info;
        private TextBox Time;
        private TextBox LocalTime;
        private Label LocalPointTime;
        private Label PointTime;
        private DomainUpDown AlarmHour;
        private DomainUpDown AlarmMinutes;
        private Button ProgramAlarm;
        private PictureBox pictureBox2;
    }
}