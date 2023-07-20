namespace CokKatmanliMimari.PL
{
    partial class KitapArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapArama));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.kitapId = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.kitapYazar = new System.Windows.Forms.Label();
            this.kitapSayfa = new System.Windows.Forms.Label();
            this.kitapTuru = new System.Windows.Forms.Label();
            this.kitapAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.idKitapListe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapAlimTeslimListe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOgrenciId = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idKitapListe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(833, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.ImageKey = "reply.png";
            this.button2.Location = new System.Drawing.Point(25, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 28);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenci.ForeColor = System.Drawing.Color.Gray;
            this.lblOgrenci.Location = new System.Drawing.Point(370, 10);
            this.lblOgrenci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(171, 29);
            this.lblOgrenci.TabIndex = 40;
            this.lblOgrenci.Text = "Kitap Bilgileri";
            // 
            // kitapId
            // 
            this.kitapId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kitapId.Location = new System.Drawing.Point(78, 497);
            this.kitapId.Margin = new System.Windows.Forms.Padding(2);
            this.kitapId.Name = "kitapId";
            this.kitapId.Size = new System.Drawing.Size(76, 20);
            this.kitapId.TabIndex = 43;
            this.kitapId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitapId_KeyPress);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.OldLace;
            this.btnGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGetir.Location = new System.Drawing.Point(168, 495);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(391, 22);
            this.btnGetir.TabIndex = 45;
            this.btnGetir.Text = "Göster";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 498);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Kitap ID:";
            // 
            // kitapYazar
            // 
            this.kitapYazar.AutoSize = true;
            this.kitapYazar.BackColor = System.Drawing.Color.Transparent;
            this.kitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapYazar.ForeColor = System.Drawing.Color.White;
            this.kitapYazar.Location = new System.Drawing.Point(96, 172);
            this.kitapYazar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Size = new System.Drawing.Size(44, 17);
            this.kitapYazar.TabIndex = 52;
            this.kitapYazar.Text = "------";
            // 
            // kitapSayfa
            // 
            this.kitapSayfa.AutoSize = true;
            this.kitapSayfa.BackColor = System.Drawing.Color.Transparent;
            this.kitapSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapSayfa.ForeColor = System.Drawing.Color.White;
            this.kitapSayfa.Location = new System.Drawing.Point(137, 99);
            this.kitapSayfa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapSayfa.Name = "kitapSayfa";
            this.kitapSayfa.Size = new System.Drawing.Size(44, 17);
            this.kitapSayfa.TabIndex = 51;
            this.kitapSayfa.Text = "------";
            // 
            // kitapTuru
            // 
            this.kitapTuru.AutoSize = true;
            this.kitapTuru.BackColor = System.Drawing.Color.Transparent;
            this.kitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapTuru.ForeColor = System.Drawing.Color.White;
            this.kitapTuru.Location = new System.Drawing.Point(91, 131);
            this.kitapTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapTuru.Name = "kitapTuru";
            this.kitapTuru.Size = new System.Drawing.Size(44, 17);
            this.kitapTuru.TabIndex = 50;
            this.kitapTuru.Text = "------";
            // 
            // kitapAd
            // 
            this.kitapAd.AutoSize = true;
            this.kitapAd.BackColor = System.Drawing.Color.Transparent;
            this.kitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAd.ForeColor = System.Drawing.Color.White;
            this.kitapAd.Location = new System.Drawing.Point(114, 55);
            this.kitapAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(44, 17);
            this.kitapAd.TabIndex = 49;
            this.kitapAd.Text = "------";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(28, 172);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(65, 17);
            this.lblSifre.TabIndex = 56;
            this.lblSifre.Text = "Yazar : ";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(28, 99);
            this.lblNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(112, 17);
            this.lblNo.TabIndex = 55;
            this.lblNo.Text = "Sayfa Sayısı : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(28, 131);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 17);
            this.lblSoyad.TabIndex = 54;
            this.lblSoyad.Text = "Türü : ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(28, 55);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(88, 17);
            this.lblAd.TabIndex = 53;
            this.lblAd.Text = "Kİtap Adı : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.idKitapListe);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(25, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 299);
            this.panel1.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(87, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "ID LİSTESİ";
            // 
            // idKitapListe
            // 
            this.idKitapListe.AllowUserToAddRows = false;
            this.idKitapListe.AllowUserToDeleteRows = false;
            this.idKitapListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idKitapListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.idKitapListe.BackgroundColor = System.Drawing.Color.White;
            this.idKitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idKitapListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idKitapListe.Location = new System.Drawing.Point(14, 31);
            this.idKitapListe.Margin = new System.Windows.Forms.Padding(2);
            this.idKitapListe.Name = "idKitapListe";
            this.idKitapListe.ReadOnly = true;
            this.idKitapListe.RowHeadersWidth = 51;
            this.idKitapListe.RowTemplate.Height = 24;
            this.idKitapListe.Size = new System.Drawing.Size(234, 252);
            this.idKitapListe.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.kitapAlimTeslimListe);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.kitapId);
            this.panel2.Controls.Add(this.btnGetir);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(303, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 528);
            this.panel2.TabIndex = 59;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "KİTABI ALANLARIN LİSTESİ";
            // 
            // kitapAlimTeslimListe
            // 
            this.kitapAlimTeslimListe.AllowUserToAddRows = false;
            this.kitapAlimTeslimListe.AllowUserToDeleteRows = false;
            this.kitapAlimTeslimListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapAlimTeslimListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kitapAlimTeslimListe.BackgroundColor = System.Drawing.Color.White;
            this.kitapAlimTeslimListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapAlimTeslimListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapAlimTeslimListe.Location = new System.Drawing.Point(15, 30);
            this.kitapAlimTeslimListe.Margin = new System.Windows.Forms.Padding(2);
            this.kitapAlimTeslimListe.Name = "kitapAlimTeslimListe";
            this.kitapAlimTeslimListe.ReadOnly = true;
            this.kitapAlimTeslimListe.RowHeadersWidth = 51;
            this.kitapAlimTeslimListe.RowTemplate.Height = 24;
            this.kitapAlimTeslimListe.Size = new System.Drawing.Size(544, 453);
            this.kitapAlimTeslimListe.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Kitap Detaylı Bilgi";
            // 
            // lblOgrenciId
            // 
            this.lblOgrenciId.AutoSize = true;
            this.lblOgrenciId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOgrenciId.Location = new System.Drawing.Point(145, 191);
            this.lblOgrenciId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrenciId.Name = "lblOgrenciId";
            this.lblOgrenciId.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciId.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.kitapAd);
            this.panel3.Controls.Add(this.kitapTuru);
            this.panel3.Controls.Add(this.kitapSayfa);
            this.panel3.Controls.Add(this.kitapYazar);
            this.panel3.Controls.Add(this.lblSifre);
            this.panel3.Controls.Add(this.lblAd);
            this.panel3.Controls.Add(this.lblNo);
            this.panel3.Controls.Add(this.lblSoyad);
            this.panel3.Location = new System.Drawing.Point(25, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 214);
            this.panel3.TabIndex = 62;
            // 
            // KitapArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblOgrenciId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitapArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapArama";
            this.Load += new System.EventHandler(this.KitapArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idKitapListe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.TextBox kitapId;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label kitapYazar;
        private System.Windows.Forms.Label kitapSayfa;
        private System.Windows.Forms.Label kitapTuru;
        private System.Windows.Forms.Label kitapAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView idKitapListe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView kitapAlimTeslimListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblOgrenciId;
        private System.Windows.Forms.Panel panel3;
    }
}