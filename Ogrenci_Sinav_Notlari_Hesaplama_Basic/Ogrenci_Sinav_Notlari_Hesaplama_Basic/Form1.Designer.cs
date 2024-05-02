namespace Ogrenci_Sinav_Notlari_Hesaplama_Basic
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 41);
            label1.Name = "label1";
            label1.Size = new Size(44, 30);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 98);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 205);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 2;
            label3.Text = "Sınav1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 205);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 3;
            label4.Text = "Sınav2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 205);
            label5.Name = "label5";
            label5.Size = new Size(65, 30);
            label5.TabIndex = 4;
            label5.Text = "Proje:";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(338, 263);
            button1.Name = "button1";
            button1.Size = new Size(235, 53);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(-1, 322);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(899, 154);
            listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 35);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 35);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 35);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(443, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 35);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(677, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 35);
            textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(900, 474);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
