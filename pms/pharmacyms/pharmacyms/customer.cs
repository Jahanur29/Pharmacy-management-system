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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int tot = a - b;
            string z = Convert.ToString(tot);
            textBox3.Text = z;
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO customer (cu_id,cu_name,cu_address,cu_phone,Total_amount,Advance_amount,Due_amount) VALUES ('" + txtcuid.Text + "','" + txtcunm.Text + "', '" + txtcuad.Text + "','" + txtcuph.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error...");
                cn1.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {

        }
    }
}
