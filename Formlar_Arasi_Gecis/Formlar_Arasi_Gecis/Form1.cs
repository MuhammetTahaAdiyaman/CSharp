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

            //form2 ye ge�ildi�inde ba�lang�� formunun kapat�lmas�n�� istersek e�er
            this.Hide();
        }
    }
}
