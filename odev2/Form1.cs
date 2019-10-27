using System;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRastgeleSayi_Click(object sender, EventArgs e)
        {

            //Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler adli label'a yazdirilacak ve kullanicidan butona bastigi anda textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
            //Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
            //Her hatali giriste yeni bir rastgele sayi turetilmelidir...
            
            Random rnd = new Random();
            lblRastgeleSayi.Text = rnd.Next(10000000, 100000000).ToString();
        }

        private void lblKalanHakkimiz_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMetinGirisAlani_TextChanged(object sender, EventArgs e)
        {
            txtMetinGirisAlani.Focus();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtMetinGirisAlani.Text == lblRastgeleSayi.Text)
            {
                MessageBox.Show("Giriş Yapıldı");
            }
            else
            {
                int hak = int.Parse(lblKalanHakkimiz.Text);                
                hak -= 1;
                lblKalanHakkimiz.Text = hak.ToString();
                txtMetinGirisAlani.Clear();
                MessageBox.Show("Girdiğiniz sayı yanlış, lütfen tekrar deneyiniz.");

                if (hak == 0)
                {
                    btnGirisYap.Enabled = false;
                    txtMetinGirisAlani.Enabled = false;
                }
                else
                {

                }
            }

            Random rnd = new Random();
            lblRastgeleSayi.Text = rnd.Next(10000000, 100000000).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
