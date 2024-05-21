namespace CMS
{
    partial class DepartmentDetails
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
            this.LblDepartmentDetails = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DepartmentTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDepartmentDetails
            // 
            this.LblDepartmentDetails.AutoSize = true;
            this.LblDepartmentDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartmentDetails.Location = new System.Drawing.Point(604, 131);
            this.LblDepartmentDetails.Name = "LblDepartmentDetails";
            this.LblDepartmentDetails.Size = new System.Drawing.Size(244, 30);
            this.LblDepartmentDetails.TabIndex = 1;
            this.LblDepartmentDetails.Text = "Department Details";
            this.LblDepartmentDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(1291, 21);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 44);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DepartmentTable
            // 
            this.DepartmentTable.AllowUserToAddRows = false;
            this.DepartmentTable.AllowUserToDeleteRows = false;
            this.DepartmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentTable.Location = new System.Drawing.Point(485, 190);
            this.DepartmentTable.Name = "DepartmentTable";
            this.DepartmentTable.ReadOnly = true;
            this.DepartmentTable.RowHeadersWidth = 62;
            this.DepartmentTable.RowTemplate.Height = 28;
            this.DepartmentTable.Size = new System.Drawing.Size(413, 315);
            this.DepartmentTable.TabIndex = 5;
            // 
            // DepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1361, 624);
            this.Controls.Add(this.DepartmentTable);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblDepartmentDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentDetails";
            this.Load += new System.EventHandler(this.DepartmentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDepartmentDetails;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DepartmentTable;
    }
}