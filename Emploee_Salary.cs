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
    public partial class frmEmploee_Salary : Form
    {
        public frmEmploee_Salary()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployee_Menu ma = new frmEmployee_Menu();
            ma.Show();
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lo = new frmLogin();
            lo.Show();
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("SerialNumber LIKE '%{0}%'", txtuser.Text);
            dataGridView1.DataSource = dv;
        }

        public DataTable dt { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\11\Employeesdb.mdb");
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from emploee where [FULL-NAME] like('" + txtuser.Text + "%')";

            command.CommandText = query;
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {

                txtName.Text = dr.GetValue(1).ToString();
                txtPosition.Text = dr.GetValue(3).ToString();
                txtMonth.Text = dr.GetValue(13).ToString();
                //textBox1.Text = dr.GetValue(16).ToString();
                //txtDay.Text = dr.GetValue(14).ToString();
                txtTotalSalary.Text = dr.GetValue(15).ToString();
                
                
            }
        }

        private void frmEmploee_Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet12.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet12.emploee);

        }
    }
}
