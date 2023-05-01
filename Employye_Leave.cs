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
    public partial class frmEmployye_Leave : Form
    {
        public frmEmployye_Leave()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.EndEdit();
            emploeeTableAdapter.Update(employeesdbDataSet11);
            MessageBox.Show("Data has been save");
        }

        private void Employye_Leave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet11.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet11.emploee);
            // TODO: This line of code loads data into the 'employeesdbDataSet8.LeaveEmployee' table. You can move, or remove it, as needed.
            this.leaveEmployeeTableAdapter1.Fill(this.employeesdbDataSet8.LeaveEmployee);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.AddNew();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lo = new frmLogin();
            lo.Show();

            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployee_Menu lo = new frmEmployee_Menu();
            lo.Show();

            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                txtStatus.Text = dr.GetValue(8).ToString();
                txtdateStart.Text = dr.GetValue(9).ToString();
                txtdateEnd.Text = dr.GetValue(10).ToString();
            }
        }
    }
}
