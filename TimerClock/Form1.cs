using System.Media;

namespace TimerClock
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        String sTime, sPointTime, sAlarmTime, sHour, sMinutes, sSeconds = "00";

        private void Menu_Program_Alarm_Abort_Click(object sender, EventArgs e)
        {
            sHour = "00"; sMinutes = "00";
            ProgramAlarm.Text = "Alarm Canceled";
            sAlarmTime = "";
            AlarmHour.Text = "00";
            AlarmMinutes.Text = "00";
            newToolStripMenuItem.Enabled = true; Menu_Alarm_New.Enabled = true;
            Menu_Program_Exit.Enabled = true;
        }

        private void Menu_Alarm_Abort_Click(object sender, EventArgs e)
        {
            sHour = "00"; sMinutes = "00";
            ProgramAlarm.Text = "Alarm Canceled";
            sAlarmTime = "";
            AlarmHour.Text = "00";
            AlarmMinutes.Text = "00";
            newToolStripMenuItem.Enabled = true; Menu_Alarm_New.Enabled = true;
            Menu_Program_Exit.Enabled = true;
        }

        private void Menu_Program_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Program_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2023© Cristopher Sic \n V Bachillerato \"B\" - 34", "..:: Developer Information ::..");
        }

        private void Menu_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2023© Cristopher Sic \n V Bachillerato \"B\" - 34", "..:: Developer Information ::..");
        }

        private void Menu_Program_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Use the \"Alarm > New\" to create a new Alarm.\n2) Program you'r Alarm.\n3) Wait fot it...", "How to use?");
        }

        private void Menu_Alarm_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Use the \"Alarm > New\" to create a new Alarm.\n2) Program you'r Alarm.\n3) Wait fot it...", "How to use?");
        }

        private void Menu_Alarm_New_Click(object sender, EventArgs e)
        {
            AlarmHour.Enabled = true; AlarmHour.Text = DateTime.Now.ToString("hh");
            AlarmMinutes.Enabled = true; AlarmMinutes.Text = ""+(Int32.Parse(DateTime.Now.ToString("mm"))+1);
            ProgramAlarm.Enabled = true; ProgramAlarm.Text = "Program Alarm";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlarmHour.Enabled = true; AlarmHour.Text = DateTime.Now.ToString("hh");
            AlarmMinutes.Enabled = true; AlarmMinutes.Text = "" + (Int32.Parse(DateTime.Now.ToString("mm")) + 1);
            ProgramAlarm.Enabled = true; ProgramAlarm.Text = "Program Alarm";
        }

        private void ProgramAlarm_Click(object sender, EventArgs e)
        {
            AlarmHour.Enabled = false; Menu_Alarm_New.Enabled = false;
            AlarmMinutes.Enabled = false; Menu_Program_Exit.Enabled = false;
            ProgramAlarm.Enabled = false; newToolStripMenuItem.Enabled = false;
            sHour = AlarmHour.Text;
            sMinutes = AlarmMinutes.Text;
            ProgramAlarm.Text = "Programed!!";
            sAlarmTime = sHour+":"+sMinutes+":"+sSeconds;
        }

        public Form1()
        {
            InitializeComponent();
            myTimer.Start();
            myTimer.Tick += new EventHandler(Timer_Tick);
            myTimer.Interval = 1000;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            sTime = DateTime.Now.ToString("hh:mm:ss");
            sPointTime = DateTime.Now.ToString("tt");
            Time.Text = sTime; PointTime.Text = sPointTime;
            LocalTime.Text = sTime; LocalPointTime.Text = sPointTime;
            SoundPlayer song = new SoundPlayer();
            song.SoundLocation = "C://Users//Usuario//Downloads//mr.blue sky.wav";
            if (sTime.Equals(sAlarmTime))
            {
                song.Play();
                var Message = MessageBox.Show("Time is Over!! Clock Time: "+sAlarmTime, "Programed Alarm");
                if (Message == DialogResult.OK)
                {
                    song.Stop();
                    AlarmHour.Text = "Hour";
                    AlarmMinutes.Text = "Minutes";
                    ProgramAlarm.Text = "Program Alarm";
                    newToolStripMenuItem.Enabled = true; Menu_Alarm_New.Enabled = true;
                    Menu_Program_Exit.Enabled = true;
                }
            }
        }
    }
}