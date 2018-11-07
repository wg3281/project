using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace winForm_
{
    public partial class Timer1 : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer();
        int T = 0;       
        /// <summary>
        /// 通过定时器（10ms）获取计时时间
        /// </summary>
        /// <param name="t">计数值(10ms)</param>
        /// <returns></returns>
        public string GetTimeStyle (int t)
        {
            string hh,mm,ss,mms;
            int h, m, s, ms, temp;
            temp = t / 100;
            ms = t % 100;
            s = temp % 60;
            m = temp / 60 % 60;
            h = temp / 3600;
            if (ms < 10)
            {
                mms = "0" + ms.ToString();
            }
            else
            {
                mms = ms.ToString();
            }
            if (s < 10)
            {
                ss = "0" + s.ToString();
            }
            else
            {
                ss = s.ToString();
            }
            if (m < 10)
            {
                mm = "0" + m.ToString();
            }
            else
            {
                mm = m.ToString();
            }
            if (h < 10)
            {
                hh = "0" + h.ToString();
            }
            else
            {
                hh = h.ToString();
            }
            return hh+":"+mm+":"+ss+"."+mms;
        }
        public Timer1()
        {
            InitializeComponent();
        }

        private void Timer1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            label2.Text = DateTime.Now.ToString();
            SoundPlayer soundPlayer = new SoundPlayer();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1, 15) + label1.Text.Substring(0, 1);
            label2.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour == 4 && DateTime.Now.Minute == 6)
            {
                soundPlayer.SoundLocation = @"";
            }

        }

        private void Timer1_Activated(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void Timer1_Deactivate(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            T = T + 1;
            label3.Text = GetTimeStyle(T);
        }

        private void Starbtn_Click(object sender, EventArgs e)
        {
            timer3.Enabled = !timer3.Enabled;
            if (timer3.Enabled)
            {
                Starbtn.Text = "停止计时";
                Clearbtn.Enabled = false;
            }
            else
            {
                Starbtn.Text = "开始计时";
                Clearbtn.Enabled = true;
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            T = 0;
            label3.Text = "00:00:00.00";
        }
    }
}
