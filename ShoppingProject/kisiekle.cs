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
    public partial class kisiekleform : Form
    {

        OleDbConnection con=new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=market.accdb");
      
        OleDbDataAdapter da;
        
        OleDbCommand cmd;
        DataSet ds;

        public kisiekleform()
        {
            InitializeComponent();
        }

        private void kisieklebtn_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            try { 
            OleDbCommand eklekomut = new OleDbCommand("INSERT INTO musteri (mus_tc, mus_adi , mus_sad) VALUES ('" + musnotextbox.Text.Trim() + "', '" + musaditextbox.Text.Trim() + "','" + mussoyaditextbox.Text.Trim() + "')", con);
            eklekomut.ExecuteNonQuery();
           
            }
            catch(Exception)
            {

            }
            con.Close();
            this.Close();
            ShoppingMainPage smp = new ShoppingMainPage();
            smp.Close();
        }
    }
}
