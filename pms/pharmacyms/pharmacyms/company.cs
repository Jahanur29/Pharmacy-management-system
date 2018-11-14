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
    public partial class company : Form
    {
        public company()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO company (cm_id,cm_name,cm_address,cm_city,cm_phone) VALUES ('" + txtcpid.Text + "', '" + txtcpnm.Text + "', '" + txtcpad.Text + "','" + textBox1.Text + "','" + txtcpph.Text + "')", cn1);


            try
            {
                cmd1.ExecuteNonQuery();
                 MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcpph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcpad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcpnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void company_Load(object sender, EventArgs e)
        {

        }
    }
}
