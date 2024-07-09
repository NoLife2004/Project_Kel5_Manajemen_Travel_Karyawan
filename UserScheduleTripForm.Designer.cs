namespace Project_Kel5_Manajemen_Travel
{
    partial class UserScheduleTripForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.panelEditCreate = new System.Windows.Forms.Panel();
            this.lbEdit = new System.Windows.Forms.Label();
            this.lbCreate = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.creatBtn = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.fillTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBtnSearch = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.employee_gridData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.nexTrip_AdventureDataSet = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSet();
            this.jadwalTripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwal_TripTableAdapter = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSetTableAdapters.Jadwal_TripTableAdapter();
            this.idjadwalTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalberangkatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuberangkatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalpulangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktupulangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusjadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIdStaff = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panelEditCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_AdventureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalTripBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.panelEditCreate);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.fillTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cancelBtnSearch);
            this.panel2.Controls.Add(this.create);
            this.panel2.Controls.Add(this.change);
            this.panel2.Controls.Add(this.employee_gridData);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(20, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 639);
            this.panel2.TabIndex = 14;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(984, 456);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(12, 17);
            this.lbID.TabIndex = 30;
            this.lbID.Text = " ";
            // 
            // panelEditCreate
            // 
            this.panelEditCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.panelEditCreate.Controls.Add(this.cbIdStaff);
            this.panelEditCreate.Controls.Add(this.lbEdit);
            this.panelEditCreate.Controls.Add(this.lbCreate);
            this.panelEditCreate.Controls.Add(this.cancelBtn);
            this.panelEditCreate.Controls.Add(this.updateBtn);
            this.panelEditCreate.Controls.Add(this.creatBtn);
            this.panelEditCreate.Controls.Add(this.email);
            this.panelEditCreate.Controls.Add(this.password);
            this.panelEditCreate.Controls.Add(this.label6);
            this.panelEditCreate.Controls.Add(this.username);
            this.panelEditCreate.Controls.Add(this.label5);
            this.panelEditCreate.Controls.Add(this.phone);
            this.panelEditCreate.Controls.Add(this.label4);
            this.panelEditCreate.Controls.Add(this.label3);
            this.panelEditCreate.Controls.Add(this.cbxRole);
            this.panelEditCreate.Controls.Add(this.label2);
            this.panelEditCreate.Controls.Add(this.label1);
            this.panelEditCreate.Location = new System.Drawing.Point(56, 273);
            this.panelEditCreate.Name = "panelEditCreate";
            this.panelEditCreate.Size = new System.Drawing.Size(909, 344);
            this.panelEditCreate.TabIndex = 0;
            this.panelEditCreate.Visible = false;
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdit.Location = new System.Drawing.Point(57, 55);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(171, 25);
            this.lbEdit.TabIndex = 31;
            this.lbEdit.Text = "Edit Schedule Trip";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(57, 55);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(194, 25);
            this.lbCreate.TabIndex = 30;
            this.lbCreate.Text = "Create Schedule Trip";
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
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(223, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(218, 20);
            this.email.TabIndex = 7;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(593, 215);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 20);
            this.password.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password :";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(593, 165);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 20);
            this.username.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username :";
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Location = new System.Drawing.Point(223, 214);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(218, 20);
            this.phone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(593, 114);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(218, 21);
            this.cbxRole.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Role :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Staff :";
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
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(820, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Welcome to Schedule Trip\r\n";
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
            // 
            // employee_gridData
            // 
            this.employee_gridData.AllowUserToAddRows = false;
            this.employee_gridData.AllowUserToDeleteRows = false;
            this.employee_gridData.AllowUserToResizeColumns = false;
            this.employee_gridData.AllowUserToResizeRows = false;
            this.employee_gridData.AutoGenerateColumns = false;
            this.employee_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employee_gridData.ColumnHeadersHeight = 30;
            this.employee_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.employee_gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjadwalTripDataGridViewTextBoxColumn,
            this.idstaffDataGridViewTextBoxColumn,
            this.idpaketDataGridViewTextBoxColumn,
            this.idunitDataGridViewTextBoxColumn,
            this.tanggalberangkatDataGridViewTextBoxColumn,
            this.waktuberangkatDataGridViewTextBoxColumn,
            this.tanggalpulangDataGridViewTextBoxColumn,
            this.waktupulangDataGridViewTextBoxColumn,
            this.statusjadwalDataGridViewTextBoxColumn,
            this.kapasitasDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.employee_gridData.DataSource = this.jadwalTripBindingSource;
            this.employee_gridData.EnableHeadersVisualStyles = false;
            this.employee_gridData.Location = new System.Drawing.Point(56, 71);
            this.employee_gridData.Name = "employee_gridData";
            this.employee_gridData.ReadOnly = true;
            this.employee_gridData.RowHeadersVisible = false;
            this.employee_gridData.RowHeadersWidth = 20;
            this.employee_gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employee_gridData.Size = new System.Drawing.Size(908, 402);
            this.employee_gridData.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Schedule Trip";
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
            // 
            // nexTrip_AdventureDataSet
            // 
            this.nexTrip_AdventureDataSet.DataSetName = "NexTrip_AdventureDataSet";
            this.nexTrip_AdventureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalTripBindingSource
            // 
            this.jadwalTripBindingSource.DataMember = "Jadwal_Trip";
            this.jadwalTripBindingSource.DataSource = this.nexTrip_AdventureDataSet;
            // 
            // jadwal_TripTableAdapter
            // 
            this.jadwal_TripTableAdapter.ClearBeforeFill = true;
            // 
            // idjadwalTripDataGridViewTextBoxColumn
            // 
            this.idjadwalTripDataGridViewTextBoxColumn.DataPropertyName = "id_jadwalTrip";
            this.idjadwalTripDataGridViewTextBoxColumn.HeaderText = "id_jadwalTrip";
            this.idjadwalTripDataGridViewTextBoxColumn.Name = "idjadwalTripDataGridViewTextBoxColumn";
            this.idjadwalTripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idstaffDataGridViewTextBoxColumn
            // 
            this.idstaffDataGridViewTextBoxColumn.DataPropertyName = "id_staff";
            this.idstaffDataGridViewTextBoxColumn.HeaderText = "id_staff";
            this.idstaffDataGridViewTextBoxColumn.Name = "idstaffDataGridViewTextBoxColumn";
            this.idstaffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpaketDataGridViewTextBoxColumn
            // 
            this.idpaketDataGridViewTextBoxColumn.DataPropertyName = "id_paket";
            this.idpaketDataGridViewTextBoxColumn.HeaderText = "id_paket";
            this.idpaketDataGridViewTextBoxColumn.Name = "idpaketDataGridViewTextBoxColumn";
            this.idpaketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idunitDataGridViewTextBoxColumn
            // 
            this.idunitDataGridViewTextBoxColumn.DataPropertyName = "id_unit";
            this.idunitDataGridViewTextBoxColumn.HeaderText = "id_unit";
            this.idunitDataGridViewTextBoxColumn.Name = "idunitDataGridViewTextBoxColumn";
            this.idunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalberangkatDataGridViewTextBoxColumn
            // 
            this.tanggalberangkatDataGridViewTextBoxColumn.DataPropertyName = "tanggal_berangkat";
            this.tanggalberangkatDataGridViewTextBoxColumn.HeaderText = "tanggal_berangkat";
            this.tanggalberangkatDataGridViewTextBoxColumn.Name = "tanggalberangkatDataGridViewTextBoxColumn";
            this.tanggalberangkatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waktuberangkatDataGridViewTextBoxColumn
            // 
            this.waktuberangkatDataGridViewTextBoxColumn.DataPropertyName = "waktu_berangkat";
            this.waktuberangkatDataGridViewTextBoxColumn.HeaderText = "waktu_berangkat";
            this.waktuberangkatDataGridViewTextBoxColumn.Name = "waktuberangkatDataGridViewTextBoxColumn";
            this.waktuberangkatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalpulangDataGridViewTextBoxColumn
            // 
            this.tanggalpulangDataGridViewTextBoxColumn.DataPropertyName = "tanggal_pulang";
            this.tanggalpulangDataGridViewTextBoxColumn.HeaderText = "tanggal_pulang";
            this.tanggalpulangDataGridViewTextBoxColumn.Name = "tanggalpulangDataGridViewTextBoxColumn";
            this.tanggalpulangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waktupulangDataGridViewTextBoxColumn
            // 
            this.waktupulangDataGridViewTextBoxColumn.DataPropertyName = "waktu_pulang";
            this.waktupulangDataGridViewTextBoxColumn.HeaderText = "waktu_pulang";
            this.waktupulangDataGridViewTextBoxColumn.Name = "waktupulangDataGridViewTextBoxColumn";
            this.waktupulangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusjadwalDataGridViewTextBoxColumn
            // 
            this.statusjadwalDataGridViewTextBoxColumn.DataPropertyName = "status_jadwal";
            this.statusjadwalDataGridViewTextBoxColumn.HeaderText = "status_jadwal";
            this.statusjadwalDataGridViewTextBoxColumn.Name = "statusjadwalDataGridViewTextBoxColumn";
            this.statusjadwalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapasitasDataGridViewTextBoxColumn
            // 
            this.kapasitasDataGridViewTextBoxColumn.DataPropertyName = "kapasitas";
            this.kapasitasDataGridViewTextBoxColumn.HeaderText = "kapasitas";
            this.kapasitasDataGridViewTextBoxColumn.Name = "kapasitasDataGridViewTextBoxColumn";
            this.kapasitasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cbIdStaff
            // 
            this.cbIdStaff.FormattingEnabled = true;
            this.cbIdStaff.Location = new System.Drawing.Point(223, 110);
            this.cbIdStaff.Name = "cbIdStaff";
            this.cbIdStaff.Size = new System.Drawing.Size(218, 21);
            this.cbIdStaff.TabIndex = 32;
            // 
            // UserScheduleTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.panel2);
            this.Name = "UserScheduleTripForm";
            this.Size = new System.Drawing.Size(1060, 688);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEditCreate.ResumeLayout(false);
            this.panelEditCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_AdventureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalTripBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel panelEditCreate;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fillTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelBtnSearch;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.DataGridView employee_gridData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjadwalTripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalberangkatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuberangkatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalpulangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktupulangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusjadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jadwalTripBindingSource;
        private NexTrip_AdventureDataSet nexTrip_AdventureDataSet;
        private NexTrip_AdventureDataSetTableAdapters.Jadwal_TripTableAdapter jadwal_TripTableAdapter;
        private System.Windows.Forms.ComboBox cbIdStaff;
    }
}
