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
    public partial class formSiparisAyrintilar : Form
    {
        public formSiparisAyrintilar()
        {
            InitializeComponent();
        }
        // Gerekli değişkenler ve önceki formdan gelen değişkenler
        public string siparisId;
        string masa_numarasi;
        string saat;
        string garson;
        string[] siparisler;

        // Form açıldığı zaman geçerli siparişin bilgileri Kafe sınıfında bulunan sipariş bilgileri getir statik metodu ile 
        // getirilir ve siparişlistele metodu çağırılır
        
        private void formSiparisAyrintilar_Load(object sender, EventArgs e)
        {
            DataTable gecerliSiparis = Kafe.SiparisBilgileriGetir(siparisId);
            masa_numarasi = gecerliSiparis.Rows[0]["masa_numarasi"].ToString();
            siparisler = gecerliSiparis.Rows[0]["siparisler"].ToString().Split(',');
            saat = gecerliSiparis.Rows[0]["saat"].ToString();
            garson = gecerliSiparis.Rows[0]["garson"].ToString();

            lblMasaNumarasi.Text = "Masa " + masa_numarasi + "'in Siparişi";
            lblGarson.Text = "Siparişi alan: " + garson;
            lblSiparisSaati.Text = "Sipariş saati: " + saat;
            pictureboxGarson.Image = Image.FromFile(Kafe.path + "//resimler//" + garson + ".png");
            pictureboxGarson.SizeMode = PictureBoxSizeMode.Zoom;
            SiparisleriListele(siparisler);
        }
        // Siparişleri sözlüğe aktarır ve düzenli bir biçinde listeler
        private void SiparisleriListele(string[] siparisler)
        {
            var DuzenliSiparisler = Kafe.SiparisSozlukOlustur(siparisler);

            //Size = new Size(300, 230 + (DuzenliSiparisler.Count() * 28));
            Location = new Point(500, 100);

            int count = 0;
            foreach(KeyValuePair<string, int> siparis in DuzenliSiparisler)
            {
                Label label = new Label();
                label.Text = siparis.Value.ToString() + " adet " + siparis.Key.ToString();
                label.Font = new Font(label.Font.Name, 12F);
                label.Width = 500;
                Controls.Add(label);
                label.Top = count * 30 + 180;
                label.Left = 7;
                count++;
            }
        }
    }
}
