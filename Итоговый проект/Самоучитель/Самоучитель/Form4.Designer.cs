
namespace Самоучитель
{
    partial class UchitelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UchitelForm));
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.TeachBP = new System.Windows.Forms.PictureBox();
            this.LessonNumLb = new System.Windows.Forms.Label();
            this.MessageLb2 = new System.Windows.Forms.Label();
            this.MessageLb = new System.Windows.Forms.Label();
            this.TemaLb = new System.Windows.Forms.Label();
            this.TmeticsLb = new System.Windows.Forms.Label();
            this.LessonLb1 = new System.Windows.Forms.Label();
            this.LessonLb2 = new System.Windows.Forms.Label();
            this.LessonLb3 = new System.Windows.Forms.Label();
            this.LessonLb4 = new System.Windows.Forms.Label();
            this.LessonLb5 = new System.Windows.Forms.Label();
            this.LessonLb6 = new System.Windows.Forms.Label();
            this.LessRusLb1 = new System.Windows.Forms.Label();
            this.LessRusLb2 = new System.Windows.Forms.Label();
            this.LessRusLb3 = new System.Windows.Forms.Label();
            this.LessRusLb4 = new System.Windows.Forms.Label();
            this.LessRusLb5 = new System.Windows.Forms.Label();
            this.LessRusLb6 = new System.Windows.Forms.Label();
            this.tireLb1 = new System.Windows.Forms.Label();
            this.tireLb2 = new System.Windows.Forms.Label();
            this.tireLb3 = new System.Windows.Forms.Label();
            this.tireLb4 = new System.Windows.Forms.Label();
            this.tireLb5 = new System.Windows.Forms.Label();
            this.tireLb6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachBP)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitPB
            // 
            this.ExitPB.Image = global::Самоучитель.Properties.Resources.Выход;
            this.ExitPB.Location = new System.Drawing.Point(428, 343);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(88, 103);
            this.ExitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPB.TabIndex = 4;
            this.ExitPB.TabStop = false;
            this.ExitPB.Click += new System.EventHandler(this.ExitPB_Click);
            // 
            // TeachBP
            // 
            this.TeachBP.Image = global::Самоучитель.Properties.Resources.Учитель;
            this.TeachBP.Location = new System.Drawing.Point(366, 12);
            this.TeachBP.Name = "TeachBP";
            this.TeachBP.Size = new System.Drawing.Size(150, 150);
            this.TeachBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TeachBP.TabIndex = 5;
            this.TeachBP.TabStop = false;
            this.TeachBP.Click += new System.EventHandler(this.TeachBP_Click);
            // 
            // LessonNumLb
            // 
            this.LessonNumLb.AutoSize = true;
            this.LessonNumLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonNumLb.Location = new System.Drawing.Point(362, 177);
            this.LessonNumLb.Name = "LessonNumLb";
            this.LessonNumLb.Size = new System.Drawing.Size(99, 19);
            this.LessonNumLb.TabIndex = 19;
            this.LessonNumLb.Text = "Занятие № ";
            // 
            // MessageLb2
            // 
            this.MessageLb2.AutoSize = true;
            this.MessageLb2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLb2.Location = new System.Drawing.Point(12, 32);
            this.MessageLb2.Name = "MessageLb2";
            this.MessageLb2.Size = new System.Drawing.Size(353, 19);
            this.MessageLb2.TabIndex = 21;
            this.MessageLb2.Text = "новые слова, а после сдавать их. Желаем удачи!";
            // 
            // MessageLb
            // 
            this.MessageLb.AutoSize = true;
            this.MessageLb.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessageLb.Location = new System.Drawing.Point(12, 9);
            this.MessageLb.Name = "MessageLb";
            this.MessageLb.Size = new System.Drawing.Size(342, 19);
            this.MessageLb.TabIndex = 20;
            this.MessageLb.Text = "Вы в режиме учителя, здесь вы будете изучать ";
            // 
            // TemaLb
            // 
            this.TemaLb.AutoSize = true;
            this.TemaLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemaLb.Location = new System.Drawing.Point(12, 89);
            this.TemaLb.Name = "TemaLb";
            this.TemaLb.Size = new System.Drawing.Size(56, 19);
            this.TemaLb.TabIndex = 22;
            this.TemaLb.Text = "Тема: ";
            // 
            // TmeticsLb
            // 
            this.TmeticsLb.AutoSize = true;
            this.TmeticsLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TmeticsLb.Location = new System.Drawing.Point(85, 89);
            this.TmeticsLb.Name = "TmeticsLb";
            this.TmeticsLb.Size = new System.Drawing.Size(0, 19);
            this.TmeticsLb.TabIndex = 23;
            // 
            // LessonLb1
            // 
            this.LessonLb1.AutoSize = true;
            this.LessonLb1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLb1.Location = new System.Drawing.Point(13, 142);
            this.LessonLb1.Name = "LessonLb1";
            this.LessonLb1.Size = new System.Drawing.Size(0, 19);
            this.LessonLb1.TabIndex = 25;
            // 
            // LessonLb2
            // 
            this.LessonLb2.AutoSize = true;
            this.LessonLb2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLb2.Location = new System.Drawing.Point(11, 185);
            this.LessonLb2.Name = "LessonLb2";
            this.LessonLb2.Size = new System.Drawing.Size(0, 19);
            this.LessonLb2.TabIndex = 26;
            // 
            // LessonLb3
            // 
            this.LessonLb3.AutoSize = true;
            this.LessonLb3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLb3.Location = new System.Drawing.Point(12, 219);
            this.LessonLb3.Name = "LessonLb3";
            this.LessonLb3.Size = new System.Drawing.Size(0, 19);
            this.LessonLb3.TabIndex = 27;
            // 
            // LessonLb4
            // 
            this.LessonLb4.AutoSize = true;
            this.LessonLb4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLb4.Location = new System.Drawing.Point(12, 260);
            this.LessonLb4.Name = "LessonLb4";
            this.LessonLb4.Size = new System.Drawing.Size(0, 19);
            this.LessonLb4.TabIndex = 28;
            // 
            // LessonLb5
            // 
            this.LessonLb5.AutoSize = true;
            this.LessonLb5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLb5.Location = new System.Drawing.Point(12, 298);
            this.LessonLb5.Name = "LessonLb5";
            this.LessonLb5.Size = new System.Drawing.Size(0, 19);
            this.LessonLb5.TabIndex = 29;
            // 
            // LessonLb6
            // 
            this.LessonLb6.AutoSize = true;
            this.LessonLb6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonLb6.Location = new System.Drawing.Point(11, 333);
            this.LessonLb6.Name = "LessonLb6";
            this.LessonLb6.Size = new System.Drawing.Size(0, 19);
            this.LessonLb6.TabIndex = 30;
            // 
            // LessRusLb1
            // 
            this.LessRusLb1.AutoSize = true;
            this.LessRusLb1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessRusLb1.Location = new System.Drawing.Point(186, 142);
            this.LessRusLb1.Name = "LessRusLb1";
            this.LessRusLb1.Size = new System.Drawing.Size(0, 19);
            this.LessRusLb1.TabIndex = 31;
            // 
            // LessRusLb2
            // 
            this.LessRusLb2.AutoSize = true;
            this.LessRusLb2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessRusLb2.Location = new System.Drawing.Point(185, 185);
            this.LessRusLb2.Name = "LessRusLb2";
            this.LessRusLb2.Size = new System.Drawing.Size(0, 19);
            this.LessRusLb2.TabIndex = 32;
            // 
            // LessRusLb3
            // 
            this.LessRusLb3.AutoSize = true;
            this.LessRusLb3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessRusLb3.Location = new System.Drawing.Point(185, 219);
            this.LessRusLb3.Name = "LessRusLb3";
            this.LessRusLb3.Size = new System.Drawing.Size(0, 19);
            this.LessRusLb3.TabIndex = 33;
            // 
            // LessRusLb4
            // 
            this.LessRusLb4.AutoSize = true;
            this.LessRusLb4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessRusLb4.Location = new System.Drawing.Point(185, 260);
            this.LessRusLb4.Name = "LessRusLb4";
            this.LessRusLb4.Size = new System.Drawing.Size(0, 19);
            this.LessRusLb4.TabIndex = 34;
            // 
            // LessRusLb5
            // 
            this.LessRusLb5.AutoSize = true;
            this.LessRusLb5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessRusLb5.Location = new System.Drawing.Point(186, 298);
            this.LessRusLb5.Name = "LessRusLb5";
            this.LessRusLb5.Size = new System.Drawing.Size(0, 19);
            this.LessRusLb5.TabIndex = 35;
            // 
            // LessRusLb6
            // 
            this.LessRusLb6.AutoSize = true;
            this.LessRusLb6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessRusLb6.Location = new System.Drawing.Point(186, 333);
            this.LessRusLb6.Name = "LessRusLb6";
            this.LessRusLb6.Size = new System.Drawing.Size(0, 19);
            this.LessRusLb6.TabIndex = 36;
            // 
            // tireLb1
            // 
            this.tireLb1.AutoSize = true;
            this.tireLb1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireLb1.Location = new System.Drawing.Point(124, 140);
            this.tireLb1.Name = "tireLb1";
            this.tireLb1.Size = new System.Drawing.Size(17, 22);
            this.tireLb1.TabIndex = 37;
            this.tireLb1.Text = "-";
            // 
            // tireLb2
            // 
            this.tireLb2.AutoSize = true;
            this.tireLb2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireLb2.Location = new System.Drawing.Point(124, 217);
            this.tireLb2.Name = "tireLb2";
            this.tireLb2.Size = new System.Drawing.Size(17, 22);
            this.tireLb2.TabIndex = 38;
            this.tireLb2.Text = "-";
            // 
            // tireLb3
            // 
            this.tireLb3.AutoSize = true;
            this.tireLb3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireLb3.Location = new System.Drawing.Point(124, 183);
            this.tireLb3.Name = "tireLb3";
            this.tireLb3.Size = new System.Drawing.Size(17, 22);
            this.tireLb3.TabIndex = 39;
            this.tireLb3.Text = "-";
            // 
            // tireLb4
            // 
            this.tireLb4.AutoSize = true;
            this.tireLb4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireLb4.Location = new System.Drawing.Point(124, 258);
            this.tireLb4.Name = "tireLb4";
            this.tireLb4.Size = new System.Drawing.Size(17, 22);
            this.tireLb4.TabIndex = 40;
            this.tireLb4.Text = "-";
            // 
            // tireLb5
            // 
            this.tireLb5.AutoSize = true;
            this.tireLb5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireLb5.Location = new System.Drawing.Point(124, 331);
            this.tireLb5.Name = "tireLb5";
            this.tireLb5.Size = new System.Drawing.Size(17, 22);
            this.tireLb5.TabIndex = 41;
            this.tireLb5.Text = "-";
            // 
            // tireLb6
            // 
            this.tireLb6.AutoSize = true;
            this.tireLb6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireLb6.Location = new System.Drawing.Point(124, 296);
            this.tireLb6.Name = "tireLb6";
            this.tireLb6.Size = new System.Drawing.Size(17, 22);
            this.tireLb6.TabIndex = 42;
            this.tireLb6.Text = "-";
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
            this.comboBox1.Location = new System.Drawing.Point(366, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UchitelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(528, 458);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tireLb6);
            this.Controls.Add(this.tireLb5);
            this.Controls.Add(this.tireLb4);
            this.Controls.Add(this.tireLb3);
            this.Controls.Add(this.tireLb2);
            this.Controls.Add(this.tireLb1);
            this.Controls.Add(this.LessRusLb6);
            this.Controls.Add(this.LessRusLb5);
            this.Controls.Add(this.LessRusLb4);
            this.Controls.Add(this.LessRusLb3);
            this.Controls.Add(this.LessRusLb2);
            this.Controls.Add(this.LessRusLb1);
            this.Controls.Add(this.LessonLb6);
            this.Controls.Add(this.LessonLb5);
            this.Controls.Add(this.LessonLb4);
            this.Controls.Add(this.LessonLb3);
            this.Controls.Add(this.LessonLb2);
            this.Controls.Add(this.LessonLb1);
            this.Controls.Add(this.TmeticsLb);
            this.Controls.Add(this.TemaLb);
            this.Controls.Add(this.MessageLb2);
            this.Controls.Add(this.MessageLb);
            this.Controls.Add(this.LessonNumLb);
            this.Controls.Add(this.TeachBP);
            this.Controls.Add(this.ExitPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UchitelForm";
            this.Text = "Учитель";
            this.Load += new System.EventHandler(this.UchitelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachBP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.PictureBox TeachBP;
        private System.Windows.Forms.Label LessonNumLb;
        private System.Windows.Forms.Label MessageLb2;
        private System.Windows.Forms.Label MessageLb;
        private System.Windows.Forms.Label TemaLb;
        private System.Windows.Forms.Label TmeticsLb;
        private System.Windows.Forms.Label LessonLb1;
        private System.Windows.Forms.Label LessonLb2;
        private System.Windows.Forms.Label LessonLb3;
        private System.Windows.Forms.Label LessonLb4;
        private System.Windows.Forms.Label LessonLb5;
        private System.Windows.Forms.Label LessonLb6;
        private System.Windows.Forms.Label LessRusLb1;
        private System.Windows.Forms.Label LessRusLb2;
        private System.Windows.Forms.Label LessRusLb3;
        private System.Windows.Forms.Label LessRusLb4;
        private System.Windows.Forms.Label LessRusLb5;
        private System.Windows.Forms.Label LessRusLb6;
        private System.Windows.Forms.Label tireLb1;
        private System.Windows.Forms.Label tireLb2;
        private System.Windows.Forms.Label tireLb3;
        private System.Windows.Forms.Label tireLb4;
        private System.Windows.Forms.Label tireLb5;
        private System.Windows.Forms.Label tireLb6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}