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
    public partial class TestForm : Form
    {
        int CS; //Нужна для определения варианта теста, на стадии проверки ответов
        int timeMin = 5;
        public TestForm()
        {
            InitializeComponent();
        }
        public void TestPicture()
        {

        }
        static public string wrds;
        private void TestForm_Load(object sender, EventArgs e)
        {
            TestPicture();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            wrds = openFileDialog1.FileName;// получаем выбранный файл
        }

        private void ExitPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeLB_Click(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.Enabled = false;
            TestAnasw1.Enabled = true; TestAnasw2.Enabled = true; TestAnasw3.Enabled = true;
            TestAnasw4.Enabled = true; TestAnasw5.Enabled = true; TestAnasw6.Enabled = true;
            OcenkaPB.ImageLocation = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\Дизайн\Время.png";
        } //запуск теста и таймера

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop(); comboBox1.Enabled = true;
            CheckAnsw();
            TestAnasw1.Enabled = false; TestAnasw2.Enabled = false; TestAnasw3.Enabled = false;
            TestAnasw4.Enabled = false; TestAnasw5.Enabled = false; TestAnasw6.Enabled = false;
            TimerLb.Text = "5";
        } //остановка теста и таймера

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeMin--; TimerLb.Text = timeMin.ToString();
            if (timeMin == 0)
            {
                timer1.Stop(); comboBox1.Enabled = true;
                CheckAnsw();
                TestAnasw1.Enabled = false; TestAnasw2.Enabled = false; TestAnasw3.Enabled = false;
                TestAnasw4.Enabled = false; TestAnasw5.Enabled = false; TestAnasw6.Enabled = false;
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0: { WordTest();  CS = 0; break; }
                case 1: { WordTest2(); CS = 1; break; }
                case 2: { WordTest3(); CS = 2; break; }
                case 3: { WordTest4(); CS = 3; break; }
                case 4: { WordTest5(); CS = 4; break; }
            }
        }
        public void WordTest()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            QuestLb1.Text = word[2]; QuestLb2.Text = word[4]; QuestLb3.Text = word[6]; 
            QuestLb4.Text = word[8]; QuestLb5.Text = word[10]; QuestLb6.Text = word[12];
        } //вывод слов на тест для 1го варианта
        public void WordTest2()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            QuestLb1.Text = word[18]; QuestLb2.Text = word[20]; QuestLb3.Text = word[22];
            QuestLb4.Text = word[24]; QuestLb5.Text = word[26]; QuestLb6.Text = word[28];
        } //вывод слов на тест для 2го варианта
        public void WordTest3()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            QuestLb1.Text = word[34]; QuestLb2.Text = word[36]; QuestLb3.Text = word[38];
            QuestLb4.Text = word[40]; QuestLb5.Text = word[42]; QuestLb6.Text = word[44];
        } //вывод слов на тест для 3го варианта
        public void WordTest4()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            QuestLb1.Text = word[50]; QuestLb2.Text = word[52]; QuestLb3.Text = word[54];
            QuestLb4.Text = word[56]; QuestLb5.Text = word[58]; QuestLb6.Text = word[60];
        } //вывод слов на тест для 4го варианта
        public void WordTest5()
        {

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            QuestLb1.Text = word[66]; QuestLb2.Text = word[68]; QuestLb3.Text = word[70];
            QuestLb4.Text = word[72]; QuestLb5.Text = word[74]; QuestLb6.Text = word[76];
        } //вывод слов на тест для 5го варианта
        public void CheckAnsw()
        {
            int Ocenka = 0; //переменная для подсчёта правильных ответов

            //string wrds = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            if (CS == 0)
            {
                if (TestAnasw1.Text == word[3])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw2.Text == word[5])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw3.Text == word[7])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw4.Text == word[9])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw5.Text == word[11])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;

            } //если выбран 1й вариант
            if (CS == 1)
            {
                if (TestAnasw1.Text == word[19])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw2.Text == word[21])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw3.Text == word[23])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw4.Text == word[25])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw5.Text == word[27])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;

            } //если выбран 2й вариант
            if (CS == 2)
            {
                if (TestAnasw1.Text == word[35])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw2.Text == word[37])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw3.Text == word[39])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw4.Text == word[41])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw5.Text == word[43])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;

            } //если выбран 3й вариант
            if (CS == 3)
            {
                if (TestAnasw1.Text == word[51])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw2.Text == word[53])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw3.Text == word[55])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw4.Text == word[57])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw5.Text == word[59])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;

            } //если выбран 4й вариант
            if (CS == 4)
            {
                if (TestAnasw1.Text == word[67])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw2.Text == word[69])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw3.Text == word[71])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw4.Text == word[73])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;
                if (TestAnasw5.Text == word[75])
                {
                    Ocenka += 1;
                }
                else
                    Ocenka = Ocenka;

            } //если выбран 5й вариант
            if (Ocenka == 5)
                OcenkaPB.ImageLocation = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\Дизайн\5.png";
            else
                if (Ocenka == 4)
                OcenkaPB.ImageLocation = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\Дизайн\4.png";
            else
                if (Ocenka == 3)
                OcenkaPB.ImageLocation = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\Дизайн\3.png";
            else
                if (Ocenka <= 2)
                OcenkaPB.ImageLocation = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\Дизайн\2.png";
        } //проверка ответов

        private void TimerLb_Click(object sender, EventArgs e)
        {

        }

        private void TimerLb2_Click(object sender, EventArgs e)
        {

        }
    }
}
