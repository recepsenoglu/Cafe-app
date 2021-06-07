
namespace cafe_app
{
    partial class formSiparisAyrintilar
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
            this.lblMasaNumarasi = new System.Windows.Forms.Label();
            this.lblSiparisSaati = new System.Windows.Forms.Label();
            this.lblGarson = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureboxGarson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGarson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMasaNumarasi
            // 
            this.lblMasaNumarasi.AutoSize = true;
            this.lblMasaNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNumarasi.Location = new System.Drawing.Point(92, 23);
            this.lblMasaNumarasi.Name = "lblMasaNumarasi";
            this.lblMasaNumarasi.Size = new System.Drawing.Size(227, 31);
            this.lblMasaNumarasi.TabIndex = 0;
            this.lblMasaNumarasi.Text = "Masa X\'in Siparişi";
            // 
            // lblSiparisSaati
            // 
            this.lblSiparisSaati.AutoSize = true;
            this.lblSiparisSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisSaati.Location = new System.Drawing.Point(16, 73);
            this.lblSiparisSaati.Name = "lblSiparisSaati";
            this.lblSiparisSaati.Size = new System.Drawing.Size(112, 20);
            this.lblSiparisSaati.TabIndex = 1;
            this.lblSiparisSaati.Text = "Sipariş saati: ";
            // 
            // lblGarson
            // 
            this.lblGarson.AutoSize = true;
            this.lblGarson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGarson.Location = new System.Drawing.Point(17, 107);
            this.lblGarson.Name = "lblGarson";
            this.lblGarson.Size = new System.Drawing.Size(106, 20);
            this.lblGarson.TabIndex = 2;
            this.lblGarson.Text = "Siparişi alan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(152, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Siparişler";
            // 
            // pictureboxGarson
            // 
            this.pictureboxGarson.Location = new System.Drawing.Point(258, 73);
            this.pictureboxGarson.Name = "pictureboxGarson";
            this.pictureboxGarson.Size = new System.Drawing.Size(121, 100);
            this.pictureboxGarson.TabIndex = 4;
            this.pictureboxGarson.TabStop = false;
            // 
            // formSiparisAyrintilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 528);
            this.Controls.Add(this.pictureboxGarson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGarson);
            this.Controls.Add(this.lblSiparisSaati);
            this.Controls.Add(this.lblMasaNumarasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formSiparisAyrintilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Ayrıntıları";
            this.Load += new System.EventHandler(this.formSiparisAyrintilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGarson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasaNumarasi;
        private System.Windows.Forms.Label lblSiparisSaati;
        private System.Windows.Forms.Label lblGarson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureboxGarson;
    }
}