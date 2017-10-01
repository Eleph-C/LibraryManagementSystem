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
    class Uye
    {
        OleDbConnection KutuphaneUyesi = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\UyeVeritabani.accdb");
        private int uyekimlik;

        public int Uyekimlik
        {
            get { return uyekimlik; }
            set { uyekimlik = value; }
        }
        private string uyeadi;

        public string Uyeadi
        {
            get { return uyeadi; }
            set { uyeadi = value; }
        }
        private string uyeemail;

        public string Uyeemail
        {
            get { return uyeemail; }
            set { uyeemail = value; }
        }
        private int uyetelefon;

        public int Uyetelefon
        {
            get { return uyetelefon; }
            set { uyetelefon = value; }
        }
        private string uyesifre;

        public string Uyesifre
        {
            get { return uyesifre; }
            set { uyesifre = value; }
        }
        private DataGridView membersdata;

        public DataGridView Membersdata
        {
            get { return membersdata; }
            set { membersdata = value; }
        }
        public Uye() { }
        public bool KutuphaneyeUyeGetir()
        {
            bool check = false;
            KutuphaneUyesi.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Uye", KutuphaneUyesi);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable uyelistesi = new DataTable();
            adapter.Fill(uyelistesi);
            membersdata.DataSource = uyelistesi;
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneUyesi.Close();
            return check;
        }
        public bool KutuphaneyeUyeEkle()
        {
            bool check = false;
            KutuphaneUyesi.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Uye(UyeKimlik,UyeAdi,UyeEmail,UyeTelefon,UyeSifre) values (@uyekimlik,@uyeadi,@uyeemail,@uyetelefon,@uyesifre)", KutuphaneUyesi);
            komut.Parameters.AddWithValue("uyekimlik", uyekimlik);
            komut.Parameters.AddWithValue("uyeadi", uyeadi);
            komut.Parameters.AddWithValue("uyeemail", uyeemail);
            komut.Parameters.AddWithValue("uyetelefon", uyetelefon);
            komut.Parameters.AddWithValue("uyesifre", uyesifre);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneUyesi.Close();
            return check;
        }
        public bool KutuphanedekiUyeyiDuzenle()
        {
            bool check = false;
            KutuphaneUyesi.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Uye SET Uyeadi = '" + uyeadi + "',UyeEmail='" + uyeemail + "',UyeTelefon='" + uyetelefon + "',UyeSifre='" + uyesifre + "' where UyeKimlik=" + uyekimlik + "", KutuphaneUyesi);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneUyesi.Close();
            return check;
        }
        public bool KutuphanedenUyeSil()
        {
            bool check = false;
            KutuphaneUyesi.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Uye where UyeKimlik=@uyekimlik", KutuphaneUyesi);
            komut.Parameters.AddWithValue("@uyekimlik", uyekimlik);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneUyesi.Close();
            return check;
        }
        public bool KutuphaneyeUyeGirisi()
        {
            Boolean durum;
            try
            {
                KutuphaneUyesi.Open();
                OleDbCommand komut = new OleDbCommand("Select * from Uye where UyeEmail = '" + uyeemail + "'AND UyeSifre = '" + uyesifre + "'", KutuphaneUyesi);
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
                KutuphaneUyesi.Close();
                return durum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
        public bool KutuphanedekiUyeAdSifresiYenile()
        {
            bool check = false;
            KutuphaneUyesi.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Uye SET UyeSifre = '" + uyesifre + "'where UyeEmail ='" + uyeemail + "'", KutuphaneUyesi);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneUyesi.Close();
            return check;

        }
        public DataTable KutuphanedeUyeAra()
        {
            KutuphaneUyesi.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Uye WHERE UyeEmail ='" + uyeemail + "'", KutuphaneUyesi);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            komut.ExecuteNonQuery();
            DataTable kitaplistesi = new DataTable();
            adapter.Fill(kitaplistesi);
            KutuphaneUyesi.Close();
            return kitaplistesi;
            
        }
    }
}
