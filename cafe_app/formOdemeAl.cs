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
    public partial class formOdemeAl : Form
    {
        public formOdemeAl()
        {
            InitializeComponent();
        }
        // Önceki formdan gelen değişkenler
        public string masa_numarasi;
        public int[] idler;
        public double toplamUcret;

        // Form açıldığında ödenecek tutar bir labelde yazar
        private void formOdemeAl_Load(object sender, EventArgs e)
        {
            lblOdenecekTutar.Text = "Ödenecek Tutar: " + toplamUcret.ToString() + "₺";
        }
        // sayı veya virgül butonlarına basıldığında butonun texti textboxa eklenir
        private void butonClick(object sender, EventArgs e)
        {
            txtOdeme.Text += ((Button)sender).Text;
        }
        // textboxın en sağındaki değer silinir
        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtOdeme.Text != "") txtOdeme.Text = txtOdeme.Text.Substring(0, txtOdeme.TextLength - 1);
        }
        // Öde butonuna basıldığında ücret yeterli değil ise hata mesajı verir. Ücret yeterli ise Kafe sınıfındaki
        // siparişsil metodu çağırılır ve önceki formdan gelen sipariş idleri parametre olarak verilir ve veri tabanından
        // bu siparişler silinir. Daha sonra işlem başarılı diye bir mesaj gönderilir. Ve para üstü gösterilir.
        private void btnOde_Click(object sender, EventArgs e)
        {
            double tutar = double.Parse(txtOdeme.Text);
            if(tutar < toplamUcret)
            {
                MessageBox.Show("Lütfen yeterli miktar girin!");
            }
            else
            {
                for (int i = 0; i < idler.Length; i++)
                    Kafe.SiparisSil(idler[i].ToString());

                string mesaj ="Ödeme işlemi başarıyla gerçekleşti.\nPara üstü: " + (tutar - toplamUcret).ToString();
                string baslik = "Başarılı";
                var sonuc = MessageBox.Show(mesaj, baslik,MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (sonuc == DialogResult.OK)
                {
                    GirisFormu girisFormu = new GirisFormu();
                    girisFormu.Show();
                    Hide();
                }
            }
        }

        // Bu form kapandığında giriş formu açılır
        private void formOdemeAl_FormClosed(object sender, FormClosedEventArgs e)
        {
            formKasa formKasa = new formKasa();
            formKasa.masa_numarasi = masa_numarasi;
            formKasa.Show();
        }
    }
}
