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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btn_imt_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void btn_sifrenideyis_Click(object sender, EventArgs e)
        {

        }
    }
}
