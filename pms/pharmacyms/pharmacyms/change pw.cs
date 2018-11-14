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
    public partial class change_pw : Form
    {
        public change_pw()
        {
            InitializeComponent();
        }

        private void change_pw_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");

            // con.Open();(Data Source=(LocalDB)\v11.0;AttachDbFilename="F:\databs project\pharmacyms\pharmacyms\Data.mdf";Integrated Security=True)
            if ( txtodus.Text != "  ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update login set password='" + txtcnfirm.Text + "' where UserName='" + txtodus.Text + "' ", con);

                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Change SuccesfullY ");
                }

                catch
                {
                    MessageBox.Show("ErrOr");
                }

            }
            else
            {
                MessageBox.Show("Enter User Name and Password");
            }
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtodus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
