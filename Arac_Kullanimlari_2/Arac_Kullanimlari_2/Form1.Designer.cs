namespace Arac_Kullanimlari_2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "Gaziantep", "Malatya", "Elazığ", "İstanbul", "Konya" });
            comboBox1.Location = new Point(68, 72);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 31);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(68, 130);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 31);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(235, 214);
            button2.Name = "button2";
            button2.Size = new Size(106, 32);
            button2.TabIndex = 3;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 188);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 5;
            label2.Text = "Şehir";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Mühendis", "Pilot" });
            listBox1.Location = new Point(647, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 96);
            listBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(647, 179);
            button3.Name = "button3";
            button3.Size = new Size(106, 32);
            button3.TabIndex = 7;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(790, 95);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 10;
            label1.Text = "Meslek";
            // 
            // button4
            // 
            button4.Location = new Point(957, 121);
            button4.Name = "button4";
            button4.Size = new Size(106, 32);
            button4.TabIndex = 9;
            button4.Text = "Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(790, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 31);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1257, 690);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Araç Kullanimlari 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private ListBox listBox1;
        private Button button3;
        private Label label1;
        private Button button4;
        private TextBox textBox2;
    }
}
