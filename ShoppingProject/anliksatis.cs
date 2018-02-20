using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoppingProject
{
    public partial class anliksatis : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=market.accdb");

        OleDbDataAdapter da;

        OleDbCommand cmd;
        DataSet ds = new DataSet();
        public anliksatis()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(barkodtextbox.Text);
            con.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from satis", con);
            adtr.Fill(ds, "satis");
            dataGridView2.DataSource = ds.Tables["satis"];
            adtr.Dispose();
            con.Close();
        }
    }
}
