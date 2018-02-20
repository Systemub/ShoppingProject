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
    public partial class depo : Form
    {
        public depo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            depokayit dk = new depokayit();
            dk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            depotakip dt = new depotakip();
            dt.Show();
        }
    }
}
