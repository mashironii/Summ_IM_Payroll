using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummOOP
{
    public partial class DTR_HOME : Form
    {
        Konek kon = new Konek();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rd;
        public DTR_HOME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegNewEmpbBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegEmpForm reg = new RegEmpForm();
            reg.ShowDialog();
            this.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeInOutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimeInOutForm frm = new TimeInOutForm();
            frm.ShowDialog();
            this.Show();
        }

        private void SearchEmpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogIn adLog = new AdminLogIn();
            adLog.ShowDialog();
            this.Show();
            
        }
    }
}
