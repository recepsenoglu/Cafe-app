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
    public partial class formSef : Form
    {
        public formSef()
        {
            InitializeComponent();
        }
        // Form açıldığında siparişleri görüntüle metodu çağırılır
        private void formSef_Load(object sender, EventArgs e)
        {
            SiparisleriGorüntüle();
            timer1.Start();
        }
        // Kafe sınıfından siparislerigetir statik metodu çağırılır ve siparişler datagridviewda gösterilir
        private void SiparisleriGorüntüle()
        {
            datagridSiparisler.DataSource = Kafe.SiparisleriGetir();
            datagridSiparisler.Columns[0].Width = 0;
            datagridSiparisler.Columns[1].Width = 60;
            datagridSiparisler.Columns[1].HeaderText = "Sipariş Saati";
            datagridSiparisler.Columns[2].HeaderText = "Masa Numarası";
            datagridSiparisler.Columns[3].HeaderText = "Sipariş Durumu";
        }

        // Siparişler her 10 saniyede bir yenilenir
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye % 5 == 0) SiparisleriGorüntüle();
            saniye++;
        }
        // Sağ tık menüsündeki Sil butonuna basıldığında Emin misiniz mesajı çıkar ve evete basılırsa Kafe sınıfında
        // bulunan siparissil statik metodu çağırılır. İlgili sipariş silinir.
        private void sil_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Siparişi silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop))
            {
                // Exam sınıfında bulunan static deneme silme metodu. Parametre olarak deneme id'si alır
                Kafe.SiparisSil(datagridSiparisler.CurrentRow.Cells["id"].Value.ToString());
                SiparisleriGorüntüle();
                MessageBox.Show("Sipariş başarıyla silindi.");
            }
        }
        // Sağ tık menüsündeki Tamamlandı butonuna basıldığında Emin misiniz mesajı çıkar ve evete basılırsa Kafe sınıfında
        // bulunan siparistamamla statik metodu çağırılır. İlgili siparişin sipariş durumu değeri tamamlandı olarak değiştirilir.
        private void tamamlandi_Click(object sender, EventArgs e)
        {
            Kafe.SiparisTamamlandi(datagridSiparisler.CurrentRow.Cells["id"].Value.ToString());
            SiparisleriGorüntüle();
        }
        // Bir siparişe çift tıklandığı zaman siparisayrintilar formu açılır ve o siparişin idsi gönderilir
        private void datagridSiparisler_DoubleClick(object sender, EventArgs e)
        {
            formSiparisAyrintilar formSiparisAyrintilar = new formSiparisAyrintilar();
            formSiparisAyrintilar.siparisId = datagridSiparisler.CurrentRow.Cells["id"].Value.ToString();
            formSiparisAyrintilar.ShowDialog();
        }

        // Bu form kapandığında giriş formu açılır
        private void formSef_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();
        }
    }
}
