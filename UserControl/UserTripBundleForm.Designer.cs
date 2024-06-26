namespace Project_Kel5_Manajemen_Travel
{
    partial class UserTripBundleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fillTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelBtnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.TripBundle_gridData = new System.Windows.Forms.DataGridView();
            this.editPanel = new System.Windows.Forms.Panel();
            this.idTripBundle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.idRole = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.createPanel = new System.Windows.Forms.Panel();
            this.insertIdTripBundle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insertDeskripsi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.insertName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelCreate = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.nexTrip_Adventure = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSet();
            this.paket_TripTableAdapter = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSetTableAdapters.Paket_TripTableAdapter();
            this.nexTrip_AdventureDataSet = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSet();
            this.paketTripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paket_TripTableAdapter1 = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSetTableAdapters.Paket_TripTableAdapter();
            this.idpaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsipaketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TripBundle_gridData)).BeginInit();
            this.editPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_Adventure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_AdventureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketTripBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Trip Bundle";
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.Color.White;
            this.showPanel.Controls.Add(this.search);
            this.showPanel.Controls.Add(this.label7);
            this.showPanel.Controls.Add(this.refresh);
            this.showPanel.Controls.Add(this.label8);
            this.showPanel.Controls.Add(this.label9);
            this.showPanel.Controls.Add(this.fillTxt);
            this.showPanel.Controls.Add(this.label10);
            this.showPanel.Controls.Add(this.cancelBtnSearch);
            this.showPanel.Controls.Add(this.btnCreate);
            this.showPanel.Controls.Add(this.btnChange);
            this.showPanel.Controls.Add(this.TripBundle_gridData);
            this.showPanel.Location = new System.Drawing.Point(32, 24);
            this.showPanel.Margin = new System.Windows.Forms.Padding(4);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(705, 799);
            this.showPanel.TabIndex = 17;
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
            this.search.Location = new System.Drawing.Point(589, 384);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(36, 36);
            this.search.TabIndex = 21;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = global::Project_Kel5_Manajemen_Travel.Properties.Resources.Refresh;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.refresh.Location = new System.Drawing.Point(193, 455);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(33, 31);
            this.refresh.TabIndex = 20;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 682);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Code for Life, Life for Code ^-^";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 350);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Please fill in below to search";
            // 
            // fillTxt
            // 
            this.fillTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillTxt.Location = new System.Drawing.Point(219, 384);
            this.fillTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fillTxt.Multiline = true;
            this.fillTxt.Name = "fillTxt";
            this.fillTxt.Size = new System.Drawing.Size(362, 35);
            this.fillTxt.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 384);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "ID or Name :";
            // 
            // cancelBtnSearch
            // 
            this.cancelBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.cancelBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelBtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtnSearch.Location = new System.Drawing.Point(240, 450);
            this.cancelBtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtnSearch.Name = "cancelBtnSearch";
            this.cancelBtnSearch.Size = new System.Drawing.Size(119, 39);
            this.cancelBtnSearch.TabIndex = 16;
            this.cancelBtnSearch.Text = "Cancel";
            this.cancelBtnSearch.UseVisualStyleBackColor = false;
            this.cancelBtnSearch.Click += new System.EventHandler(this.cancelBtnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(507, 450);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 39);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChange.Location = new System.Drawing.Point(373, 450);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(119, 39);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // TripBundle_gridData
            // 
            this.TripBundle_gridData.AllowUserToAddRows = false;
            this.TripBundle_gridData.AllowUserToDeleteRows = false;
            this.TripBundle_gridData.AllowUserToResizeColumns = false;
            this.TripBundle_gridData.AllowUserToResizeRows = false;
            this.TripBundle_gridData.AutoGenerateColumns = false;
            this.TripBundle_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TripBundle_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.TripBundle_gridData.ColumnHeadersHeight = 30;
            this.TripBundle_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TripBundle_gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpaketDataGridViewTextBoxColumn,
            this.namapaketDataGridViewTextBoxColumn,
            this.deskripsipaketDataGridViewTextBoxColumn});
            this.TripBundle_gridData.DataSource = this.paketTripBindingSource;
            this.TripBundle_gridData.EnableHeadersVisualStyles = false;
            this.TripBundle_gridData.Location = new System.Drawing.Point(87, 87);
            this.TripBundle_gridData.Margin = new System.Windows.Forms.Padding(4);
            this.TripBundle_gridData.Name = "TripBundle_gridData";
            this.TripBundle_gridData.ReadOnly = true;
            this.TripBundle_gridData.RowHeadersVisible = false;
            this.TripBundle_gridData.RowHeadersWidth = 20;
            this.TripBundle_gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TripBundle_gridData.Size = new System.Drawing.Size(539, 218);
            this.TripBundle_gridData.TabIndex = 16;
            this.TripBundle_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TripBundle_gridData_CellContentClick);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.White;
            this.editPanel.Controls.Add(this.idTripBundle);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.deskripsi);
            this.editPanel.Controls.Add(this.idRole);
            this.editPanel.Controls.Add(this.label11);
            this.editPanel.Controls.Add(this.label13);
            this.editPanel.Controls.Add(this.label14);
            this.editPanel.Controls.Add(this.btnDelete);
            this.editPanel.Controls.Add(this.name);
            this.editPanel.Controls.Add(this.btnUpdate);
            this.editPanel.Location = new System.Drawing.Point(760, 24);
            this.editPanel.Margin = new System.Windows.Forms.Padding(4);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(627, 394);
            this.editPanel.TabIndex = 18;
            this.editPanel.Visible = false;
            // 
            // idTripBundle
            // 
            this.idTripBundle.AutoSize = true;
            this.idTripBundle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTripBundle.Location = new System.Drawing.Point(219, 100);
            this.idTripBundle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idTripBundle.Name = "idTripBundle";
            this.idTripBundle.Size = new System.Drawing.Size(15, 23);
            this.idTripBundle.TabIndex = 28;
            this.idTripBundle.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Deskripsi         :";
            // 
            // deskripsi
            // 
            this.deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskripsi.Location = new System.Drawing.Point(220, 210);
            this.deskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.deskripsi.Multiline = true;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(346, 33);
            this.deskripsi.TabIndex = 27;
            // 
            // idRole
            // 
            this.idRole.AutoSize = true;
            this.idRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRole.Location = new System.Drawing.Point(196, 87);
            this.idRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idRole.Name = "idRole";
            this.idRole.Size = new System.Drawing.Size(15, 23);
            this.idRole.TabIndex = 25;
            this.idRole.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 32);
            this.label11.TabIndex = 22;
            this.label11.Text = "Edit Trip Bundle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 100);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "ID Trip Bundle :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(84, 154);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Name             :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(252, 266);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(221, 154);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(346, 33);
            this.name.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(427, 266);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 39);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.Color.White;
            this.createPanel.Controls.Add(this.insertIdTripBundle);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.insertDeskripsi);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.insertName);
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Controls.Add(this.cancelCreate);
            this.createPanel.Controls.Add(this.btnconfirm);
            this.createPanel.Location = new System.Drawing.Point(760, 425);
            this.createPanel.Margin = new System.Windows.Forms.Padding(4);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(627, 398);
            this.createPanel.TabIndex = 19;
            this.createPanel.Visible = false;
            // 
            // insertIdTripBundle
            // 
            this.insertIdTripBundle.AutoSize = true;
            this.insertIdTripBundle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertIdTripBundle.Location = new System.Drawing.Point(219, 83);
            this.insertIdTripBundle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insertIdTripBundle.Name = "insertIdTripBundle";
            this.insertIdTripBundle.Size = new System.Drawing.Size(15, 23);
            this.insertIdTripBundle.TabIndex = 33;
            this.insertIdTripBundle.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Deskripsi         :";
            // 
            // insertDeskripsi
            // 
            this.insertDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertDeskripsi.Location = new System.Drawing.Point(219, 193);
            this.insertDeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.insertDeskripsi.Multiline = true;
            this.insertDeskripsi.Name = "insertDeskripsi";
            this.insertDeskripsi.Size = new System.Drawing.Size(346, 33);
            this.insertDeskripsi.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID Trip Bundle :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Name             :";
            // 
            // insertName
            // 
            this.insertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertName.Location = new System.Drawing.Point(220, 137);
            this.insertName.Margin = new System.Windows.Forms.Padding(4);
            this.insertName.Multiline = true;
            this.insertName.Name = "insertName";
            this.insertName.Size = new System.Drawing.Size(346, 33);
            this.insertName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Create Trip Bundle";
            // 
            // cancelCreate
            // 
            this.cancelCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.cancelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelCreate.Location = new System.Drawing.Point(252, 262);
            this.cancelCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.Size = new System.Drawing.Size(119, 39);
            this.cancelCreate.TabIndex = 15;
            this.cancelCreate.Text = "Cancel";
            this.cancelCreate.UseVisualStyleBackColor = false;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnconfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnconfirm.Location = new System.Drawing.Point(427, 262);
            this.btnconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(119, 39);
            this.btnconfirm.TabIndex = 13;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // nexTrip_Adventure
            // 
            this.nexTrip_Adventure.DataSetName = "NexTrip_Adventure";
            this.nexTrip_Adventure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paket_TripTableAdapter
            // 
            this.paket_TripTableAdapter.ClearBeforeFill = true;
            // 
            // nexTrip_AdventureDataSet
            // 
            this.nexTrip_AdventureDataSet.DataSetName = "NexTrip_AdventureDataSet";
            this.nexTrip_AdventureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paketTripBindingSource
            // 
            this.paketTripBindingSource.DataMember = "Paket_Trip";
            this.paketTripBindingSource.DataSource = this.nexTrip_AdventureDataSet;
            // 
            // paket_TripTableAdapter1
            // 
            this.paket_TripTableAdapter1.ClearBeforeFill = true;
            // 
            // idpaketDataGridViewTextBoxColumn
            // 
            this.idpaketDataGridViewTextBoxColumn.DataPropertyName = "id_paket";
            this.idpaketDataGridViewTextBoxColumn.HeaderText = "ID Paket";
            this.idpaketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpaketDataGridViewTextBoxColumn.Name = "idpaketDataGridViewTextBoxColumn";
            this.idpaketDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpaketDataGridViewTextBoxColumn.Width = 125;
            // 
            // namapaketDataGridViewTextBoxColumn
            // 
            this.namapaketDataGridViewTextBoxColumn.DataPropertyName = "nama_paket";
            this.namapaketDataGridViewTextBoxColumn.HeaderText = "Nama Paket";
            this.namapaketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapaketDataGridViewTextBoxColumn.Name = "namapaketDataGridViewTextBoxColumn";
            this.namapaketDataGridViewTextBoxColumn.ReadOnly = true;
            this.namapaketDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskripsipaketDataGridViewTextBoxColumn
            // 
            this.deskripsipaketDataGridViewTextBoxColumn.DataPropertyName = "deskripsi_paket";
            this.deskripsipaketDataGridViewTextBoxColumn.HeaderText = "Deskripsi Paket";
            this.deskripsipaketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsipaketDataGridViewTextBoxColumn.Name = "deskripsipaketDataGridViewTextBoxColumn";
            this.deskripsipaketDataGridViewTextBoxColumn.ReadOnly = true;
            this.deskripsipaketDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserTripBundleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.showPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserTripBundleForm";
            this.Size = new System.Drawing.Size(1413, 847);
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TripBundle_gridData)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_Adventure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_AdventureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketTripBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fillTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelBtnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView TripBundle_gridData;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label idRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deskripsi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox insertDeskripsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox insertName;
        private System.Windows.Forms.Label idTripBundle;
        private System.Windows.Forms.Label insertIdTripBundle;
        private NexTrip_AdventureDataSet nexTrip_Adventure;
        private NexTrip_AdventureDataSetTableAdapters.Paket_TripTableAdapter paket_TripTableAdapter;
        private System.Windows.Forms.BindingSource paketTripBindingSource;
        private NexTrip_AdventureDataSet nexTrip_AdventureDataSet;
        private NexTrip_AdventureDataSetTableAdapters.Paket_TripTableAdapter paket_TripTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapaketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsipaketDataGridViewTextBoxColumn;
    }
}
