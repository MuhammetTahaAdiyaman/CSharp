namespace Kitapci_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satinAlinanKitapSayisi, fiyat;
            double toplam;
            fiyat = 8;

            satinAlinanKitapSayisi = Convert.ToInt32(textBox1.Text);

            if(satinAlinanKitapSayisi > 0 && satinAlinanKitapSayisi <= 20)
            {
                toplam = (fiyat * satinAlinanKitapSayisi) - (satinAlinanKitapSayisi * fiyat * 0.20);
            }else if(satinAlinanKitapSayisi >= 21 && satinAlinanKitapSayisi <= 40)
            {
                toplam = (fiyat * satinAlinanKitapSayisi) - (satinAlinanKitapSayisi * fiyat * 0.40);

            }
            else
            {
                toplam = (fiyat * satinAlinanKitapSayisi) - (satinAlinanKitapSayisi * fiyat * 0.50);

            }

            textBox2.Text = toplam.ToString() + "TL";
        }
    }
}
