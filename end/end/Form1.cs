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

        
        private void Form1_Load(object sender, EventArgs e)
        {
          
            panelcheck.Hide();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Hide();
            panelwarning.Hide();
            groupBox1.BackColor = Color.Transparent;
            panelcheck.BackColor = Color.Transparent;
            panelmember.BackColor = Color.Transparent;
            paneladmin.BackColor = Color.Transparent;
            panelbooks.BackColor = Color.Transparent;
            panelwarning.BackColor = Color.Transparent;
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
            txtbookname.Text = "";
            txtbookauthor.Text = "";
            txtbookpage.Text = "";
            combobookcategory.Text = "";
            txtbookpublisher.Text = "";
            txtbooknumber.Text = "";
            txtbookdate.Text = "";
            txtbooktranslated.Text = "";
            txtbooknumber.Text = "";
            KitapNumarasiDolumuBosmu();
        }
        Kitap kitap;
        Uye uye;
        Yonetici yonetici;
        private void adnbtn1_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtbooknumber.Text != "")
            {
                
                //int kitapyayintarihi = Convert.ToInt32(txtbookdate.Text);
                //int kitapnumarasi = Convert.ToInt32(txtbooknumber.Text);
                //int bookpage = Convert.ToInt32(txtbookpage.Text);
                //string kitabioduncalankisi = "";
                //DateTime kisiyeverilistarihi = DateTime.Today;
                //DateTime kisidenalinistarihi = DateTime.Today;
                //Kitap kitap = new Kitap(kitapnumarasi, txtbookname.Text, txtbookauthor.Text, bookpage, combobookcategory.Text, txtbookpublisher.Text, txtbooktranslated.Text, kitapyayintarihi, kitabioduncalankisi, kisiyeverilistarihi, kisidenalinistarihi);
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
                DialogResult result = MessageBox.Show("Do You Want To Delete ?", "Information", MessageBoxButtons.YesNo);
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
            string kitapnumarasi = kitaplistesidata.Rows[selected].Cells[0].Value.ToString().TrimEnd();
            string kitapadi = kitaplistesidata.Rows[selected].Cells[1].Value.ToString().TrimEnd();
            string kitapyazari = kitaplistesidata.Rows[selected].Cells[2].Value.ToString().TrimEnd();
            string kitapsayfasayisi = kitaplistesidata.Rows[selected].Cells[3].Value.ToString().TrimEnd();
            string kitapkategori = kitaplistesidata.Rows[selected].Cells[4].Value.ToString().TrimEnd();
            string kitapyayinci = kitaplistesidata.Rows[selected].Cells[5].Value.ToString().TrimEnd();
            string kitaptercumani = kitaplistesidata.Rows[selected].Cells[6].Value.ToString().TrimEnd();
            string kitapyayintarihi = kitaplistesidata.Rows[selected].Cells[7].Value.ToString().TrimEnd();
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
            string bookname = kitaplistesidata2.Rows[selected].Cells[1].Value.ToString().TrimEnd();
            string member = kitaplistesidata2.Rows[selected].Cells[8].Value.ToString().TrimEnd();
            string given = kitaplistesidata2.Rows[selected].Cells[9].Value.ToString().TrimEnd();
            string taken = kitaplistesidata2.Rows[selected].Cells[10].Value.ToString().TrimEnd();
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
            kitap = new Kitap();
            kitap.KitapNumarasi = Convert.ToInt32(txtbooknumber.Text);
            kitap.KitapAdi = txtbookname.Text;
            kitap.KitapYazari = txtbookauthor.Text;
            kitap.KitapSayfaSayisi = Convert.ToInt32(txtbookpage.Text);
            kitap.KitapKategori = combobookcategory.Text;
            kitap.KitapYayincisi = txtbookpublisher.Text;
            kitap.KitapTercumani = txtbooktranslated.Text;
            kitap.KitapYayinlanmaTarihi = Convert.ToInt32(txtbookdate.Text);
            //kitap.KitabiOduncAlanKisi = "";
            //kitap.KisiyeVerilisZamani = kisiyeverilistarihi;
            //kitap.KisidenAlinisZamani = kisidenalinistarihi;
            if (kitap.KutuphanedekiKitabiDuzenle())
            {
                MessageBox.Show("Kitap Duzeltildi");
            }
            //Veritabani.KitapDuzenle(Convert.ToInt32(txtbooknumber.Text), txtbookname.Text, txtbookauthor.Text, Convert.ToInt32(txtbookpage.Text), combobookcategory.Text, txtbookpublisher.Text, txtbooktranslated.Text, Convert.ToInt32(txtbookdate.Text));
            showdatakitap();
            KitapNumarasiDolumuBosmu();
        }

        private void booklist_Click(object sender, EventArgs e)
        {
            list form = new list();
            form.Show();
        }
        
        
        private void checkinout_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[1].ToString();//COMBOBOX HATA VERIR KOYULMAZSA
            panelcheck.Show();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Hide();
            panelwarning.Hide();
           showdatakitap();
        }

        private void addoreditbtn_Click(object sender, EventArgs e)
        {
            comboitems.Text = comboitems.Items[1].ToString();//COMBOBOX HATA VERIR KOYULMAZSA
            panelcheck.Hide();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Show();
            panelwarning.Hide();
           showdatakitap();
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
                //kitaplar.Open();
                //SqlCommand komut = new SqlCommand("Update datas set member='" + txtcheckmembername.Text + "',givendate ='" + givendatetime.Text + "',takendate ='" + takendatetime.Text + "' where bookname='" + txtcheckbookname.Text + "'", kitaplar);
                //try { komut.ExecuteNonQuery(); }
                //catch { MessageBox.Show("Check in is failed successfully"); }
                //kitaplar.Close();
                string verilenzaman = givendatetime.Text;
                string alinanzaman = takendatetime.Text;
                kitap = new Kitap();
                kitap.KitabiOduncAlanKisi = txtcheckmembername.Text;
                kitap.KisiyeVerilisZamani = verilenzaman;
                kitap.KisidenAlinisZamani = alinanzaman;
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
                MessageBox.Show("Empty Spaces");
           
        }
       
        private void btnupdate_Click(object sender, EventArgs e)
        {
            //uyeler.Open();
            //SqlCommand komut = new SqlCommand("Update memberedit set name='" + txtmembername.Text + "',email='" + txtmemberemail.Text + "',phone='" + txtmemberphone.Text + "',tc='" + txtmembertc.Text + "',password='" + txtmemeberpass.Text + "'where name='" + txtmembername.Text + "'", uyeler);
            //try { komut.ExecuteNonQuery(); }
            //catch { MessageBox.Show("Update is failed successfully"); }
            //uyeler.Close();
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
                    MessageBox.Show("Uye Duzenlendi");
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
                //uyeler.Open();
                //SqlCommand komut = new SqlCommand("Insert into memberedit(name,email,phone,tc,password)Values(@name,@email,@phone,@tc,@password)", uyeler);
                //komut.Parameters.AddWithValue("@name", txtmembername.Text);
                //komut.Parameters.AddWithValue("@email", txtmemberemail.Text);
                //komut.Parameters.AddWithValue("@phone", txtmemberphone.Text);
                //komut.Parameters.AddWithValue("@tc", txtmembertc.Text);
                //komut.Parameters.AddWithValue("@password", txtmemeberpass.Text);
                //try { komut.ExecuteNonQuery(); }
                //catch { MessageBox.Show("Add command is failed successfully"); }
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
                //uyeler.Close();
                txtmembername.Clear();
                txtmemberemail.Clear();
                txtmemberphone.Clear();
                txtmembertc.Clear();
                txtmemberpass.Clear();

            }
            else
                MessageBox.Show("Empty Spaces !");
            
        }

        private void addeditmember_Click(object sender, EventArgs e)
        {
            
            panelcheck.Hide();
            panelmember.Show();
            paneladmin.Hide();
            panelbooks.Hide();
            panelwarning.Hide();
            showdatamember();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panelcheck.Hide();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Show();
            panelwarning.Hide();
        }

        private void mEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panelcheck.Hide();
            panelmember.Show();
            paneladmin.Hide();
            panelbooks.Hide();
            panelwarning.Hide();
        }

        private void tHEBOOKLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list form = new list();
            form.Show();
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
        /*private static string CreateRandomPassword()
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            char[] chars = new char[8];
            Random rd = new Random();

            for (int i = 0; i < 8; i++)
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];

            return new string(chars);
        }*/
        
        private void newadmin_Click(object sender, EventArgs e)
        {
            panelcheck.Hide();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Hide();
            groupBox1.Hide();
            panelwarning.Show();
            
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
           
            panelcheck.Hide();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Hide();
            panelwarning.Show();
        }

        private void cHECKINOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            panelcheck.Show();
            panelmember.Hide();
            paneladmin.Hide();
            panelbooks.Hide();
            panelwarning.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to DELETE ?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //uyeler.Open();
                //SqlCommand komut = new SqlCommand("Delete from memberedit where name=@name", uyeler);
                //komut.Parameters.AddWithValue("@name", txtmembername.Text);
                //try { komut.ExecuteNonQuery(); }
                //catch { MessageBox.Show("Delete is failed successfully"); }
                //uyeler.Close();
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

        private void btnoutcheck_Click_1(object sender, EventArgs e)
        {
            DateTime alinmatarihi = Convert.ToDateTime(takendatetime.Value.ToString());
            DateTime gununtarihi = Convert.ToDateTime(checkouttime.Value.ToString());
            TimeSpan fark;
            fark = alinmatarihi - gununtarihi;
            int gecikme = Int32.Parse(fark.Days.ToString());
            kitap = new Kitap();
            kitap.KitabiOduncAlanKisi = string.Empty;
            kitap.KisiyeVerilisZamani = "";
            kitap.KisidenAlinisZamani = "";
            kitap.KitapAdi = txtcheckbookname.Text;
            if (kitap.KutuphanedenKitapCheckInOut())
            {
                if (gecikme > 0)
                {
                    MessageBox.Show(gecikme + " kadar gun daha var");
                }
                else if (gecikme < 0)
                {
                    double a = (-1 * gecikme) * (0.75);
                    MessageBox.Show("kitabinizin iade tarihi " + (-1 * gecikme) + " gun once bitti" + "\n" + a + " tl odemeniz gerekmekte.");
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
            if (txtadminname.Text != "")
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
            MessageBox.Show("Empty Spaces !");
           
            
        }

        private void btnupdate2_Click(object sender, EventArgs e)
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

        private void btndelete2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to DELETE ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void btnokey_Click(object sender, EventArgs e)
        {
            
            //adminler.Open();
            //SqlCommand komut = new SqlCommand("Select * from adminedit where Name like '%" + txtadminuser.Text + "%'", adminler);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //gizliadminlistesidata.DataSource = ds.Tables[0];
            //adminler.Close();
            //string kelime1 = "Admin";
            //string kelime2 = "Worker";
            //string a = gizliadminlistesidata.CurrentRow.Cells[5].Value.ToString();
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
                    groupBox1.Show();
                    
                }
                else { MessageBox.Show("Kullanici adi veya sifre hatali"); }
                

                //if (gizliadminlistesidata.CurrentRow.Cells[5].Value.ToString().TrimEnd() == kelime1)
                //{
                //    //adminler.Open();
                //    //SqlCommand sorgula = new SqlCommand("select * from adminedit where name='" + txtadminuser.Text + "' and password='" + txtadminpass.Text + "'", adminler);
                //    //SqlDataReader dr = sorgula.ExecuteReader();
                //    //if (dr.Read())
                //    //{
                //    //txtadminemail.Clear();
                //    //txtadminpass.Clear();
                //    //panelwarning.Hide();
                //    //paneladmin.Show();
                //    //groupBox1.Show();
                //    //}
                //    //else
                //    //    MessageBox.Show("Wrong username or passsword...");
                //    //adminler.Close(); 
                    
                //    //gizli admin listesi panelwarning te okey butonunun altindadir
                //}
                //else if (gizliadminlistesidata.CurrentRow.Cells[5].Value.ToString().TrimEnd() == kelime2)
                //{
                //    MessageBox.Show(kelime2 + " can't access to this panel");
                //    txtadminuser.Text = "";
                //    txtadminpass.Text = "";
                //}
                //else
                //    MessageBox.Show("Invalid Wrong");
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
            groupBox1.Show();
            panelcheck.Show();
            panelwarning.Hide();
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
            
            MessageBox.Show("Contact us at canyil97@hotmail.com", "You Need Help ?");
        }

        private void comboitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchlbl.Text="Search "+comboitems.Text;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (comboitems.Text != "")
            {
                //kitaplar.Open();
                //SqlCommand komut = new SqlCommand("Select * from datas where " + comboitems.Text + " like '%" + txtsearch.Text + "%'", kitaplar);
                //SqlDataAdapter da = new SqlDataAdapter(komut);
                //komut.ExecuteNonQuery();
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //kitaplistesidata.DataSource = ds.Tables[0];
                //kitaplar.Close();
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
            checkbooknamelbl.Text = "Search " + comboBox1.Text+" :";
        }

       

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Something gone wrong", "Information!");
        }  
    }
}
