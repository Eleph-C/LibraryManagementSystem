using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace end
{
    public partial class login : Form
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
        public string txt;
        public login()
        {
            
            InitializeComponent();
            booksdata.Visible = false;
            lblsearchbook.Parent = pictureBox2;
            lblcontactwithdrctr.Parent = pictureBox2;
            lbluser.Parent = pictureBox4;
            lblusername.Parent = pictureBox4;
            lbluserpass.Parent = pictureBox4;
            linkLabellost.Parent = pictureBox4;
            lbladminpass.Parent = pictureBox5;
            lbladminname.Parent = pictureBox5;
            lbladmin.Parent = pictureBox5;
            linkLabellost2.Parent = pictureBox5;
            lbluseremail.Parent = pictureBox6;
            lblsendeduser.Parent = pictureBox7;
            lblnewpassworduser.Parent = pictureBox8;
            lblconfrmpassuser.Parent = pictureBox8;
            lbladminemail.Parent = pictureBox9;
            lblcodsended2.Parent = pictureBox10;
            lbladminnewpassword.Parent = pictureBox11;
            lbladminconfirmpass.Parent = pictureBox11;
            piclibraryrules.Hide();
            
        }
        veritabani Veritabani = new veritabani();
        Kitap kitap;
        Uye uye;
        Yonetici yonetici;
        public void showkitap()
        {
            kitap = new Kitap();
            kitap.Booksdata = booksdata;
            kitap.Booksdata2 = booksdata;
            kitap.KutuphaneyeKitapGetir();
            //Veritabani.KitapGetir(booksdata);
        }
        private void btnuserlogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);  
        }

       
        public static string GetRandomString()
        {
            Random R = new Random();
            char[] ArrRandomChar = new char[6];
            for (int i = 0; i < 6; i++)
                ArrRandomChar[i] = (char)('A' + R.Next(0, 26));
            return new string(ArrRandomChar);
        }
        string a = GetRandomString();
       
        private void btnusersavepass_Click(object sender, EventArgs e)
        {

           if (txtnewpassworduser.Text.Length < 6)
            {
                MessageBox.Show("6 dan kucuk deger");
            }
            else if (txtnewpassworduser.Text.Length > 6 || txtconfrmpassuser.Text == txtnewpassworduser.Text)
            {
                uye = new Uye();
                uye.Uyesifre = txtnewpassworduser.Text;
                uye.Uyeemail = txtuseremail.Text;
                if (uye.KutuphanedekiUyeyiDuzenle())
                {
                    MessageBox.Show("Bilgileriniz Kaydedildi");
                }
                //Veritabani.UyeSifreYenile(txtnewpassworduser.Text, txtuseremail.Text);
                //uyeler.Open();
                //SqlCommand komut = new SqlCommand("Update memberedit set password='" + txtnewpassworduser.Text + "' where email='" + txtuseremail.Text + "'", uyeler);
                ////komut.Parameters.AddWithValue("@password", txtnewpassworduser.Text);
                //try { komut.ExecuteNonQuery(); }
                //catch { MessageBox.Show("Changing password is failed successfully"); }
                //uyeler.Close();
                //MessageBox.Show("The password changed successfully");
                tabControl1.SelectTab(1);
            }
            else
            {
                MessageBox.Show("Dogru Degerler Girilmedi");
            }
        }



        private void btnusercancel_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtkullaniciemail.Text = "";
            txtkullanicisifre.Text = "";
        }

        private void btncanceladmin_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtyoneticiemail.Text = "";
            txtyoneticisifre.Text = "";
        }

        private void linkLabellost_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btnusersendcode_Click_1(object sender, EventArgs e)
        {

            if (txtuseremail.Text == "")
            {
                MessageBox.Show("Give True Values !");


            }
            if (txtuseremail.Text != "")
            {
                try
                {
                    
                    MailMessage message = new MailMessage();
                    message.Subject = "C&U LIBRARY";
                    message.From = new MailAddress("canyil97@hotmail.com");
                    message.Body = a;
                    message.To.Add(txtuseremail.Text);
                    SmtpClient server = new SmtpClient();
                    server.Credentials = new System.Net.NetworkCredential("canyil97@hotmail.com", "can.yilmaz");
                    server.Host = "smtp.live.com";
                    server.Port = 587;
                    server.EnableSsl = true;﻿
                    server.Send(message);
                    tabControl1.SelectTab(4);
                }
                catch
                {
                    MessageBox.Show("Give True Values !");
                }
            }
        }

        private void btnusercode_Click_1(object sender, EventArgs e)
        {
            if (txtcodeuser.Text == a)tabControl1.SelectTab(5);
            else MessageBox.Show("Wrong code try again");  
        }

        private void btncanceluser2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
        private void btnadminlog_Click_1(object sender, EventArgs e)
        {
            yonetici = new Yonetici();
            yonetici.Adminemail = txtyoneticiemail.Text;
            yonetici.Adminsifre = txtyoneticisifre.Text;
            if ( yonetici.KutuphaneAdminiGiris())
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Hide();
            }
            else { MessageBox.Show("Kullanici adi veya Sifre hatali"); }
            //if (adminler.State == ConnectionState.Closed){
            //adminler.Open();
            //SqlCommand sorgula = new SqlCommand("select * from adminedit where name='" + txtadminname.Text + "' and password='" + txtadminpass.Text + "'", adminler);
            //SqlDataReader dr = sorgula.ExecuteReader();
            //if (dr.Read())
            //{
            //    Form1 yeni = new Form1();
            //    yeni.Show();
            //    this.Hide();
            //}
            //else
            //    MessageBox.Show("Wrong username or passsword...");
            //adminler.Close();
            //}    
        }
        
        private void btnuserlog_Click_1(object sender, EventArgs e)
        {
            uye = new Uye();
            uye.Uyeemail = txtkullaniciemail.Text;
            uye.Uyesifre = txtkullanicisifre.Text;
            if (uye.KutuphaneyeUyeGirisi())
            {
                user frm = new user(uye.KutuphanedeUyeAra());
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya Sifre hatali");
            }
            //if (uyeler.State == ConnectionState.Closed)
            //{
            //    uyeler.Open();
            //    SqlCommand sorgula = new SqlCommand("select * from memberedit where name='" + txtusername.Text + "' and password='" + txtuserpass.Text + "'", uyeler);
            //    SqlDataReader dr = sorgula.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        txt = txtusername.Text;
            //        user frm = new user(txt);
            //        frm.Show();
            //        this.Hide();
            //    }
            //    else
            //        MessageBox.Show("Wrong username or passsword...");
            //    uyeler.Close();
            //}    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void btnadminsendcod_Click(object sender, EventArgs e)
        {
            if (txtadminemail.Text == "")
            {
                MessageBox.Show("Give True Values !");


            }
            if (txtadminemail.Text != "")
            {
                try
                {
                    
                    MailMessage message = new MailMessage();
                    message.Subject = "C&U LIBRARY";
                    message.From = new MailAddress("canyil97@hotmail.com");
                    message.Body = a;
                    message.To.Add(txtadminemail.Text);
                    SmtpClient server = new SmtpClient();
                    server.Credentials = new System.Net.NetworkCredential("canyil97@hotmail.com", "can.yilmaz");
                    server.Host = "smtp.live.com";
                    server.Port = 587;
                    server.EnableSsl = true;﻿
                    server.Send(message);
                    tabControl1.SelectTab(7);
                }
                catch
                {
                    MessageBox.Show("Give True Values !");
                }
            }
          
        }

        private void btnadmincod_Click(object sender, EventArgs e)
        {
            if (txtadmincod.Text == a)  tabControl1.SelectTab(8);
            else MessageBox.Show("Wrong code try again");
        }

        private void btnadminsavepass_Click(object sender, EventArgs e)
        {
            if (txtadminnewpass.Text.Length < 6)
            {
                MessageBox.Show("6 dan kucuk");
            }
            else if (txtadminnewpass.Text.Length > 6 || txtadminconfirmpass.Text == txtadminnewpass.Text)
            {
                yonetici.Adminemail = txtadminemail.Text;
                yonetici.Adminsifre = txtadminnewpass.Text;
                if (yonetici.KutuphaneAdminiDuzenle())
                {
                    MessageBox.Show("Bilgileriniz Kaydedildi");
                }
                //Veritabani.AdminSifreYenile(txtadminemail.Text, txtadminnewpass.Text);
                //adminler.Open();
                //SqlCommand komut = new SqlCommand("Update adminedit set password='" + txtadminnewpass.Text + "' where email='" + txtadminemail.Text + "'", adminler);
                //try { komut.ExecuteNonQuery(); }
                //catch { MessageBox.Show("Changin password is failed successfully"); }
                //adminler.Close();
                tabControl1.SelectTab(2);
            }
            else
            {
                MessageBox.Show("Give True Valid");
            }
           
        }


        private void btncanceladmin2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void login_Load(object sender, EventArgs e)
        {
            
            
            
            showkitap();
        }

        private void btnrules_Click(object sender, EventArgs e)
        {
           
            piclibraryrules.Visible = true;
            btnrules2.Visible = true;
            btnrules.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            piclibraryrules.Visible = false;
            btnrules2.Visible = false;
            btnrules.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            booksdata.Visible = false;
            //txtsearch.Text = "";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != string.Empty)
            {
                booksdata.Visible = true;
                kitap = new Kitap();
                kitap.Booksdata = booksdata;
                kitap.Booksdata2 = booksdata;
                kitap.KitapKategori = "KitapAdi";
                kitap.Kelimeara = txtsearch.Text;
                kitap.KutuphanedeKitapAra();
                //Veritabani.KitapAra(booksdata, "KitapAdi", txtsearch.Text);
            }
            else
            {
                booksdata.Visible = false;
                booksdata.ClearSelection();
            }
            //kitaplar.Open();
            //SqlCommand komut = new SqlCommand("Select * from datas where bookname like '%" + txtsearch.Text + "%'", kitaplar);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataSet ds = new DataSet();
            //try { da.Fill(ds); }
            //catch { MessageBox.Show("Something Happened While Logining To SQL Table"); }
            //booksdata.DataSource = ds.Tables[0];
            //kitaplar.Close();
        }

        

       
    }
}
