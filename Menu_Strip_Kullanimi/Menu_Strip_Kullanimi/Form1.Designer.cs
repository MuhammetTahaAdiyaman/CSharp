namespace Menu_Strip_Kullanimi
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
            menuStrip1 = new MenuStrip();
            kategorilerToolStripMenuItem = new ToolStripMenuItem();
            aksiyonToolStripMenuItem = new ToolStripMenuItem();
            madMaxToolStripMenuItem = new ToolStripMenuItem();
            romantikToolStripMenuItem = new ToolStripMenuItem();
            psILoveUToolStripMenuItem = new ToolStripMenuItem();
            aynıYıldızınAltındaToolStripMenuItem = new ToolStripMenuItem();
            korkuToolStripMenuItem = new ToolStripMenuItem();
            korkuSeansıToolStripMenuItem = new ToolStripMenuItem();
            bilimKurguToolStripMenuItem = new ToolStripMenuItem();
            uzayYolcularıToolStripMenuItem = new ToolStripMenuItem();
            renklerToolStripMenuItem = new ToolStripMenuItem();
            maviToolStripMenuItem = new ToolStripMenuItem();
            turuncuToolStripMenuItem = new ToolStripMenuItem();
            griToolStripMenuItem = new ToolStripMenuItem();
            hızlıErişimToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategorilerToolStripMenuItem, renklerToolStripMenuItem, hızlıErişimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1257, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            kategorilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aksiyonToolStripMenuItem, romantikToolStripMenuItem, korkuToolStripMenuItem, bilimKurguToolStripMenuItem });
            kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            kategorilerToolStripMenuItem.Size = new Size(76, 20);
            kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            aksiyonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { madMaxToolStripMenuItem });
            aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            aksiyonToolStripMenuItem.Size = new Size(136, 22);
            aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // madMaxToolStripMenuItem
            // 
            madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
            madMaxToolStripMenuItem.Size = new Size(124, 22);
            madMaxToolStripMenuItem.Text = "Mad Max";
            // 
            // romantikToolStripMenuItem
            // 
            romantikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { psILoveUToolStripMenuItem, aynıYıldızınAltındaToolStripMenuItem });
            romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            romantikToolStripMenuItem.Size = new Size(136, 22);
            romantikToolStripMenuItem.Text = "Romantik";
            // 
            // psILoveUToolStripMenuItem
            // 
            psILoveUToolStripMenuItem.Name = "psILoveUToolStripMenuItem";
            psILoveUToolStripMenuItem.Size = new Size(180, 22);
            psILoveUToolStripMenuItem.Text = "Ps: I Love U";
            // 
            // aynıYıldızınAltındaToolStripMenuItem
            // 
            aynıYıldızınAltındaToolStripMenuItem.Name = "aynıYıldızınAltındaToolStripMenuItem";
            aynıYıldızınAltındaToolStripMenuItem.Size = new Size(180, 22);
            aynıYıldızınAltındaToolStripMenuItem.Text = "Aynı Yıldızın Altında";
            // 
            // korkuToolStripMenuItem
            // 
            korkuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { korkuSeansıToolStripMenuItem });
            korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            korkuToolStripMenuItem.Size = new Size(136, 22);
            korkuToolStripMenuItem.Text = "Korku";
            // 
            // korkuSeansıToolStripMenuItem
            // 
            korkuSeansıToolStripMenuItem.Name = "korkuSeansıToolStripMenuItem";
            korkuSeansıToolStripMenuItem.Size = new Size(141, 22);
            korkuSeansıToolStripMenuItem.Text = "Korku Seansı";
            // 
            // bilimKurguToolStripMenuItem
            // 
            bilimKurguToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uzayYolcularıToolStripMenuItem });
            bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            bilimKurguToolStripMenuItem.Size = new Size(136, 22);
            bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // uzayYolcularıToolStripMenuItem
            // 
            uzayYolcularıToolStripMenuItem.Name = "uzayYolcularıToolStripMenuItem";
            uzayYolcularıToolStripMenuItem.Size = new Size(147, 22);
            uzayYolcularıToolStripMenuItem.Text = "Uzay Yolcuları";
            // 
            // renklerToolStripMenuItem
            // 
            renklerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maviToolStripMenuItem, turuncuToolStripMenuItem, griToolStripMenuItem });
            renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            renklerToolStripMenuItem.Size = new Size(58, 20);
            renklerToolStripMenuItem.Text = "Renkler";
            // 
            // maviToolStripMenuItem
            // 
            maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            maviToolStripMenuItem.Size = new Size(118, 22);
            maviToolStripMenuItem.Text = "Mavi";
            maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
            // 
            // turuncuToolStripMenuItem
            // 
            turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            turuncuToolStripMenuItem.Size = new Size(118, 22);
            turuncuToolStripMenuItem.Text = "Turuncu";
            turuncuToolStripMenuItem.Click += turuncuToolStripMenuItem_Click;
            // 
            // griToolStripMenuItem
            // 
            griToolStripMenuItem.Name = "griToolStripMenuItem";
            griToolStripMenuItem.Size = new Size(118, 22);
            griToolStripMenuItem.Text = "Gri";
            griToolStripMenuItem.Click += griToolStripMenuItem_Click;
            // 
            // hızlıErişimToolStripMenuItem
            // 
            hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            hızlıErişimToolStripMenuItem.Size = new Size(77, 20);
            hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(180, 22);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(180, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategorilerToolStripMenuItem;
        private ToolStripMenuItem aksiyonToolStripMenuItem;
        private ToolStripMenuItem madMaxToolStripMenuItem;
        private ToolStripMenuItem romantikToolStripMenuItem;
        private ToolStripMenuItem korkuToolStripMenuItem;
        private ToolStripMenuItem bilimKurguToolStripMenuItem;
        private ToolStripMenuItem psILoveUToolStripMenuItem;
        private ToolStripMenuItem aynıYıldızınAltındaToolStripMenuItem;
        private ToolStripMenuItem korkuSeansıToolStripMenuItem;
        private ToolStripMenuItem uzayYolcularıToolStripMenuItem;
        private ToolStripMenuItem renklerToolStripMenuItem;
        private ToolStripMenuItem maviToolStripMenuItem;
        private ToolStripMenuItem turuncuToolStripMenuItem;
        private ToolStripMenuItem griToolStripMenuItem;
        private ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
