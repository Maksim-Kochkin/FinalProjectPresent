using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Самоучитель
{
    public partial class UchitelForm : Form
    {
        public UchitelForm()
        {
            InitializeComponent();
        }
        static public string wrds;
        public void WordsLess()
        {
            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            LessonLb1.Text = word[2]; LessRusLb1.Text = word[3];
            LessonLb2.Text = word[4]; LessRusLb2.Text = word[5];
            LessonLb3.Text = word[6]; LessRusLb3.Text = word[7];
            LessonLb4.Text = word[8]; LessRusLb4.Text = word[9];
            LessonLb5.Text = word[10]; LessRusLb5.Text = word[11];
            LessonLb6.Text = word[12]; LessRusLb6.Text = word[13];
            TmeticsLb.Text = word[1];
        } //слова 1го урока
        public void WordLess2()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            LessonLb1.Text = word[18]; LessRusLb1.Text = word[19];
            LessonLb2.Text = word[20]; LessRusLb2.Text = word[21];
            LessonLb3.Text = word[22]; LessRusLb3.Text = word[23];
            LessonLb4.Text = word[24]; LessRusLb4.Text = word[25];
            LessonLb5.Text = word[26]; LessRusLb5.Text = word[27];
            LessonLb6.Text = word[28]; LessRusLb6.Text = word[29];
            TmeticsLb.Text = word[17];
        } //слова 2го урока
        public void WordLess3()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            LessonLb1.Text = word[34]; LessRusLb1.Text = word[35];
            LessonLb2.Text = word[36]; LessRusLb2.Text = word[37];
            LessonLb3.Text = word[38]; LessRusLb3.Text = word[39];
            LessonLb4.Text = word[40]; LessRusLb4.Text = word[41];
            LessonLb5.Text = word[42]; LessRusLb5.Text = word[43];
            LessonLb6.Text = word[44]; LessRusLb6.Text = word[45];
            TmeticsLb.Text = word[33];
        } //слова 3го урока
        public void WordLess4()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            LessonLb1.Text = word[50]; LessRusLb1.Text = word[51];
            LessonLb2.Text = word[52]; LessRusLb2.Text = word[53];
            LessonLb3.Text = word[54]; LessRusLb3.Text = word[55];
            LessonLb4.Text = word[56]; LessRusLb4.Text = word[57];
            LessonLb5.Text = word[58]; LessRusLb5.Text = word[59];
            LessonLb6.Text = word[60]; LessRusLb6.Text = word[61];
            TmeticsLb.Text = word[49];
        } //слова 4го урока
        public void WordLess5() 
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            LessonLb1.Text = word[66]; LessRusLb1.Text = word[67];
            LessonLb2.Text = word[68]; LessRusLb2.Text = word[69];
            LessonLb3.Text = word[70]; LessRusLb3.Text = word[71];
            LessonLb4.Text = word[72]; LessRusLb4.Text = word[73];
            LessonLb5.Text = word[74]; LessRusLb5.Text = word[75];
            LessonLb6.Text = word[76]; LessRusLb6.Text = word[77];
            TmeticsLb.Text = word[65];
        } //слова 5го урока
        public void TeacherPicture()
        {

        }
        public void NumLess()
        {
            
        }
        private void UchitelForm_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            wrds = openFileDialog1.FileName;// получаем выбранный файл
            TeacherPicture();
            NumLess();     
        }
        private void ExitPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: { WordsLess(); break; }
                case 1: { WordLess2(); break; }
                case 2: { WordLess3(); break; }
                case 3: { WordLess4(); break; }
                case 4: { WordLess5(); break; }
            }
        } //определение номера урока
        private void TeachBP_Click(object sender, EventArgs e)
        {

        }
    }
}
