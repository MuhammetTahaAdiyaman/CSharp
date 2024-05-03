namespace Sinif_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.renk = "Beyaz";
            araba.hiz = 200;
            araba.motorGucu = 1245;
            araba.fiyat = 500000;
            araba.durum = 's';
            araba.YIL = 2016;
            araba.MARKA = "Wolksvagen";
            araba.muayene = 2017;
            araba.plaka = "34AI1881";
            araba.sahip = "Taha Adýyaman";

            label1.Text = araba.renk;
            label2.Text = araba.hiz.ToString();
            label3.Text = araba.fiyat.ToString();
            label4.Text = araba.durum.ToString();   
            label5.Text = araba.motorGucu.ToString();   
            label6.Text = araba.YIL.ToString();
            label7.Text = araba.MARKA.ToString();
            label8.Text = araba.muayene.ToString();
            label9.Text = araba.plaka.ToString();
            label10.Text = araba.sahip.ToString();
        }
    }
}
