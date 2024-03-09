using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SummOOP
{
    public partial class SearchEmp : Form
    {
        Konek kon = new Konek();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public SearchEmp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTRDataSet.table_Attendance' table. You can move, or remove it, as needed.
           // this.table_AttendanceTableAdapter.Fill(this.dTRDataSet.table_Attendance);
            // TODO: This line of code loads data into the 'dTRDataSet4.table_Attendance' table. You can move, or remove it, as needed.
            this.table_AttendanceTableAdapter4.Fill(this.dTRDataSet4.table_Attendance);
            // TODO: This line of code loads data into the 'dTRDataSet3.table_Attendance' table. You can move, or remove it, as needed.
           // this.table_AttendanceTableAdapter3.Fill(this.dTRDataSet3.table_Attendance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpTxtBox.Text == "")
            {
                MessageBox.Show("Please enter EMPLOYEE ID to search.");
            }
            else
            {
                conn = kon.getCon();
                conn.Open();
                ds = new DataSet();
                //only display total hour and overtime hrs for computation
                String sql = "select [EMPLOYEE ID],[LOG DATE], [TOTAL HOURS], [TOTAL OVERTIME HOURS] from table_Attendance where [EMPLOYEE ID] = '" + EmpTxtBox.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                dataGridView1.DataSource = dv;
                conn.Close();
                da.Dispose();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //set to zero if blank
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox9.Text =="")
            {
                textBox9.Text = "0";
            }

            //calculate weekly salary
            double days, dayRate, SumSal;
            days = Convert.ToDouble(textBox1.Text);
            dayRate = Convert.ToDouble(textBox2.Text);
            SumSal = days * dayRate;
            
            //display sum
            label8.Text = SumSal.ToString();

            double overPrem, overPay, overHrs;
            overHrs = Convert.ToDouble(textBox3.Text);
            
            overPrem = (dayRate / 8) * overHrs;
            label12.Text = overPrem.ToString();
            //overpay

            //total salary
            double GrossSalary = SumSal + overPrem;
            label13.Text = GrossSalary.ToString();

            //deductions
            double cashAdv = Convert.ToDouble(textBox4.Text);
            double foodDed = Convert.ToDouble(textBox5.Text);
            double sssDed = Convert.ToDouble(textBox6.Text);
            double philHealth = Convert.ToDouble(textBox7.Text);
            double pagIbig = Convert.ToDouble(textBox8.Text);
            double otherDed = Convert.ToDouble(textBox9.Text);
            //sum deduction
            double sumDeduction = cashAdv + foodDed + sssDed + philHealth + pagIbig + otherDed;

            label22.Text = sumDeduction.ToString();
            label24.Text = (GrossSalary - sumDeduction).ToString();


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
