namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyetin kuruluþ tarihi aþaðýdakilerden hangisidir ?";
                BtnA.Text = 1920.ToString();
                BtnB.Text = 1921.ToString();
                BtnC.Text = 1922.ToString();
                BtnD.Text = 1923.ToString();
                label4.Text = 1923.ToString();
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Aþaðýdakilerden hangisi asal sayýdýr ? ";
                BtnA.Text = 0.ToString();
                BtnB.Text = 2.ToString();
                BtnC.Text = 8.ToString();
                BtnD.Text = 12.ToString();
                label4.Text = 2.ToString();
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Araba sevdasý kitabýnýn yazarý kimdir ?";
                BtnA.Text = "Recaizade Mahmut Ekrem";
                BtnB.Text = "Sait Faik";
                BtnC.Text = "Tevfik Fikret";
                BtnD.Text = "Nazým Hikmet";
                label4.Text = "Recaizade Mahmut Ekrem";
                BtnSonraki.Text = "Sonuçlar";
            }

            if(soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;

                MessageBox.Show("Doðru:" + dogru + "\n" + "Yanlýþ: " + yanlis);
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblDogruPng.Text = "DOÐRU";
                LblDogruPng.Visible = true;
                LblYanlisPng.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblYanlisPng.Text = "YANLIÞ";
                LblYanlisPng.Visible = true;
                LblDogruPng.Visible = false;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblDogruPng.Text = "DOÐRU";
                LblDogruPng.Visible = true;
                LblYanlisPng.Visible = false;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblYanlisPng.Text = "YANLIÞ";
                LblYanlisPng.Visible = true;
                LblDogruPng.Visible = false;

            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblDogruPng.Text = "DOÐRU";
                LblDogruPng.Visible = true;
                LblYanlisPng.Visible = false;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblYanlisPng.Text = "YANLIÞ";
                LblYanlisPng.Visible = true;
                LblDogruPng.Visible = false;

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                LblDogruPng.Text = "DOÐRU";
                LblDogruPng.Visible = true;
                LblYanlisPng.Visible = false;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                LblYanlisPng.Text = "YANLIÞ";
                LblYanlisPng.Visible = true;
                LblDogruPng.Visible = false;

            }
        }
    }
}
