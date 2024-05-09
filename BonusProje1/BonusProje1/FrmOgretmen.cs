using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup frmKulup = new FrmKulup();
            frmKulup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmOgrenci = new FrmOgrenci();   
            frmOgrenci.Show();
        }
    }
}
