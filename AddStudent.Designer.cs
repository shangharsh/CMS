namespace CMS
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.PickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.ComboDepartment = new System.Windows.Forms.ComboBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtMobNumber = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTeacherName = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.LblTeacherName = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(781, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Student\'s Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(132, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1543, 315);
            this.dataGridView1.TabIndex = 45;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1132, 222);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 45);
            this.BtnDelete.TabIndex = 44;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(1132, 161);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(141, 45);
            this.BtnUpdate.TabIndex = 43;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(1132, 94);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 45);
            this.BtnSave.TabIndex = 42;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // ComboGender
            // 
            this.ComboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Location = new System.Drawing.Point(739, 211);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(223, 37);
            this.ComboGender.TabIndex = 41;
            // 
            // PickerDateTime
            // 
            this.PickerDateTime.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PickerDateTime.Location = new System.Drawing.Point(132, 324);
            this.PickerDateTime.Name = "PickerDateTime";
            this.PickerDateTime.Size = new System.Drawing.Size(418, 37);
            this.PickerDateTime.TabIndex = 40;
            // 
            // ComboDepartment
            // 
            this.ComboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDepartment.FormattingEnabled = true;
            this.ComboDepartment.Location = new System.Drawing.Point(442, 211);
            this.ComboDepartment.Name = "ComboDepartment";
            this.ComboDepartment.Size = new System.Drawing.Size(225, 37);
            this.ComboDepartment.TabIndex = 39;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(737, 94);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(225, 35);
            this.TxtAddress.TabIndex = 38;
            // 
            // TxtMobNumber
            // 
            this.TxtMobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMobNumber.Location = new System.Drawing.Point(442, 94);
            this.TxtMobNumber.Name = "TxtMobNumber";
            this.TxtMobNumber.Size = new System.Drawing.Size(225, 35);
            this.TxtMobNumber.TabIndex = 37;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(132, 211);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(225, 35);
            this.TxtEmail.TabIndex = 36;
            // 
            // TxtTeacherName
            // 
            this.TxtTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTeacherName.Location = new System.Drawing.Point(132, 94);
            this.TxtTeacherName.Name = "TxtTeacherName";
            this.TxtTeacherName.Size = new System.Drawing.Size(225, 35);
            this.TxtTeacherName.TabIndex = 35;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblAddress.Location = new System.Drawing.Point(733, 62);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(105, 30);
            this.LblAddress.TabIndex = 33;
            this.LblAddress.Text = "Address";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDOB.Location = new System.Drawing.Point(128, 292);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(159, 30);
            this.LblDOB.TabIndex = 32;
            this.LblDOB.Text = "Date of Birth";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDepartment.Location = new System.Drawing.Point(437, 179);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(157, 30);
            this.LblDepartment.TabIndex = 31;
            this.LblDepartment.Text = "Department";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblGender.Location = new System.Drawing.Point(733, 179);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(104, 30);
            this.LblGender.TabIndex = 30;
            this.LblGender.Text = "Gender";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblEmail.Location = new System.Drawing.Point(128, 179);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(78, 30);
            this.LblEmail.TabIndex = 29;
            this.LblEmail.Text = "Email";
            // 
            // LblMobileNumber
            // 
            this.LblMobileNumber.AutoSize = true;
            this.LblMobileNumber.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblMobileNumber.Location = new System.Drawing.Point(437, 62);
            this.LblMobileNumber.Name = "LblMobileNumber";
            this.LblMobileNumber.Size = new System.Drawing.Size(199, 30);
            this.LblMobileNumber.TabIndex = 34;
            this.LblMobileNumber.Text = "Mobile Number";
            // 
            // LblTeacherName
            // 
            this.LblTeacherName.AutoSize = true;
            this.LblTeacherName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblTeacherName.Location = new System.Drawing.Point(128, 62);
            this.LblTeacherName.Name = "LblTeacherName";
            this.LblTeacherName.Size = new System.Drawing.Size(245, 30);
            this.LblTeacherName.TabIndex = 28;
            this.LblTeacherName.Text = "Student\'s Full Name";
            // 
            // no
            // 
            this.no.HeaderText = "S.NO.";
            this.no.MinimumWidth = 8;
            this.no.Name = "no";
            this.no.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student\'s Full Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gender";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date of Birth";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Department";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fees";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1003);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ComboGender);
            this.Controls.Add(this.PickerDateTime);
            this.Controls.Add(this.ComboDepartment);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtMobNumber);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTeacherName);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblDepartment);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblMobileNumber);
            this.Controls.Add(this.LblTeacherName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox ComboGender;
        private System.Windows.Forms.DateTimePicker PickerDateTime;
        private System.Windows.Forms.ComboBox ComboDepartment;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtMobNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTeacherName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.Label LblTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}