namespace UFO
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UFO = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.Button();
            this.ScorePanel = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.SpeedUp = new System.Windows.Forms.Button();
            this.SpeedDown = new System.Windows.Forms.Button();
            this.LanguageChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UFO
            // 
            this.UFO.Image = ((System.Drawing.Image)(resources.GetObject("UFO.Image")));
            this.UFO.Location = new System.Drawing.Point(63, 53);
            this.UFO.Name = "UFO";
            this.UFO.Size = new System.Drawing.Size(50, 50);
            this.UFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UFO.TabIndex = 0;
            this.UFO.TabStop = false;
            // 
            // bar
            // 
            this.bar.Image = ((System.Drawing.Image)(resources.GetObject("bar.Image")));
            this.bar.Location = new System.Drawing.Point(160, 500);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(400, 5);
            this.bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bar.TabIndex = 2;
            this.bar.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(88, 29);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 5;
            this.Reset.TabStop = false;
            this.Reset.Text = "重新開始";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ScorePanel
            // 
            this.ScorePanel.AutoSize = true;
            this.ScorePanel.Font = new System.Drawing.Font("新細明體", 10F);
            this.ScorePanel.Location = new System.Drawing.Point(12, 12);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(41, 14);
            this.ScorePanel.TabIndex = 4;
            this.ScorePanel.Text = "label1";
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(12, 29);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(70, 23);
            this.Pause.TabIndex = 3;
            this.Pause.TabStop = false;
            this.Pause.Text = "暫停";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // SpeedUp
            // 
            this.SpeedUp.Location = new System.Drawing.Point(169, 29);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(23, 23);
            this.SpeedUp.TabIndex = 6;
            this.SpeedUp.TabStop = false;
            this.SpeedUp.Text = "+";
            this.SpeedUp.UseVisualStyleBackColor = true;
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // SpeedDown
            // 
            this.SpeedDown.Location = new System.Drawing.Point(198, 29);
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.Size = new System.Drawing.Size(23, 23);
            this.SpeedDown.TabIndex = 7;
            this.SpeedDown.TabStop = false;
            this.SpeedDown.Text = "-";
            this.SpeedDown.UseVisualStyleBackColor = true;
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            // 
            // LanguageChange
            // 
            this.LanguageChange.Location = new System.Drawing.Point(227, 29);
            this.LanguageChange.Name = "LanguageChange";
            this.LanguageChange.Size = new System.Drawing.Size(70, 23);
            this.LanguageChange.TabIndex = 8;
            this.LanguageChange.TabStop = false;
            this.LanguageChange.Text = "繁體中文";
            this.LanguageChange.UseVisualStyleBackColor = true;
            this.LanguageChange.Click += new System.EventHandler(this.LanguageChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.LanguageChange);
            this.Controls.Add(this.SpeedDown);
            this.Controls.Add(this.SpeedUp);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.UFO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "UFO";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.UFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox UFO;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label ScorePanel;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button SpeedUp;
        private System.Windows.Forms.Button SpeedDown;
        private System.Windows.Forms.Button LanguageChange;
    }
}

