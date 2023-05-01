namespace managent
{
    partial class frmForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPriveos = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtBOB = new System.Windows.Forms.DateTimePicker();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesdbDataSet1 = new managent.EmployeesdbDataSet1();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbQualifition = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUALIFICATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emploeeTableAdapter = new managent.EmployeesdbDataSet1TableAdapters.emploeeTableAdapter();
            this.cmdsex = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.employeesdbDataSet10 = new managent.EmployeesdbDataSet10();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.emploeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesdbDataSet11 = new managent.EmployeesdbDataSet11();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.emploeeTableAdapter1 = new managent.EmployeesdbDataSet11TableAdapters.emploeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPriveos
            // 
            this.btnPriveos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnPriveos, "btnPriveos");
            this.btnPriveos.ForeColor = System.Drawing.Color.White;
            this.btnPriveos.Name = "btnPriveos";
            this.btnPriveos.UseVisualStyleBackColor = false;
            this.btnPriveos.Click += new System.EventHandler(this.btnPriveos_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtBOB
            // 
            this.dtBOB.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtBOB.CalendarMonthBackground = System.Drawing.Color.Aqua;
            this.dtBOB.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtBOB.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dtBOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "DOB", true));
            resources.ApplyResources(this.dtBOB, "dtBOB");
            this.dtBOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBOB.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dtBOB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtBOB.Name = "dtBOB";
            this.dtBOB.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // emploeeBindingSource
            // 
            this.emploeeBindingSource.DataMember = "emploee";
            this.emploeeBindingSource.DataSource = this.employeesdbDataSet1;
            // 
            // employeesdbDataSet1
            // 
            this.employeesdbDataSet1.DataSetName = "EmployeesdbDataSet1";
            this.employeesdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "POSITION", true));
            resources.ApplyResources(this.cmbPosition, "cmbPosition");
            this.cmbPosition.ForeColor = System.Drawing.Color.Blue;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            resources.GetString("cmbPosition.Items"),
            resources.GetString("cmbPosition.Items1"),
            resources.GetString("cmbPosition.Items2"),
            resources.GetString("cmbPosition.Items3"),
            resources.GetString("cmbPosition.Items4"),
            resources.GetString("cmbPosition.Items5"),
            resources.GetString("cmbPosition.Items6"),
            resources.GetString("cmbPosition.Items7"),
            resources.GetString("cmbPosition.Items8")});
            this.cmbPosition.Name = "cmbPosition";
            // 
            // cmbQualifition
            // 
            this.cmbQualifition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "QUALIFICATION", true));
            resources.ApplyResources(this.cmbQualifition, "cmbQualifition");
            this.cmbQualifition.ForeColor = System.Drawing.Color.Blue;
            this.cmbQualifition.FormattingEnabled = true;
            this.cmbQualifition.Items.AddRange(new object[] {
            resources.GetString("cmbQualifition.Items"),
            resources.GetString("cmbQualifition.Items1"),
            resources.GetString("cmbQualifition.Items2"),
            resources.GetString("cmbQualifition.Items3"),
            resources.GetString("cmbQualifition.Items4"),
            resources.GetString("cmbQualifition.Items5"),
            resources.GetString("cmbQualifition.Items6"),
            resources.GetString("cmbQualifition.Items7")});
            this.cmbQualifition.Name = "cmbQualifition";
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "NUMBER", true));
            resources.ApplyResources(this.txtNumber, "txtNumber");
            this.txtNumber.ForeColor = System.Drawing.Color.Blue;
            this.txtNumber.Name = "txtNumber";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "ADDRESS", true));
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.ForeColor = System.Drawing.Color.Blue;
            this.txtAddress.Name = "txtAddress";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "FULL-NAME", true));
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.ForeColor = System.Drawing.Color.Blue;
            this.txtFullName.Name = "txtFullName";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "ID", true));
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.ForeColor = System.Drawing.Color.Blue;
            this.txtId.Name = "txtId";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.Name = "lblPosition";
            // 
            // lblSex
            // 
            resources.ApplyResources(this.lblSex, "lblSex");
            this.lblSex.Name = "lblSex";
            // 
            // lblNumber
            // 
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.Name = "lblNumber";
            // 
            // lblQualification
            // 
            resources.ApplyResources(this.lblQualification, "lblQualification");
            this.lblQualification.Name = "lblQualification";
            // 
            // lblAddress
            // 
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.Name = "lblAddress";
            // 
            // lblDOB
            // 
            resources.ApplyResources(this.lblDOB, "lblDOB");
            this.lblDOB.Name = "lblDOB";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // lblFullName
            // 
            resources.ApplyResources(this.lblFullName, "lblFullName");
            this.lblFullName.Name = "lblFullName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fULLNAMEDataGridViewTextBoxColumn,
            this.qUALIFICATIONDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.nUMBERDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.sEXDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emploeeBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fULLNAMEDataGridViewTextBoxColumn
            // 
            this.fULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULL-NAME";
            resources.ApplyResources(this.fULLNAMEDataGridViewTextBoxColumn, "fULLNAMEDataGridViewTextBoxColumn");
            this.fULLNAMEDataGridViewTextBoxColumn.Name = "fULLNAMEDataGridViewTextBoxColumn";
            // 
            // qUALIFICATIONDataGridViewTextBoxColumn
            // 
            this.qUALIFICATIONDataGridViewTextBoxColumn.DataPropertyName = "QUALIFICATION";
            resources.ApplyResources(this.qUALIFICATIONDataGridViewTextBoxColumn, "qUALIFICATIONDataGridViewTextBoxColumn");
            this.qUALIFICATIONDataGridViewTextBoxColumn.Name = "qUALIFICATIONDataGridViewTextBoxColumn";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            resources.ApplyResources(this.pOSITIONDataGridViewTextBoxColumn, "pOSITIONDataGridViewTextBoxColumn");
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            // 
            // nUMBERDataGridViewTextBoxColumn
            // 
            this.nUMBERDataGridViewTextBoxColumn.DataPropertyName = "NUMBER";
            resources.ApplyResources(this.nUMBERDataGridViewTextBoxColumn, "nUMBERDataGridViewTextBoxColumn");
            this.nUMBERDataGridViewTextBoxColumn.Name = "nUMBERDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            resources.ApplyResources(this.dOBDataGridViewTextBoxColumn, "dOBDataGridViewTextBoxColumn");
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // sEXDataGridViewTextBoxColumn
            // 
            this.sEXDataGridViewTextBoxColumn.DataPropertyName = "SEX";
            resources.ApplyResources(this.sEXDataGridViewTextBoxColumn, "sEXDataGridViewTextBoxColumn");
            this.sEXDataGridViewTextBoxColumn.Name = "sEXDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            resources.ApplyResources(this.aDDRESSDataGridViewTextBoxColumn, "aDDRESSDataGridViewTextBoxColumn");
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // cmdsex
            // 
            this.cmdsex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "SEX", true));
            resources.ApplyResources(this.cmdsex, "cmdsex");
            this.cmdsex.ForeColor = System.Drawing.Color.Blue;
            this.cmdsex.FormattingEnabled = true;
            this.cmdsex.Items.AddRange(new object[] {
            resources.GetString("cmdsex.Items"),
            resources.GetString("cmdsex.Items1")});
            this.cmdsex.Name = "cmdsex";
            // 
            // lblMenu
            // 
            resources.ApplyResources(this.lblMenu, "lblMenu");
            this.lblMenu.Name = "lblMenu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // employeesdbDataSet10
            // 
            this.employeesdbDataSet10.DataSetName = "EmployeesdbDataSet10";
            this.employeesdbDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::managent.Properties.Resources.icons8_admin_settings_male_961;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::managent.Properties.Resources.pngegg_4_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource1, "PASSWORD", true));
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Name = "txtPassword";
            // 
            // emploeeBindingSource1
            // 
            this.emploeeBindingSource1.DataMember = "emploee";
            this.emploeeBindingSource1.DataSource = this.employeesdbDataSet11;
            // 
            // employeesdbDataSet11
            // 
            this.employeesdbDataSet11.DataSetName = "EmployeesdbDataSet11";
            this.employeesdbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource1, "USERNAME", true));
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.ForeColor = System.Drawing.Color.Blue;
            this.txtUser.HideSelection = false;
            this.txtUser.Name = "txtUser";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.Name = "UserName";
            // 
            // emploeeTableAdapter1
            // 
            this.emploeeTableAdapter1.ClearBeforeFill = true;
            // 
            // frmForm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPriveos);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtBOB);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.cmdsex);
            this.Controls.Add(this.cmbQualifition);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForm1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPriveos;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtBOB;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbQualifition;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeesdbDataSet1 employeesdbDataSet1;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private EmployeesdbDataSet1TableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUALIFICATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmdsex;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private EmployeesdbDataSet10 employeesdbDataSet10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserName;
        private EmployeesdbDataSet11 employeesdbDataSet11;
        private System.Windows.Forms.BindingSource emploeeBindingSource1;
        private EmployeesdbDataSet11TableAdapters.emploeeTableAdapter emploeeTableAdapter1;
    }
}

