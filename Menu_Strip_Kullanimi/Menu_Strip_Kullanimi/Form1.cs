namespace Menu_Strip_Kullanimi
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

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void hakkýmýzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //birinci metin, ikinci baþlýk, üçüncü buton, dönrdüncü logo.
            MessageBox.Show("Bu proje Taha ADIYAMAN tarafýndan yapýldý", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
