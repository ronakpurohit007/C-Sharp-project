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
    public partial class frmADSalary : Form
    {
        public frmADSalary()
        {
            InitializeComponent();
        }

        private void frmADSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet12.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet12.emploee);

        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                txtId.Text = dr.GetValue(0).ToString();
                txtName.Text = dr.GetValue(1).ToString();
                txtPosition.Text = dr.GetValue(3).ToString();
                cmbMonth.Text = dr.GetValue(13).ToString();
                txtDay.Text = dr.GetValue(16).ToString();
                txtSalary.Text = dr.GetValue(14).ToString();
                txtTotalSalary.Text = dr.GetValue(15).ToString();
                
               
                
            }
            else
            {
                MessageBox.Show("No Record Fund");
            }
            connection.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("SerialNumber LIKE '%{0}%'", txtId.Text);
            dataGridView1.DataSource = dv;
        }

        public DataTable dt { get; set; }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            txtTotalSalary.Text = (Convert.ToInt32(txtSalary.Text) * Convert.ToInt32(txtDay.Text)).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.EndEdit();
            emploeeTableAdapter.Update(employeesdbDataSet12);
            MessageBox.Show("Data has been save");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MoveNext();
        }

        private void btnPriveos_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MovePrevious();
        }
    }
}
