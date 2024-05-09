using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TAHA\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True;");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked == true)
            {
                c = "Kız";
            }
            if(radioButton2.Checked == true)
            {
                c = "Erkek";
            }

            ds.OgrenciEkle(TxtOgrenciAd.Text, TxtOgrenciSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtOgrenciId.Text));    

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtOgrenciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtOgrenciAd.Text, TxtOgrenciSoyad.Text,byte.Parse (comboBox1.SelectedValue.ToString()), c, int.Parse(TxtOgrenciId.Text));

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }
    }
}
