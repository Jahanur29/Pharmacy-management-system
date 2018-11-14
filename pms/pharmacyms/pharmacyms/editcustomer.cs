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
    public partial class editcustomer : Form
    {
        public editcustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox5.Text);
            int tot = a - b;
            string z = Convert.ToString(tot);
            textBox4.Text = z;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update customer set Total_amount='" + textBox2.Text + "',Advance_amount='" + textBox5.Text + "',Due_amount='" + textBox4.Text + "' where cu_id='" + textBox1.Text + "'", con);

          
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cust Information update SuccesfullY ");
            }

            catch
            {
                MessageBox.Show("ErrOr");
            }

            }
        }
    }

