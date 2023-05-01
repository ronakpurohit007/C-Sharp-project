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
    public partial class frmad_menu : Form
    {
        public frmad_menu()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmForm1 fm = new frmForm1();
            fm.Show();
            this.Close();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLogin lo = new frmLogin();
            lo.Show();

            this.Close();
        }

        private void btnemploeelist_Click(object sender, EventArgs e)
        {
            frmEmployeeList fm = new frmEmployeeList();
            fm.Show();
            this.Close();
        }

        private void btnEmployeeleave_Click(object sender, EventArgs e)
        {
            frmAdminLeave ad = new frmAdminLeave();
            ad.Show();
            this.Close();
        }

        private void btnEmployeesalary_Click(object sender, EventArgs e)
        {
            frmADSalary sr = new frmADSalary();
            sr.Show();

            this.Close();
        }
    }
}
