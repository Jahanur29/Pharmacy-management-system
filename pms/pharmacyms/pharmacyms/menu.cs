using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Data.SqlClient;
namespace pharmacyms
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void addMedicinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mdcn mc = new mdcn();
            
               
           // mc.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                
        }

        private void addCompnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_pw cp = new change_pw();
            cp.Show();
            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salesRepotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Show();
            this.Hide();
        }

        private void medicinDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sellreport sp = new sellreport();
            sp.Show();
            this.Hide();
        }

        private void parchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer cu = new customer();
            cu.Show();
            this.Hide();
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            company co = new company();
            co.Show();
            this.Hide();
        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchasereprt st = new purchasereprt();
            st.Show();
            this.Hide();
        }

        private void medicinToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void viewMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchcustomer vcu = new searchcustomer();
            vcu.Show();
            this.Hide();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serchcompany vcm = new serchcompany();
            vcm.Show();
            this.Hide();
        }

        private void removeCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rmvcompany rcm = new rmvcompany();
            rcm.Show();
            this.Hide();
        }
    
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rmvcustomer rcu = new rmvcustomer();
            rcu.Show();
            this.Hide();
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchcustomer vcu = new searchcustomer();
            vcu.Show();
            this.Hide();
        }

        private void compantListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editcompany ecm = new editcompany();
            ecm.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editcustomer ecu = new editcustomer();
            ecu.Show();
            this.Hide();
        }

        private void orderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcompany vcm = new viewcompany();
            vcm.Show();
            this.Hide();
        }

        private void medicineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcustomer s = new viewcustomer();
            s.Show();
            this.Hide();
        }

        private void companyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void purToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase p = new purchase();
            p.Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
