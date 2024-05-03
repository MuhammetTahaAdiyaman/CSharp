namespace Timer_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text= sayac.ToString();

            if(sayac > 0 && sayac < 30)
            {
                this.BackColor = Color.Red;
            }
            else if(sayac > 30 && sayac < 50)
            {
                this.BackColor = Color.Yellow;
            }
            else if (sayac > 50 && sayac < 100) 
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
