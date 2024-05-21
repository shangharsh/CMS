namespace CMS
{
    partial class TeacherDetails
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
            this.LblTeacherDetails = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TeacherTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTeacherDetails
            // 
            this.LblTeacherDetails.AutoSize = true;
            this.LblTeacherDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTeacherDetails.Location = new System.Drawing.Point(634, 129);
            this.LblTeacherDetails.Name = "LblTeacherDetails";
            this.LblTeacherDetails.Size = new System.Drawing.Size(197, 30);
            this.LblTeacherDetails.TabIndex = 1;
            this.LblTeacherDetails.Text = "Teacher Details";
            this.LblTeacherDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(1285, 23);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 44);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TeacherTable
            // 
            this.TeacherTable.AllowUserToAddRows = false;
            this.TeacherTable.AllowUserToDeleteRows = false;
            this.TeacherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherTable.Location = new System.Drawing.Point(20, 190);
            this.TeacherTable.Name = "TeacherTable";
            this.TeacherTable.ReadOnly = true;
            this.TeacherTable.RowHeadersWidth = 62;
            this.TeacherTable.RowTemplate.Height = 28;
            this.TeacherTable.Size = new System.Drawing.Size(1309, 411);
            this.TeacherTable.TabIndex = 5;
            // 
            // TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1356, 624);
            this.Controls.Add(this.TeacherTable);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblTeacherDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherDetails";
            this.Load += new System.EventHandler(this.TeacherDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTeacherDetails;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView TeacherTable;
    }
}