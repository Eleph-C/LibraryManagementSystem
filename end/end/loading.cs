using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(loadingline.Value ==100)
            {
                timer1.Stop();
                login login = new login();
                login.Show();
                this.Hide();
                
            }
            else
            {
                loadingline.Value = loadingline.Value + 10;
            }
        }

        private void loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
