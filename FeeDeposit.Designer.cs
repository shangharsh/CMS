namespace CMS
{
    partial class FeeDeposit
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
            this.PickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.ComboDepartment = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtStdName = new System.Windows.Forms.TextBox();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTeacherName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSemFee = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(760, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Payment\'s Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(111, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1313, 315);
            this.dataGridView1.TabIndex = 64;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1111, 235);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 45);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(1111, 174);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(141, 45);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(1111, 107);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 45);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PickerPaymentDate
            // 
            this.PickerPaymentDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PickerPaymentDate.Location = new System.Drawing.Point(110, 231);
            this.PickerPaymentDate.Name = "PickerPaymentDate";
            this.PickerPaymentDate.Size = new System.Drawing.Size(418, 37);
            this.PickerPaymentDate.TabIndex = 4;
            // 
            // ComboDepartment
            // 
            this.ComboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDepartment.FormattingEnabled = true;
            this.ComboDepartment.Location = new System.Drawing.Point(699, 107);
            this.ComboDepartment.Name = "ComboDepartment";
            this.ComboDepartment.Size = new System.Drawing.Size(225, 37);
            this.ComboDepartment.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(409, 107);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(225, 35);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtStdName
            // 
            this.TxtStdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStdName.Location = new System.Drawing.Point(111, 107);
            this.TxtStdName.Name = "TxtStdName";
            this.TxtStdName.Size = new System.Drawing.Size(225, 35);
            this.TxtStdName.TabIndex = 1;
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDOB.Location = new System.Drawing.Point(106, 199);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(215, 30);
            this.LblDOB.TabIndex = 51;
            this.LblDOB.Text = "Date of Payment";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDepartment.Location = new System.Drawing.Point(694, 75);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(157, 30);
            this.LblDepartment.TabIndex = 50;
            this.LblDepartment.Text = "Department";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblEmail.Location = new System.Drawing.Point(405, 75);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(78, 30);
            this.LblEmail.TabIndex = 48;
            this.LblEmail.Text = "Email";
            // 
            // LblTeacherName
            // 
            this.LblTeacherName.AutoSize = true;
            this.LblTeacherName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblTeacherName.Location = new System.Drawing.Point(107, 75);
            this.LblTeacherName.Name = "LblTeacherName";
            this.LblTeacherName.Size = new System.Drawing.Size(245, 30);
            this.LblTeacherName.TabIndex = 47;
            this.LblTeacherName.Text = "Student\'s Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(694, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "Semester Fee";
            // 
            // TxtSemFee
            // 
            this.TxtSemFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSemFee.Location = new System.Drawing.Point(698, 231);
            this.TxtSemFee.Name = "TxtSemFee";
            this.TxtSemFee.Size = new System.Drawing.Size(225, 35);
            this.TxtSemFee.TabIndex = 5;
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
            // Column3
            // 
            this.Column3.HeaderText = "Date of Payment";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
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
            this.Column7.HeaderText = "Semester Fee";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // FeeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 854);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PickerPaymentDate);
            this.Controls.Add(this.ComboDepartment);
            this.Controls.Add(this.TxtSemFee);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtStdName);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTeacherName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeeDeposit";
            this.Text = "FeeDeposit";
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
        private System.Windows.Forms.DateTimePicker PickerPaymentDate;
        private System.Windows.Forms.ComboBox ComboDepartment;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtStdName;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTeacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSemFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}