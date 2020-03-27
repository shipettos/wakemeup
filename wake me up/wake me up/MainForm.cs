//Created : 17/10/2014
//Update 1 : 13/11/2014
//Version : 1.2
//Programmer : Andreas Socratous



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace wake_me_up
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //global variables
        int MIN = 0; int HOUR = 0;
        int m = 0;
        int h = 0;
        int TimerUsage = 0, AlarmUsage = 0;

        /// <summary>
        /// Play Method for 
        /// alarm and Timer
        /// </summary>
        public void PlayMethod()
        {
           if (RBLocalSound.Checked)
                 WMPControl.URL = txtfileInput.Text;
           else if (RBDefaltSound.Checked)
           {
               switch (AlarmList.Text)
               {
                   case "Minions - Banana":
                       {
                           WMPControl.URL = "banana_minions.wav";
                           break;
                       }
                   case "Minions - Fire Alarm":
                       {
                           WMPControl.URL = "minion_fire_alarm.wav";
                           break;
                       }
                   case "Rock Alarm" :
                       {
                           WMPControl.URL = "Alarm_rock.wav";
                           break;
                       }
                   case "Classic Alarm" :
                       {
                           WMPControl.URL = "ring_ring_ring.wav";
                           break;
                       }
               }
           }
           else if (RBYoutube.Checked)
           {
               LinkLabel.Link youtubeLink = new LinkLabel.Link();
               if (txtYoutube.Text.Contains("https://www.youtube.com/watch"))
               {
                   youtubeLink.LinkData = txtYoutube.Text;
                   LinkLabel youtubePageLink = new LinkLabel();

                   youtubePageLink.Links.Add(youtubeLink);

                   Process.Start(youtubeLink.LinkData as string);
               }
               else
               {
                   MessageBox.Show("URL is not correct", "Input Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
               }
           }
                    
   
        }


        /// <summary>
        /// Command Button Alarm
        /// It will set up the alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdalarm_Click(object sender, EventArgs e)
        {
            //try reading hours
            try
            {
                HOUR = int.Parse(alarmHour.Text);

            }
            catch (FormatException exp)
            {
                MessageBox.Show("Value cannot contain Letters", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.timerHour.Focus();
                this.timerHour.SelectAll();
                return;
            }

            // TRY reading minutes - test
            
            try
            {
                MIN = int.Parse(alarmMin.Text);
            }
            catch (FormatException exp)
            {
                MessageBox.Show("Value cannot contail Letters", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.timerHour.Focus();
                this.timerHour.SelectAll();
                return;

            }


            this.WindowState = FormWindowState.Minimized;
            AlarmTimer.Enabled = true;
            MainTab.Enabled = false;
            FileChoser.Enabled = false;

            AlarmUsage++;
        }
        /// <summary>
        /// The user can choose a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileChoser_Click(object sender, EventArgs e)
        {

            

            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.DefaultExt = ".mp3";
            fileDialog.Filter = "Mp3 Files (*.mp3)|*.mp3|WMA Files (*.wma)|*.wma";
            
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {            
                    this.txtfileInput.Text = fileDialog.FileName;   
                    cmdalarm.Enabled = true;
                    cmdtimer.Enabled = true;
            }
            if (txtfileInput.Text == "")
            {
                cmdalarm.Enabled = false;
                cmdtimer.Enabled = false;
            }
            
        }

        /// <summary>
        /// Command Button Timer
        /// It will set up the Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdtimer_Click(object sender, EventArgs e)
        {
            int hour; int min;


            //try reading hours

            try
            {
                hour = int.Parse(timerHour.Text);
                
            }
            catch (FormatException exp)
            {
                MessageBox.Show("Value cannot contain Letters", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.timerHour.Focus();
                this.timerHour.SelectAll();
                return;
            }
            // try reading minutes
            try
            {
                min = int.Parse(timerMin.Text);
            }
            catch(FormatException exp)
            {
                MessageBox.Show("Value cannot contail Letters", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.timerHour.Focus();
                this.timerHour.SelectAll();
                return;
            }


           

            //converting time to milliseconds

            int mills;

            this.WindowState = FormWindowState.Minimized;

             if (hour == 0 || min == 0)
                mills = 2;
             else
                mills = min * 60 * 1000 + hour * 3600 *1000;
            
            Timer.Interval = mills-1;

            Timer.Enabled = true;
            MainTab.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            FileChoser.Enabled = false;
            TimerUsage++;


        }

        /// <summary>
        /// First Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string strMins, strHours;
            
            if (m != MIN || h != HOUR)
            {
                
                strMins = DateTime.Now.ToString("mm");
                m = int.Parse(strMins);

                strHours = DateTime.Now.ToString("hh");
                h = int.Parse(strHours);
            }
            else
            {
                PlayMethod();
                System.Console.WriteLine("malaka");
                this.WindowState = FormWindowState.Normal;
                AlarmTimer.Enabled = false;
                MainTab.Enabled = true;
            }
        }

        /// <summary>
        /// second Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                PlayMethod();
                System.Console.WriteLine("MALAKA");
                this.WindowState = FormWindowState.Normal;
                MainTab.Enabled = true;
                Timer.Enabled = false;
            }

        }

        /// <summary>
        /// Link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }

        /// <summary>
        /// Link to webpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.facebook.com/ACPotamiServicesProducts";
            pageLink.Links.Add(link);


            AlarmList.SelectedItem = "Minions - Banana";
            FileChoser.Enabled = false;

            if (txtfileInput.Text == "")
            {
                   startAlarmToolStripMenuItem.Enabled = false;
                   startTimerToolStripMenuItem.Enabled = false;

            }
        }

        /// <summary>
        /// About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.ShowDialog();
        }

        /// <summary>
        /// sets the font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.Font = this.Font;
            this.fontDialog1.ShowDialog();

            this.Font = fontDialog1.Font;
        }

        /// <summary>
        /// sets the backcolor of the tabs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.AlarmTab.BackColor;
            this.colorDialog1.ShowDialog();

            this.AlarmTab.BackColor = colorDialog1.Color;
            this.TimerTab.BackColor = colorDialog1.Color;
        }

        /// <summary>
        /// sets the backcolor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.BackColor;
            this.colorDialog1.ShowDialog();

            this.BackColor = this.colorDialog1.Color;

        }

        /// <summary>
        /// Extra controls in menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTab_Click(object sender, EventArgs e)
        {
            if (txtfileInput.Text == "")
            {
                startAlarmToolStripMenuItem.Enabled = false;
                startTimerToolStripMenuItem.Enabled = false;

            }
            else
                if (MainTab.SelectedTab == TimerTab)
               {
                   startAlarmToolStripMenuItem.Enabled = false;
                   startTimerToolStripMenuItem.Enabled = true;
                }
                else
                {
                    startAlarmToolStripMenuItem.Enabled = true;
                    startTimerToolStripMenuItem.Enabled = false;
                }
            }

        /// <summary>
        /// Exit in Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// sets comment objects to visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBComment_CheckedChanged(object sender, EventArgs e)
        {
            this.lblComment.Visible = this.CBComment.Checked;
            this.txtComment.Visible = this.CBComment.Checked;
            this.txtcomment2.Visible = this.CBComment.Checked;
        }

        /// <summary>
        /// Sets Windows Media Player Controls to Visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBWmp_CheckedChanged(object sender, EventArgs e)
        {
            this.WMPControl.Visible = this.CBWmp.Checked;
        }

        /// <summary>
        /// Radio Button that enables the MainTab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBTab_CheckedChanged(object sender, EventArgs e)
        {
            AlarmSound.Enabled = RBDefaltSound.Checked;

        }

        /// <summary>
        /// Enables Reccomendations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBRec_CheckedChanged(object sender, EventArgs e)
        {
            FileChoser.Enabled = RBLocalSound.Checked;
            cmdalarm.Enabled = (!RBLocalSound.Checked);
            cmdtimer.Enabled = (!RBLocalSound.Checked);
            
        }

        /// <summary>
        /// Youtube link option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBYoutube_CheckedChanged(object sender, EventArgs e)
        {
            txtYoutube.Visible = RBYoutube.Checked;
            txtYoutube.Clear();
            lblYoutube.Visible = RBYoutube.Checked;
            txtYoutube.Enabled = RBYoutube.Checked;
            cmdalarm.Enabled = false;
            cmdtimer.Enabled = false;
            cmdcheck.Visible = RBYoutube.Checked;
        }


        /// <summary>
        ///showing the total usage of timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timesUsedTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Timer Usage : " + TimerUsage.ToString(), "Timer Usage",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// showing the total usage of alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timesUsedAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Alarm Usage : " + AlarmUsage.ToString(), "Alarm Usage",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// summing the total usage of the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Program Usage : " + (TimerUsage + AlarmUsage).ToString(), "Total Usage",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// checking if URL is right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdcheck_Click(object sender, EventArgs e)
        {
            if (!(txtYoutube.Text.Contains("https://www.youtube.com/watch")))
            {
                 MessageBox.Show("URL is not correct", "Input Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtYoutube.Enabled = false;
                cmdtimer.Enabled = true;
                cmdalarm.Enabled = true;
            }
        }

        private void txtComment_Click(object sender, EventArgs e)
        {
            this.txtComment.Text = "";
        }

        private void txtcomment2_Click(object sender, EventArgs e)
        {
            this.txtcomment2.Text = "";
        }
    
 
 
    }
}
