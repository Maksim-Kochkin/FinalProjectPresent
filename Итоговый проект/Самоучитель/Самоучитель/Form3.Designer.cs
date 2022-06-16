
namespace Самоучитель
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.MessageLb = new System.Windows.Forms.Label();
            this.MessageLb2 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TestAnasw1 = new System.Windows.Forms.TextBox();
            this.TestAnasw2 = new System.Windows.Forms.TextBox();
            this.TestAnasw3 = new System.Windows.Forms.TextBox();
            this.TestAnasw4 = new System.Windows.Forms.TextBox();
            this.TestAnasw5 = new System.Windows.Forms.TextBox();
            this.QuestLb1 = new System.Windows.Forms.Label();
            this.QuestLb2 = new System.Windows.Forms.Label();
            this.QuestLb3 = new System.Windows.Forms.Label();
            this.QuestLb4 = new System.Windows.Forms.Label();
            this.QuestLb5 = new System.Windows.Forms.Label();
            this.OcenkLb = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.TimerLb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestAnasw6 = new System.Windows.Forms.TextBox();
            this.QuestLb6 = new System.Windows.Forms.Label();
            this.TimerLb2 = new System.Windows.Forms.Label();
            this.OcenkaPB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.TestBP = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.OcenkaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestBP)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageLb
            // 
            this.MessageLb.AutoSize = true;
            this.MessageLb.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessageLb.Location = new System.Drawing.Point(12, 9);
            this.MessageLb.Name = "MessageLb";
            this.MessageLb.Size = new System.Drawing.Size(313, 19);
            this.MessageLb.TabIndex = 4;
            this.MessageLb.Text = "Время на прохождение теста ограничено. ";
            // 
            // MessageLb2
            // 
            this.MessageLb2.AutoSize = true;
            this.MessageLb2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLb2.Location = new System.Drawing.Point(12, 32);
            this.MessageLb2.Name = "MessageLb2";
            this.MessageLb2.Size = new System.Drawing.Size(349, 19);
            this.MessageLb2.TabIndex = 5;
            this.MessageLb2.Text = "Будьте внимательны и собраны. Желаем удачи!";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(138, 63);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(113, 40);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Начать тест";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StopBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBtn.Location = new System.Drawing.Point(257, 63);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(113, 40);
            this.StopBtn.TabIndex = 7;
            this.StopBtn.Text = "Завершить";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TestAnasw1
            // 
            this.TestAnasw1.Enabled = false;
            this.TestAnasw1.Location = new System.Drawing.Point(209, 115);
            this.TestAnasw1.Multiline = true;
            this.TestAnasw1.Name = "TestAnasw1";
            this.TestAnasw1.Size = new System.Drawing.Size(161, 43);
            this.TestAnasw1.TabIndex = 8;
            // 
            // TestAnasw2
            // 
            this.TestAnasw2.Enabled = false;
            this.TestAnasw2.Location = new System.Drawing.Point(209, 165);
            this.TestAnasw2.Multiline = true;
            this.TestAnasw2.Name = "TestAnasw2";
            this.TestAnasw2.Size = new System.Drawing.Size(161, 43);
            this.TestAnasw2.TabIndex = 9;
            // 
            // TestAnasw3
            // 
            this.TestAnasw3.Enabled = false;
            this.TestAnasw3.Location = new System.Drawing.Point(209, 214);
            this.TestAnasw3.Multiline = true;
            this.TestAnasw3.Name = "TestAnasw3";
            this.TestAnasw3.Size = new System.Drawing.Size(161, 43);
            this.TestAnasw3.TabIndex = 10;
            // 
            // TestAnasw4
            // 
            this.TestAnasw4.Enabled = false;
            this.TestAnasw4.Location = new System.Drawing.Point(209, 263);
            this.TestAnasw4.Multiline = true;
            this.TestAnasw4.Name = "TestAnasw4";
            this.TestAnasw4.Size = new System.Drawing.Size(161, 43);
            this.TestAnasw4.TabIndex = 11;
            // 
            // TestAnasw5
            // 
            this.TestAnasw5.Enabled = false;
            this.TestAnasw5.Location = new System.Drawing.Point(209, 312);
            this.TestAnasw5.Multiline = true;
            this.TestAnasw5.Name = "TestAnasw5";
            this.TestAnasw5.Size = new System.Drawing.Size(161, 43);
            this.TestAnasw5.TabIndex = 12;
            // 
            // QuestLb1
            // 
            this.QuestLb1.AutoSize = true;
            this.QuestLb1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestLb1.Location = new System.Drawing.Point(12, 115);
            this.QuestLb1.Name = "QuestLb1";
            this.QuestLb1.Size = new System.Drawing.Size(0, 19);
            this.QuestLb1.TabIndex = 13;
            // 
            // QuestLb2
            // 
            this.QuestLb2.AutoSize = true;
            this.QuestLb2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestLb2.Location = new System.Drawing.Point(12, 165);
            this.QuestLb2.Name = "QuestLb2";
            this.QuestLb2.Size = new System.Drawing.Size(0, 19);
            this.QuestLb2.TabIndex = 14;
            // 
            // QuestLb3
            // 
            this.QuestLb3.AutoSize = true;
            this.QuestLb3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestLb3.Location = new System.Drawing.Point(12, 214);
            this.QuestLb3.Name = "QuestLb3";
            this.QuestLb3.Size = new System.Drawing.Size(0, 19);
            this.QuestLb3.TabIndex = 15;
            // 
            // QuestLb4
            // 
            this.QuestLb4.AutoSize = true;
            this.QuestLb4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestLb4.Location = new System.Drawing.Point(12, 263);
            this.QuestLb4.Name = "QuestLb4";
            this.QuestLb4.Size = new System.Drawing.Size(0, 19);
            this.QuestLb4.TabIndex = 16;
            // 
            // QuestLb5
            // 
            this.QuestLb5.AutoSize = true;
            this.QuestLb5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestLb5.Location = new System.Drawing.Point(13, 312);
            this.QuestLb5.Name = "QuestLb5";
            this.QuestLb5.Size = new System.Drawing.Size(0, 19);
            this.QuestLb5.TabIndex = 17;
            // 
            // OcenkLb
            // 
            this.OcenkLb.AutoSize = true;
            this.OcenkLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OcenkLb.Location = new System.Drawing.Point(394, 182);
            this.OcenkLb.Name = "OcenkLb";
            this.OcenkLb.Size = new System.Drawing.Size(116, 19);
            this.OcenkLb.TabIndex = 18;
            this.OcenkLb.Text = "Ваша оценка:";
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLB.Location = new System.Drawing.Point(8, 427);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(160, 19);
            this.TimeLB.TabIndex = 19;
            this.TimeLB.Text = "Оставшееся время:";
            this.TimeLB.Click += new System.EventHandler(this.TimeLB_Click);
            // 
            // TimerLb
            // 
            this.TimerLb.AutoSize = true;
            this.TimerLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLb.Location = new System.Drawing.Point(185, 427);
            this.TimerLb.Name = "TimerLb";
            this.TimerLb.Size = new System.Drawing.Size(18, 19);
            this.TimerLb.TabIndex = 20;
            this.TimerLb.Text = "5";
            this.TimerLb.Click += new System.EventHandler(this.TimerLb_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(12, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "№ занятия:";
            // 
            // TestAnasw6
            // 
            this.TestAnasw6.Enabled = false;
            this.TestAnasw6.Location = new System.Drawing.Point(209, 361);
            this.TestAnasw6.Multiline = true;
            this.TestAnasw6.Name = "TestAnasw6";
            this.TestAnasw6.Size = new System.Drawing.Size(161, 43);
            this.TestAnasw6.TabIndex = 23;
            // 
            // QuestLb6
            // 
            this.QuestLb6.AutoSize = true;
            this.QuestLb6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestLb6.Location = new System.Drawing.Point(13, 361);
            this.QuestLb6.Name = "QuestLb6";
            this.QuestLb6.Size = new System.Drawing.Size(0, 19);
            this.QuestLb6.TabIndex = 24;
            // 
            // TimerLb2
            // 
            this.TimerLb2.AutoSize = true;
            this.TimerLb2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLb2.Location = new System.Drawing.Point(205, 427);
            this.TimerLb2.Name = "TimerLb2";
            this.TimerLb2.Size = new System.Drawing.Size(45, 19);
            this.TimerLb2.TabIndex = 26;
            this.TimerLb2.Text = "мин.";
            this.TimerLb2.Click += new System.EventHandler(this.TimerLb2_Click);
            // 
            // OcenkaPB
            // 
            this.OcenkaPB.Location = new System.Drawing.Point(398, 204);
            this.OcenkaPB.Name = "OcenkaPB";
            this.OcenkaPB.Size = new System.Drawing.Size(100, 100);
            this.OcenkaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OcenkaPB.TabIndex = 25;
            this.OcenkaPB.TabStop = false;
            // 
            // ExitPB
            // 
            this.ExitPB.Image = global::Самоучитель.Properties.Resources.Выход;
            this.ExitPB.Location = new System.Drawing.Point(428, 343);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(88, 103);
            this.ExitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPB.TabIndex = 3;
            this.ExitPB.TabStop = false;
            this.ExitPB.Click += new System.EventHandler(this.ExitPB_Click);
            // 
            // TestBP
            // 
            this.TestBP.Image = global::Самоучитель.Properties.Resources.Тест;
            this.TestBP.Location = new System.Drawing.Point(376, 9);
            this.TestBP.Name = "TestBP";
            this.TestBP.Size = new System.Drawing.Size(140, 136);
            this.TestBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestBP.TabIndex = 2;
            this.TestBP.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(528, 458);
            this.Controls.Add(this.TimerLb2);
            this.Controls.Add(this.OcenkaPB);
            this.Controls.Add(this.QuestLb6);
            this.Controls.Add(this.TestAnasw6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TimerLb);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.OcenkLb);
            this.Controls.Add(this.QuestLb5);
            this.Controls.Add(this.QuestLb4);
            this.Controls.Add(this.QuestLb3);
            this.Controls.Add(this.QuestLb2);
            this.Controls.Add(this.QuestLb1);
            this.Controls.Add(this.TestAnasw5);
            this.Controls.Add(this.TestAnasw4);
            this.Controls.Add(this.TestAnasw3);
            this.Controls.Add(this.TestAnasw2);
            this.Controls.Add(this.TestAnasw1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.MessageLb2);
            this.Controls.Add(this.MessageLb);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.TestBP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OcenkaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestBP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TestBP;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Label MessageLb;
        private System.Windows.Forms.Label MessageLb2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TestAnasw1;
        private System.Windows.Forms.TextBox TestAnasw2;
        private System.Windows.Forms.TextBox TestAnasw3;
        private System.Windows.Forms.TextBox TestAnasw4;
        private System.Windows.Forms.TextBox TestAnasw5;
        private System.Windows.Forms.Label QuestLb1;
        private System.Windows.Forms.Label QuestLb2;
        private System.Windows.Forms.Label QuestLb3;
        private System.Windows.Forms.Label QuestLb4;
        private System.Windows.Forms.Label QuestLb5;
        private System.Windows.Forms.Label OcenkLb;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Label TimerLb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TestAnasw6;
        private System.Windows.Forms.Label QuestLb6;
        private System.Windows.Forms.PictureBox OcenkaPB;
        private System.Windows.Forms.Label TimerLb2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}