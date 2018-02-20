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
    public partial class toptancı : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=market.accdb");

        OleDbDataAdapter da;

        OleDbCommand cmd;
        DataSet ds;
        public toptancı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();

            int alinan_urun_miktari = Convert.ToInt32(alinan_urun_miktbox.Text);
          
          
             
                OleDbCommand toptancikmt = new OleDbCommand("INSERT INTO toptanci (top_adi, top_borc) VALUES ('" + top_name_tbox.Text.Trim() + "', '" + alinan_urun_miktari + "')", con);
                toptancikmt.ExecuteNonQuery();
            con.Close();
            this.Close();
            ShoppingMainPage smp = new ShoppingMainPage();
            smp.Close();
        }
          
          
        }
}
