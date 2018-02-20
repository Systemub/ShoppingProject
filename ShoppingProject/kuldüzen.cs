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
    public partial class kuldüzen : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=market.accdb");

        OleDbDataAdapter da;

        OleDbCommand cmd;
        DataSet ds;
        public kuldüzen()
        {
            InitializeComponent();
        }

        private void kuldüzen_Load(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM musteri", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            adapter.Dispose();
        }
    }
}
