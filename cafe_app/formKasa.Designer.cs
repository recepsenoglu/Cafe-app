
namespace cafe_app
{
    partial class formKasa
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
            this.SuspendLayout();
            // 
            // lblMasaNumarasi
            // 
            this.lblMasaNumarasi.AutoSize = true;
            this.lblMasaNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNumarasi.Location = new System.Drawing.Point(12, 9);
            this.lblMasaNumarasi.Name = "lblMasaNumarasi";
            this.lblMasaNumarasi.Size = new System.Drawing.Size(301, 29);
            this.lblMasaNumarasi.TabIndex = 0;
            this.lblMasaNumarasi.Text = "Masa X\'in Tüm Siparişleri";
            // 
            // formKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 892);
            this.Controls.Add(this.lblMasaNumarasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formKasa_FormClosed);
            this.Load += new System.EventHandler(this.formKasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasaNumarasi;
    }
}