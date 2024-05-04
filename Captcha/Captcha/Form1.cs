namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l" };
            string[] sembol2 = { "*", "-", "/", "+" };

            Random random = new Random();

            int s1, s2, s3;
            s1 = random.Next(0, sembol1.Length);
            s2 = random.Next(0, sembol2.Length);
            s3 = random.Next(1, 10);
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString()+s3.ToString();
        }
    }
}
