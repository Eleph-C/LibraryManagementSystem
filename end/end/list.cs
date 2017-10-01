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
    public partial class list : Form
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
        public list()
        {
            InitializeComponent();
            paneltools.BackColor = Color.Transparent;
        }
        Kitap kitap = new Kitap();
        public void showdata()
        {
            kitap = new Kitap();
            kitap.Booksdata = booksdata;
            kitap.Booksdata2 = booksdata;
            kitap.KutuphaneyeKitapGetir();
            //Veritabani.KitapGetir(booksdata);
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void list_Load(object sender, EventArgs e)
        {
            showdata();
            comboitems.Text = "KitapAdi";
        }
        private void txtitems_TextChanged(object sender, EventArgs e)
        {
            if(comboitems.Text!="")
            {
                kitap = new Kitap();
                kitap.Booksdata = booksdata;
                kitap.Booksdata2 = booksdata;
                kitap.KitapKategori = comboitems.Text;
                kitap.Kelimeara = txtitems.Text;
                kitap.KutuphanedeKitapAra();
                //Veritabani.KitapAra(booksdata, comboitems.Text, txtitems.Text);
            }
           
        }
        

       
        
    }
}
