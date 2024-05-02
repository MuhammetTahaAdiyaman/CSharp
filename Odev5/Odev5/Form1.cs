namespace Odev5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   /*
            int kisaKenar, uzunKenar, dikdortgenAlan, dikdortgenCevre;
            kisaKenar = 10;
            uzunKenar = 20;
            dikdortgenAlan = kisaKenar * uzunKenar;
            dikdortgenCevre = 2*(kisaKenar+uzunKenar);

            label1.Text = "Dikdörtgen alan:" + dikdortgenAlan + " " + "Dikdörtgen Çevre:" + dikdortgenCevre;
            */

            int sinav1,sinav2,sinav3;
            int ortalama;
            sinav1 = 70;
            sinav2 = 89;
            sinav3 = 100;
            ortalama = (sinav1+sinav2 +sinav3)/3;

            label1.Text = "Ortalama: "+ ortalama.ToString();
        }
    }
}
