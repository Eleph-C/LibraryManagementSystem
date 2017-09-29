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
            loadingline.Increment(7);
           // loadingline.Step = 10;
            if(loadingline.Value ==100)
            {
                timer1.Stop();
                
                this.Close();
               
            }
        }
    }
}
