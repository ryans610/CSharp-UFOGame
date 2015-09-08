using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, string> eng = new Dictionary<string, string>();
            eng.Add("surviveTime", "Survive Time");
            eng.Add("speed", "Speed");
            eng.Add("second", "sec");
            eng.Add("pause", "Pause");
            eng.Add("continue", "Continue");
            eng.Add("dead", "You are dead");
            eng.Add("reset", "ReStart");
            dictionary.Add("eng", eng);
            languageList.Add("English", "eng");
            Dictionary<string, string> cht = new Dictionary<string, string>();
            cht.Add("surviveTime", "存活時間");
            cht.Add("speed", "速度");
            cht.Add("second", "秒");
            cht.Add("pause", "暫停");
            cht.Add("continue", "繼續");
            cht.Add("dead", "你死了");
            cht.Add("reset", "重新開始");
            dictionary.Add("cht", cht);
            languageList.Add("繁體中文", "cht");
            Initialize();
            timer1.Enabled = true;
        }

        //initialize
        private void Initialize()
        {
            surviveTime = 0;
            stepX = 1;
            stepY = 1;
            speed = 1;
            UFO.Location = new Point((int)(this.Width * 0.2), (int)(this.Height * 0.2));
            PanelUpdate();
        }

        //propertie
        private int speed = 1;
        private int stepX = 1;
        private int stepY = 1;
        private double surviveTime = 0;
        private string language = "cht";

        //message
        private Dictionary<string, string> languageList = new Dictionary<string, string>();
        private Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
        
        private void PanelUpdate()
        {
            ScorePanel.Text = dictionary[language]["surviveTime"] + "：" + surviveTime.ToString("0.00") + dictionary[language]["second"] + " " + dictionary[language]["speed"] + "：" + speed.ToString();
        }

        private void LanguageChange_Click(object sender, EventArgs e)
        {
            ChangeLanguage();
            ScorePanel.Focus();
        }

        private void ChangeLanguage()
        {
            bool found = false;
            foreach (KeyValuePair<string, string> kv in languageList)
            {
                if (found)
                {
                    language = kv.Value;
                    LanguageChange.Text = kv.Key;
                    found = false;
                    break;
                }
                else
                {
                    if (kv.Key == LanguageChange.Text)
                    {
                        found = true;
                    }
                }
            }
            if (found)
            {
                language = languageList.ElementAt(0).Value;
                LanguageChange.Text = languageList.ElementAt(0).Key;
            }
            PanelUpdate();
            if (timer1.Enabled)
            {
                Pause.Text = dictionary[language]["pause"];
            }
            else
            {
                Pause.Text = dictionary[language]["continue"];
            }
            Reset.Text = dictionary[language]["reset"];
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //move
            UFO.Location = new Point(UFO.Location.X + stepX * speed, UFO.Location.Y + stepY * speed);
            //bounce
            if (UFO.Location.Y + UFO.Height > bar.Location.Y &&
                UFO.Location.Y < bar.Location.Y &&
                UFO.Location.X > bar.Location.X - UFO.Width &&
                UFO.Location.X < bar.Location.X + bar.Width)
            {
                stepY = -stepY;
            }
            if (UFO.Location.X < 0 || UFO.Location.X + UFO.Width > this.Width)
            {
                stepX = -stepX;
            }
            if (UFO.Location.Y < 0)
            {
                stepY = -stepY;
            }
            //score
            surviveTime += (double)timer1.Interval / 1000;
            PanelUpdate();
            //dead
            if (UFO.Location.Y + UFO.Height > this.Height)
            {
                timer1.Enabled = false;
                MessageBox.Show(dictionary[language]["dead"] + "!\n" + dictionary[language]["surviveTime"] + "：" + surviveTime.ToString("0.00") + dictionary[language]["second"]);
                Initialize();
            }
        }

        //bar move
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            RePositionBar();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RePositionBar();
        }

        private void RePositionBar()
        {
            bar.Location = new Point(MousePosition.X - bar.Width / 2, (int)(this.Height * 0.8));
        }

        //pause
        private void Pause_Click(object sender, EventArgs e)
        {
            DoPause();
            ScorePanel.Focus();
        }

        private void DoPause()
        {
            if (timer1.Enabled)
            {
                Pause.Text = dictionary[language]["continue"];
                timer1.Enabled = false;
            }
            else
            {
                Pause.Text = dictionary[language]["pause"];
                timer1.Enabled = true;
            }
        }

        //speed control
        private void SpeedUp_Click(object sender, EventArgs e)
        {
            SpeedChange(1);
            ScorePanel.Focus();
        }

        private void SpeedDown_Click(object sender, EventArgs e)
        {
            SpeedChange(-1);
            ScorePanel.Focus();
        }

        private void SpeedChange(int value)
        {
            speed += value;
            if (speed <= 0)
            {
                speed = 1;
            }
        }

        //reset
        private void Reset_Click(object sender, EventArgs e)
        {
            Initialize();
            ScorePanel.Focus();
        }

        //key control
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    DoPause();
                    break;
                case Keys.Escape:
                    timer1.Enabled = false;
                    MessageBox.Show(dictionary[language]["surviveTime"] + "：" + surviveTime.ToString("0.00") + dictionary[language]["second"]);
                    this.Close();
                    break;
                case Keys.Add:
                    SpeedChange(1);
                    break;
                case Keys.Subtract:
                    SpeedChange(-1);
                    break;
                case Keys.L:
                    ChangeLanguage();
                    break;
            }
        }
    }
}
