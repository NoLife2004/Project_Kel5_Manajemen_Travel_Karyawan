namespace Project_Kel5_Manajemen_Travel
{
    partial class UserUnitForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.creatBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.employee_gridData = new System.Windows.Forms.DataGridView();
            this.idunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokursiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopolisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTravelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nexTrip_Adventure = new Project_Kel5_Manajemen_Travel.NexTrip_Adventure();
            this.unitTravelTableAdapter = new Project_Kel5_Manajemen_Travel.NexTrip_AdventureTableAdapters.UnitTravelTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTravelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_Adventure)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.creatBtn);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 344);
            this.panel1.TabIndex = 14;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancel.Location = new System.Drawing.Point(811, 269);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 32);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(581, 269);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 32);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateBtn.Location = new System.Drawing.Point(351, 269);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 32);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // creatBtn
            // 
            this.creatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.creatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.creatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.creatBtn.Location = new System.Drawing.Point(121, 269);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(89, 32);
            this.creatBtn.TabIndex = 12;
            this.creatBtn.Text = "Create";
            this.creatBtn.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(229, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 20);
            this.name.TabIndex = 6;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(229, 126);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(218, 47);
            this.email.TabIndex = 7;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(702, 205);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 20);
            this.password.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password :";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(702, 126);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 20);
            this.username.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username :";
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Location = new System.Drawing.Point(229, 205);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(218, 20);
            this.phone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "nama_role";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(702, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id_role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Role :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Unit :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.employee_gridData);
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 286);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Unit Data";
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
            this.idunitDataGridViewTextBoxColumn,
            this.nokursiDataGridViewTextBoxColumn,
            this.nopolisiDataGridViewTextBoxColumn,
            this.statusunitDataGridViewTextBoxColumn,
            this.jenisunitDataGridViewTextBoxColumn,
            this.merkunitDataGridViewTextBoxColumn});
            this.employee_gridData.DataSource = this.unitTravelBindingSource;
            this.employee_gridData.EnableHeadersVisualStyles = false;
            this.employee_gridData.Location = new System.Drawing.Point(60, 77);
            this.employee_gridData.Name = "employee_gridData";
            this.employee_gridData.ReadOnly = true;
            this.employee_gridData.RowHeadersVisible = false;
            this.employee_gridData.RowHeadersWidth = 20;
            this.employee_gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employee_gridData.Size = new System.Drawing.Size(908, 177);
            this.employee_gridData.TabIndex = 0;
            this.employee_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_gridData_CellContentClick);
            // 
            // idunitDataGridViewTextBoxColumn
            // 
            this.idunitDataGridViewTextBoxColumn.DataPropertyName = "id_unit";
            this.idunitDataGridViewTextBoxColumn.HeaderText = "ID Unit";
            this.idunitDataGridViewTextBoxColumn.Name = "idunitDataGridViewTextBoxColumn";
            this.idunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nokursiDataGridViewTextBoxColumn
            // 
            this.nokursiDataGridViewTextBoxColumn.DataPropertyName = "no_kursi";
            this.nokursiDataGridViewTextBoxColumn.HeaderText = "Number of Seat";
            this.nokursiDataGridViewTextBoxColumn.Name = "nokursiDataGridViewTextBoxColumn";
            this.nokursiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nopolisiDataGridViewTextBoxColumn
            // 
            this.nopolisiDataGridViewTextBoxColumn.DataPropertyName = "no_polisi";
            this.nopolisiDataGridViewTextBoxColumn.HeaderText = "Police Number";
            this.nopolisiDataGridViewTextBoxColumn.Name = "nopolisiDataGridViewTextBoxColumn";
            this.nopolisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusunitDataGridViewTextBoxColumn
            // 
            this.statusunitDataGridViewTextBoxColumn.DataPropertyName = "status_unit";
            this.statusunitDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusunitDataGridViewTextBoxColumn.Name = "statusunitDataGridViewTextBoxColumn";
            this.statusunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenisunitDataGridViewTextBoxColumn
            // 
            this.jenisunitDataGridViewTextBoxColumn.DataPropertyName = "jenis_unit";
            this.jenisunitDataGridViewTextBoxColumn.HeaderText = "Type";
            this.jenisunitDataGridViewTextBoxColumn.Name = "jenisunitDataGridViewTextBoxColumn";
            this.jenisunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // merkunitDataGridViewTextBoxColumn
            // 
            this.merkunitDataGridViewTextBoxColumn.DataPropertyName = "merk_unit";
            this.merkunitDataGridViewTextBoxColumn.HeaderText = "Merk";
            this.merkunitDataGridViewTextBoxColumn.Name = "merkunitDataGridViewTextBoxColumn";
            this.merkunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitTravelBindingSource
            // 
            this.unitTravelBindingSource.DataMember = "UnitTravel";
            this.unitTravelBindingSource.DataSource = this.nexTrip_Adventure;
            // 
            // nexTrip_Adventure
            // 
            this.nexTrip_Adventure.DataSetName = "NexTrip_Adventure";
            this.nexTrip_Adventure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitTravelTableAdapter
            // 
            this.unitTravelTableAdapter.ClearBeforeFill = true;
            // 
            // UserUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserUnitForm";
            this.Size = new System.Drawing.Size(1060, 688);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTravelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nexTrip_Adventure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView employee_gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokursiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopolisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unitTravelBindingSource;
        private NexTrip_Adventure nexTrip_Adventure;
        private NexTrip_AdventureTableAdapters.UnitTravelTableAdapter unitTravelTableAdapter;
    }
}
