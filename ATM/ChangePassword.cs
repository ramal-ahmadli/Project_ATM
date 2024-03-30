using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }


        private void btn_imtinaa_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void btn_sifrenideyisdir_Click(object sender, EventArgs e)
        {
            string yeniSifre = textBox_yenisifre.Text;
            //if (yeniSifre)
            //{
            //    label_sifredeyisdirildi.Visible = true;
            //}
            
        }
    }
}
