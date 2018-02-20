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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void kulekle_Click(object sender, EventArgs e)
        {
            kisiekleform ks = new kisiekleform();
            ks.Show();
            this.Hide();

        }

        private void kuldüzen_Click(object sender, EventArgs e)
        {
            kuldüzen kd = new kuldüzen();
            kd.Show();
            this.Hide();
            ShoppingMainPage smp = new ShoppingMainPage();
            smp.Close();
            
        }
    }
}
