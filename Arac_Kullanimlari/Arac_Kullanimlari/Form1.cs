namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba D�nya!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Taha Ad�yaman";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Emel";
            label7.Text = "Ozt�rk";
            label8.Text = "Ogretmen";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yaz�l�m M�hendisli�i";
            label9.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
