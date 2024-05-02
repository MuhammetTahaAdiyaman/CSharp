namespace Ucak_Bilet_Rezervasyon_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox2 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 113);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(956, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MingLiU-ExtB", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(110, 23);
            label8.Name = "label8";
            label8.Size = new Size(648, 64);
            label8.TabIndex = 9;
            label8.Text = "Jüpiter Hava Yolları";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(110, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 350);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // button2
            // 
            button2.Location = new Point(399, 94);
            button2.Name = "button2";
            button2.Size = new Size(61, 36);
            button2.TabIndex = 8;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 200);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 34);
            dateTimePicker1.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(107, 266);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(286, 34);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "İstanbul", "Adana", "Konya" });
            comboBox2.Location = new Point(107, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(286, 36);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "İstanbul", "Adana", "Konya" });
            comboBox1.Location = new Point(107, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 36);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 269);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 200);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 2;
            label3.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 134);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 63);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(667, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 350);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(141, 180);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(286, 34);
            maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(141, 114);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(286, 34);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 34);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Location = new Point(315, 246);
            button1.Name = "button1";
            button1.Size = new Size(128, 47);
            button1.TabIndex = 5;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 183);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 4;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 117);
            label6.Name = "label6";
            label6.Size = new Size(37, 28);
            label6.TabIndex = 3;
            label6.Text = "TC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 51);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 2;
            label5.Text = "Ad ve Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(0, 509);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1258, 312);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 840);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label7;
        private ListBox listBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label8;
    }
}
