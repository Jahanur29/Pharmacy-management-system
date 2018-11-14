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
    public partial class editcompany : Form
    {
        public editcompany()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");
           
            con.Open();
                    SqlCommand cmd = new SqlCommand("update company set cm_address='" + textBox3.Text + "',cm_city='"+textBox4.Text+"',cm_phone='"+textBox5.Text+"' where cm_id='"+textBox1.Text+"'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Company Information update SuccesfullY ");
                    }

                    catch
                    {
                        MessageBox.Show("ErrOr");
                    }

                }

            }

        }


