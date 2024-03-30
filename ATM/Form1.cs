namespace ATM
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pins = { 1234 };

            if(sifre.Text == pins[0].ToString())
            {
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else if (sifre.Text == pins[1].ToString())
            {
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                error_message.Visible = true;
            }
        }
    }
}
