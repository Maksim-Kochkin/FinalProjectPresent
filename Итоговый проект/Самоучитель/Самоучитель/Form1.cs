using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самоучитель
{
    public partial class MenuSamouchitel : Form
    {

        public MenuSamouchitel()
        {
            InitializeComponent();
        }

        private void MenuSamouchitel_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SlovarForm.ActiveForm.Enabled = true;
        }

        private void SlovarPb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TestForm"] == null)
            {
                SlovarForm SlovFrm = new SlovarForm();
                SlovFrm.Show(this);
            }
        }

        private void TestPb_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["UchitelForm"] == null)
                {
                     if (Application.OpenForms["SlovarForm"] == null)
                     {
                        TestForm TestFrm = new TestForm();
                        TestFrm.Show(this); //запуск формы
                     }
                }
        }

        private void UchitelPb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TestForm"] == null)
            {
                UchitelForm UcitelFrm = new UchitelForm();
                UcitelFrm.Show(this);
            }
        }
        public void Guard() //Защита от хитрости (запсук тест + словарь/учитель)
        {
            
        }
    }
}
