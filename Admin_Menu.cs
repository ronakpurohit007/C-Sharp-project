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
    public partial class frmAdmin_Menu : Form
    {
        public frmAdmin_Menu()
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
            loadform(new frmForm1());

           

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // side panel
            SidePanel.Visible = true;
            SidePanel1.Visible = true;

            //Pic
            PicPanel.Visible = false;


            SidePanel.Height = btnSearch.Height;
            SidePanel.Top = btnSearch.Top;

            // toggle panel
            if 
               ( MainPanel.Visible = true);
            else
                MainPanel.Visible = false;
            loadform(new frmEmployeeList());
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            // side panel
            SidePanel.Visible = true;
            SidePanel1.Visible = true;


            //Pic
            PicPanel.Visible = false;

            SidePanel.Height = btnLeave.Height;
            SidePanel.Top = btnLeave.Top;

            // toggle panel
            if 
               ( MainPanel.Visible = true);
            else
                MainPanel.Visible = false;
            loadform(new frmAdminLeave());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            // side panel
            SidePanel.Visible = true;
            SidePanel1.Visible = true;
            

            SidePanel.Height = btnSalary.Height;
            SidePanel.Top = btnSalary.Top;


            //Pic
            PicPanel.Visible = false;


            // toggle panel
            if 
               ( MainPanel.Visible = true);
            else
                MainPanel.Visible = false;
            loadform(new frmADSalary());
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
