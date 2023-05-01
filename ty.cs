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
    public partial class frmTY : Form
    {
        public static frmTY instance;
        public frmTY()
        {
           
            InitializeComponent();
            instance = this;

        }

        private void ty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesdbDataSet10.emploee' table. You can move, or remove it, as needed.
            this.emploeeTableAdapter.Fill(this.employeesdbDataSet10.emploee);
           

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
          
        
     
        }
    
        public object ID { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            
        }

        public OleDbConnection con { get; set; }

        public OleDbCommand cmd { get; set; }

        public OleDbDataReader dr { get; set; }

        private void txtday_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
