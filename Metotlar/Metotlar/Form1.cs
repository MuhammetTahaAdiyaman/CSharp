namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void degerAta()
        {
            textBox1.Text = "Taha";
            textBox2.Text = "Adýyaman";
            textBox3.Text = "Konya";
            textBox4.Text = "Öðrenci";

        }

        private void renklendir()
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.Tan;
            textBox3.BackColor = Color.SaddleBrown;
            textBox4.BackColor = Color.CadetBlue;

        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            degerAta();
        }
    }
}
