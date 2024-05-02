namespace Odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet, yas, meslek;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            cinsiyet = textBox3.Text;
            yas = textBox4.Text;    
            meslek = textBox5.Text;

            listBox1.Items.Add("Ad: " + ad + " " + "Soyad: " + soyad + " " + "Cinsiyet: " + cinsiyet + " " + "Yaþ: " + yas + " " + "Meslek: " + meslek);
        }
    }
}
