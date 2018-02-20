using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingProject
{
    public partial class ShoppingMainPage : Form
    {
        public ShoppingMainPage()
        {
            InitializeComponent();
        }

        private void depobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            depo dep = new depo();
            dep.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
            this.Hide();
            

           

        }

        private void istatistikbtn_Click(object sender, EventArgs e)
        {
            istatistik ist = new istatistik();
            ist.Show();
            this.Hide();

        }

        private void anliksatisbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            anliksatis ans = new anliksatis();
            ans.Show();
        }

        private void ShoppingMainPage_Load(object sender, EventArgs e)
        {

        }

        private void datealert_Click(object sender, EventArgs e)
        {
            toptancı tp = new toptancı();
            tp.Show();
        }
    }
}
