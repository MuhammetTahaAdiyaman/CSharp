namespace Random_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int s1, s2, s3;
            s1 = random.Next(1,10);
            s2 = random.Next(1,10);
            s3 = random.Next(1,10); 

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();    
            label3.Text = s3.ToString();    
        }
    }
}
