using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace managent
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet4.AdminLogin' table. You can move, or remove it, as needed.
            this.adminLoginTableAdapter.Fill(this.employeesdbDataSet4.AdminLogin);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string username = txtuser.Text;  
            string password = txtpassword.Text;

            if ((this.txtuser.Text == "admin") && (this.txtpassword.Text == "admin"))
            {

                MessageBox.Show("Wel-Come");


                frmAdmin_Menu fm = new frmAdmin_Menu();
                fm.Show();
                this.Close();
            }
           
            else
            {
                
                MessageBox.Show("User Name and Password Incorrect");
            }

          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
