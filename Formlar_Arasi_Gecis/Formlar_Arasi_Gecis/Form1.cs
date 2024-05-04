namespace Formlar_Arasi_Gecis
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

            form2.Show();

            //form2 ye geçildiðinde baþlangýç formunun kapatýlmasýnýý istersek eðer
            this.Hide();
        }
    }
}
