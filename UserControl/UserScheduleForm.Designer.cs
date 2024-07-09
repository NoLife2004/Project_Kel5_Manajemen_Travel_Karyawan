namespace Project_Kel5_Manajemen_Travel
{
    partial class UserScheduleForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnScheduleTrip = new System.Windows.Forms.Button();
            this.btnScheduleBus = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnScheduleTrip);
            this.panel2.Controls.Add(this.btnScheduleBus);
            this.panel2.Location = new System.Drawing.Point(20, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 639);
            this.panel2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Please select the menu below";
            // 
            // btnScheduleTrip
            // 
            this.btnScheduleTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnScheduleTrip.FlatAppearance.BorderSize = 0;
            this.btnScheduleTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleTrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnScheduleTrip.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScheduleTrip.Location = new System.Drawing.Point(378, 303);
            this.btnScheduleTrip.Name = "btnScheduleTrip";
            this.btnScheduleTrip.Size = new System.Drawing.Size(124, 32);
            this.btnScheduleTrip.TabIndex = 17;
            this.btnScheduleTrip.Text = "Schedule Trip";
            this.btnScheduleTrip.UseVisualStyleBackColor = false;
            this.btnScheduleTrip.Click += new System.EventHandler(this.btnScheduleTrip_Click);
            // 
            // btnScheduleBus
            // 
            this.btnScheduleBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btnScheduleBus.FlatAppearance.BorderSize = 0;
            this.btnScheduleBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleBus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnScheduleBus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScheduleBus.Location = new System.Drawing.Point(518, 303);
            this.btnScheduleBus.Name = "btnScheduleBus";
            this.btnScheduleBus.Size = new System.Drawing.Size(124, 32);
            this.btnScheduleBus.TabIndex = 16;
            this.btnScheduleBus.Text = "Schedule Bus";
            this.btnScheduleBus.UseVisualStyleBackColor = false;
            this.btnScheduleBus.Click += new System.EventHandler(this.btnScheduleBus_Click);
            // 
            // UserScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(214)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.panel2);
            this.Name = "UserScheduleForm";
            this.Size = new System.Drawing.Size(1060, 688);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnScheduleTrip;
        private System.Windows.Forms.Button btnScheduleBus;
        private System.Windows.Forms.Label label7;
    }
}
