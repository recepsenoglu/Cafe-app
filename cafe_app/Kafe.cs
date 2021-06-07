using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_app
{
    class Kafe
    {
        // Menülerin tutulduğu dictionary tipli değişkenler
        public static Dictionary<string, double> aperatifler = new Dictionary<string, double>();
        public static Dictionary<string, double> kahvalti = new Dictionary<string, double>();
        public static Dictionary<string, double> tostveburgerler = new Dictionary<string, double>();
        public static Dictionary<string, double> pizzalar = new Dictionary<string, double>();
        public static Dictionary<string, double> tatlilar = new Dictionary<string, double>();
        public static Dictionary<string, double> icecekler = new Dictionary<string, double>();

        // Programın çalıştığı dizin
        public static string path = Application.StartupPath;

        // Masaüstü yolu
        static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Veritabanı bağlantı nesnesi
        static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"+
            "Data Source=" + desktop + "\\Kafe_Veritabani.accdb");
        
        
        // Parametre olarak verilen menü ismine göre ilgili menü sözlüğünü döndürür
        public static Dictionary<string, double> MenuGetir(string tur)
        {
            switch(tur)
            {
                case "kahvalti":
                    return kahvalti;
                case "aperatifler":
                    return aperatifler;
                case "tostveburgerler":
                    return tostveburgerler;
                case "pizzalar":
                    return pizzalar;
                case "tatlilar":
                    return tatlilar;
                case "icecekler":
                    return icecekler;
            }
            return aperatifler;
        }
        // Veritabanına sipariş ekler
        public static bool SiparisGonder(string masa_numarasi, string siparisListesi, string ucret, string garson)
        {
            string saat = DateTime.Now.ToLongTimeString(); 
            try
            {
                baglanti.Open();
                string CommandText = "insert into siparisler (masa_numarasi,siparisler,saat,siparis_durumu,ucret,garson) values('" + masa_numarasi + "','" +
                    siparisListesi + "','" + saat + "','" + "Yeni" + "','" + ucret + "','" + garson + "')";
                OleDbCommand command = new OleDbCommand(CommandText, baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Veritabanından tüm siparişleri çeker
        public static DataTable SiparisleriGetir()
        {
            baglanti.Open();
            string commandText = "select id,saat,masa_numarasi,siparis_durumu from siparisler order by id desc";
            OleDbCommand command = new OleDbCommand(commandText, baglanti);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            baglanti.Close();
            return dataTable;
        }
        // Masanın dolu olup olmadığını kontrol eder
        public static bool MasaDolumu(string masa_numarasi)
        {
            baglanti.Open();
            string CommandText = "select * from siparisler WHERE masa_numarasi='" + masa_numarasi + "'";
            OleDbCommand command = new OleDbCommand(CommandText, baglanti);
            OleDbDataReader dr;
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        // Veritabanından sipariş siler
        public static void SiparisSil(string id)
        {
            baglanti.Open();
            string CommandText = "delete from siparisler where id=" + id;
            OleDbCommand command = new OleDbCommand(CommandText, baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        // Veritabanındaki bir siparişin sipariş durumu özelliğini tamamlandı olarak değiştirir
        public static void SiparisTamamlandi(string id)
        {
            baglanti.Open();
            string CommandText = "update siparisler set siparis_durumu = 'Tamamlandı' where id = " + id;
            OleDbCommand command = new OleDbCommand(CommandText, baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        // Verilen ürünün fiyatını sözlüklerden çeker
        public static double UcretGetir(string urun)
        {
            if (aperatifler.ContainsKey(urun))
                return double.Parse(aperatifler[urun].ToString());
            else if (kahvalti.ContainsKey(urun))
                return double.Parse(kahvalti[urun].ToString());
            else if (tostveburgerler.ContainsKey(urun))
                return double.Parse(tostveburgerler[urun].ToString());
            else if (pizzalar.ContainsKey(urun))
                return double.Parse(pizzalar[urun].ToString());
            else if (tatlilar.ContainsKey(urun))
                return double.Parse(tatlilar[urun].ToString());
            else if (icecekler.ContainsKey(urun))
                return double.Parse(icecekler[urun].ToString());
            return 0.0;
        }
        // Idsi verilen bir siparişin bilgilerini veritabanından çeker
        public static DataTable SiparisBilgileriGetir(string id)
        {
            baglanti.Open();
            string commandText = "select masa_numarasi,saat,siparisler,garson from siparisler where id=" + int.Parse(id);
            OleDbCommand command = new OleDbCommand(commandText, baglanti);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            baglanti.Close();
            return dataTable;
        }
        // Verilen masa numarası eşleşen siparişleri çeker
        public static DataTable MasaBilgileriGetir(string masa_numarasi)
        {
            baglanti.Open();
            string commandText = "select id,saat,siparisler,garson,ucret from siparisler where masa_numarasi= '" + masa_numarasi + "'";
            OleDbCommand command = new OleDbCommand(commandText, baglanti);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            baglanti.Close();
            return dataTable;
        }
        // Siparişleri düzenlemek için sözlük oluşturup siparişleri key, adetlerini value olarak tutar
        public static Dictionary<string,int> SiparisSozlukOlustur(string[] siparisler)
        {
            var DuzenliSiparisler = new Dictionary<string, int>();

            foreach (string urun in siparisler)
            {
                if (DuzenliSiparisler.ContainsKey(urun))
                    DuzenliSiparisler[urun] += 1;
                else
                    DuzenliSiparisler.Add(urun, 1);
            }

            return DuzenliSiparisler;
        }
        // Veritabanından menüleri çeker ve ilgili sözlüklere ekler
        public static void MenuleriVeritabanindanCek()
        {
            if (aperatifler.Count > 0) return;
            baglanti.Open();
            string commandText = "select * from Menuler";
            OleDbCommand command = new OleDbCommand(commandText, baglanti);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string[,,] urunlervefiyatlar = new string[6, 2, 16];
            for (int i = 0; i < 6; i++)
            {
                string[] gecerliUrunler = dataTable.Rows[i]["Urunler"].ToString().Split(',');
                string[] gecerliFiyatlar = dataTable.Rows[i]["Fiyatlar"].ToString().Split(';');

                for (int j = 0; j < gecerliUrunler.Length; j++)
                {
                    urunlervefiyatlar[i, 0, j] = gecerliUrunler[j];
                    urunlervefiyatlar[i, 1, j] = gecerliFiyatlar[j];
                }
            }
            baglanti.Close();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    switch (i)
                    {
                        case 0:
                            tostveburgerler.Add(urunlervefiyatlar[i, 0, j], double.Parse(urunlervefiyatlar[i, 1, j]));
                            break;
                        case 1:
                            pizzalar.Add(urunlervefiyatlar[i, 0, j], double.Parse(urunlervefiyatlar[i, 1, j]));
                            break;
                        case 2:
                            tatlilar.Add(urunlervefiyatlar[i, 0, j], double.Parse(urunlervefiyatlar[i, 1, j]));
                            break;
                        case 3:
                            icecekler.Add(urunlervefiyatlar[i, 0, j], double.Parse(urunlervefiyatlar[i, 1, j]));
                            break;
                        case 4:
                            aperatifler.Add(urunlervefiyatlar[i, 0, j], double.Parse(urunlervefiyatlar[i, 1, j]));
                            break;
                        case 5:
                            kahvalti.Add(urunlervefiyatlar[i, 0, j], double.Parse(urunlervefiyatlar[i, 1, j]));
                            break;
                    }
                }
            }
        }
    }
}
