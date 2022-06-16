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
    public partial class SlovarForm : Form
    {
        public SlovarForm()
        {
            InitializeComponent();
        }
        public void WordsFile()
        {
            
        }
        public void SlovarPicture()
        {

        } //все пути для изорбражений
        static public string wrds;
        public void Base() //слова в dataGrid'e
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string wrds = openFileDialog1.FileName;// получаем выбранный файл
            //string wrds1 = @"C:\Users\Пользователь\Desktop\КУПК\Итоговый проект\WfP.txt";
            string[] word = File.ReadAllLines(wrds, Encoding.UTF8);
            for (int i = 0; i < word.Length-2; i = i+2)
            {
                dataGridView1.Rows.Add(word[i], word[i+1]);
            }
        }
        static public string wrd;
        private void SlovarForm_Load(object sender, EventArgs e)
        {
            
            SlovarPicture();
            Base();
        }

        private void ExitPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
