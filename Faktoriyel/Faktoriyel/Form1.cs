namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, toplam = 1;

            sayi = Convert.ToInt32(textBox1.Text);

            for(int i = 1; i <= sayi; i++)
            {
                toplam = toplam * i;
            }

            textBox2.Text = toplam.ToString();
        }
    }
}
