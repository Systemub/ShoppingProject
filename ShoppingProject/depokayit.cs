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
    public partial class depokayit : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=market.accdb");

        OleDbDataAdapter da;

        OleDbCommand cmd;
        DataSet ds;
        public depokayit()
        {
            InitializeComponent();
        }

        private void depouruneklebtn_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = con;
            con.Open();
            int barkod=Convert.ToInt32(barkodtbox.Text);

          
            int urun_miktar=Convert.ToInt32(urunmiktbox.Text);
            int urun_birim=Convert.ToInt32(urunbirimfiyattbox.Text);
            int urun_top_fiyat = Convert.ToInt32(urunmiktbox.Text) * Convert.ToInt32(urunbirimfiyattbox.Text);
          
                OleDbCommand eklekomut = new OleDbCommand("INSERT INTO depo (barkod,urun_adet,urun_adi,urun_bf,urun_top_fiyat) VALUES ('" + barkod + "','" + urun_miktar + "','" + urunaditbox.Text + "', '" + urun_birim + "', '" + urun_top_fiyat+ "')", con);
                eklekomut.ExecuteNonQuery();
            

            
            con.Close();
            this.Close();
        }
    }
}
