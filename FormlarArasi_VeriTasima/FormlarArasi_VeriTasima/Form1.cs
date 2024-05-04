namespace FormlarArasi_VeriTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ad = textBox1.Text;
            form2.soyad = textBox2.Text;
            form2.meslek = textBox3.Text;
            form2.Show();
            this.Hide();

        }
    }
}
