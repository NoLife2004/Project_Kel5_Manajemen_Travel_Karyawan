namespace Project_Kel5_Manajemen_Travel
{
    partial class UserCustomersForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.fillTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBtnSearch = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEditCreate = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.lbEdit = new System.Windows.Forms.Label();
            this.lbCreate = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.creatBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.callNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_gridData = new System.Windows.Forms.DataGridView();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namacustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nexTrip_AdventureDataSet = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSet();
            this.customerTableAdapter = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSetTableAdapters.CustomerTableAdapter();
            this.panel2.SuspendLayout();
            this.panelEditCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_AdventureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(808, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Welcome to Data Customer";
            // 
            // fillTxt
            // 
            this.fillTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillTxt.Location = new System.Drawing.Point(641, 521);
            this.fillTxt.Multiline = true;
            this.fillTxt.Name = "fillTxt";
            this.fillTxt.Size = new System.Drawing.Size(285, 29);
            this.fillTxt.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID or Name :";
            // 
            // cancelBtnSearch
            // 
            this.cancelBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.cancelBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelBtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtnSearch.Location = new System.Drawing.Point(641, 581);
            this.cancelBtnSearch.Name = "cancelBtnSearch";
            this.cancelBtnSearch.Size = new System.Drawing.Size(66, 26);
            this.cancelBtnSearch.TabIndex = 24;
            this.cancelBtnSearch.Text = "Cancel";
            this.cancelBtnSearch.UseVisualStyleBackColor = false;
            this.cancelBtnSearch.Click += new System.EventHandler(this.cancelBtnSearch_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.create.ForeColor = System.Drawing.SystemColors.Control;
            this.create.Location = new System.Drawing.Point(860, 581);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(66, 26);
            this.create.TabIndex = 22;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.change.ForeColor = System.Drawing.SystemColors.Control;
            this.change.Location = new System.Drawing.Point(716, 581);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(66, 26);
            this.change.TabIndex = 25;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = global::Project_Kel5_Manajemen_Travel.Properties.Resources.Search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.SystemColors.Control;
            this.search.Location = new System.Drawing.Point(932, 521);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(27, 29);
            this.search.TabIndex = 28;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(788, 581);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(66, 26);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Customer Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(552, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Please fill in below to search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.panelEditCreate);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.fillTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cancelBtnSearch);
            this.panel2.Controls.Add(this.create);
            this.panel2.Controls.Add(this.change);
            this.panel2.Controls.Add(this.customer_gridData);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(20, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 639);
            this.panel2.TabIndex = 14;
            // 
            // panelEditCreate
            // 
            this.panelEditCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.panelEditCreate.Controls.Add(this.lbID);
            this.panelEditCreate.Controls.Add(this.lbEdit);
            this.panelEditCreate.Controls.Add(this.lbCreate);
            this.panelEditCreate.Controls.Add(this.cancelBtn);
            this.panelEditCreate.Controls.Add(this.updateBtn);
            this.panelEditCreate.Controls.Add(this.creatBtn);
            this.panelEditCreate.Controls.Add(this.name);
            this.panelEditCreate.Controls.Add(this.address);
            this.panelEditCreate.Controls.Add(this.callNum);
            this.panelEditCreate.Controls.Add(this.label5);
            this.panelEditCreate.Controls.Add(this.label3);
            this.panelEditCreate.Controls.Add(this.cbxGender);
            this.panelEditCreate.Controls.Add(this.label2);
            this.panelEditCreate.Controls.Add(this.label1);
            this.panelEditCreate.Location = new System.Drawing.Point(56, 273);
            this.panelEditCreate.Name = "panelEditCreate";
            this.panelEditCreate.Size = new System.Drawing.Size(909, 344);
            this.panelEditCreate.TabIndex = 0;
            this.panelEditCreate.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(585, 260);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(12, 17);
            this.lbID.TabIndex = 30;
            this.lbID.Text = " ";
            this.lbID.Visible = false;
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdit.Location = new System.Drawing.Point(57, 55);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(191, 25);
            this.lbEdit.TabIndex = 31;
            this.lbEdit.Text = "Edit Customers Data";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(57, 55);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(214, 25);
            this.lbCreate.TabIndex = 30;
            this.lbCreate.Text = "Create Customers Data";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Location = new System.Drawing.Point(612, 258);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 32);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateBtn.Location = new System.Drawing.Point(722, 258);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 32);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // creatBtn
            // 
            this.creatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.creatBtn.FlatAppearance.BorderSize = 0;
            this.creatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.creatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.creatBtn.Location = new System.Drawing.Point(722, 257);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(89, 32);
            this.creatBtn.TabIndex = 12;
            this.creatBtn.Text = "Create";
            this.creatBtn.UseVisualStyleBackColor = false;
            this.creatBtn.Click += new System.EventHandler(this.creatBtn_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(223, 114);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 20);
            this.name.TabIndex = 6;
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Location = new System.Drawing.Point(223, 164);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(218, 36);
            this.address.TabIndex = 7;
            // 
            // callNum
            // 
            this.callNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.callNum.Location = new System.Drawing.Point(593, 165);
            this.callNum.Name = "callNum";
            this.callNum.Size = new System.Drawing.Size(218, 20);
            this.callNum.TabIndex = 10;
            this.callNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.callNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Call Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // cbxGender
            // 
            this.cbxGender.DisplayMember = "id_role";
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(593, 114);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(218, 21);
            this.cbxGender.TabIndex = 9;
            this.cbxGender.ValueMember = "id_role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // customer_gridData
            // 
            this.customer_gridData.AllowUserToAddRows = false;
            this.customer_gridData.AllowUserToDeleteRows = false;
            this.customer_gridData.AllowUserToResizeColumns = false;
            this.customer_gridData.AllowUserToResizeRows = false;
            this.customer_gridData.AutoGenerateColumns = false;
            this.customer_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customer_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customer_gridData.ColumnHeadersHeight = 30;
            this.customer_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customer_gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcustomerDataGridViewTextBoxColumn,
            this.namacustomerDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn});
            this.customer_gridData.DataSource = this.customerBindingSource;
            this.customer_gridData.EnableHeadersVisualStyles = false;
            this.customer_gridData.Location = new System.Drawing.Point(56, 71);
            this.customer_gridData.Name = "customer_gridData";
            this.customer_gridData.ReadOnly = true;
            this.customer_gridData.RowHeadersVisible = false;
            this.customer_gridData.RowHeadersWidth = 20;
            this.customer_gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customer_gridData.Size = new System.Drawing.Size(908, 402);
            this.customer_gridData.TabIndex = 0;
            this.customer_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_gridData_CellContentClick);
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "Customers ID";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            this.idcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcustomerDataGridViewTextBoxColumn.Width = 145;
            // 
            // namacustomerDataGridViewTextBoxColumn
            // 
            this.namacustomerDataGridViewTextBoxColumn.DataPropertyName = "nama_customer";
            this.namacustomerDataGridViewTextBoxColumn.HeaderText = "Name";
            this.namacustomerDataGridViewTextBoxColumn.Name = "namacustomerDataGridViewTextBoxColumn";
            this.namacustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.namacustomerDataGridViewTextBoxColumn.Width = 213;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 160;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Address";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            this.alamatDataGridViewTextBoxColumn.Width = 225;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "Call Number";
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.ReadOnly = true;
            this.notelpDataGridViewTextBoxColumn.Width = 160;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.nexTrip_AdventureDataSet;
            // 
            // nexTrip_AdventureDataSet
            // 
            this.nexTrip_AdventureDataSet.DataSetName = "NexTrip_AdventureDataSet";
            this.nexTrip_AdventureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // UserCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.panel2);
            this.Name = "UserCustomersForm";
            this.Size = new System.Drawing.Size(1060, 688);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEditCreate.ResumeLayout(false);
            this.panelEditCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_AdventureDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fillTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelBtnSearch;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEditCreate;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox callNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customer_gridData;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private NexTrip_AdventureDataSet nexTrip_AdventureDataSet;
        private NexTrip_AdventureDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namacustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
    }
}
