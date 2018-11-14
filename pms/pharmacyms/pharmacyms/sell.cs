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
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
        }

        private void sell_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        void updateMedicine()
        {

            int remain = bachabache();
            if (remain > 0)
            {
                string xx = bachabache().ToString();

                string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

                SqlConnection con = new SqlConnection(cns);
                //cn1.Open();

                con.Open();
                SqlCommand sa = new SqlCommand("update Table1 set pur_quantity='" + xx + "' where m_name='" + textBox14.Text + "'", con);
                try
                {
                    sa.ExecuteNonQuery();
                    MessageBox.Show("Update");
                }

                catch
                {
                    MessageBox.Show("error");
                    con.Close();
                }


            }
            else
            {
                MessageBox.Show("please go anothe r store ");
            }
            

        }


        int bachabache()
        {

           
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            string qury="select sum(pur_quantity) from Table1 where m_name='"+textBox14.Text+"' ";
            SqlCommand sc = new SqlCommand(qury, cn1);
       
                int alu = Convert.ToInt32(textBox10.Text);

                int begun = 0 + (Int32)sc.ExecuteScalar();
                int zz = begun - alu;
               string bari=zz.ToString();
             //  MessageBox.Show(bari);

               return zz;
                


            }
        

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

       


      
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True");




            con.Open();
            // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
            SqlCommand sc = new SqlCommand("delete from sales where sales_id='" + textBox16.Text + "'", con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete SuccesFully!!!!  ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
            dateTimePicker2.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from sales where  sales_date='" + dateTimePicker2.Text + "'or m_name='" + textBox14.Text + "' or cu_name='" + textBox1.Text + "'or payment_type='" + comboBox1.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();

        }

        private void saveClick(object sender, EventArgs e)
        {
            updateMedicine();
            int a = Convert.ToInt32(textBox12.Text);
            int b = Convert.ToInt32(textBox10.Text);
            int tot = a * b;
            string z = Convert.ToString(tot);
            textBox9.Text = z;
            int x = Convert.ToInt32(textBox10.Text);
           // int z = Convert.ToInt32(purchase.pur_quantity);
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO sales (sales_id,sales_date,m_name,m_power,per_unit_price,m_quantity,total_price,cu_id,cu_name,payment_type) VALUES ('" + textBox16.Text + "','" + dateTimePicker2.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox12.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "')", cn1);
           // SqlCommand sc = new SqlCommand("delete from puchase where pur_quantity='" + textBox1.Text + "'", cn1);

            try
            {
                cmd1.ExecuteNonQuery();
              //  sc.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                cn1.Close();
            }
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\pharmacym(1)\pms\pharmacyms\pharmacyms\Data.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from sales where  sales_date='" + dateTimePicker2.Text + "'or m_name='" + textBox14.Text + "' or cu_name='" + textBox1.Text + "'or payment_type='" + comboBox1.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();

        }

        private void delete_Click_1(object sender, EventArgs e)
        {

        }

        private void reset_Click_1(object sender, EventArgs e)
        {

        }
    }
}
