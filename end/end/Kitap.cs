using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end
{
    class Kitap : veritabani
    {
       
        OleDbConnection Kutuphane = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\KutuphaneVeritabani.accdb");
        
        private int kitapnumarasi;
        public int KitapNumarasi
        {
            get { return kitapnumarasi; }
            set { kitapnumarasi = value; }
        }

        private string kitapadi;
        public string KitapAdi
        {
            get { return kitapadi; }
            set { kitapadi = value; }
        }
        private string kitapyazari;

        public string KitapYazari
        {
            get { return kitapyazari; }
            set { kitapyazari = value; }
        }
        private int kitapsayfasayisi;

        public int KitapSayfaSayisi
        {
            get { return kitapsayfasayisi; }
            set { kitapsayfasayisi = value; }
        }
        private string kitapkategori;

        public string KitapKategori
        {
            get { return kitapkategori; }
            set { kitapkategori = value; }
        }
        private string kitapyayincisi;

        public string KitapYayincisi
        {
            get { return kitapyayincisi; }
            set { kitapyayincisi = value; }
        }
        private string kitaptercumani;

        public string KitapTercumani
        {
            get { return kitaptercumani; }
            set { kitaptercumani = value; }
        }
        private int kitapyayinlanmatarihi;

        public int KitapYayinlanmaTarihi
        {
            get { return kitapyayinlanmatarihi; }
            set { kitapyayinlanmatarihi = value; }
        }
        private string kitabioduncalankisi;

        public string KitabiOduncAlanKisi
        {
            get { return kitabioduncalankisi; }
            set { kitabioduncalankisi = value; }
        }
        private string kisiyeveriliszamani;

        public string KisiyeVerilisZamani
        {
            get { return kisiyeveriliszamani; }
            set { kisiyeveriliszamani = value; }
        }
        private string kisidenaliniszamani;

        public string KisidenAlinisZamani
        {
            get { return kisidenaliniszamani; }
            set { kisidenaliniszamani = value; }
        }
        private DataGridView booksdata;

        public DataGridView Booksdata
        {
            get { return booksdata; }
            set { booksdata = value; }
        }
        private DataGridView booksdata2;

        public DataGridView Booksdata2
        {
            get { return booksdata2; }
            set { booksdata2 = value; }
        }
        private string kelimeara;

        public string Kelimeara
        {
            get { return kelimeara; }
            set { kelimeara = value; }
        }
        public Kitap()
        {

        }
        public bool KutuphaneyeKitapGetir()
        {
            bool check = false;
            Kutuphane.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitap", Kutuphane);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable kitaplistesi = new DataTable();
            adapter.Fill(kitaplistesi);
            booksdata.DataSource = kitaplistesi;
            booksdata2.DataSource = kitaplistesi;
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            Kutuphane.Close();
            return check;
        }
        public bool KutuphaneyeKitapEkle()
        {
            bool check = false;
            OleDbCommand komut = new OleDbCommand("Insert into Kitap(KitapNumarasi,KitapAdi,KitapYazari,KitapSayfaSayisi,KitapKategori,KitapYayinci,KitapTercumani,KitapYayinTarihi) values(@kitapnumarasi,@kitapadi,@kitapyazari,@kitapsayfasayisi,@kitapkategori,@kitapyayinci,@kitaptercumani,@kitapyayintarihi)", Kutuphane);
            komut.Parameters.AddWithValue("@kitapnumarasi", kitapnumarasi);
            komut.Parameters.AddWithValue("@kitapadi", kitapadi);
            komut.Parameters.AddWithValue("@kitapyazari", kitapyazari);
            komut.Parameters.AddWithValue("@kitapsayfasayisi", kitapsayfasayisi);
            komut.Parameters.AddWithValue("@kitapkategori", kitapkategori);
            komut.Parameters.AddWithValue("@kitapyayinci", kitapyayincisi);
            komut.Parameters.AddWithValue("@kitaptercumani", kitaptercumani);
            komut.Parameters.AddWithValue("@kitapyayintarihi", kitapyayinlanmatarihi);
            Kutuphane.Open();
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            Kutuphane.Close();
            return check;
            //KitapEkle(kitapnumarasi, kitapadi, kitapyazari, kitapsayfasayisi, kitapkategori, kitapyayincisi, kitaptercumani, kitapyayinlanmatarihi);
        }
        public bool KutuphanedekiKitabiDuzenle()
        {
            bool check=false;
            Kutuphane.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitap SET KitapAdi ='" + kitapadi + "',KitapYazari = '" + kitapyazari + "',KitapSayfaSayisi = '" + kitapsayfasayisi + "',KitapKategori='" + kitapkategori + "',KitapYayinci='" + kitapyayincisi + "',KitapTercumani = '" + kitaptercumani + "',KitapYayinTarihi = '" + kitapyayinlanmatarihi + "' where KitapNumarasi =" + kitapnumarasi + "", Kutuphane);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            Kutuphane.Close();
            return check;
        }
        public bool KutuphanedenKitapSil()
        {
            bool check = false;
            Kutuphane.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Kitap where KitapNumarasi=@kitapnumarasi", Kutuphane);
            komut.Parameters.AddWithValue("@kitapnumarasi", kitapnumarasi);
            if(komut.ExecuteNonQuery()>0)
            {
                check=true;
            }
            Kutuphane.Close();
            return check;
        }
        public bool KutuphanedenKitapCheckInOut()
        {
            bool check = false;
            Kutuphane.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitap SET KitapSahibi='" + kitabioduncalankisi + "',UyeyeVerilisTarihi ='" + kisiyeveriliszamani + "',UyedenAlinisTarihi = '" + kisidenaliniszamani + "' where KitapAdi='" + kitapadi + "'", Kutuphane);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            Kutuphane.Close();
            return check;
        }
        public bool KutuphanedeKitapAra()
        {
            bool check = false;
            Kutuphane.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitap WHERE "+kitapkategori+" Like '"+kelimeara+"%'",Kutuphane);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            DataTable kitaplistesi = new DataTable();
            adapter.Fill(kitaplistesi);
            booksdata.DataSource = kitaplistesi;
            Kutuphane.Close();
            return check;
        }
        public bool KutuphanedeKisiyeKitapAra()
        {
            bool check = false;
            Kutuphane.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitap WHERE KitapSahibi = '" + kelimeara + "'", Kutuphane);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            DataTable kitaplistesi = new DataTable();
            adapter.Fill(kitaplistesi);
            booksdata.DataSource = kitaplistesi;
            Kutuphane.Close();
            return check;
        }

    }
}
