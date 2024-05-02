namespace Arac_Kullanimlari
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
            Button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(550, 16);
            Button1.Name = "Button1";
            Button1.Size = new Size(238, 57);
            Button1.TabIndex = 0;
            Button1.Text = "Tıklayın";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(37, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 1;
            label1.Text = "Adınız:";
            // 
            // button2
            // 
            button2.Location = new Point(37, 58);
            button2.Name = "button2";
            button2.Size = new Size(165, 46);
            button2.TabIndex = 2;
            button2.Text = "Yazdır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(119, 25);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 180);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Adınız:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 211);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Soyadınız:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 244);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 6;
            label5.Text = "Mesleğiniz:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 180);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 211);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 244);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(37, 274);
            button3.Name = "button3";
            button3.Size = new Size(140, 42);
            button3.TabIndex = 10;
            button3.Text = "Bilgi Getir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(480, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(480, 303);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "aktar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(662, 282);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 13;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(Button1);
            Name = "Form1";
            Text = "İlk Kod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label9;
    }
}
