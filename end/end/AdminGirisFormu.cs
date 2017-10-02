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
    public partial class AdminGirisFormu : Form
    {
        public AdminGirisFormu()
        {
            InitializeComponent();
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
        private void btnadminsendcod_Click(object sender, EventArgs e)
        {
            if (txtadminemail.Text == string.Empty)
            {
                MessageBox.Show("Dogru Karakterle Girilmedi !");
            }
            if (txtadminemail.Text != string.Empty)
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
                    tabControl1.SelectTab(2);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void btncanceladmin2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void btnadmincod_Click(object sender, EventArgs e)
        {
            if (txtadmincod.Text == a) tabControl1.SelectTab(3);
            else MessageBox.Show("Yanlis kod tekrar deneyin");
        }
        Yonetici yonetici;
        private void btnadminsavepass_Click(object sender, EventArgs e)
        {
            if (txtadminnewpass.Text.Length < 6)
            {
                MessageBox.Show("Girilen Sifre En Az 6 Karakter Icermeli");
            }
            else if (txtadminnewpass.Text.Length > 6 || txtadminconfirmpass.Text == txtadminnewpass.Text)
            {
                yonetici = new Yonetici();
                yonetici.Adminemail = txtadminemail.Text;
                yonetici.Adminsifre = txtadminnewpass.Text;
                if (yonetici.KutuphaneAdminiAdlaDuzenle())
                {
                    MessageBox.Show("Bilgileriniz Kaydedildi");
                }
                //Veritabani.AdminSifreYenile(txtadminemail.Text, txtadminnewpass.Text);
                tabControl1.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Dogru Degerler Girilmedi");
            }
        }
        private void btnadminlog_Click(object sender, EventArgs e)
        {
            yonetici = new Yonetici();
            yonetici.Adminemail = txtyoneticiemail.Text;
            yonetici.Adminsifre = txtyoneticisifre.Text;
            if (yonetici.KutuphaneAdminiGiris())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else { MessageBox.Show("Kullanici adi veya Sifre hatali"); }            
        }
        private void btncanceladmin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
        private void linkLabellost2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void AdminGirisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
