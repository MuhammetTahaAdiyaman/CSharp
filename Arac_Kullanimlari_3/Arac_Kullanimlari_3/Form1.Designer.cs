﻿namespace Arac_Kullanimlari_3
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(142, 58);
            maskedTextBox1.Margin = new Padding(5);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(266, 32);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 58);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 1;
            label1.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 130);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 3;
            label2.Text = "TC:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(142, 130);
            maskedTextBox2.Margin = new Padding(5);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(266, 32);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 210);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 5;
            label3.Text = "Tarih:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(142, 210);
            maskedTextBox3.Margin = new Padding(5);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(266, 32);
            maskedTextBox3.TabIndex = 4;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 299);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(142, 299);
            maskedTextBox4.Margin = new Padding(5);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(266, 32);
            maskedTextBox4.TabIndex = 6;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Location = new Point(142, 382);
            button1.Name = "button1";
            button1.Size = new Size(190, 43);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(668, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(541, 329);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(991, 464);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 145);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(57, 494);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 32);
            dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(117, 554);
            button2.Name = "button2";
            button2.Size = new Size(190, 43);
            button2.TabIndex = 12;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox4;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}
