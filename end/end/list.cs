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
        veritabani Veritabani = new veritabani();
        public void showdata()
        {
            Veritabani.KitapGetir(booksdata);
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
                Veritabani.KitapAra(booksdata, comboitems.Text, txtitems.Text);
            //kitaplar.Open();
            //SqlCommand komut = new SqlCommand("Select * from datas where " + comboitems.Text + " like '%" + txtitems.Text + "%'", kitaplar);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //try { komut.ExecuteNonQuery(); }
            //catch { MessageBox.Show("Something gone wrong"); }
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //booksdata.DataSource = ds.Tables[0];
            //kitaplar.Close();
            }
           
        }
        

       
        
    }
}
