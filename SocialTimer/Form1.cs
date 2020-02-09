using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SocialTimer
{
    public struct TimeSet
    {
        public string tName;
        public int tHour, tMinute, tSecond;
        public Label[] tLabels;
        public DateTime tDate;
        public Button tButton;
        public Timer tTimer;
        public bool flag, stopflag;
    }

    public struct LoadTimeSet
    {
        public string tName;
        public int tMaxLP, tCurrrentLP, tRecoverCycle;
    }

    public partial class Main : Form
    {
        public Form tForm;
        CreateNewTimer newT;
        OpenFileDialog ofd;
        public Main()
        {
            InitializeComponent();
        }

        private void 新規タイマーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newT = new CreateNewTimer();
            newT.ParentForm = this;
            newT.ShowDialog();
            newT.Dispose();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        public void SetTimer(string tName, int tMaxLP, int tCurrentLP, int tRecoverCycle, out string structtName, out int h, out int m, out int s, out DateTime dtSet)
        {
            DateTime dtNow;
            TimeSpan ts;

            structtName = tName;

            h = 0;
            s = 0;
            m = (tMaxLP - tCurrentLP) * tRecoverCycle;
            for (int i = 0; m >= 60; i++)
            {
                h += 1;
                m -= 60;
            }
            ts = new TimeSpan(h, m, s);
            dtNow = DateTime.Now;
            dtSet = dtNow + ts;
        }

        public void CreatetForm(TimeSet timeset)
        {
            tForm = new Form();

            tForm.SuspendLayout();
            TimeSet newTS = new TimeSet();
            newTS.tLabels = new Label[5];

            newTS.tTimer = new Timer();
            for (int i = 0; i < newTS.tLabels.Length; i++)
            {
                newTS.tLabels[i] = new Label();
                newTS.tLabels[i].AutoSize = true;
                newTS.tLabels[i].Font = new System.Drawing.Font("Century", 20);

            }

            tForm.Name = timeset.tName;
            tForm.Text = timeset.tName + " (Next " + timeset.tDate.Hour.ToString("d2") + ":" + timeset.tDate.Minute.ToString("d2") + "." + timeset.tDate.Second.ToString("d2") + ")";
            tForm.MaximizeBox = false;
            tForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            tForm.Size = new System.Drawing.Size(220, 130);

            newTS.tLabels[0].Text = timeset.tHour.ToString();
            newTS.tLabels[0].Location = new Point(40, 10);

            newTS.tLabels[1].Text = ":";
            newTS.tLabels[1].Location = new Point(80, 10);

            newTS.tLabels[2].Text = timeset.tMinute.ToString();
            newTS.tLabels[2].Location = new Point(100, 10);

            newTS.tLabels[3].Text = timeset.tSecond.ToString();
            newTS.tLabels[3].Font = new System.Drawing.Font("Century", 16);
            newTS.tLabels[3].Location = new Point(140, 15);

            newTS.tButton = new Button();
            newTS.tButton.Text = "一時停止";
            newTS.tButton.Location = new Point(50, 50);
            newTS.tButton.Click += delegate(object sender, EventArgs e)
            {
                SuspendButtonClick(newTS.tButton, ref timeset, ref newTS.tTimer, ref newTS.tLabels[0], ref newTS.tLabels[2], ref newTS.tLabels[3]);
            };

            // タイマーの実装
            newTS.tTimer.Interval = 100;
            newTS.tTimer.Tick += delegate(object sender, EventArgs e)
            {
                RefreshTimeText(ref timeset, ref newTS.tLabels[0], ref newTS.tLabels[2], ref newTS.tLabels[3]);
            };
            timeset.flag = false;
            timeset.stopflag = false;

            tForm.Controls.Add(newTS.tLabels[0]);
            tForm.Controls.Add(newTS.tLabels[1]);
            tForm.Controls.Add(newTS.tLabels[2]);
            tForm.Controls.Add(newTS.tLabels[3]);
            tForm.Controls.Add(newTS.tButton);

            tForm.ResumeLayout(false);
            tForm.Show();

            timeset.flag = true;
            newTS.tTimer.Start();
        }

        public void RefreshTimeText(ref TimeSet timeset, ref Label lblHour, ref Label lblMinute, ref Label lblSecond)
        {
            TimeSpan CurrentTS = new TimeSpan(0, 0, 0);
            DateTime dtnow = DateTime.Now;
            CurrentTS = timeset.tDate - dtnow;

            lblHour.Text = CurrentTS.Hours.ToString("d2");
            lblMinute.Text = CurrentTS.Minutes.ToString("d2");
            lblSecond.Text = CurrentTS.Seconds.ToString("d2");
            
        }

        public void SuspendButtonClick(Button sender, ref TimeSet timeset, ref Timer timer, ref Label lblHour, ref Label lblMinute, ref Label lblSecond)
        {
            if (timeset.flag == false && timeset.stopflag == true)
            {
                TimeSpan _ts = new TimeSpan(int.Parse(lblHour.Text), int.Parse(lblMinute.Text), int.Parse(lblSecond.Text));
                DateTime _dtNow = DateTime.Now;
                timeset.tDate = _dtNow + _ts;
                timeset.flag = true;
                timeset.stopflag = false;
                timer.Start();
                sender.Text = "一時停止";
            }
            else
            {
                timer.Stop();
                timeset.stopflag = true;
                timeset.flag = false;
                sender.Text = "再　生";
            }
        }

        private void 既存のタイマーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "XMLファイル(*.xml)|*.xml|すべてのファイル(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        TimeSet _TimeSet = new TimeSet();
                        XmlSerializer _serializer = new XmlSerializer(typeof(LoadTimeSet));
                        StreamReader sr = new StreamReader(ofd.FileNames[i], new System.Text.UTF8Encoding(false));
                        LoadTimeSet newTimeSet = (LoadTimeSet)_serializer.Deserialize(sr);
                        sr.Close();
                        SetTimer(newTimeSet.tName, newTimeSet.tMaxLP, newTimeSet.tCurrrentLP, newTimeSet.tRecoverCycle, out _TimeSet.tName, out _TimeSet.tHour, out _TimeSet.tMinute, out _TimeSet.tSecond, out _TimeSet.tDate);
                        CreatetForm(_TimeSet);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Nortification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
