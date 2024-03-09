using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummOOP
{
    public partial class RegEmpForm : Form
    {
        Konek kon = new Konek();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        int val = 1000;
        public RegEmpForm()
        {
            InitializeComponent();
        }

        private void RegEmpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTRDataSet.table_EmployeeInt' table. You can move, or remove it, as needed.
            this.table_EmployeeIntTableAdapter.Fill(this.dTRDataSet.table_EmployeeInt);
            // TODO: This line of code loads data into the 'dTRDataSet4.table_EmployeeInt' table. You can move, or remove it, as needed.
           // this.table_EmployeeIntTableAdapter2.Fill(this.dTRDataSet4.table_EmployeeInt);
            // TODO: This line of code loads data into the 'dTRDataSet3.table_EmployeeInt' table. You can move, or remove it, as needed.
          //  this.table_EmployeeIntTableAdapter1.Fill(this.dTRDataSet3.table_EmployeeInt);
            EmpIdGen();
          
        }

        public void EmpIdGen()
        {
            //auto generates employee ID upon registration
            conn = kon.getCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from table_EmployeeInt", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            i++;
            int valLbl = val + i;
            //display current available employee ID
            label5.Text = valLbl.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prevent null input
            if (textBox2.Text == "")
            {
                MessageBox.Show("Your Last Name cannot be empty!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Your First Name cannot be empty!");
            }
            else
            {
                conn = kon.getCon();
                conn.Open();
                //To create new Employee Data
                cmd = new SqlCommand("insert into table_EmployeeInt values ('" + label5.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Registered Successfully.");
                EmpIdGen();
                //reset textfields in case of multiple account creation
                textBox2.Text = "";
                textBox3.Text = "";

                cmd.Dispose();
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // this.table_EmployeeIntTableAdapter1.Fill(this.dTRDataSet3.table_EmployeeInt);
            // this.table_EmployeeIntTableAdapter2.Fill(this.dTRDataSet4.table_EmployeeInt);
            this.table_EmployeeIntTableAdapter.Fill(this.dTRDataSet.table_EmployeeInt);

            //auto update table
        }
    }
}
