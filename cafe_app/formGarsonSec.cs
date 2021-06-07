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
    public partial class formGarsonSec : Form
    {
        public formGarsonSec()
        {
            InitializeComponent();
        }

        // Buton tipinde bir buton dizisi oluşturduk
        Button[] butonlar = new Button[6];

        private void formGarsonSec_Load(object sender, EventArgs e)
        {
            // Garson seçme formu açıldığı zaman garson butonları oluşturduğumuz buton tipindeki buton dizisine aktardık
            butonlar[0] = Halil;
            butonlar[1] = Cahit;
            butonlar[2] = Aslı;
            butonlar[3] = Gülnaz;
            butonlar[4] = Buse;
            butonlar[5] = Feyza;

            // Garson seçim butonlarına resimleri yükledik
            for (int i = 0; i < butonlar.Length; i++)
            {
                butonlar[i].BackgroundImage = Image.FromFile(Kafe.path + "//resimler//" + butonlar[i].Name + ".png");
            }
        }

        // Herhangi bir garson butonuna tıklandığı zaman bu fonksiyon çağırılır
        private void butonTıkla(object sender, EventArgs e)
        {
            // Hangi butonun bu eventi çağırdığını buluyoruz
            Button button = (Button)sender;

            // Masa seçme formunu sipariş ekleme amacıyla açtık
            formMasaSec formMasaSec = new formMasaSec();
            formMasaSec.garson = button.Name;
            formMasaSec.amac = "siparis_ekle";
            formMasaSec.Show();
            Hide();
        }

        // Görsellik için mouse garson butonlarından birinin üzerine geldiği zaman butonun etrafını kırmızı yaptık
        private void mouseUzerinde(object sender, EventArgs e)
        {
            // Hangi butonun bu eventi çağırdığını buluyoruz
            Button button = (Button)sender;    

            button.FlatAppearance.BorderColor = Color.Red;
            button.FlatAppearance.BorderSize = 2;
        }
        // Aynı şekilde mouse butonun dışına çıktığı zaman buton kenarlarını siyah yaptık
        private void mouseDisarida(object sender, EventArgs e)
        {
            for (int i = 0; i < butonlar.Length; i++)
            {
                butonlar[i].FlatAppearance.BorderColor = Color.Black;
                butonlar[i].FlatAppearance.BorderSize = 1;
            }
        }

        // Bu form kapandığı zaman giriş formu açılıyor
        private void formGarsonSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            girisFormu.Show();
        }
    }
}
