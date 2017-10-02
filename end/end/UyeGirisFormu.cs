using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end
{
    public partial class UyeGirisFormu : Form
    {
        public UyeGirisFormu()
        {
            InitializeComponent();
        }
        Uye uye;
        private void btnuserlog_Click(object sender, EventArgs e)
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
        }
        private void btnusercancel_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
        private void linkLabellost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(1);
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
        private void btnusersendcode_Click(object sender, EventArgs e)
        {
            if (txtuseremail.Text == string.Empty)
            {
                MessageBox.Show("Dogru Karakterle Girilmedi !");
            }
            if (txtuseremail.Text != string.Empty)
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
                    tabControl1.SelectTab(2);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void btncanceluser2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void btnusercode_Click(object sender, EventArgs e)
        {
            if (txtcodeuser.Text == a) tabControl1.SelectTab(3);
            else MessageBox.Show("Yanlis Kod Tekrar Deneyin");  
        }
        private void btnusersavepass_Click(object sender, EventArgs e)
        {
            if (txtnewpassworduser.Text.Length < 6)
            {
                MessageBox.Show("Girilen Sifre En Az 6 Karakter Icermeli");
            }
            else if (txtnewpassworduser.Text.Length > 6 || txtconfrmpassuser.Text == txtnewpassworduser.Text)
            {
                uye = new Uye();
                uye.Uyesifre = txtnewpassworduser.Text;
                uye.Uyeemail = txtuseremail.Text;
                if (uye.KutuphanedekiUyeAdSifresiYenile())
                {
                    MessageBox.Show("Bilgileriniz Kaydedildi");
                }
                //Veritabani.UyeSifreYenile(txtnewpassworduser.Text, txtuseremail.Text);
                tabControl1.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Dogru Degerler Girilmedi");
            }
        }

        private void UyeGirisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
