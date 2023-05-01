using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace managent
{
    public partial class frmLogin : Form
    {
        public frmLogin()

        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            


            frmEmployee_Data f3 = new frmEmployee_Data(label2.Text);

            string usr = txtuser.Text;
            string psw = txtpassword.Text;
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\11\Employeesdb.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM emploee where USERNAME='" + txtuser.Text + "' AND PASSWORD='" + txtpassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmEmployee_Menu f2 = new frmEmployee_Menu();
                f2.Show();
                this.Hide();


               
                
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
                
            }

            con.Close();
        
        }

        public OleDbConnection con { get; set; }

        public OleDbCommand cmd { get; set; }

        public OleDbDataReader dr { get; set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmad_signUp fm = new frmad_signUp();
            fm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin fm = new frmAdminLogin();
            fm.Show();
            this.Hide();
        }
        
    }
}
