namespace Dizi_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int ortalama = 0;
            int toplam = 0;
            int[] sayilar = { 1, 2, 3,4,5,6,7,8,23,43,54,65,32,12,76,87,98,110};
            foreach (int i in sayilar) { 
                if(i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam += i;
                    sayac++;
                }

            }

            label2.Text = toplam.ToString();
            label4.Text = (toplam / sayilar.Length).ToString();
            label5.Text =  sayac.ToString();    
        }
    }
}
