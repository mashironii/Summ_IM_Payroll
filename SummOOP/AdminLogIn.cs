using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummOOP
{
    public partial class AdminLogIn : Form
    {
        String UserTrue = "admin", PassTrue = "1234";
        
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
                        
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegNewEmpbBTN_Click(object sender, EventArgs e)
        {
            String UserInput, PassInput;
            UserInput = userBox.Text;
            PassInput = passBox.Text;
            //check if user input is same as set login credentials
            if (UserInput == UserTrue && PassInput == PassTrue)
            {
                this.Close();
                SearchEmp ad = new SearchEmp();
                ad.ShowDialog();
            } else
            {
                MessageBox.Show("Incorrect Username or Password!");
                //reset textfields after incorrect input
                userBox.Text = "";
                passBox.Text = "";
            }
        }
    }
}
