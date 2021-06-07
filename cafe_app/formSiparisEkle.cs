using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cafe_app
{
    public partial class formSiparisEkle : Form
    {
        public formSiparisEkle()
        {
            InitializeComponent();
        }
        // Önceki formdan gelen değişkenler
        public string masa_numarası;
        public string garson;
        // Buton dizini oluşturduk
        Button[] butonlar = new Button[16];

        // Bu form kapandığında giriş formu açılır
        private void formSiparisEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();
        }

        // Bu form açıldığında Kafe sınıfının statik bir metodu olan menuleriveritabanindancek metodu çağırılır.
        // Ayrıca menu getir metodu da aperatifler parametresiyle çağırılır ve labele masa numarası yazdırılır.
        private void formSiparisEkle_Load(object sender, EventArgs e)
        {
            Kafe.MenuleriVeritabanindanCek();
            menuGetir(aperatifler, e);
            lblMasaNumarasi.Text = "Masa " + masa_numarası;
        }
        // İlgili menüyü Kafe sınıfından çeker ve buton isimleri ayarlama metodunu çağırır
        private void menuGetir(object sender, EventArgs e)
        {
            Dictionary<string, double> menu = Kafe.MenuGetir(((Button)sender).Name);
            buton_isimleri_ayarla(menu);
        }

        // Parametre olarak verilen sözlük tipindeki menünün keylerini yani ürün isimlerini butonlar oluşturup sırasıyla yazdırır.
        private void buton_isimleri_ayarla(Dictionary<string, double> menu)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Controls.Remove(butonlar[(i * 4 + j)]);
                }
            }
            int k = 0, l = 0;

            foreach (KeyValuePair<string, double> urun in menu)
            {
                Button btn = new Button();
                btn.Name = "btn" + (k * 4 + l).ToString();
                btn.Text = urun.Key;
                btn.Height = 55;
                btn.Width = 80;
                btn.Top = 35 + k * 75;
                btn.Left = 170 + l * 90;
                btn.Click += new System.EventHandler(this.SipariseEkle);
                butonlar[(k * 4 + l)] = btn;
                this.Controls.Add(btn);
                l++;
                if (l == 4)
                {
                    l = 0;
                    k++;
                }
            }
        }

        // Bir üst metodda oluşturulan ürün butonlarından herhangi birine tıklandığı zaman tıklanan butonun textini 
        // sipariş listesi adlı listboxa ekler
        private void SipariseEkle(object sender, EventArgs e)
        {
            listboxSiparisListesi.Items.Add(((Button)sender).Text);
        }
        // Sipariş listesi listboxından seçilen ürünü siler
        private void btnSil_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            int secim = listboxSiparisListesi.SelectedIndex;
            if (secim != -1)
                listboxSiparisListesi.Items.RemoveAt(secim);
        }
        // Siparişi göndere basıldığı zaman listboxtaki siparişler içinde döner ve bu siparişleri Kafe sınıfının statik bir metodu
        // olan SiparisGonder metoduna parametre olarak verir ve siparişleri ve ücretlerini veritabanına ekler
        private void btnSiparisiGonder_Click(object sender, EventArgs e)
        {
            string siparisler = "";
            double ucret = 0.0;
            for (int i = 0; i < listboxSiparisListesi.Items.Count; i++)
            {
                siparisler += listboxSiparisListesi.Items[i].ToString() + ",";
                ucret += Kafe.UcretGetir(listboxSiparisListesi.Items[i].ToString());
            }
            if(siparisler != "") siparisler = siparisler.Substring(0, siparisler.Length - 1);

            if (!Kafe.SiparisGonder(masa_numarası, siparisler, ucret.ToString(), garson)) MessageBox.Show("Bir hata oluştu!");
            else
            {
                MessageBox.Show("Sipariş başarıyla kaydedildi.");
                Close();
            }
        }
        // Listboxta hiçbişey seçilmediği zaman sil butonunun deaktif kalmasını sağlar
        private void listboxSiparisListesi_Click(object sender, EventArgs e)
        {
            if (listboxSiparisListesi.Items.Count > 0 && listboxSiparisListesi.SelectedIndex != -1)
                btnSil.Enabled = true;
        }
    }
}
