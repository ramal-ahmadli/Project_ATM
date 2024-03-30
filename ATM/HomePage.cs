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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_nagd_Click(object sender, EventArgs e)
        {
            WithdrawalPage withdrawalPage = new WithdrawalPage();
            withdrawalPage.Show();
        }

        private void btn_hesabdancixis_Click(object sender, EventArgs e)
        {
            Giris form1 = new Giris();
            form1.Show();
        }

        private void btn_xid_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
        }
    }
}
