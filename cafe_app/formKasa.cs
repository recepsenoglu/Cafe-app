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
    public partial class formKasa : Form
    {
        public formKasa()
        {
            InitializeComponent();
        }
        // Garson seçme formundan gelen masa numarasını bu değişkende tutuyoruz
        public string masa_numarasi;

        // Gerekli değişkenleri oluşturduk
        int[] idler = new int[10];
        string[] saatler = new string[10];
        string[] garsonlar = new string[10];
        string[] ucretler = new string[10];
        string[] siparisler = new string[10];
        double toplamUcret = 0.0;

        // Kasa formu açıldığında seçilen masanın değerlerini alıyoruz
        private void formKasa_Load(object sender, EventArgs e)
        {
            // Kafe sınıfından masabilgilerigetir statik metodunu çağırarark o masanın sipariş bilgilerini aldık
            DataTable MasaBilgileri = Kafe.MasaBilgileriGetir(masa_numarasi);

            for(int i = 0; i < MasaBilgileri.Rows.Count; i++)
            {
                idler[i] = int.Parse(MasaBilgileri.Rows[i]["id"].ToString());
                ucretler[i] = MasaBilgileri.Rows[i]["ucret"].ToString();
                siparisler[i] = MasaBilgileri.Rows[i]["siparisler"].ToString();
                saatler[i] = MasaBilgileri.Rows[i]["saat"].ToString();
                garsonlar[i] = MasaBilgileri.Rows[i]["garson"].ToString();
            }

            lblMasaNumarasi.Text = "Masa " + masa_numarasi + "'in Tüm Siparişleri";

            // Siparişleri ve fiyatlarını listelemek için listele metodunu çağırdık
            Listele();
        }

        // Listele metodu seçilen masanın verdiği siparişleri, fiyatlarını ve toplam fiyatı labeller oluşturarak listeler
        private void Listele()
        {
            int indis0 = 0;
            int indis1 = 0;
            while(siparisler[indis0] != null)
            {
                // Her siparişin saatini ve siparişi alan garson ismini yazdırdık
                Label lblSaat = new Label();
                lblSaat.Text = saatler[indis0] + "  -  Garson " + garsonlar[indis0];
                lblSaat.Font = new Font(lblSaat.Font.Name, 10F);
                lblSaat.Width = 500;
                lblSaat.Height = 15;
                Controls.Add(lblSaat);
                lblSaat.Top = 33 + indis1 * 21;
                lblSaat.Left = 7;
                indis1++; 

                // Düzensiz biçimde gelen siparişleri sözlüğe aktararak key=sipariş,value=adet şeklinde düzenledik
                var DuzenliSiparisler = Kafe.SiparisSozlukOlustur(siparisler[indis0].Split(','));

                Location = new Point(500, 80);
                
                foreach (KeyValuePair<string, int> siparis in DuzenliSiparisler)
                {
                    // Her siparişin adet ve fiyatını çarparak toplam ücret değişkenine ekledik
                    toplamUcret += Kafe.UcretGetir(siparis.Key.ToString()) * int.Parse(siparis.Value.ToString());

                    // Her siparişin labelini oluşturup textini yazdırdık
                    Label label = new Label();
                    label.Text = siparis.Value.ToString() + " adet " + siparis.Key.ToString() + " : " +
                        (Kafe.UcretGetir(siparis.Key.ToString()) * int.Parse(siparis.Value.ToString())) + "₺";
                    label.Font = new Font(label.Font.Name, 10F);
                    label.Width = 500;
                    Controls.Add(label);
                    label.Top = 35 + indis1 * 21;
                    label.Left = 7;
                    indis1++;
                }
                indis0++;
            }

            // Toplam ücret
            Label lblToplamUcret = new Label();
            lblToplamUcret.Text = "Toplam Ödenecek Tutar: " + toplamUcret.ToString() + "₺";
            lblToplamUcret.Font = new Font(lblToplamUcret.Font.Name, 16F);
            lblToplamUcret.Width = 500;
            Controls.Add(lblToplamUcret);
            lblToplamUcret.Top = 60 + indis1 * 21;
            lblToplamUcret.Left = 7;
            indis1++;

            // Ödeme butonu oluşturduk
            Button odemeButonu = new Button();
            odemeButonu.Text = "Ödeme al";
            odemeButonu.Width = 500;
            odemeButonu.Height = 40;
            Controls.Add(odemeButonu);
            odemeButonu.Click += new System.EventHandler(this.OdemeAl);
            odemeButonu.Top = 80 + indis1 * 21;
            odemeButonu.Left = 7;
        }

        // Ödeme butonun basıldığı zaman ödeme al metodu çalışır ve bu metod ödeme alma formunu açar
        private void OdemeAl(object sender, EventArgs e)
        {
            formOdemeAl formOdemeAl = new formOdemeAl();
            formOdemeAl.idler = idler;
            formOdemeAl.toplamUcret = toplamUcret;
            formOdemeAl.masa_numarasi = masa_numarasi;
            formOdemeAl.Show();
            Hide();
        }

        // Bu form kapandığında giriş formu açılır
        private void formKasa_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();
        }
    }
}
