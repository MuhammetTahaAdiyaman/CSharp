namespace Bilgi_Yarismasi
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblSoruNo = new Label();
            LblDogru = new Label();
            LblYanlis = new Label();
            LblDogruPng = new Label();
            LblYanlisPng = new Label();
            BtnSonraki = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-3, 0);
            richTextBox1.Margin = new Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(741, 282);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(21, 351);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(153, 49);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(206, 351);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(153, 49);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(393, 351);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(153, 49);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(585, 351);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(153, 49);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(798, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(814, 95);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(819, 170);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            LblSoruNo.AutoSize = true;
            LblSoruNo.Location = new Point(922, 34);
            LblSoruNo.Name = "LblSoruNo";
            LblSoruNo.Size = new Size(63, 25);
            LblSoruNo.TabIndex = 8;
            LblSoruNo.Text = "label4";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(922, 95);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(63, 25);
            LblDogru.TabIndex = 9;
            LblDogru.Text = "label5";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(922, 170);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(63, 25);
            LblYanlis.TabIndex = 10;
            LblYanlis.Text = "label6";
            // 
            // LblDogruPng
            // 
            LblDogruPng.AutoSize = true;
            LblDogruPng.Location = new Point(872, 375);
            LblDogruPng.Name = "LblDogruPng";
            LblDogruPng.Size = new Size(63, 25);
            LblDogruPng.TabIndex = 11;
            LblDogruPng.Text = "label7";
            LblDogruPng.Visible = false;
            // 
            // LblYanlisPng
            // 
            LblYanlisPng.AutoSize = true;
            LblYanlisPng.Location = new Point(968, 375);
            LblYanlisPng.Name = "LblYanlisPng";
            LblYanlisPng.Size = new Size(63, 25);
            LblYanlisPng.TabIndex = 12;
            LblYanlisPng.Text = "label8";
            LblYanlisPng.Visible = false;
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(832, 233);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(153, 49);
            BtnSonraki.TabIndex = 13;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(749, 463);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 14;
            label4.Text = "label7";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(851, 463);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 15;
            label5.Text = "label7";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(1053, 545);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnSonraki);
            Controls.Add(LblYanlisPng);
            Controls.Add(LblDogruPng);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(LblSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblSoruNo;
        private Label LblDogru;
        private Label LblYanlis;
        private Label LblDogruPng;
        private Label LblYanlisPng;
        private Button BtnSonraki;
        private Label label4;
        private Label label5;
    }
}
