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
        private string txt;
        veritabani Veritabani = new veritabani();
        public user(string txt)
        {
            InitializeComponent();
            panelchangepass.Hide();
            panelbooks.Hide();
            panelchangepass.BackColor = Color.Transparent;
            panelbooks.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            panelchangepass.Parent = pictureBox1;
            panelbooks.Parent = pictureBox1;
            groupBox1.Parent = pictureBox1;
            this.txt = txt;
        }

        public user()
        {
            // TODO: Complete member initialization
        }

       
        public void showdata()
        {
            Veritabani.KitapGetir(booksdata);
        }


        private void btnchangepass_Click(object sender, EventArgs e)
        {
            panelbooks.Hide();
            panelchangepass.Show();
        }

        private void btnborrowedbooks_Click(object sender, EventArgs e)
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
                MessageBox.Show("6 dan kucuk");
            }
            else if(txtnewpass.Text.Length>=6 || txtconfirmpass.Text==txtnewpass.Text)
            {
                Veritabani.UyeSifreAdYenile(txt, txtnewpass.Text);
                //uyeler.Open();
                //SqlCommand komut = new SqlCommand("Update memberedit set password='" + txtnewpass.Text + "' where name='" + txt + "'", uyeler);
                //komut.Parameters.AddWithValue("@password", txtnewpass.Text);
                //komut.ExecuteNonQuery();
                //uyeler.Close();
                MessageBox.Show("The password changed successfully");
            }
            else
            {
                MessageBox.Show("Give True Valid");
            }
           
        }

        private void user_Load(object sender, EventArgs e)
        {
            Veritabani.KitapAra(booksdata, "KitapSahibi", txt);
           //kitaplar.Open();
           //SqlCommand komut = new SqlCommand("Select * from datas where member like '%" + txt + "%'", kitaplar);
           //SqlDataAdapter da = new SqlDataAdapter(komut);
           //DataSet ds = new DataSet();
           //da.Fill(ds);
           //booksdata.DataSource = ds.Tables[0];
           //kitaplar.Close();
           
            
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            txtnewpass.Text = "";
            txtconfirmpass.Text = "";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us at canyil97@hotmail.com", "You Need Help ?");
        }

        
        
    }
}
