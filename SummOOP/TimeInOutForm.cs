using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace SummOOP
{
    public partial class TimeInOutForm : Form
    {
        Konek kon = new Konek();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public TimeInOutForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //display current time and date
            lblDate.Text = DateTime.Now.ToString("M/dd/yyyy");
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeInOutForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dTRDataSet4.table_Attendance' table. You can move, or remove it, as needed.
            this.table_AttendanceTableAdapter3.Fill(this.dTRDataSet4.table_Attendance);
            // TODO: This line of code loads data into the 'dTRDataSet3.table_Attendance' table. You can move, or remove it, as needed.
            //this.table_AttendanceTableAdapter2.Fill(this.dTRDataSet3.table_Attendance);
            //load table content upon loading in

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your EMPLOYEE ID to time in / out.");
            }
            else
            {
                //find employee in employee database if they exist
                conn = kon.getCon();
                conn.Open();
                dt = new DataTable();
                String sql = "select * from table_EmployeeInt where [EMPLOYEE ID] = '" + textBox1.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
                da.Dispose();

                if (dt.Rows.Count > 0) //if a record is found
                {
                    conn = kon.getCon();
                    conn.Open();
                    dt = new DataTable();
                    //check if employee has already timed in and out for the day
                    sql = "select * from table_Attendance where [EMPLOYEE ID] = '" + textBox1.Text + "' and [LOG DATE] = '" + lblDate.Text + "' and AM_isLogged='Time In' and PM_isLogged='Time Out'";
                    da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    conn.Close();
                    da.Dispose();

                    if (dt.Rows.Count > 0) //if a record shows up
                    {
                        MessageBox.Show("You have already timed IN and OUT for the day.");
                    }else
                    {
                        conn = kon.getCon();
                        conn.Open();
                        dt = new DataTable();
                        //check if emp already timed in
                        sql = "select * from table_Attendance where [EMPLOYEE ID] = '" + textBox1.Text + "' and [LOG DATE] = '" + lblDate.Text + "' and AM_isLogged='Time In'";
                        da = new SqlDataAdapter(sql, conn);
                        da.Fill(dt);
                        conn.Close();
                        da.Dispose();

                        if (dt.Rows.Count > 0) //if a record shows up, employee already timed in, employee is then timed out
                        {
                            conn = kon.getCon();
                            conn.Open();
                            //update database, computes total hours
                            SqlCommand cmd = new SqlCommand("update table_Attendance set [TIME OUT] = '" + lblTime.Text + "', PM_isLogged= 'Time Out', [TOTAL HOURS] = DATEDIFF(second, CONVERT(DateTime, [TIME IN], 108), CONVERT(DateTime, '" + DateTime.Now.ToLongTimeString() + "', 108))/3600 where [EMPLOYEE ID] = '" + textBox1.Text + "' and [LOG DATE] = '" + lblDate.Text + "'", conn);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //get total hour value
                            SqlCommand sCmd = new SqlCommand("select [TOTAL HOURS] from table_Attendance where [EMPLOYEE ID] = '" + textBox1.Text + "' and [LOG DATE] = '" + lblDate.Text + "'", conn);
                            var totalHoursResult = sCmd.ExecuteScalar();
                            sCmd.Dispose();
                            int Total = Convert.ToInt32(totalHoursResult);
                            //check whether employee has overtime
                            //any less than 9 returns negative number so is set to 0 instead
                            if (Total > 9)
                            {
                                SqlCommand uCmd = new SqlCommand("update table_Attendance set [TOTAL OVERTIME HOURS] = ((DATEDIFF(second, CONVERT(DateTime, [TIME IN], 108), CONVERT(DateTime, '" + DateTime.Now.ToLongTimeString() + "', 108)) / 3600) - 9) where [EMPLOYEE ID] = '" + textBox1.Text + "' and [LOG DATE] = '" + lblDate.Text + "'", conn);
                                uCmd.ExecuteNonQuery();
                                uCmd.Dispose();
                            }
                            else
                            {
                                SqlCommand uCmd = new SqlCommand("update table_Attendance set [TOTAL OVERTIME HOURS] = 0 where [EMPLOYEE ID] = '" + textBox1.Text + "' and [LOG DATE] = '" + lblDate.Text + "'", conn);
                                uCmd.ExecuteNonQuery();
                                uCmd.Dispose();
                            }
                            MessageBox.Show("Time Out Success.");

                            conn.Close();
                          //  [TOTAL OVERTIME HOURS] = ((DATEDIFF(second, CONVERT(DateTime, [TIME IN], 108), CONVERT(DateTime, '" + DateTime.Now.ToLongTimeString() + "', 108)) / 3600) - 9)
                        } else //time in employee if no record shows up
                        {
                            conn = kon.getCon();
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("insert into table_Attendance([EMPLOYEE ID], [LOG DATE], [TIME IN], [AM_isLogged], [PM_isLogged], [TIME OUT]) values ('"+textBox1.Text+"', '"+lblDate.Text+"', '"+lblTime.Text+"', 'Time In', '-', '-')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Time In Success.");
                            cmd.Dispose();
                            conn.Close();
                        }
                    }
                }
                else
                {
                    
                 MessageBox.Show("EMPLOYEE ID not found!");
                    
                }
            }
            //this.table_AttendanceTableAdapter2.Fill(this.dTRDataSet3.table_Attendance);
            this.table_AttendanceTableAdapter3.Fill(this.dTRDataSet4.table_Attendance);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { // only allow numbers in text field
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
