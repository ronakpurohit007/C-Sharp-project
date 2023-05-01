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
    public partial class frmEmployee_Data : Form
    {
        public frmEmployee_Data(string value)
        {
            InitializeComponent();

        }

        private void frmEmployee_Data_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("SerialNumber LIKE '%{0}%'", txtuser.Text);
            dataGridView1.DataSource = dv;
        }

        public DataTable dt { get; set; }

        private void txtuser_Enter(object sender, EventArgs e)
        {

        }

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
                txtid.Text = dr.GetValue(0).ToString();
                txtFullName.Text = dr.GetValue(1).ToString();
                txtQualification.Text = dr.GetValue(2).ToString();
                txtPosition.Text = dr.GetValue(3).ToString();
                txtNumber.Text = dr.GetValue(4).ToString();
                txtDOB.Text = dr.GetValue(5).ToString();
                txtsex.Text = dr.GetValue(6).ToString();

                txtAddress.Text = dr.GetValue(7).ToString();
            }

        }

        private void txtuser_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    

