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
    public partial class frmEmployee_Menu : Form
    {
        public frmEmployee_Menu()
        {
            InitializeComponent();
            SidePanel.Height = btnEmployee.Height;
        }

        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }
        private void btnEmployeeleave_Click(object sender, EventArgs e)
        {// side panel
            SidePanel.Visible = true;
            SidePanel1.Visible = true;

            //Pic
            PicPanel.Visible = false;


            SidePanel.Height = btnEmployeeleave.Height;
            SidePanel.Top = btnEmployeeleave.Top;

            // toggle panel
            if
               (MainPanel.Visible = true) ;
            else
                MainPanel.Visible = false;
            loadform(new frmEmployye_Leave());

        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lo = new frmLogin();
            lo.Show();

            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            // side panel
            SidePanel.Visible = true;


            //Pic
            if (PicPanel.Visible == false)
                PicPanel.Visible = true;
            else
                PicPanel.Visible = false;


            // Menu panel
            if (SidePanel1.Visible == true)
                SidePanel1.Visible = false;
            else
                SidePanel1.Visible = true;

            SidePanel.Height = btnEmployee.Height;
            SidePanel.Top = btnEmployee.Top;

            // toggle panel
            if (MainPanel.Visible == true)
                MainPanel.Visible = false;
            else
                MainPanel.Visible = true; ;
            loadform(new frmEmployee_Data(label2.Text));



         
        }

        private void btnEmployeesalary_Click(object sender, EventArgs e)
        {
            // side panel
            SidePanel.Visible = true;
            SidePanel1.Visible = true;

            //Pic
            PicPanel.Visible = false;


            SidePanel.Height = btnEmployeesalary.Height;
            SidePanel.Top = btnEmployeesalary.Top;

            // toggle panel
            if
               (MainPanel.Visible = true) ;
            else
                MainPanel.Visible = false;
            loadform(new frmEmploee_Salary());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEmployee_Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin fr = new frmLogin();
            fr.Show();
            this.Close();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
    }
}
