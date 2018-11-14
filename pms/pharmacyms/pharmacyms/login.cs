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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");
           SqlDataAdapter sda = new SqlDataAdapter(" Select Count (*) From login where username = '" + textBox1.Text + "'  and password ='" + textBox2.Text + "'", con);
          DataTable dt = new DataTable();
          sda.Fill(dt);
          if(dt.Rows[0][0].ToString() == "1")
           {
              frnt fr = new frnt();
              fr.Show();
              this.Hide();
           }
           else
           {
               MessageBox.Show("Please check username and password.....");
            }*/

            frnt fr = new frnt();
            fr.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frgtpw_Click(object sender, EventArgs e)
        {
            change_pw cp = new change_pw();
            cp.Show();
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
