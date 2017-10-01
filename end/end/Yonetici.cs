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
    class Yonetici
    {
        OleDbConnection KutuphaneAdmini = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\AdminVeritabani.accdb");
        private int adminkimlik;

        public int Adminkimlik
        {
            get { return adminkimlik; }
            set { adminkimlik = value; }
        }
        private string adminadi;

        public string Adminadi
        {
            get { return adminadi; }
            set { adminadi = value; }
        }
        private string adminemail;

        public string Adminemail
        {
            get { return adminemail; }
            set { adminemail = value; }
        }
        private int admintelefon;

        public int Admintelefon
        {
            get { return admintelefon; }
            set { admintelefon = value; }
        }
        private string adminsifre;

        public string Adminsifre
        {
            get { return adminsifre; }
            set { adminsifre = value; }
        }
        private string adminlikdurumu;

        public string Adminlikdurumu
        {
            get { return adminlikdurumu; }
            set { adminlikdurumu = value; }
        }
        private DataGridView adminsdata;

        public DataGridView Adminsdata
        {
            get { return adminsdata; }
            set { adminsdata = value; }
        }

        public bool KutuphaneyeAdmingetir()
        {
            bool check = false;
            KutuphaneAdmini.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Admin", KutuphaneAdmini);
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable adminlistesi = new DataTable();
            adapter.Fill(adminlistesi);
            adminsdata.DataSource = adminlistesi;
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneAdmini.Close();
            return check;
        }
        public bool KutuphaneyeAdminEkle()
        {
            bool check = false;
            KutuphaneAdmini.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Admin(AdminKimlik,AdminAdi,AdminEmail,AdminTelefon,AdminSifre,AdminlikDurumu) values (@adminkimlik,@adminadi,@adminemail,@admintelefon,@adminsifre,@adminlikdurumu)", KutuphaneAdmini);
            komut.Parameters.AddWithValue("@adminkimlik", adminkimlik);
            komut.Parameters.AddWithValue("@adminadi", adminadi);
            komut.Parameters.AddWithValue("@adminemail", adminemail);
            komut.Parameters.AddWithValue("@admintelefon", admintelefon);
            komut.Parameters.AddWithValue("@adminsifre", adminsifre);
            komut.Parameters.AddWithValue("@adminlikdurumu", adminlikdurumu);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneAdmini.Close();
            return check;
        }
        public bool KutuphaneAdminiDuzenle()
        {
            bool check = false;
            KutuphaneAdmini.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Admin SET AdminAdi='" + adminadi + "',AdminEmail='" + adminemail + "',AdminTelefon='" + admintelefon + "',AdminSifre='" + adminsifre + "',AdminlikDurumu='" + adminlikdurumu + "'WHERE AdminKimlik=" + adminkimlik + "", KutuphaneAdmini);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneAdmini.Close();
            return check;
        }
        public bool KutuphaneAdminiAdlaDuzenle()
        {
            bool check = false;
            KutuphaneAdmini.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Admin SET AdminSifre = '" + adminsifre + "' WHERE AdminEmail = '" + adminemail + "'", KutuphaneAdmini);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneAdmini.Close();
            return check;
        }
        public bool KutuphaneAdminiSil()
        {
            bool check = false;
            KutuphaneAdmini.Open();
            OleDbCommand komut = new OleDbCommand("Delete from Admin where AdminKimlik=@adminkimlik", KutuphaneAdmini);
            komut.Parameters.AddWithValue("@adminkimlik", adminkimlik);
            if (komut.ExecuteNonQuery() > 0)
            {
                check = true;
            }
            KutuphaneAdmini.Close();
            return check;
        }
        public bool KutuphaneAdminiGiris()
        {
            Boolean durum;
            try
            {
                KutuphaneAdmini.Open();

                OleDbCommand komut = new OleDbCommand("SELECT * FROM Admin WHERE AdminEmail='" + adminemail + "'AND AdminSifre='" + adminsifre + "'", KutuphaneAdmini);
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
                KutuphaneAdmini.Close();
                return durum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
    }
}
