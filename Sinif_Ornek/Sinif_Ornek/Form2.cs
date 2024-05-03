using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba araba2 = new Araba();
            araba2.renk = "Siyah";
            araba2.hiz = 250;
            araba2.motorGucu = 1445;
            araba2.fiyat = 1500000;
            araba2.durum = 's';

            label1.Text = araba2.renk;
            label2.Text = araba2.hiz.ToString();
            label3.Text = araba2.fiyat.ToString();
            label4.Text = araba2.durum.ToString();
            label5.Text = araba2.motorGucu.ToString();
        }
    }
}
