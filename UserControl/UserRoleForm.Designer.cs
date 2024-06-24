namespace Project_Kel5_Manajemen_Travel
{
    partial class UserRoleForm
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
            this.showPanel = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fillTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtnSearch = new System.Windows.Forms.Button();
            this.creatBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.employee_gridData = new System.Windows.Forms.DataGridView();
            this.idroleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaroleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nexTrip_Adventure = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.idRole = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roleTableAdapter = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSetTableAdapters.RoleTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createPanel = new System.Windows.Forms.Panel();
            this.insertId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.insertName = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_Adventure)).BeginInit();
            this.editPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.Color.White;
            this.showPanel.Controls.Add(this.search);
            this.showPanel.Controls.Add(this.refresh);
            this.showPanel.Controls.Add(this.label5);
            this.showPanel.Controls.Add(this.label4);
            this.showPanel.Controls.Add(this.fillTxt);
            this.showPanel.Controls.Add(this.label2);
            this.showPanel.Controls.Add(this.cancelBtnSearch);
            this.showPanel.Controls.Add(this.creatBtn);
            this.showPanel.Controls.Add(this.changeBtn);
            this.showPanel.Controls.Add(this.employee_gridData);
            this.showPanel.Controls.Add(this.label7);
            this.showPanel.Location = new System.Drawing.Point(20, 20);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(529, 649);
            this.showPanel.TabIndex = 16;
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
            this.search.Location = new System.Drawing.Point(442, 312);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(27, 29);
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
            this.refresh.Location = new System.Drawing.Point(145, 370);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(25, 25);
            this.refresh.TabIndex = 20;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Code for Life, Life for Code ^-^";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Please fill in below to search";
            // 
            // fillTxt
            // 
            this.fillTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillTxt.Location = new System.Drawing.Point(164, 312);
            this.fillTxt.Multiline = true;
            this.fillTxt.Name = "fillTxt";
            this.fillTxt.Size = new System.Drawing.Size(272, 29);
            this.fillTxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID or Name :";
            // 
            // cancelBtnSearch
            // 
            this.cancelBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.cancelBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelBtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtnSearch.Location = new System.Drawing.Point(180, 366);
            this.cancelBtnSearch.Name = "cancelBtnSearch";
            this.cancelBtnSearch.Size = new System.Drawing.Size(89, 32);
            this.cancelBtnSearch.TabIndex = 16;
            this.cancelBtnSearch.Text = "Cancel";
            this.cancelBtnSearch.UseVisualStyleBackColor = false;
            this.cancelBtnSearch.Click += new System.EventHandler(this.cancelBtnSearch_Click);
            // 
            // creatBtn
            // 
            this.creatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.creatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.creatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.creatBtn.Location = new System.Drawing.Point(380, 366);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(89, 32);
            this.creatBtn.TabIndex = 12;
            this.creatBtn.Text = "Create";
            this.creatBtn.UseVisualStyleBackColor = false;
            this.creatBtn.Click += new System.EventHandler(this.creatBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.changeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.changeBtn.Location = new System.Drawing.Point(280, 366);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(89, 32);
            this.changeBtn.TabIndex = 16;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
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
            this.idroleDataGridViewTextBoxColumn1,
            this.namaroleDataGridViewTextBoxColumn1});
            this.employee_gridData.DataSource = this.roleBindingSource;
            this.employee_gridData.EnableHeadersVisualStyles = false;
            this.employee_gridData.Location = new System.Drawing.Point(65, 71);
            this.employee_gridData.Name = "employee_gridData";
            this.employee_gridData.ReadOnly = true;
            this.employee_gridData.RowHeadersVisible = false;
            this.employee_gridData.RowHeadersWidth = 20;
            this.employee_gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employee_gridData.Size = new System.Drawing.Size(404, 177);
            this.employee_gridData.TabIndex = 16;
            this.employee_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_gridData_CellContentClick);
            // 
            // idroleDataGridViewTextBoxColumn1
            // 
            this.idroleDataGridViewTextBoxColumn1.DataPropertyName = "id_role";
            this.idroleDataGridViewTextBoxColumn1.HeaderText = "ID Role";
            this.idroleDataGridViewTextBoxColumn1.Name = "idroleDataGridViewTextBoxColumn1";
            this.idroleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idroleDataGridViewTextBoxColumn1.Width = 200;
            // 
            // namaroleDataGridViewTextBoxColumn1
            // 
            this.namaroleDataGridViewTextBoxColumn1.DataPropertyName = "nama_role";
            this.namaroleDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.namaroleDataGridViewTextBoxColumn1.Name = "namaroleDataGridViewTextBoxColumn1";
            this.namaroleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.namaroleDataGridViewTextBoxColumn1.Width = 200;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.nexTrip_Adventure;
            // 
            // nexTrip_Adventure
            // 
            this.nexTrip_Adventure.DataSetName = "NexTrip_Adventure";
            this.nexTrip_Adventure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Role Data";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(189, 180);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 32);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateBtn.Location = new System.Drawing.Point(320, 180);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 32);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(149, 125);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(260, 27);
            this.name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Role :";
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.White;
            this.editPanel.Controls.Add(this.idRole);
            this.editPanel.Controls.Add(this.label12);
            this.editPanel.Controls.Add(this.label10);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.deleteBtn);
            this.editPanel.Controls.Add(this.name);
            this.editPanel.Controls.Add(this.updateBtn);
            this.editPanel.Location = new System.Drawing.Point(569, 20);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(470, 320);
            this.editPanel.TabIndex = 17;
            this.editPanel.Visible = false;
            // 
            // idRole
            // 
            this.idRole.AutoSize = true;
            this.idRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRole.Location = new System.Drawing.Point(147, 71);
            this.idRole.Name = "idRole";
            this.idRole.Size = new System.Drawing.Size(12, 17);
            this.idRole.TabIndex = 25;
            this.idRole.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(147, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 51);
            this.label12.TabIndex = 24;
            this.label12.Text = "Vacations can be more fun \r\nusing NexTrip Adventure\r\n(◡‿◡✿)\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Edit Role";
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.Color.White;
            this.createPanel.Controls.Add(this.insertId);
            this.createPanel.Controls.Add(this.label11);
            this.createPanel.Controls.Add(this.label9);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.cancelCreate);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.insertName);
            this.createPanel.Controls.Add(this.confirm);
            this.createPanel.Location = new System.Drawing.Point(569, 346);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(470, 323);
            this.createPanel.TabIndex = 18;
            this.createPanel.Visible = false;
            // 
            // insertId
            // 
            this.insertId.AutoSize = true;
            this.insertId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertId.Location = new System.Drawing.Point(146, 65);
            this.insertId.Name = "insertId";
            this.insertId.Size = new System.Drawing.Size(12, 17);
            this.insertId.TabIndex = 24;
            this.insertId.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Create Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 51);
            this.label9.TabIndex = 22;
            this.label9.Text = "Programming is the art of algorithm design\r\nand the craft of debugging errant cod" +
    "e\r\n(-‿◦)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID Role :";
            // 
            // cancelCreate
            // 
            this.cancelCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.cancelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cancelCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelCreate.Location = new System.Drawing.Point(189, 181);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.Size = new System.Drawing.Size(89, 32);
            this.cancelCreate.TabIndex = 15;
            this.cancelCreate.Text = "Cancel";
            this.cancelCreate.UseVisualStyleBackColor = false;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name :";
            // 
            // insertName
            // 
            this.insertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertName.Location = new System.Drawing.Point(149, 124);
            this.insertName.Multiline = true;
            this.insertName.Name = "insertName";
            this.insertName.Size = new System.Drawing.Size(260, 27);
            this.insertName.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.confirm.Location = new System.Drawing.Point(320, 181);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(89, 32);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // UserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.editPanel);
            this.Name = "UserRoleForm";
            this.Size = new System.Drawing.Size(1060, 688);
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_Adventure)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private NexTrip_AdventureDataSet nexTrip_Adventure;
        private NexTrip_AdventureDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.DataGridView employee_gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaroleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fillTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtnSearch;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox insertName;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label idRole;
        private System.Windows.Forms.Label insertId;
    }
}
