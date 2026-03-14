using System.Diagnostics.Eventing.Reader;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_kaydet_click(object sender, EventArgs e)
        {
            string username = kullanýcý_adý.Text;
            string password = sifre.Text;
            string confirmPassword = sifre_tekrar.Text;

            if (sifre.Text != sifre_tekrar.Text)
            {
                MessageBox.Show("Sifreler birbiri ile ayný olmalýdýr.");
            }
           
                if (password.Length < 8)
            {
                label4.Text = "Þifre en az 8 karakter olmalýdýr.";
                label4.ForeColor = System.Drawing.Color.Red;
                return;
            }
            MessageBox.Show("Þifre kaydedildi.");
        }


            public bool buyuk_kucuk_harf_duyarlýlýgý(string metin)
        {
            bool buyukharfvar = false;
            bool kucukharfvar = false;


            foreach (char karakter in metin)
            {
                if (char.IsUpper(karakter))
                {
                    buyukharfvar = true;
                }
                else if (char.IsLower(karakter))
                {
                    kucukharfvar = true;
                }


                if (buyukharfvar && kucukharfvar)
                {
                    return true;
                }
            }
                return false;
            




        }
    }
}

