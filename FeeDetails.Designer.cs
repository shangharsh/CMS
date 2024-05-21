namespace CMS
{
    partial class FeeDetails
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
            this.LblFeeDetails = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.FeeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFeeDetails
            // 
            this.LblFeeDetails.AutoSize = true;
            this.LblFeeDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFeeDetails.Location = new System.Drawing.Point(628, 140);
            this.LblFeeDetails.Name = "LblFeeDetails";
            this.LblFeeDetails.Size = new System.Drawing.Size(241, 30);
            this.LblFeeDetails.TabIndex = 1;
            this.LblFeeDetails.Text = "Student Fee Details";
            this.LblFeeDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(1293, 21);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 44);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FeeTable
            // 
            this.FeeTable.AllowUserToAddRows = false;
            this.FeeTable.AllowUserToDeleteRows = false;
            this.FeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeeTable.Location = new System.Drawing.Point(28, 187);
            this.FeeTable.Name = "FeeTable";
            this.FeeTable.ReadOnly = true;
            this.FeeTable.RowHeadersWidth = 62;
            this.FeeTable.RowTemplate.Height = 28;
            this.FeeTable.Size = new System.Drawing.Size(1309, 411);
            this.FeeTable.TabIndex = 5;
            // 
            // FeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1361, 624);
            this.Controls.Add(this.FeeTable);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblFeeDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeDetails";
            this.Load += new System.EventHandler(this.FeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFeeDetails;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView FeeTable;
    }
}