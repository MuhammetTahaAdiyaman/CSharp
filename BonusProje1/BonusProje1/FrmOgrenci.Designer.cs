namespace BonusProje1
{
    partial class FrmOgrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtOgrenciAd = new System.Windows.Forms.TextBox();
            this.TxtOgrenciId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(637, 372);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(179, 35);
            this.BtnSil.TabIndex = 29;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(388, 372);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(181, 35);
            this.BtnEkle.TabIndex = 28;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(637, 327);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(179, 35);
            this.BtnGuncelle.TabIndex = 27;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(388, 327);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(181, 35);
            this.BtnListele.TabIndex = 26;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtOgrenciAd
            // 
            this.TxtOgrenciAd.Location = new System.Drawing.Point(160, 371);
            this.TxtOgrenciAd.Name = "TxtOgrenciAd";
            this.TxtOgrenciAd.Size = new System.Drawing.Size(208, 36);
            this.TxtOgrenciAd.TabIndex = 25;
            // 
            // TxtOgrenciId
            // 
            this.TxtOgrenciId.Location = new System.Drawing.Point(160, 328);
            this.TxtOgrenciId.Name = "TxtOgrenciId";
            this.TxtOgrenciId.Size = new System.Drawing.Size(208, 36);
            this.TxtOgrenciId.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "ÖĞRENCİ ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 224);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "ÖĞRENCİ İŞLEMLERİ PANELİ";
            // 
            // TxtOgrenciSoyad
            // 
            this.TxtOgrenciSoyad.Location = new System.Drawing.Point(160, 413);
            this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
            this.TxtOgrenciSoyad.Size = new System.Drawing.Size(208, 36);
            this.TxtOgrenciSoyad.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "SOYADI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "KULÜBÜ:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(160, 497);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 32);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "KIZ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(232, 497);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 32);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ERKEK";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "CİNSİYET:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(405, 455);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 36);
            this.textBox3.TabIndex = 37;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(649, 455);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(179, 35);
            this.BtnAra.TabIndex = 38;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 36);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(828, 539);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtOgrenciSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtOgrenciAd);
            this.Controls.Add(this.TxtOgrenciId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtOgrenciAd;
        private System.Windows.Forms.TextBox TxtOgrenciId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrenciSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}