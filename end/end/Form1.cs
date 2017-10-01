using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace end
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitap;
        Uye uye;
        Yonetici yonetici;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            showdatakitap();
        }
        
        veritabani Veritabani = new veritabani();
        public void showdatakitap()
        {
            kitap = new Kitap();
            kitap.Booksdata = kitaplistesidata;
            kitap.Booksdata2 = kitaplistesidata2;
            kitap.KutuphaneyeKitapGetir();
            //Veritabani.KitapGetir(kitaplistesidata);
            //Veritabani.KitapGetir(kitaplistesidata2);//simdilik ayarlama yapilmadi
        }
        public void showdatamember()
        {
            uye = new Uye();
            uye.Membersdata = memberlistesidata;
            uye.KutuphaneyeUyeGetir();
            //Veritabani.UyeGetir(memberlistesidata);
        }
        public void showdataadmin()
        {
            yonetici = new Yonetici();
            yonetici.Adminsdata = adminlistesidata;
            yonetici.KutuphaneyeAdmingetir();
            //Veritabani.AdminGetir(adminlistesidata);
        }     
        private void clearbtn1_Click(object sender, EventArgs e)
        {
            showdatakitap();
            kitaplistesidata.ClearSelection();
            txtbookname.Text = string.Empty;
            txtbookauthor.Text = string.Empty;
            txtbookpage.Text = string.Empty;
            combobookcategory.Text = string.Empty;
            txtbookpublisher.Text = string.Empty;
            txtbooknumber.Text = string.Empty;
            txtbookdate.Text = string.Empty;
            txtbooktranslated.Text = string.Empty;
            txtbooknumber.Text = string.Empty;
            KitapNumarasiDolumuBosmu();
        }
        
        private void adnbtn1_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtbooknumber.Text != "")
            {  
                kitap = new Kitap();
                kitap.KitapNumarasi = Convert.ToInt32(txtbooknumber.Text);
                kitap.KitapAdi = txtbookname.Text;
                kitap.KitapYazari = txtbookauthor.Text;
                kitap.KitapSayfaSayisi = Convert.ToInt32(txtbookpage.Text);
                kitap.KitapKategori = combobookcategory.Text;
                kitap.KitapYayincisi = txtbookpublisher.Text;
                kitap.KitapTercumani = txtbooktranslated.Text;
                kitap.KitapYayinlanmaTarihi = Convert.ToInt32(txtbookdate.Text);
                kitap.KitabiOduncAlanKisi = "";
                kitap.KisiyeVerilisZamani = "";
                kitap.KisidenAlinisZamani = "";
                if (kitap.KutuphaneyeKitapEkle())
                {
                    MessageBox.Show("Kitap Kayit Edildi");
                }
                //Veritabani.KitapEkle(kitapnumarasi, txtbookname.Text, txtbookauthor.Text, bookpage, combobookcategory.Text, txtbookpublisher.Text, txtbooktranslated.Text, kitapyayintarihi);
                showdatakitap();
                txtbooknumber.Text = "";
                txtbookname.Text = "";
                txtbookauthor.Text = "";
                txtbookpage.Text = "";
                txtbooktranslated.Text = "";
                txtbookpublisher.Text = "";
                combobookcategory.Text = "";
                txtbookdate.Text = "";
            }
            else
                MessageBox.Show("Book Name or Barkod is Empty !");
        }

        private void deletebtn1_Click(object sender, EventArgs e)
        {
            
            if (txtbooknumber.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Silmek istiyor musun ?", "Uyari", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int kitapnumarasi = Convert.ToInt32(txtbooknumber.Text);
                    kitap = new Kitap();
                    kitap.KitapNumarasi = kitapnumarasi;
                    if (kitap.KutuphanedenKitapSil())
                    {
                        MessageBox.Show("Kutuphaneden Kitap Silindi");
                    }
                    //Veritabani.KitapSil(kitapnumarasi);
                    showdatakitap();
                    txtbookname.Clear();
                    txtbookauthor.Clear();
                    txtbookpage.Clear();
                    txtbookpublisher.Clear();
                    txtbooknumber.Clear();
                    txtbookdate.Clear();
                    txtbooktranslated.Clear();
                    combobookcategory.Text = "";
                }
            }
            else { }
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = kitaplistesidata.SelectedCells[0].RowIndex;
            string kitapnumarasi = kitaplistesidata.Rows[selected].Cells[0].Value.ToString();
            string kitapadi = kitaplistesidata.Rows[selected].Cells[1].Value.ToString();
            string kitapyazari = kitaplistesidata.Rows[selected].Cells[2].Value.ToString();
            string kitapsayfasayisi = kitaplistesidata.Rows[selected].Cells[3].Value.ToString();
            string kitapkategori = kitaplistesidata.Rows[selected].Cells[4].Value.ToString();
            string kitapyayinci = kitaplistesidata.Rows[selected].Cells[5].Value.ToString();
            string kitaptercumani = kitaplistesidata.Rows[selected].Cells[6].Value.ToString();
            string kitapyayintarihi = kitaplistesidata.Rows[selected].Cells[7].Value.ToString();
            txtbookname.Text = kitapadi;
            txtbookauthor.Text = kitapyazari;
            txtbookpage.Text = kitapsayfasayisi;
            txtbookpublisher.Text = kitapyayinci;
            txtbooktranslated.Text = kitaptercumani;
            txtbookdate.Text = kitapyayintarihi;
            combobookcategory.Text = kitapkategori;
            txtbooknumber.Text = kitapnumarasi;
            KitapNumarasiDolumuBosmu();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = kitaplistesidata2.SelectedCells[0].RowIndex;
            string bookname = kitaplistesidata2.Rows[selected].Cells[1].Value.ToString();
            string member = kitaplistesidata2.Rows[selected].Cells[8].Value.ToString();
            string given = kitaplistesidata2.Rows[selected].Cells[9].Value.ToString();
            string taken = kitaplistesidata2.Rows[selected].Cells[10].Value.ToString();
            txtcheckbookname.Text = bookname;
            txtcheckmembername.Text = member;
            if (given != "" && taken != "")
            {
                givendatetime.Value = Convert.ToDateTime(kitaplistesidata2.Rows[selected].Cells[9].Value);
                takendatetime.Value = Convert.ToDateTime(kitaplistesidata2.Rows[selected].Cells[10].Value);
            }
            else
            {
                givendatetime.Value = DateTime.Today;
                takendatetime.Value = DateTime.Today;
            }
            
            
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = memberlistesidata.SelectedCells[0].RowIndex;
            string tc = memberlistesidata.Rows[selected].Cells[0].Value.ToString();
            string name = memberlistesidata.Rows[selected].Cells[1].Value.ToString();
            string email = memberlistesidata.Rows[selected].Cells[2].Value.ToString();
            string phone = memberlistesidata.Rows[selected].Cells[3].Value.ToString();
            string sifre = memberlistesidata.Rows[selected].Cells[4].Value.ToString();
            txtmembername.Text = name;
            txtmemberemail.Text = email;
            txtmemberphone.Text = phone;
            txtmembertc.Text = tc;
            txtmemberpass.Text = sifre;
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = adminlistesidata.SelectedCells[0].RowIndex;
            string tc = adminlistesidata.Rows[selected].Cells[0].Value.ToString();
            string name = adminlistesidata.Rows[selected].Cells[1].Value.ToString();
            string email = adminlistesidata.Rows[selected].Cells[2].Value.ToString();
            string phone = adminlistesidata.Rows[selected].Cells[3].Value.ToString();
            string sifre = adminlistesidata.Rows[selected].Cells[4].Value.ToString();
            string job = adminlistesidata.Rows[selected].Cells[5].Value.ToString();
            txtadminname.Text = name;
            txtadminemail.Text = email;
            txtadminphone.Text = phone;
            txtadmintc.Text = tc;
            txtadminpassword.Text = sifre;
            jobs.Text = job;
        }

        private void editbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                kitap = new Kitap();
                kitap.KitapNumarasi = Convert.ToInt32(txtbooknumber.Text);
                kitap.KitapAdi = txtbookname.Text;
                kitap.KitapYazari = txtbookauthor.Text;
                kitap.KitapSayfaSayisi = Convert.ToInt32(txtbookpage.Text);
                kitap.KitapKategori = combobookcategory.Text;
                kitap.KitapYayincisi = txtbookpublisher.Text;
                kitap.KitapTercumani = txtbooktranslated.Text;
                kitap.KitapYayinlanmaTarihi = Convert.ToInt32(txtbookdate.Text);
                if (kitap.KutuphanedekiKitabiDuzenle())
                {
                    MessageBox.Show("Kitap Duzeltildi");
                }
                //Veritabani.KitapDuzenle(Convert.ToInt32(txtbooknumber.Text), txtbookname.Text, txtbookauthor.Text, Convert.ToInt32(txtbookpage.Text), combobookcategory.Text, txtbookpublisher.Text, txtbooktranslated.Text, Convert.ToInt32(txtbookdate.Text));
                showdatakitap();
                KitapNumarasiDolumuBosmu();
            }
            catch { }
        }
        private void KitapNumarasiDolumuBosmu()
        {
            if (txtbooknumber.Text != string.Empty)
            {
                txtbooknumber.Enabled = false;
                brkodbtn.Enabled = false;
            }
            else
            {
                txtbooknumber.Enabled = true;
                brkodbtn.Enabled = true;
            }
        }
        private void takendatetime_ValueChanged(object sender, EventArgs e)
        {
            takendatetime.Value = givendatetime.Value.AddDays(15);
            
        }
        private void btnincheck_Click(object sender, EventArgs e)
        {
            if (txtcheckmembername.Text != "")
            {
                kitap = new Kitap();
                kitap.KitabiOduncAlanKisi = txtcheckmembername.Text;
                kitap.KisiyeVerilisZamani = givendatetime.Text;
                kitap.KisidenAlinisZamani = takendatetime.Text;
                kitap.KitapAdi = txtcheckbookname.Text;
                if (kitap.KutuphanedenKitapCheckInOut())
                {
                    MessageBox.Show("Kitap Uyeye Verildi");
                }
                //Veritabani.KitapCheckInOut(txtcheckmembername.Text, verilenzaman, alinanzaman, txtcheckbookname.Text);
                showdatakitap();
                txtcheckmembername.Clear();
            }
            else
                MessageBox.Show("Bos Birakilan Bolumler Var");
           
        }
       
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try 
            {
                uye = new Uye();
                uye.Uyekimlik = Convert.ToInt32(txtmembertc.Text);
                uye.Uyeadi = txtmembername.Text;
                uye.Uyeemail = txtmemberemail.Text;
                uye.Uyetelefon = Convert.ToInt32(txtmemberphone.Text);
                uye.Uyesifre = txtmemberpass.Text;
                if (uye.KutuphanedekiUyeyiDuzenle())
                {
                    MessageBox.Show("Uye Bilgileri Duzenlendi");
                }
                //Veritabani.UyeDuzenle(Convert.ToInt32(txtmembertc.Text), txtmembername.Text, txtmemberemail.Text, Convert.ToInt32(txtmemberphone.Text), txtmemberpass.Text); 
            }
            
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            showdatamember();
        }

        private void membershowlist_Click(object sender, EventArgs e)
        {
            showdatamember();
        }
        private void membersignupbtn_Click(object sender, EventArgs e)
        {
            if (txtmembername.Text != "")
            {
                uye = new Uye();
                uye.Uyekimlik = Convert.ToInt32(txtmembertc.Text);
                uye.Uyeadi = txtmembername.Text;
                uye.Uyeemail = txtmemberemail.Text;
                uye.Uyetelefon = Convert.ToInt32(txtmemberphone.Text);
                uye.Uyesifre = txtmemberpass.Text;
                if (uye.KutuphaneyeUyeEkle())
                {
                    MessageBox.Show("Uye Eklendi");
                }
                //Veritabani.UyeEkle(Convert.ToInt32(txtmembertc.Text), txtmembername.Text, txtmemberemail.Text,Convert.ToInt32(txtmemberphone.Text), txtmemberpass.Text);
                showdatamember();
                txtmembername.Clear();
                txtmemberemail.Clear();
                txtmemberphone.Clear();
                txtmembertc.Clear();
                txtmemberpass.Clear();
            }
            else
                MessageBox.Show("Bos Birakilan Alanlar Var");
        }
        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void mEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void tHEBOOKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListFormAc();
        }
        private void ListFormAc()
        {
            list listform = new list();
            listform.Show();
        }
       
        private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login yeni = new login();
            yeni.Show();
            this.Hide();
        }
        private static string CreateRandomPassword()
        {
            Random rd = new Random();

            String[] pasar = new String[8];
            Char[] uplet = new Char[27];
            Char[] lolet = new Char['z' - 'a' + 1];
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rd.Next(10);
            }

            int counter = 0;
            for (Char i = 'A'; i <= 'Z'; i++)
            {
                uplet[counter] = i;
                counter++;
                if (counter == uplet.Length)
                    break;
            }
            counter = 0;
            for (Char i = 'a'; i <= 'z'; i++)
            {
                lolet[counter] = i;
                counter++;
                if (counter == lolet.Length)
                    break;
            }
            String password = "";
            for (int i = 0; i < 8; i++)
            {
                int choice1, choice2, bc;
                choice1 = rd.Next(3); // [0,3)
                choice2 = rd.Next(3);
                bc = rd.Next(2) + 1; //[1,2]
                if (bc == 1)
                {
                    switch (choice1)
                    {
                        case 1: pasar[i] = Convert.ToString(uplet[(rd.Next(uplet.Length))]); break;
                        case 2: pasar[i] = Convert.ToString(lolet[rd.Next(lolet.Length)]); break;
                        default: pasar[i] = Convert.ToString(num[rd.Next(num.Length)]); break;
                    }
                }
                else
                {
                    switch (choice2)
                    {
                        case 1: pasar[i] = Convert.ToString(lolet[rd.Next(lolet.Length)]); break;
                        case 2: pasar[i] = Convert.ToString(num[rd.Next(num.Length)]); break;
                        default: pasar[i] = Convert.ToString(uplet[(rd.Next(uplet.Length))]); break;

                    }
                }
                password += pasar[i];
            }
            return password;
        }
        private void generatepassmember_Click_1(object sender, EventArgs e)
        {
            string pass = CreateRandomPassword();
            txtmemberpass.Text = pass;
        }

        private void generatepassadmin_Click(object sender, EventArgs e)
        {
            string password = CreateRandomPassword();
            txtadminpassword.Text = password;
        }

        private void nEWADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void cHECKINOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek Istiyor musunuz ?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int uyekimlik = Convert.ToInt32(txtmembertc.Text);
                    uye = new Uye();
                    uye.Uyekimlik = uyekimlik;
                    if (uye.KutuphanedenUyeSil())
                    {
                        MessageBox.Show("Uye Silindi");
                    }
                    //Veritabani.UyeSil(uyekimlik);
                    txtmembername.Clear();
                    txtmemberemail.Clear();
                    txtmemberphone.Clear();
                    txtmembertc.Clear();
                    txtmemberpass.Clear();
                    showdatamember();
                }
            }

            catch { }
           
        }
        private int GunFarki()
        {
            DateTime alinmatarihi = Convert.ToDateTime(takendatetime.Value.ToString());
            DateTime gununtarihi = Convert.ToDateTime(checkouttime.Value.ToString());
            TimeSpan fark;
            fark = alinmatarihi - gununtarihi;
            int gecikme = Int32.Parse(fark.Days.ToString());
            return gecikme;
        }
        private void btnoutcheck_Click_1(object sender, EventArgs e)
        {
            int Gunfarki = GunFarki();
            kitap = new Kitap();
            kitap.KitabiOduncAlanKisi = string.Empty;
            kitap.KisiyeVerilisZamani = "";
            kitap.KisidenAlinisZamani = "";
            kitap.KitapAdi = txtcheckbookname.Text;
            if (kitap.KutuphanedenKitapCheckInOut())
            {
                if (Gunfarki > 0)
                {
                    MessageBox.Show(Gunfarki + " kadar gun daha var");
                }
                else if (Gunfarki < 0)
                {
                    double odenecektutar = (-1 * Gunfarki) * (0.75);
                    MessageBox.Show("kitabinizin iade tarihi " + (-1 * Gunfarki) + " gun once bitti" + "\n" + odenecektutar + " tl odemeniz gerekmekte.");
                }
                MessageBox.Show("Kitap Uyeden Alindi");
                txtcheckmembername.Clear();
            }
            //Veritabani.KitapCheckInOut(txtcheckmembername.Text, givendatetime.Text="", takendatetime.Text="", txtcheckbookname.Text);
            showdatakitap();
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            showdatakitap();
        }

        private void adminshowlist_Click(object sender, EventArgs e)
        {
            showdataadmin();
        }

        private void adminsignupbtn_Click(object sender, EventArgs e)
        {
            if (txtadmintc.Text != "")
            {
                yonetici = new Yonetici();
                yonetici.Adminkimlik = Convert.ToInt32(txtadmintc.Text);
                yonetici.Adminadi = txtadminname.Text;
                yonetici.Adminemail = txtadminemail.Text;
                yonetici.Admintelefon = Convert.ToInt32(txtadminphone.Text);
                yonetici.Adminsifre = txtadminpassword.Text;
                yonetici.Adminlikdurumu = jobs.Text;
                if (yonetici.KutuphaneyeAdminEkle())
                {
                    MessageBox.Show("Yonetici Eklendi");
                }
                //Veritabani.AdminEkle(Convert.ToInt32(txtadmintc.Text), txtadminname.Text, txtadminemail.Text, Convert.ToInt32(txtadminphone.Text), txtadminpassword.Text, jobs.Text);
                showdataadmin();
                txtadminname.Clear();
                txtadminemail.Clear();
                txtadminphone.Clear();
                txtadmintc.Clear();
                txtadminpassword.Clear();
                jobs.Text = "";
            }
            MessageBox.Show("Bos Birakilmis Alanlar Var");
        }

        private void btnupdate2_Click(object sender, EventArgs e)
        {
            try
            {
                yonetici = new Yonetici();
                yonetici.Adminkimlik = Convert.ToInt32(txtadmintc.Text);
                yonetici.Adminadi = txtadminname.Text;
                yonetici.Adminemail = txtadminemail.Text;
                yonetici.Admintelefon = Convert.ToInt32(txtadminphone.Text);
                yonetici.Adminsifre = txtadminpassword.Text;
                yonetici.Adminlikdurumu = jobs.Text;
                if (yonetici.KutuphaneAdminiDuzenle())
                {
                    MessageBox.Show("Yonetici Duzenlendi");
                }
                //Veritabani.AdminDuzenle(Convert.ToInt32(txtadmintc.Text),txtadminname.Text,txtadminemail.Text,Convert.ToInt32(txtadminphone.Text),txtadminpassword.Text,jobs.Text);
                showdataadmin();
            }
            catch { }
        }

        private void btndelete2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek Istiyor musunuz ?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    yonetici = new Yonetici();
                    yonetici.Adminkimlik = Convert.ToInt32(txtadmintc.Text);
                    if (yonetici.KutuphaneAdminiSil())
                    {
                        MessageBox.Show("Yonetici Kutuphaneden Silindi");
                    }
                    //Veritabani.AdminSil(Convert.ToInt32(txtadmintc.Text));
                    txtadminname.Clear();
                    txtadminemail.Clear();
                    txtadminphone.Clear();
                    txtadmintc.Clear();
                    txtadminpassword.Clear();
                    jobs.Text = "";
                    showdataadmin();
                }
            }
            catch { }
           
        }

        private void btnokey_Click(object sender, EventArgs e)
        {
           try
            {
                yonetici = new Yonetici();
                yonetici.Adminemail = txtadminuser.Text;
                yonetici.Adminsifre = txtadminpass.Text;
                if (yonetici.KutuphaneAdminiGiris())
                {
                    txtadminemail.Clear();
                    txtadminpass.Clear();
                    panelwarning.Hide();
                    paneladmin.Show(); 
                }
                else { MessageBox.Show("Kullanici adi veya sifre hatali"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void brkodbtn_Click(object sender, EventArgs e)
        {
            //ayni sayi cikmamali AYARLANACAK
            Random r = new Random();
            String s = "9";
            String b = "0";
            int a = r.Next(8000) + 1000;
            int c = r.Next(5) + 1;
            txtbooknumber.Text = s + a.ToString() + b + c.ToString();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            txtadminuser.Text = "";
            txtadminpass.Text = "";
        }

        private void btnmemberclear_Click(object sender, EventArgs e)
        {
            txtmembername.Text = "";
            txtmemberemail.Text = "";
            txtmemberphone.Text = "";
            txtmembertc.Text = "";
            txtmemberpass.Text = "";
            memberlistesidata.ClearSelection();
        }

        private void btnadminclear_Click(object sender, EventArgs e)
        {
            txtadminname.Text = "";
            txtadminemail.Text = "";
            txtadminphone.Text = "";
            txtadmintc.Text = "";
            txtadminpassword.Text = "";
            jobs.Text = "";
            adminlistesidata.ClearSelection();
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bizimle Iletisime Gec canyil97@hotmail.com", "Yardima mi ihtiyacin var ?");
        }

        private void comboitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchlbl.Text=comboitems.Text + " Araniyor ";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (comboitems.Text != "")
            {
                kitap = new Kitap();
                kitap.Booksdata = kitaplistesidata;
                kitap.KitapKategori = comboitems.Text;
                kitap.Kelimeara = txtsearch.Text;
                kitap.KutuphanedeKitapAra();
                //Veritabani.KitapAra(kitaplistesidata, combobookcategory.Text, txtsearch.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkbooknamelbl.Text =comboBox1.Text + " Araniyor ";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                comboitems.Text = comboitems.Items[1].ToString();//COMBOBOX HATA VERIR KOYULMAZSA
                showdatakitap();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                showdatamember();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                comboBox1.Text = comboBox1.Items[1].ToString();//COMBOBOX HATA VERIR KOYULMAZSA
                showdatakitap();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                paneladmin.Hide();
                panelwarning.Show(); 
            }
        }

        private void txtcheckbookname_TextChanged(object sender, EventArgs e)
        {
            string a = txtcheckbookname.Text;
            a.ToLower();
            a = a.Replace('ı', 'i');
            a = a.Replace('ö', 'o');
            a = a.Replace('ş', 's');
            a = a.Replace('ğ', 'g');
            a = a.Replace('ü', 'u');
            a = a.Replace('ç', 'c');
            a.ToUpper();

            if (comboBox1.Text != "")
            {
                kitap = new Kitap();
                kitap.Booksdata = kitaplistesidata2;
                kitap.KitapKategori = comboBox1.Text;
                kitap.Kelimeara = a;
                kitap.KutuphanedeKitapAra();
                //Veritabani.KitapAra(kitaplistesidata2, comboBox1.Text, a);
            }
            else
                MessageBox.Show("Bir seyler yanlis gitti", "Uyari!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
  
    }
}
