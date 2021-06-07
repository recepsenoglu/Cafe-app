
namespace cafe_app
{
    partial class formSiparisEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icecekler = new System.Windows.Forms.Button();
            this.tatlilar = new System.Windows.Forms.Button();
            this.pizzalar = new System.Windows.Forms.Button();
            this.tostveburgerler = new System.Windows.Forms.Button();
            this.kahvalti = new System.Windows.Forms.Button();
            this.aperatifler = new System.Windows.Forms.Button();
            this.listboxSiparisListesi = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSiparisiGonder = new System.Windows.Forms.Button();
            this.lblMasaNumarasi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.icecekler);
            this.groupBox1.Controls.Add(this.tatlilar);
            this.groupBox1.Controls.Add(this.pizzalar);
            this.groupBox1.Controls.Add(this.tostveburgerler);
            this.groupBox1.Controls.Add(this.kahvalti);
            this.groupBox1.Controls.Add(this.aperatifler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriler";
            // 
            // icecekler
            // 
            this.icecekler.Location = new System.Drawing.Point(10, 330);
            this.icecekler.Name = "icecekler";
            this.icecekler.Size = new System.Drawing.Size(141, 53);
            this.icecekler.TabIndex = 5;
            this.icecekler.TabStop = false;
            this.icecekler.Text = "İçecekler";
            this.icecekler.UseVisualStyleBackColor = true;
            this.icecekler.Click += new System.EventHandler(this.menuGetir);
            // 
            // tatlilar
            // 
            this.tatlilar.Location = new System.Drawing.Point(10, 271);
            this.tatlilar.Name = "tatlilar";
            this.tatlilar.Size = new System.Drawing.Size(141, 53);
            this.tatlilar.TabIndex = 4;
            this.tatlilar.TabStop = false;
            this.tatlilar.Text = "Tatlılar";
            this.tatlilar.UseVisualStyleBackColor = true;
            this.tatlilar.Click += new System.EventHandler(this.menuGetir);
            // 
            // pizzalar
            // 
            this.pizzalar.Location = new System.Drawing.Point(9, 212);
            this.pizzalar.Name = "pizzalar";
            this.pizzalar.Size = new System.Drawing.Size(142, 53);
            this.pizzalar.TabIndex = 3;
            this.pizzalar.TabStop = false;
            this.pizzalar.Text = "Pizzalar";
            this.pizzalar.UseVisualStyleBackColor = true;
            this.pizzalar.Click += new System.EventHandler(this.menuGetir);
            // 
            // tostveburgerler
            // 
            this.tostveburgerler.Location = new System.Drawing.Point(9, 153);
            this.tostveburgerler.Name = "tostveburgerler";
            this.tostveburgerler.Size = new System.Drawing.Size(142, 53);
            this.tostveburgerler.TabIndex = 2;
            this.tostveburgerler.TabStop = false;
            this.tostveburgerler.Text = "Tost ve Burgerler";
            this.tostveburgerler.UseVisualStyleBackColor = true;
            this.tostveburgerler.Click += new System.EventHandler(this.menuGetir);
            // 
            // kahvalti
            // 
            this.kahvalti.Location = new System.Drawing.Point(10, 94);
            this.kahvalti.Name = "kahvalti";
            this.kahvalti.Size = new System.Drawing.Size(141, 53);
            this.kahvalti.TabIndex = 0;
            this.kahvalti.TabStop = false;
            this.kahvalti.Text = "Kahvaltı";
            this.kahvalti.UseVisualStyleBackColor = true;
            this.kahvalti.Click += new System.EventHandler(this.menuGetir);
            // 
            // aperatifler
            // 
            this.aperatifler.Location = new System.Drawing.Point(10, 35);
            this.aperatifler.Name = "aperatifler";
            this.aperatifler.Size = new System.Drawing.Size(141, 53);
            this.aperatifler.TabIndex = 1;
            this.aperatifler.TabStop = false;
            this.aperatifler.Text = "Aperatifler";
            this.aperatifler.UseVisualStyleBackColor = true;
            this.aperatifler.Click += new System.EventHandler(this.menuGetir);
            // 
            // listboxSiparisListesi
            // 
            this.listboxSiparisListesi.FormattingEnabled = true;
            this.listboxSiparisListesi.ItemHeight = 16;
            this.listboxSiparisListesi.Location = new System.Drawing.Point(756, 45);
            this.listboxSiparisListesi.Name = "listboxSiparisListesi";
            this.listboxSiparisListesi.Size = new System.Drawing.Size(235, 372);
            this.listboxSiparisListesi.TabIndex = 1;
            this.listboxSiparisListesi.Click += new System.EventHandler(this.listboxSiparisListesi_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(756, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(235, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSiparisiGonder
            // 
            this.btnSiparisiGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiGonder.Location = new System.Drawing.Point(756, 425);
            this.btnSiparisiGonder.Name = "btnSiparisiGonder";
            this.btnSiparisiGonder.Size = new System.Drawing.Size(235, 59);
            this.btnSiparisiGonder.TabIndex = 3;
            this.btnSiparisiGonder.TabStop = false;
            this.btnSiparisiGonder.Text = "Siparişi Gönder";
            this.btnSiparisiGonder.UseVisualStyleBackColor = true;
            this.btnSiparisiGonder.Click += new System.EventHandler(this.btnSiparisiGonder_Click);
            // 
            // lblMasaNumarasi
            // 
            this.lblMasaNumarasi.AutoSize = true;
            this.lblMasaNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNumarasi.Location = new System.Drawing.Point(22, 436);
            this.lblMasaNumarasi.Name = "lblMasaNumarasi";
            this.lblMasaNumarasi.Size = new System.Drawing.Size(187, 29);
            this.lblMasaNumarasi.TabIndex = 4;
            this.lblMasaNumarasi.Text = "Masa numarası";
            // 
            // formSiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 496);
            this.Controls.Add(this.lblMasaNumarasi);
            this.Controls.Add(this.btnSiparisiGonder);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listboxSiparisListesi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formSiparisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Gir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSiparisEkle_FormClosed);
            this.Load += new System.EventHandler(this.formSiparisEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button icecekler;
        private System.Windows.Forms.Button tatlilar;
        private System.Windows.Forms.Button pizzalar;
        private System.Windows.Forms.Button tostveburgerler;
        private System.Windows.Forms.Button kahvalti;
        private System.Windows.Forms.Button aperatifler;
        private System.Windows.Forms.ListBox listboxSiparisListesi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSiparisiGonder;
        private System.Windows.Forms.Label lblMasaNumarasi;
    }
}