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
        public login()
        {            
            InitializeComponent();
            booksdata.Visible = false;            
        }
        Kitap kitap;
        
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
            UyeGirisFormu uyegirisformu = new UyeGirisFormu();
            uyegirisformu.Show();
            this.Hide();
        }
        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            AdminGirisFormu admingirisformu = new AdminGirisFormu();
            admingirisformu.Show();
            this.Hide();
        }
        private void login_Load(object sender, EventArgs e)
        {            
            showkitap();
        }
        private void btnrules_Click(object sender, EventArgs e)
        {
            KutuphaneKurallari kutuphanekurallari = new KutuphaneKurallari();
            kutuphanekurallari.ShowDialog();
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
        }
        private void login_Click(object sender, EventArgs e)
        {
            booksdata.Visible = false;
            //txtsearch.Text = "";
        }
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
