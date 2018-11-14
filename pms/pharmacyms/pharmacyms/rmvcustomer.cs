using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace pharmacyms
{
    public partial class rmvcustomer : Form
    {
        public rmvcustomer()
        {
            InitializeComponent();
        }

        private void bk2main_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void rmv_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");




            con.Open();
            // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
            SqlCommand sc = new SqlCommand("delete from customer where cu_id='" + textBox1.Text + "'", con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete SuccesFully!!!!  ");
        }
    }
}
