namespace managent
{
    partial class frmad_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.btnEmployeesalary = new System.Windows.Forms.Button();
            this.btnEmployeeleave = new System.Windows.Forms.Button();
            this.btnemploeelist = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogout.Location = new System.Drawing.Point(494, 471);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(93, 29);
            this.linkLogout.TabIndex = 11;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // btnEmployeesalary
            // 
            this.btnEmployeesalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnEmployeesalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeesalary.Location = new System.Drawing.Point(642, 296);
            this.btnEmployeesalary.Name = "btnEmployeesalary";
            this.btnEmployeesalary.Size = new System.Drawing.Size(279, 88);
            this.btnEmployeesalary.TabIndex = 10;
            this.btnEmployeesalary.Text = "Employee salary";
            this.btnEmployeesalary.UseVisualStyleBackColor = false;
            this.btnEmployeesalary.Click += new System.EventHandler(this.btnEmployeesalary_Click);
            // 
            // btnEmployeeleave
            // 
            this.btnEmployeeleave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnEmployeeleave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeleave.Location = new System.Drawing.Point(137, 296);
            this.btnEmployeeleave.Name = "btnEmployeeleave";
            this.btnEmployeeleave.Size = new System.Drawing.Size(279, 88);
            this.btnEmployeeleave.TabIndex = 9;
            this.btnEmployeeleave.Text = "Employee Leave";
            this.btnEmployeeleave.UseVisualStyleBackColor = false;
            this.btnEmployeeleave.Click += new System.EventHandler(this.btnEmployeeleave_Click);
            // 
            // btnemploeelist
            // 
            this.btnemploeelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnemploeelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemploeelist.Location = new System.Drawing.Point(642, 151);
            this.btnemploeelist.Name = "btnemploeelist";
            this.btnemploeelist.Size = new System.Drawing.Size(279, 88);
            this.btnemploeelist.TabIndex = 8;
            this.btnemploeelist.Text = "Emplyoee List";
            this.btnemploeelist.UseVisualStyleBackColor = false;
            this.btnemploeelist.Click += new System.EventHandler(this.btnemploeelist_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(137, 151);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(279, 88);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Emplyoee Management";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(329, 14);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(419, 57);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Emplyoee Management";
            // 
            // frmad_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1059, 514);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnEmployeesalary);
            this.Controls.Add(this.btnEmployeeleave);
            this.Controls.Add(this.btnemploeelist);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.lblMenu);
            this.Name = "frmad_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ad_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Button btnEmployeesalary;
        private System.Windows.Forms.Button btnEmployeeleave;
        private System.Windows.Forms.Button btnemploeelist;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label lblMenu;
    }
}