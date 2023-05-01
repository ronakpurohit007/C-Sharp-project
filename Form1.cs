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
    public partial class frmForm1 : Form
    {
        public frmForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet11.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter1.Fill(this.employeesdbDataSet11.emploee);
            
            // TODO: This line of code loads data into the 'employeesdbDataSet1.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet1.emploee);

        }
        OleDbDataReader dr;
        private void btnSave_Click(object sender, EventArgs e)

        {
            emploeeBindingSource.EndEdit();
            emploeeTableAdapter.Update(employeesdbDataSet1);

            emploeeBindingSource1.EndEdit();
            emploeeTableAdapter1.Update(employeesdbDataSet11);
            MessageBox.Show("Data has been save");

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.AddNew();
            emploeeBindingSource1.AddNew();
           
        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MoveNext();
            emploeeBindingSource1.MoveNext();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.RemoveCurrent();
            emploeeBindingSource1.RemoveCurrent();
        }

        private void btnPriveos_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MovePrevious();
            emploeeBindingSource1.MovePrevious();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }
        

       
    }
}
