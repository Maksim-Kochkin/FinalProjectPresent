
namespace Самоучитель
{
    partial class MenuSamouchitel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSamouchitel));
            this.UchitelPb = new System.Windows.Forms.PictureBox();
            this.TestPb = new System.Windows.Forms.PictureBox();
            this.SlovarPb = new System.Windows.Forms.PictureBox();
            this.PbExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UchitelPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlovarPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UchitelPb
            // 
            this.UchitelPb.Image = global::Самоучитель.Properties.Resources.Учитель;
            this.UchitelPb.InitialImage = null;
            this.UchitelPb.Location = new System.Drawing.Point(142, 100);
            this.UchitelPb.Name = "UchitelPb";
            this.UchitelPb.Size = new System.Drawing.Size(120, 104);
            this.UchitelPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UchitelPb.TabIndex = 8;
            this.UchitelPb.TabStop = false;
            this.UchitelPb.Click += new System.EventHandler(this.UchitelPb_Click);
            // 
            // TestPb
            // 
            this.TestPb.Image = global::Самоучитель.Properties.Resources.Тест;
            this.TestPb.InitialImage = null;
            this.TestPb.Location = new System.Drawing.Point(268, 100);
            this.TestPb.Name = "TestPb";
            this.TestPb.Size = new System.Drawing.Size(120, 104);
            this.TestPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestPb.TabIndex = 7;
            this.TestPb.TabStop = false;
            this.TestPb.Click += new System.EventHandler(this.TestPb_Click);
            // 
            // SlovarPb
            // 
            this.SlovarPb.Image = global::Самоучитель.Properties.Resources.Книга;
            this.SlovarPb.InitialImage = null;
            this.SlovarPb.Location = new System.Drawing.Point(394, 100);
            this.SlovarPb.Name = "SlovarPb";
            this.SlovarPb.Size = new System.Drawing.Size(120, 104);
            this.SlovarPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlovarPb.TabIndex = 6;
            this.SlovarPb.TabStop = false;
            this.SlovarPb.Click += new System.EventHandler(this.SlovarPb_Click);
            // 
            // PbExit
            // 
            this.PbExit.Image = global::Самоучитель.Properties.Resources.Выход;
            this.PbExit.InitialImage = null;
            this.PbExit.Location = new System.Drawing.Point(12, 321);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(92, 104);
            this.PbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbExit.TabIndex = 5;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Самоучитель.Properties.Resources.Британия;
            this.pictureBox1.Location = new System.Drawing.Point(212, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuSamouchitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(526, 437);
            this.Controls.Add(this.UchitelPb);
            this.Controls.Add(this.TestPb);
            this.Controls.Add(this.SlovarPb);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuSamouchitel";
            this.Text = "Самоучитель меню";
            this.Load += new System.EventHandler(this.MenuSamouchitel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UchitelPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlovarPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.PictureBox SlovarPb;
        private System.Windows.Forms.PictureBox TestPb;
        private System.Windows.Forms.PictureBox UchitelPb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

