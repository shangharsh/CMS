namespace CMS
{
    partial class Dashboard
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
            this.BtnDepartment = new System.Windows.Forms.Button();
            this.LblUsername = new System.Windows.Forms.Label();
            this.BtnFee = new System.Windows.Forms.Button();
            this.BtnStudent = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.PanelStdCount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PBStudent = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelDepartCount = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PBDepartment = new System.Windows.Forms.PictureBox();
            this.PanelTeachCount = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PBTeacher = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelFeeTotal = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PBFeeCollect = new System.Windows.Forms.PictureBox();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel1.SuspendLayout();
            this.PanelStdCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBStudent)).BeginInit();
            this.PanelDepartCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDepartment)).BeginInit();
            this.PanelTeachCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTeacher)).BeginInit();
            this.PanelFeeTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFeeCollect)).BeginInit();
            this.PanelDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.AutoSize = true;
            this.BtnDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDepartment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnDepartment.Image = global::CMS.Properties.Resources.department;
            this.BtnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDepartment.Location = new System.Drawing.Point(996, 23);
            this.BtnDepartment.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.BtnDepartment.Size = new System.Drawing.Size(252, 80);
            this.BtnDepartment.TabIndex = 5;
            this.BtnDepartment.Text = "Departments";
            this.BtnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDepartment.UseVisualStyleBackColor = false;
            this.BtnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(990, 53);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(0, 20);
            this.LblUsername.TabIndex = 3;
            // 
            // BtnFee
            // 
            this.BtnFee.AutoSize = true;
            this.BtnFee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFee.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnFee.Image = global::CMS.Properties.Resources.feesDeposit;
            this.BtnFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFee.Location = new System.Drawing.Point(719, 23);
            this.BtnFee.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnFee.Name = "BtnFee";
            this.BtnFee.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.BtnFee.Size = new System.Drawing.Size(248, 80);
            this.BtnFee.TabIndex = 4;
            this.BtnFee.Text = "Fees Deposit";
            this.BtnFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFee.UseVisualStyleBackColor = false;
            this.BtnFee.Click += new System.EventHandler(this.BtnFee_Click);
            // 
            // BtnStudent
            // 
            this.BtnStudent.AutoSize = true;
            this.BtnStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudent.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnStudent.Image = global::CMS.Properties.Resources.students;
            this.BtnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudent.Location = new System.Drawing.Point(497, 23);
            this.BtnStudent.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.BtnStudent.Size = new System.Drawing.Size(199, 80);
            this.BtnStudent.TabIndex = 3;
            this.BtnStudent.Text = "Students";
            this.BtnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStudent.UseVisualStyleBackColor = false;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.AutoSize = true;
            this.BtnTeacher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeacher.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnTeacher.Image = global::CMS.Properties.Resources.teacher;
            this.BtnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTeacher.Location = new System.Drawing.Point(271, 23);
            this.BtnTeacher.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.BtnTeacher.Size = new System.Drawing.Size(203, 80);
            this.BtnTeacher.TabIndex = 2;
            this.BtnTeacher.Text = "Teachers";
            this.BtnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTeacher.UseVisualStyleBackColor = false;
            this.BtnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtnDashboard.Image = global::CMS.Properties.Resources.dashboard;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(23, 23);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.BtnDashboard.Size = new System.Drawing.Size(225, 80);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FlowLayoutPanel1.Controls.Add(this.BtnDashboard);
            this.FlowLayoutPanel1.Controls.Add(this.BtnTeacher);
            this.FlowLayoutPanel1.Controls.Add(this.BtnStudent);
            this.FlowLayoutPanel1.Controls.Add(this.BtnFee);
            this.FlowLayoutPanel1.Controls.Add(this.LblUsername);
            this.FlowLayoutPanel1.Controls.Add(this.BtnDepartment);
            this.FlowLayoutPanel1.Controls.Add(this.BtnLogout);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(1673, 126);
            this.FlowLayoutPanel1.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.AutoSize = true;
            this.BtnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Image = global::CMS.Properties.Resources.logout;
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.Location = new System.Drawing.Point(1271, 23);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(7, 20, 7, 20);
            this.BtnLogout.Size = new System.Drawing.Size(252, 80);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PanelStdCount
            // 
            this.PanelStdCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelStdCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelStdCount.Controls.Add(this.label2);
            this.PanelStdCount.Controls.Add(this.PBStudent);
            this.PanelStdCount.Controls.Add(this.Label1);
            this.PanelStdCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelStdCount.Location = new System.Drawing.Point(199, 126);
            this.PanelStdCount.Name = "PanelStdCount";
            this.PanelStdCount.Size = new System.Drawing.Size(252, 249);
            this.PanelStdCount.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(97, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "1000";
            // 
            // PBStudent
            // 
            this.PBStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBStudent.Image = global::CMS.Properties.Resources.students_2643463;
            this.PBStudent.Location = new System.Drawing.Point(45, 55);
            this.PBStudent.Name = "PBStudent";
            this.PBStudent.Size = new System.Drawing.Size(158, 143);
            this.PBStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBStudent.TabIndex = 1;
            this.PBStudent.TabStop = false;
            this.PBStudent.Click += new System.EventHandler(this.PBStudent_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LimeGreen;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(252, 46);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Students";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDepartCount
            // 
            this.PanelDepartCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelDepartCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelDepartCount.Controls.Add(this.label5);
            this.PanelDepartCount.Controls.Add(this.label6);
            this.PanelDepartCount.Controls.Add(this.PBDepartment);
            this.PanelDepartCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelDepartCount.Location = new System.Drawing.Point(880, 126);
            this.PanelDepartCount.Name = "PanelDepartCount";
            this.PanelDepartCount.Size = new System.Drawing.Size(252, 249);
            this.PanelDepartCount.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LimeGreen;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Departments";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(109, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "4";
            // 
            // PBDepartment
            // 
            this.PBDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBDepartment.Image = global::CMS.Properties.Resources.building_1158534;
            this.PBDepartment.Location = new System.Drawing.Point(45, 55);
            this.PBDepartment.Name = "PBDepartment";
            this.PBDepartment.Size = new System.Drawing.Size(158, 143);
            this.PBDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBDepartment.TabIndex = 1;
            this.PBDepartment.TabStop = false;
            this.PBDepartment.Click += new System.EventHandler(this.PBDepartment_Click);
            // 
            // PanelTeachCount
            // 
            this.PanelTeachCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelTeachCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelTeachCount.Controls.Add(this.label4);
            this.PanelTeachCount.Controls.Add(this.PBTeacher);
            this.PanelTeachCount.Controls.Add(this.label3);
            this.PanelTeachCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelTeachCount.Location = new System.Drawing.Point(539, 126);
            this.PanelTeachCount.Name = "PanelTeachCount";
            this.PanelTeachCount.Size = new System.Drawing.Size(252, 249);
            this.PanelTeachCount.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(97, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "100";
            // 
            // PBTeacher
            // 
            this.PBTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBTeacher.Image = global::CMS.Properties.Resources.teacher_4345051;
            this.PBTeacher.Location = new System.Drawing.Point(45, 55);
            this.PBTeacher.Name = "PBTeacher";
            this.PBTeacher.Size = new System.Drawing.Size(158, 143);
            this.PBTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBTeacher.TabIndex = 1;
            this.PBTeacher.TabStop = false;
            this.PBTeacher.Click += new System.EventHandler(this.PBTeacher_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teachers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFeeTotal
            // 
            this.PanelFeeTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelFeeTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelFeeTotal.Controls.Add(this.label7);
            this.PanelFeeTotal.Controls.Add(this.label8);
            this.PanelFeeTotal.Controls.Add(this.PBFeeCollect);
            this.PanelFeeTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelFeeTotal.Location = new System.Drawing.Point(1213, 126);
            this.PanelFeeTotal.Name = "PanelFeeTotal";
            this.PanelFeeTotal.Size = new System.Drawing.Size(252, 249);
            this.PanelFeeTotal.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LimeGreen;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fee Collected";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(97, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "100000";
            // 
            // PBFeeCollect
            // 
            this.PBFeeCollect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBFeeCollect.Image = global::CMS.Properties.Resources.feesDeposit1;
            this.PBFeeCollect.Location = new System.Drawing.Point(45, 55);
            this.PBFeeCollect.Name = "PBFeeCollect";
            this.PBFeeCollect.Size = new System.Drawing.Size(158, 143);
            this.PBFeeCollect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFeeCollect.TabIndex = 1;
            this.PBFeeCollect.TabStop = false;
            this.PBFeeCollect.Click += new System.EventHandler(this.PBFeeCollect_Click);
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PanelDashboard.Controls.Add(this.PanelFeeTotal);
            this.PanelDashboard.Controls.Add(this.PanelTeachCount);
            this.PanelDashboard.Controls.Add(this.PanelDepartCount);
            this.PanelDashboard.Controls.Add(this.PanelStdCount);
            this.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDashboard.Location = new System.Drawing.Point(0, 126);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(1673, 623);
            this.PanelDashboard.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1673, 749);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.FlowLayoutPanel1.PerformLayout();
            this.PanelStdCount.ResumeLayout(false);
            this.PanelStdCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBStudent)).EndInit();
            this.PanelDepartCount.ResumeLayout(false);
            this.PanelDepartCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDepartment)).EndInit();
            this.PanelTeachCount.ResumeLayout(false);
            this.PanelTeachCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTeacher)).EndInit();
            this.PanelFeeTotal.ResumeLayout(false);
            this.PanelFeeTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFeeCollect)).EndInit();
            this.PanelDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDepartment;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button BtnFee;
        private System.Windows.Forms.Button BtnStudent;
        private System.Windows.Forms.Button BtnTeacher;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        private System.Windows.Forms.Panel PanelStdCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PBStudent;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel PanelDepartCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PBDepartment;
        private System.Windows.Forms.Panel PanelTeachCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelFeeTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PBFeeCollect;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.Button BtnLogout;
    }
}

