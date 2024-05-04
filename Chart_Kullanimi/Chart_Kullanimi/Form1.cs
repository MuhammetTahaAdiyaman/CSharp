namespace Chart_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void yeþilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void hakkýmýzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Taha ADIYAMAN 4.05.2024", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");

        }
    }
}
