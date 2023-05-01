namespace managent
{
    partial class frmADSalary
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPriveos = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesdbDataSet12 = new managent.EmployeesdbDataSet12();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emploeeTableAdapter = new managent.EmployeesdbDataSet12TableAdapters.emploeeTableAdapter();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYMONTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKINGDAYSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALSALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic);
            this.lblMenu.Location = new System.Drawing.Point(12, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(186, 36);
            this.lblMenu.TabIndex = 153;
            this.lblMenu.Text = "Emplyoee Salary";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(624, 196);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(78, 16);
            this.lblFullName.TabIndex = 155;
            this.lblFullName.Text = "Full Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(704, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 3);
            this.panel2.TabIndex = 157;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "ID", true));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Blue;
            this.txtId.HideSelection = false;
            this.txtId.Location = new System.Drawing.Point(705, 163);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(147, 14);
            this.txtId.TabIndex = 156;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "FULL-NAME", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.HideSelection = false;
            this.txtName.Location = new System.Drawing.Point(705, 198);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(147, 14);
            this.txtName.TabIndex = 156;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(704, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 3);
            this.panel1.TabIndex = 157;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "POSITION", true));
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.Color.Blue;
            this.txtPosition.HideSelection = false;
            this.txtPosition.Location = new System.Drawing.Point(706, 230);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(147, 14);
            this.txtPosition.TabIndex = 156;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(705, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 3);
            this.panel3.TabIndex = 157;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(706, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 3);
            this.panel4.TabIndex = 157;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.White;
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.Blue;
            this.txtSalary.HideSelection = false;
            this.txtSalary.Location = new System.Drawing.Point(708, 300);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(147, 14);
            this.txtSalary.TabIndex = 156;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(707, 314);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 3);
            this.panel5.TabIndex = 157;
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.White;
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.Color.Blue;
            this.txtDay.HideSelection = false;
            this.txtDay.Location = new System.Drawing.Point(708, 337);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(147, 14);
            this.txtDay.TabIndex = 156;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(707, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 3);
            this.panel6.TabIndex = 157;
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BackColor = System.Drawing.Color.White;
            this.txtTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalSalary.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotalSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "TOTALSALARY", true));
            this.txtTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSalary.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalSalary.HideSelection = false;
            this.txtTotalSalary.Location = new System.Drawing.Point(706, 368);
            this.txtTotalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.ReadOnly = true;
            this.txtTotalSalary.Size = new System.Drawing.Size(147, 14);
            this.txtTotalSalary.TabIndex = 156;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(705, 382);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 3);
            this.panel7.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(679, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 155;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(653, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 155;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(638, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 155;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(605, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 155;
            this.label4.Text = "Working Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(617, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 155;
            this.label5.Text = "Day Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(609, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 155;
            this.label7.Text = "Total Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(628, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 155;
            this.label6.Text = "Search Id";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Blue;
            this.txtSearch.HideSelection = false;
            this.txtSearch.Location = new System.Drawing.Point(705, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 14);
            this.txtSearch.TabIndex = 156;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(704, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(147, 3);
            this.panel8.TabIndex = 157;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(704, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 158;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(805, 404);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 30);
            this.btnNext.TabIndex = 158;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPriveos
            // 
            this.btnPriveos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.btnPriveos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPriveos.ForeColor = System.Drawing.Color.White;
            this.btnPriveos.Location = new System.Drawing.Point(604, 404);
            this.btnPriveos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriveos.Name = "btnPriveos";
            this.btnPriveos.Size = new System.Drawing.Size(83, 30);
            this.btnPriveos.TabIndex = 159;
            this.btnPriveos.Text = "Previous";
            this.btnPriveos.UseVisualStyleBackColor = false;
            this.btnPriveos.Click += new System.EventHandler(this.btnPriveos_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::managent.Properties.Resources.icons8_find_user_male_30;
            this.btnSearch.Location = new System.Drawing.Point(854, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 32);
            this.btnSearch.TabIndex = 158;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::managent.Properties.Resources.Screenshot__320_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::managent.Properties.Resources.icons8_cash_in_hand_100;
            this.pictureBox2.Location = new System.Drawing.Point(692, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 160;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fULLNAMEDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.sALARYMONTHDataGridViewTextBoxColumn,
            this.wORKINGDAYSDataGridViewTextBoxColumn,
            this.tOTALSALARYDataGridViewTextBoxColumn,
            this.daySalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emploeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(332, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 150);
            this.dataGridView1.TabIndex = 161;
            // 
            // employeesdbDataSet12
            // 
            this.employeesdbDataSet12.DataSetName = "EmployeesdbDataSet12";
            this.employeesdbDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emploeeBindingSource
            // 
            this.emploeeBindingSource.DataMember = "emploee";
            this.emploeeBindingSource.DataSource = this.employeesdbDataSet12;
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "SALARYMONTH", true));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "jan  2022",
            "Feb  2022",
            "Mar  2022",
            "Apr  2022",
            "May  2022",
            "Jun  2022",
            "Jul  2022",
            "Aug  2022",
            "Sep  2022",
            "Oct  2022",
            "Nov  2022",
            "Dec  2022"});
            this.cmbMonth.Location = new System.Drawing.Point(707, 260);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(148, 21);
            this.cmbMonth.TabIndex = 162;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fULLNAMEDataGridViewTextBoxColumn
            // 
            this.fULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULL-NAME";
            this.fULLNAMEDataGridViewTextBoxColumn.HeaderText = "FULL-NAME";
            this.fULLNAMEDataGridViewTextBoxColumn.Name = "fULLNAMEDataGridViewTextBoxColumn";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            // 
            // sALARYMONTHDataGridViewTextBoxColumn
            // 
            this.sALARYMONTHDataGridViewTextBoxColumn.DataPropertyName = "SALARYMONTH";
            this.sALARYMONTHDataGridViewTextBoxColumn.HeaderText = "SALARYMONTH";
            this.sALARYMONTHDataGridViewTextBoxColumn.Name = "sALARYMONTHDataGridViewTextBoxColumn";
            // 
            // wORKINGDAYSDataGridViewTextBoxColumn
            // 
            this.wORKINGDAYSDataGridViewTextBoxColumn.DataPropertyName = "WORKINGDAYS";
            this.wORKINGDAYSDataGridViewTextBoxColumn.HeaderText = "WORKINGDAYS";
            this.wORKINGDAYSDataGridViewTextBoxColumn.Name = "wORKINGDAYSDataGridViewTextBoxColumn";
            // 
            // tOTALSALARYDataGridViewTextBoxColumn
            // 
            this.tOTALSALARYDataGridViewTextBoxColumn.DataPropertyName = "TOTALSALARY";
            this.tOTALSALARYDataGridViewTextBoxColumn.HeaderText = "TOTALSALARY";
            this.tOTALSALARYDataGridViewTextBoxColumn.Name = "tOTALSALARYDataGridViewTextBoxColumn";
            // 
            // daySalaryDataGridViewTextBoxColumn
            // 
            this.daySalaryDataGridViewTextBoxColumn.DataPropertyName = "DaySalary";
            this.daySalaryDataGridViewTextBoxColumn.HeaderText = "DaySalary";
            this.daySalaryDataGridViewTextBoxColumn.Name = "daySalaryDataGridViewTextBoxColumn";
            // 
            // frmADSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 536);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPriveos);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmADSalary";
            this.Text = "ADSalary";
            this.Load += new System.EventHandler(this.frmADSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesdbDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPriveos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeesdbDataSet12 employeesdbDataSet12;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private EmployeesdbDataSet12TableAdapters.emploeeTableAdapter emploeeTableAdapter;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYMONTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKINGDAYSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALSALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daySalaryDataGridViewTextBoxColumn;
    }
}