namespace Ucak_Bilet_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + "\n" + "Tarih: " + dateTimePicker1.Text + "\n" + "Saat: " + maskedTextBox1.Text + "\n" + "Yolcu Bilgileri: " + "\n" + "Ad-Soyad: " + textBox1.Text + "\n" + "TC: " + maskedTextBox2.Text + "\n" + "Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Bilgileri Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String temp;
            temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }
    }
}
