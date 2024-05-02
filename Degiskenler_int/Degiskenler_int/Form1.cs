namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   /*
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            label1.Text = sayi.ToString();  
            */

            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label1.Text = sonuc.ToString(); 
        }
    }
}
