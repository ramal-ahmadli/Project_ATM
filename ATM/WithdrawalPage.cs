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
    public partial class WithdrawalPage : Form
    {
        public WithdrawalPage()
        {
            InitializeComponent();
        }

        decimal bankBalans = 90;
        decimal balans = 100;

        private void btn_hesab_Click(object sender, EventArgs e)
        {
            textBox_mebleg.Clear();
        }

        private void btn_balans_Click(object sender, EventArgs e)
        {
            label_balans.Visible = true;
            label_balans.Text = "Balans: " + balans.ToString() + " AZN";
        }

        private void btn_imtina_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
        }

        private void btn_tesdiq_Click(object sender, EventArgs e)
        {
            decimal pul = Convert.ToDecimal(textBox_mebleg.Text);
            
            if (bankBalans < 0 )
            {
                label_successmessage.Text = "Bankomatda yetərli məbləğ yoxdur";
            }
            else
            {
                if (pul < balans && balans > 0)
                {
                    balans = balans - pul;
                    label_successmessage.Text = "Əməliyyat uğurla tamalandı";
                    label_balans.Text = "Balans: " + balans.ToString() + " AZN";
                }
                else
                {
                    label_successmessage.Text = "Balansda kifayət qədər məbləğ yoxdur";
                }
                
            }
        }
    }
}
