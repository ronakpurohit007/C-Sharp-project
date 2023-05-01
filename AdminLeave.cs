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
    public partial class frmAdminLeave : Form
    {
        public frmAdminLeave()
        {
            InitializeComponent();
        }

        private void frmAdminLeave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet11.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet11.emploee);
           
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.EndEdit();
            emploeeTableAdapter.Update(employeesdbDataSet11);
            MessageBox.Show("Data has been save");
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
            frmad_menu lo = new frmad_menu();
            lo.Show();

            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MoveNext();
        }

        private void btnPriveos_Click(object sender, EventArgs e)
        {
            emploeeBindingSource.MovePrevious();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
