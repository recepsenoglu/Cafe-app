
namespace cafe_app
{
    partial class GirisFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnSef = new System.Windows.Forms.Button();
            this.btnGarson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKasa
            // 
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.Image = global::cafe_app.Properties.Resources.kasa;
            this.btnKasa.Location = new System.Drawing.Point(635, 16);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(283, 500);
            this.btnKasa.TabIndex = 0;
            this.btnKasa.TabStop = false;
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnSef
            // 
            this.btnSef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSef.Image = global::cafe_app.Properties.Resources.seff;
            this.btnSef.Location = new System.Drawing.Point(336, 16);
            this.btnSef.Name = "btnSef";
            this.btnSef.Size = new System.Drawing.Size(283, 500);
            this.btnSef.TabIndex = 0;
            this.btnSef.TabStop = false;
            this.btnSef.UseVisualStyleBackColor = true;
            this.btnSef.Click += new System.EventHandler(this.btnSef_Click);
            // 
            // btnGarson
            // 
            this.btnGarson.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGarson.Image = global::cafe_app.Properties.Resources.garson1;
            this.btnGarson.Location = new System.Drawing.Point(31, 16);
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.Size = new System.Drawing.Size(289, 500);
            this.btnGarson.TabIndex = 0;
            this.btnGarson.TabStop = false;
            this.btnGarson.UseVisualStyleBackColor = true;
            this.btnGarson.Click += new System.EventHandler(this.btnGarson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(437, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ŞEF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(721, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "KASA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "GARSON";
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnSef);
            this.Controls.Add(this.btnGarson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGarson;
        private System.Windows.Forms.Button btnSef;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

