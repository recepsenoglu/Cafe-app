
namespace cafe_app
{
    partial class formSef
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
            this.components = new System.ComponentModel.Container();
            this.datagridSiparisler = new System.Windows.Forms.DataGridView();
            this.cntxtmnSiparis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tamamlandi = new System.Windows.Forms.ToolStripMenuItem();
            this.sil = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridSiparisler)).BeginInit();
            this.cntxtmnSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridSiparisler
            // 
            this.datagridSiparisler.AllowUserToAddRows = false;
            this.datagridSiparisler.AllowUserToResizeColumns = false;
            this.datagridSiparisler.AllowUserToResizeRows = false;
            this.datagridSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSiparisler.BackgroundColor = System.Drawing.Color.White;
            this.datagridSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSiparisler.ContextMenuStrip = this.cntxtmnSiparis;
            this.datagridSiparisler.Location = new System.Drawing.Point(12, 12);
            this.datagridSiparisler.Name = "datagridSiparisler";
            this.datagridSiparisler.ReadOnly = true;
            this.datagridSiparisler.RowHeadersWidth = 51;
            this.datagridSiparisler.RowTemplate.Height = 24;
            this.datagridSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSiparisler.Size = new System.Drawing.Size(349, 447);
            this.datagridSiparisler.TabIndex = 0;
            this.datagridSiparisler.DoubleClick += new System.EventHandler(this.datagridSiparisler_DoubleClick);
            // 
            // cntxtmnSiparis
            // 
            this.cntxtmnSiparis.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtmnSiparis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamamlandi,
            this.sil});
            this.cntxtmnSiparis.Name = "cntxtmnSiparis";
            this.cntxtmnSiparis.Size = new System.Drawing.Size(160, 52);
            // 
            // tamamlandi
            // 
            this.tamamlandi.Name = "tamamlandi";
            this.tamamlandi.Size = new System.Drawing.Size(159, 24);
            this.tamamlandi.Text = "Tamamlandı";
            this.tamamlandi.Click += new System.EventHandler(this.tamamlandi_Click);
            // 
            // sil
            // 
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(159, 24);
            this.sil.Text = "Sil";
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formSef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 478);
            this.Controls.Add(this.datagridSiparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formSef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şef Siparişleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSef_FormClosed);
            this.Load += new System.EventHandler(this.formSef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridSiparisler)).EndInit();
            this.cntxtmnSiparis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cntxtmnSiparis;
        private System.Windows.Forms.ToolStripMenuItem tamamlandi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sil;
        public System.Windows.Forms.DataGridView datagridSiparisler;
    }
}