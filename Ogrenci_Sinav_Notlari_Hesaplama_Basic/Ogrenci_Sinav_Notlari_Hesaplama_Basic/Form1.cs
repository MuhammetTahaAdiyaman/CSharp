namespace Ogrenci_Sinav_Notlari_Hesaplama_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sinav1, sinav2, proje;
            double ortalama;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            sinav1 = Convert.ToInt32(textBox3.Text);
            sinav2 = Convert.ToInt32(textBox4.Text);    
            proje = Convert.ToInt32(textBox5.Text); 

            ortalama = (sinav1+ sinav2+proje)/3;

            listBox1.Items.Add(ad + " " + soyad + " " + "Ortalama: " + ortalama);
                  
        }
    }
}
