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
    public partial class frmEmployeeList : Form
    {

        public frmEmployeeList()
        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;
            InitializeComponent();
            myCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\11\Employeesdb.mdb");
        
        

        
        }

       

        

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
           
            

            // TODO: This line of code loads data into the 'employeesdbDataSet2.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet2.emploee);


            this.emploeeTableAdapter.Fill(this.employeesdbDataSet2.emploee);
            
        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lo = new frmLogin();
            lo.Show();

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmad_menu lo = new frmad_menu();
            lo.Show();

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lo = new frmLogin();
            lo.Show();

            this.Close();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\11\Employeesdb.mdb");
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from emploee where [ID] like('" + txtSearch.Text + "%')";

            command.CommandText = query;
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                txtFullName.Text = dr.GetValue(1).ToString();
                textBox3.Text = dr.GetValue(2).ToString();
                txtPosition.Text = dr.GetValue(3).ToString();
                txtNumber.Text = dr.GetValue(4).ToString();
                textBox2.Text = dr.GetValue(5).ToString();
                textBox5.Text = dr.GetValue(6).ToString();
                txtAddress.Text = dr.GetValue(7).ToString();
            }
            else 
            {
                MessageBox.Show("No Record Fund");
            }
            connection.Close();
          
        
        }


        public OleDbConnection myCon { get; set; }

       


        private void btnNext_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MoveNext();
        }

        private void btnPriveos_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MovePrevious();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("SerialNumber LIKE '%{0}%'", textBox1.Text);
            dataGridView2.DataSource = dv;
        }

        public DataTable dt { get; set; }
    }

        
    
}
