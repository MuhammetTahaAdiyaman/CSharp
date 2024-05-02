namespace Odev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telefonModel;
            double fiyat;
            telefonModel = textBox1.Text;
            fiyat = Convert.ToDouble(textBox2.Text);

            double yuzdeSekizKDV, yuzdeOnSekizKDV;
            yuzdeOnSekizKDV = (fiyat * 18 / 100) + fiyat;
            yuzdeSekizKDV = (fiyat * 8 / 100) + fiyat;

            listBox1.Items.Add("Telefon: " + telefonModel + "%8 kdv: " + yuzdeSekizKDV + " " + "%18 kdv: " + yuzdeOnSekizKDV);
        }
    }
}
