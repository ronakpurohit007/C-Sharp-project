using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
 

namespace managent
{
    public partial class frmad_signUp : Form
    {
        public frmad_signUp()
        {
            InitializeComponent();
        }

        private void frmad_signUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet11.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet11.emploee);
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.EndEdit();
            emploeeTableAdapter.Update(employeesdbDataSet11);
            MessageBox.Show("Data has been save");
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin fm = new frmLogin();
            fm.Show();
            this.Hide();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpassword.Visible = true;


            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\11\Employeesdb.mdb");
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from emploee where [USERNAME] like('" + txtuser.Text + "%')";

            command.CommandText = query;
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                txtuser.Text = dr.GetValue(11).ToString();
                txtpassword.Text = dr.GetValue(12).ToString();
                
            }
            else
            {
                MessageBox.Show("No Record Fund");
            }
            connection.Close();



        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logindbBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("SerialNumber LIKE '%{0}%'", txtuser.Text);
            dataGridView1.DataSource = dv;
        }

        public DataTable dt { get; set; }
    }
}
