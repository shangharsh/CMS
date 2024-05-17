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
            this.StudentTable = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboStdGender = new System.Windows.Forms.ComboBox();
            this.PickerStdDateTime = new System.Windows.Forms.DateTimePicker();
            this.ComboStdDepartment = new System.Windows.Forms.ComboBox();
            this.TxtStdAddress = new System.Windows.Forms.TextBox();
            this.TxtStdNum = new System.Windows.Forms.TextBox();
            this.TxtStdEmail = new System.Windows.Forms.TextBox();
            this.TxtStdName = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.LblTeacherName = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).BeginInit();
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
            // StudentTable
            // 
            this.StudentTable.AllowUserToAddRows = false;
            this.StudentTable.AllowUserToDeleteRows = false;
            this.StudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentTable.Location = new System.Drawing.Point(132, 471);
            this.StudentTable.Name = "StudentTable";
            this.StudentTable.ReadOnly = true;
            this.StudentTable.RowHeadersWidth = 62;
            this.StudentTable.RowTemplate.Height = 28;
            this.StudentTable.Size = new System.Drawing.Size(1543, 315);
            this.StudentTable.TabIndex = 45;
            this.StudentTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentTable_CellDoubleClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1132, 222);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 45);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(1132, 161);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(141, 45);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(1132, 94);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 45);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ComboStdGender
            // 
            this.ComboStdGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboStdGender.FormattingEnabled = true;
            this.ComboStdGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.ComboStdGender.Location = new System.Drawing.Point(739, 211);
            this.ComboStdGender.Name = "ComboStdGender";
            this.ComboStdGender.Size = new System.Drawing.Size(223, 37);
            this.ComboStdGender.TabIndex = 6;
            // 
            // PickerStdDateTime
            // 
            this.PickerStdDateTime.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PickerStdDateTime.Location = new System.Drawing.Point(132, 324);
            this.PickerStdDateTime.Name = "PickerStdDateTime";
            this.PickerStdDateTime.Size = new System.Drawing.Size(418, 37);
            this.PickerStdDateTime.TabIndex = 7;
            // 
            // ComboStdDepartment
            // 
            this.ComboStdDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboStdDepartment.FormattingEnabled = true;
            this.ComboStdDepartment.Location = new System.Drawing.Point(442, 211);
            this.ComboStdDepartment.Name = "ComboStdDepartment";
            this.ComboStdDepartment.Size = new System.Drawing.Size(225, 37);
            this.ComboStdDepartment.TabIndex = 5;
            // 
            // TxtStdAddress
            // 
            this.TxtStdAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStdAddress.Location = new System.Drawing.Point(737, 94);
            this.TxtStdAddress.Name = "TxtStdAddress";
            this.TxtStdAddress.Size = new System.Drawing.Size(225, 35);
            this.TxtStdAddress.TabIndex = 3;
            // 
            // TxtStdNum
            // 
            this.TxtStdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStdNum.Location = new System.Drawing.Point(442, 94);
            this.TxtStdNum.Name = "TxtStdNum";
            this.TxtStdNum.Size = new System.Drawing.Size(225, 35);
            this.TxtStdNum.TabIndex = 2;
            // 
            // TxtStdEmail
            // 
            this.TxtStdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStdEmail.Location = new System.Drawing.Point(132, 211);
            this.TxtStdEmail.Name = "TxtStdEmail";
            this.TxtStdEmail.Size = new System.Drawing.Size(225, 35);
            this.TxtStdEmail.TabIndex = 4;
            // 
            // TxtStdName
            // 
            this.TxtStdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStdName.Location = new System.Drawing.Point(132, 94);
            this.TxtStdName.Name = "TxtStdName";
            this.TxtStdName.Size = new System.Drawing.Size(225, 35);
            this.TxtStdName.TabIndex = 1;
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
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(132, 33);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 26);
            this.TxtId.TabIndex = 47;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(1132, 285);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(141, 45);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1003);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentTable);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ComboStdGender);
            this.Controls.Add(this.PickerStdDateTime);
            this.Controls.Add(this.ComboStdDepartment);
            this.Controls.Add(this.TxtStdAddress);
            this.Controls.Add(this.TxtStdNum);
            this.Controls.Add(this.TxtStdEmail);
            this.Controls.Add(this.TxtStdName);
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
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentTable;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox ComboStdGender;
        private System.Windows.Forms.DateTimePicker PickerStdDateTime;
        private System.Windows.Forms.ComboBox ComboStdDepartment;
        private System.Windows.Forms.TextBox TxtStdAddress;
        private System.Windows.Forms.TextBox TxtStdNum;
        private System.Windows.Forms.TextBox TxtStdEmail;
        private System.Windows.Forms.TextBox TxtStdName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.Label LblTeacherName;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnReset;
    }
}