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
    public partial class user : Form
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
        private DataTable datasource;
        veritabani Veritabani = new veritabani();
        Kitap kitap;
        Uye uye;
        public user(DataTable _datasource)
        {
            InitializeComponent();
            panelchangepass.Hide();
            panelbooks.Hide();
            panelchangepass.BackColor = Color.Transparent;
            panelbooks.BackColor = Color.Transparent;
            this.datasource = _datasource;
        }

        private void btnsifredegis_Click(object sender, EventArgs e)
        {
            panelbooks.Hide();
            panelchangepass.Show();
        }
        private void btnkitaplariniz_Click(object sender, EventArgs e)
        {
            panelchangepass.Hide();
            panelbooks.Show();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchangepass.Show();
            panelbooks.Hide();
        }
        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelchangepass.Hide();
            panelbooks.Show();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login yeni = new login();
            yeni.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (txtnewpass.Text.Length<6)
            {
                MessageBox.Show("Olusturmak Istediginiz Sifre En Az 6 Degerden Olusmali");
            }
            else if(txtnewpass.Text.Length>=6 || txtconfirmpass.Text==txtnewpass.Text)
            {
                uye = new Uye();
                uye.Uyeemail = label2.Text;
                uye.Uyesifre = txtnewpass.Text;
                if (uye.KutuphanedekiUyeAdSifresiYenile())
                {
                    MessageBox.Show("Sifreniz Degistirildi");
                }
                //Veritabani.UyeSifreAdYenile(txt, txtnewpass.Text);
            }
            else
            {
                MessageBox.Show("Istenmeyen Karakterler Var");
            } 
        }
        private void user_Load(object sender, EventArgs e)
        {
            label1.Text = datasource.Rows[0][1].ToString();
            label2.Text = datasource.Rows[0][2].ToString();
            kitap = new Kitap();
            kitap.Kelimeara = label1.Text;
            kitap.Booksdata = booksdata;
            kitap.KutuphanedeKisiyeKitapAra();
            //booksdata.DataSource = datasource;
            //Veritabani.KitapAra(booksdata, "KitapSahibi", txt);
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            txtnewpass.Text = "";
            txtconfirmpass.Text = "";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizimle Iletisime Gec canyil97@hotmail.com", "Yardima mi ihtiyacin var ?");
        }

        private void user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        
    }
}
