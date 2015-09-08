using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace UFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
            timer1.Enabled = true;
        }

        //初始化
        private void Initialize()
        {
            surviveTime = 0;
            stepX = 1;
            stepY = 1;
            speed = 1;
            UFO.Location = new Point((int)(this.Width * 0.2), (int)(this.Height * 0.2));
            PanelUpdate();
        }

        //參數設定
        private int speed = 1;
        private int stepX = 1;
        private int stepY = 1;
        private double surviveTime = 0;

        //文字設定
        private void PanelUpdate()
        {
            ScorePanel.Text = "存活時間：" + surviveTime.ToString("0.00") + "秒 速度：" + speed.ToString();
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //移動
            UFO.Location = new Point(UFO.Location.X + stepX * speed, UFO.Location.Y + stepY * speed);
            //反彈
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
            //分數計算
            surviveTime += (double)timer1.Interval / 1000;
            PanelUpdate();
            //死亡判斷
            if (UFO.Location.Y + UFO.Height > this.Height)
            {
                timer1.Enabled = false;
                MessageBox.Show("你死了!\n存活時間：" + surviveTime.ToString("0.00") + "秒");
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
                Pause.Text = "繼續";
                timer1.Enabled = false;
            }
            else
            {
                Pause.Text = "暫停";
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
                    MessageBox.Show("存活時間：" + surviveTime.ToString("0.00") + "秒");
                    this.Close();
                    break;
                case Keys.Add:
                    SpeedChange(1);
                    break;
                case Keys.Subtract:
                    SpeedChange(-1);
                    break;
            }
        }
    }
}
