namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }

        private int carp(int s1, int s2, int s3)
        {
            int s4 = s1 * s2 * s3;
            return s4;
        }

        private int kupHesapla(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = topla(2, 3).ToString();
            label2.Text = carp(2, 3, 4).ToString();
            label3.Text = topla(10, 123).ToString();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            int sayiOrnek = Convert.ToInt32(textBox1.Text);
            label4.Text = kupHesapla(sayiOrnek).ToString();
        }
    }
}
