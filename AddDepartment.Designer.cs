namespace CMS
{
    partial class AddDepartment
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
            this.DepartmentTable = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(732, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 80;
            this.label1.Text = "Department\'s Details";
            // 
            // DepartmentTable
            // 
            this.DepartmentTable.AllowUserToAddRows = false;
            this.DepartmentTable.AllowUserToDeleteRows = false;
            this.DepartmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentTable.Location = new System.Drawing.Point(615, 457);
            this.DepartmentTable.Name = "DepartmentTable";
            this.DepartmentTable.ReadOnly = true;
            this.DepartmentTable.RowHeadersWidth = 62;
            this.DepartmentTable.RowTemplate.Height = 28;
            this.DepartmentTable.Size = new System.Drawing.Size(413, 315);
            this.DepartmentTable.TabIndex = 79;
            this.DepartmentTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentTable_CellDoubleClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(854, 234);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 45);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(854, 173);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(141, 45);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(854, 106);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(141, 45);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDepartment.Location = new System.Drawing.Point(590, 110);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(157, 30);
            this.LblDepartment.TabIndex = 69;
            this.LblDepartment.Text = "Department";
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepartment.Location = new System.Drawing.Point(595, 155);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(177, 37);
            this.TxtDepartment.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(854, 294);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(141, 45);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(595, 81);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(55, 26);
            this.TxtId.TabIndex = 81;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 851);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentTable);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblDepartment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.Load += new System.EventHandler(this.DepartmentTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DepartmentTable;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtId;
    }
}