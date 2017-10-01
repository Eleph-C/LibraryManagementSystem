using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace end
{
    class veritabani
    {
        //SqlConnection kitaplar = new SqlConnection("Data Source=ELEPH-C\\MYSQL;Initial Catalog=kutuphane;Integrated Security=True;");
        //SqlConnection uyeler = new SqlConnection("Data Source=ELEPH-C\\MYSQL;Initial Catalog=member;Integrated Security=True;");
        //SqlConnection adminler = new SqlConnection("Data Source=ELEPH-C\\MYSQL;Initial Catalog=admin;Integrated Security=True;");
        OleDbConnection Kitap = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\KutuphaneVeritabani.accdb");
        OleDbConnection Admin = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\AdminVeritabani.accdb");
        OleDbConnection Uye = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\UyeVeritabani.accdb");
        static Form1 anaform = new Form1();
        public void KitapGetir(DataGridView kitaplistesidata)
        {
            Kitap.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitap", Kitap);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable kitaplistesi = new DataTable();
            adapter.Fill(kitaplistesi);
            kitaplistesidata.DataSource = kitaplistesi;
            Kitap.Close();
        }
        public void AdminGetir(DataGridView adminlistesidata)
        {
            Admin.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Admin", Admin);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable adminlistesi = new DataTable();
            adapter.Fill(adminlistesi);
            adminlistesidata.DataSource = adminlistesi;
            Admin.Close();
        }
        public void UyeGetir(DataGridView uyelistesidata)
        {
            Uye.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Uye", Uye);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable uyelistesi = new DataTable();
            adapter.Fill(uyelistesi);
            uyelistesidata.DataSource = uyelistesi;
            Uye.Close();
        }
        public void KitapEkle(int kitapnumarasi, string kitapadi, string kitapyazari, int kitapsayfasayisi, string kitapkategori, string kitapyayinci, string kitaptercumani,int kitapyayintarihi)
        {

            OleDbCommand komut = new OleDbCommand("Insert into Kitap(KitapNumarasi,KitapAdi,KitapYazari,KitapSayfaSayisi,KitapKategori,KitapYayinci,KitapTercumani,KitapYayinTarihi) values(@kitapnumarasi,@kitapadi,@kitapyazari,@kitapsayfasayisi,@kitapkategori,@kitapyayinci,@kitaptercumani,@kitapyayintarihi)", Kitap);
            komut.Parameters.AddWithValue("@kitapnumarasi", kitapnumarasi);
            komut.Parameters.AddWithValue("@kitapadi", kitapadi);
            komut.Parameters.AddWithValue("@kitapyazari", kitapyazari);
            komut.Parameters.AddWithValue("@kitapsayfasayisi", kitapsayfasayisi);
            komut.Parameters.AddWithValue("@kitapkategori", kitapkategori);
            komut.Parameters.AddWithValue("@kitapyayinci", kitapyayinci);
            komut.Parameters.AddWithValue("@kitaptercumani", kitaptercumani);
            komut.Parameters.AddWithValue("@kitapyayintarihi", kitapyayintarihi);
            Kitap.Open();
            komut.ExecuteNonQuery();
            Kitap.Close();
        }
        public void KitapDuzenle(int kitapnumarasi, string kitapadi, string kitapyazari, int kitapsayfasayisi, string kitapkategori, string kitapyayinci, string kitaptercumani, int kitapyayintarihi)
        {
            Kitap.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitap SET KitapAdi ='" + kitapadi + "',KitapYazari = '" + kitapyazari + "',KitapSayfaSayisi = '" + kitapsayfasayisi + "',KitapKategori='" + kitapkategori + "',KitapYayinci='" + kitapyayinci + "',KitapTercumani = '" + kitaptercumani + "',KitapYayinTarihi = '" + kitapyayintarihi + "' where KitapNumarasi ="+kitapnumarasi+"", Kitap);
            komut.ExecuteNonQuery();
            Kitap.Close();
        }
        public void KitapCheckInOut(string kitapsahibi, string uyeyeverilistarihi, string uyedenalinistarihi, string kitapadi)
        {
            Kitap.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitap SET KitapSahibi='"+kitapsahibi+"',UyeyeVerilisTarihi ='" + uyeyeverilistarihi + "',UyedenAlinisTarihi = '" + uyedenalinistarihi + "' where KitapAdi='"+kitapadi+"'", Kitap);
            komut.ExecuteNonQuery();
            Kitap.Close();
        }
        public void KitapSil(int kitapnumarasi)
        {
            Kitap.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Kitap where KitapNumarasi=@kitapnumarasi", Kitap);
            komut.Parameters.AddWithValue("@kitapnumarasi", kitapnumarasi);
            komut.ExecuteNonQuery();
            Kitap.Close();
        }
        public void KitapAra(DataGridView kitaplistesidata, string aramakategori,string aramasonucu)
        {
            Kitap.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Kitap where " + aramakategori + " like '%" + aramasonucu + "%'", Kitap);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            komut.ExecuteNonQuery();
            DataTable kitaplistesi = new DataTable();
            adapter.Fill(kitaplistesi);
            kitaplistesidata.DataSource = kitaplistesi;
            Kitap.Close();
        }
        public void UyeEkle(int uyekimlik,string uyeadi,string uyeemail,int uyetelefon,string uyesifre)
        {
            Uye.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Uye(UyeKimlik,UyeAdi,UyeEmail,UyeTelefon,UyeSifre) values (@uyekimlik,@uyeadi,@uyeemail,@uyetelefon,@uyesifre)", Uye);
            komut.Parameters.AddWithValue("uyekimlik", uyekimlik);
            komut.Parameters.AddWithValue("uyeadi", uyeadi);
            komut.Parameters.AddWithValue("uyeemail", uyeemail);
            komut.Parameters.AddWithValue("uyetelefon", uyetelefon);
            komut.Parameters.AddWithValue("uyesifre", uyesifre);
            komut.ExecuteNonQuery();
            Uye.Close();
        }
        public void UyeDuzenle(int uyekimlik,string uyeadi,string uyeemail,int uyetelefon,string uyesifre)
        {
            Uye.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Uye SET Uyeadi = '" + uyeadi + "',UyeEmail='" + uyeemail + "',UyeTelefon='" + uyetelefon + "',UyeSifre='" + uyesifre + "' where UyeKimlik="+uyekimlik+"", Uye);
            komut.ExecuteNonQuery();
            Uye.Close();
        }
        public void UyeSil(int uyekimlik)
        {
            Uye.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Uye where UyeKimlik=@uyekimlik", Uye);
            komut.Parameters.AddWithValue("@uyekimlik", uyekimlik);
            komut.ExecuteNonQuery();
            Uye.Close();
        }
        public Boolean UyeGiris(string uyeadi,string uyesifre)
        {
            Boolean durum;
            try
            {
                Uye.Open();
                OleDbCommand komut = new OleDbCommand("Select * from Uye where UyeAdi = '" + uyeadi + "'AND UyeSifre = '" + uyesifre + "'", Uye);
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
                Uye.Close();
                return durum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
        public void UyeSifreYenile(string uyeemail,string uyesifre)
        {
            Uye.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Uye SET UyeSifre = '" + uyesifre + "'where UyeEmail ='" + uyeemail + "'", Uye);
            komut.ExecuteNonQuery();
            Uye.Close();
        }
        public void UyeSifreAdYenile(string uyeadi,string uyesifre)
        {
            Uye.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Uye SET UyeSifre = '" + uyesifre + "'where UyeAdi ='" + uyeadi + "'", Uye);
            komut.ExecuteNonQuery();
            Uye.Close();
        }
        public void AdminEkle(int adminkimlik,string adminadi,string adminemail,int admintelefon,string adminsifre,string adminlikdurumu)
        {
            Admin.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Admin(AdminKimlik,AdminAdi,AdminEmail,AdminTelefon,AdminSifre,AdminlikDurumu) values (@adminkimlik,@adminadi,@adminemail,@admintelefon,@adminsifre,@adminlikdurumu)",Admin);
            komut.Parameters.AddWithValue("@adminkimlik", adminkimlik);
            komut.Parameters.AddWithValue("@adminadi", adminadi);
            komut.Parameters.AddWithValue("@adminemail", adminemail);
            komut.Parameters.AddWithValue("@admintelefon", admintelefon);
            komut.Parameters.AddWithValue("@adminsifre", adminsifre);
            komut.Parameters.AddWithValue("@adminlikdurumu", adminlikdurumu);
            komut.ExecuteNonQuery();
            Admin.Close();
        }
        public void AdminDuzenle(int adminkimlik, string adminadi, string adminemail, int admintelefon, string adminsifre, string adminlikdurumu)
        {
            Admin.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Admin SET AdminAdi='"+adminadi+"',AdminEmail='"+adminemail+"',AdminTelefon='"+admintelefon+"',AdminSifre='"+adminsifre+"',AdminlikDurumu='"+adminlikdurumu+"'WHERE AdminKimlik="+adminkimlik+"",Admin);
            komut.ExecuteNonQuery();
            Admin.Close();
        }
        public void AdminSil(int adminkimlik)
        {
            Admin.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Admin where AdminKimlik=@adminkimlik", Admin);
            komut.Parameters.AddWithValue("@adminkimlik", adminkimlik);
            komut.ExecuteNonQuery();
            Admin.Close();
        }
        public Boolean AdminGiris(string adminemail,string adminsifre)
        {
            Boolean durum;
            try
            {
                Admin.Open();
                
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Admin WHERE AdminEmail='" + adminemail + "'AND AdminSifre='" + adminsifre + "'",Admin);
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                { 
                    durum = true;
                }
                else
                {
                    durum = false;
                }
                Admin.Close();
                return durum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }

        }
        public void AdminSifreYenile(string adminemail,string adminsifre)
        {
            Admin.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Admin SET AdminSifre = '" + adminsifre + "'WHERE AdminEmail ='" + adminemail + "'", Admin);
            komut.ExecuteNonQuery();
            Admin.Close();
        }
    }
}
