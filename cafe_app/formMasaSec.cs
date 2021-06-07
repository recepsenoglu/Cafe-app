using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_app
{
    public partial class formMasaSec : Form
    {
        public formMasaSec()
        {
            InitializeComponent();
        }
        // Önceki formdan gelen değişkenler
        public string garson;
        public string amac;

        // Masa seçme formu açıldığında masa butonları oluşturulur
        private void formGarson_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "Lütfen Masa Seçin";
            lbl.Font = new Font("Calibri", 16);
            lbl.Width = 500;
            lbl.Top = 13;
            lbl.Left = 150;
            Controls.Add(lbl);

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Text = (i*5 + j+1).ToString();
                    btn.Font = new Font("Calibri", 20);
                    btn.Height = 70;
                    btn.Width = 70;
                    btn.Top = 40 + i * 90;
                    btn.Left = 20 + j * 90;
                    btn.TabStop = false;
                    btn.Click += new System.EventHandler(this.btnClick);

                    this.Controls.Add(btn);
                }           
            }
        }

        // Masa butonlarından birine tıklandığında formun açılış amacına göre sipariş ekle formu ya da
        // ödeme al formu açılır
        private void btnClick(object sender, EventArgs e)
        {
            string masa_numarasi = ((Button)sender).Text;

            if(amac == "siparis_ekle")
            {
                formSiparisEkle formSiparisEkle = new formSiparisEkle();
                formSiparisEkle.masa_numarası = masa_numarasi;
                formSiparisEkle.garson = garson;
                formSiparisEkle.Show();
                Hide();
            }
            else if (amac == "odeme_al")
            {
                if (Kafe.MasaDolumu(masa_numarasi))
                {
                    formKasa formKasa = new formKasa();
                    formKasa.masa_numarasi = masa_numarasi;
                    formKasa.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Bu masa boş.");
            }
        }

        // Bu form kapandığında giriş formu açılır
        private void formGarson_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();
        }
    }
}
