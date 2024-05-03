namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string[] isimler = { "Ali", "Ahmet", "Mehmet", "Aslý", "Hakan" };
            label1.Text = isimler[3];
            */

            /*
            int[] sayilar = { 1, 2, 3 };  
            label1.Text = sayilar[0].ToString();
            */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string[] sehirler = { "Ankara", "Eskiþehir", "Antalya", "Adana", "Bursa", "Balýkesir" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }
            */

            /*

            int[] sayilar = { 1, 2, 3,4,5,6,7,8,9,10 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            } 
            */
            //foreach döngüsünü anlatmak için örnek verelim
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }



        }
    }
}
