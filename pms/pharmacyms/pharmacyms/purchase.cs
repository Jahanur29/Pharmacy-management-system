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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox7.Text);
            int b = Convert.ToInt32(textBox8.Text);
            int tot = a * b;
            string z = Convert.ToString(tot);
            textBox9.Text = z;
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Table1(id,pur_date,cm_name,m_name,m_power,m_catagori,exp_date,per_unit_price,pur_quantity,total_price) VALUES ('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + txtcat.Text + "','" + dateTimePicker2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", cn1);


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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void purchase_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from Table1 where id='" + textBox1.Text + "'or pur_date='" + dateTimePicker1.Text + "'or m_name='" + textBox5.Text + "' or cm_name='" + textBox2.Text + "'or m_catagori='" + txtcat.Text + "'or exp_date='" + dateTimePicker2.Text + "'", con);
           // SqlDataAdapter sb = new SqlDataAdapter("select *from purchase where  pur_date='" + dateTimePicker1.Text + "'", con);
            //SqlDataAdapter sc = new SqlDataAdapter("select *from purchase where m_name='" + textBox5.Text + "'", con);
            //SqlDataAdapter sd = new SqlDataAdapter("select *from purchase where cm_name='" + textBox2.Text + "'", con);
            //SqlDataAdapter se = new SqlDataAdapter("select *from purchase where m_catagori='" + txtcat.Text + "'", con);
          //  SqlDataAdapter sf = new SqlDataAdapter("select *from purchase where  exp_date='" + dateTimePicker2.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            //sb.Fill(data1);
            //sc.Fill(data1);
         //   sd.Fill(data1);
           // se.Fill(data1);
         //  sf.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            txtcat.Text = "";
            textBox6.Text = "";
            dateTimePicker2.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");




            con.Open();
            // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
            SqlCommand sc = new SqlCommand("delete from purchase where pur_id='" + textBox1.Text + "'", con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete SuccesFully!!!!  ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
