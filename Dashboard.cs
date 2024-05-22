using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Dashboard : Form
    {
        
        public Login login = new Login();
        public StudentDetails studentDetails = new StudentDetails();
        public TeacherDetails teacherDetails = new TeacherDetails();
        public DepartmentDetails departmentDetails = new DepartmentDetails();
        public FeeDetails feeDetails = new FeeDetails();
        public string username;

        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PanelDashboard.Visible = true;
            PanelDashboard.BringToFront();
            PanelDashboard.Show();
        }

        

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            AddStudent addStudent = new AddStudent();
            FeeDeposit feeDeposit = new FeeDeposit();
            AddDepartment addDepartment = new AddDepartment();
            PanelDashboard.Visible = true;
            PanelDashboard.Show();
            PanelDashboard.BringToFront();
            addTeacher.Close();
            addStudent.Close();
            addDepartment.Close();
            feeDeposit.Close();
        }
        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            //AddTeacher addTeacher = new AddTeacher
            //{
            //   TopLevel = false,
            //   Dock = DockStyle.Fill
            //};
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.TopLevel = false;
            addTeacher.Dock = DockStyle.Fill;
            PanelDashboard.Controls.Add(addTeacher);
            addTeacher.Show();
            addTeacher.BringToFront();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.TopLevel = false;
            addStudent.Dock = DockStyle.Fill;
            PanelDashboard.Controls.Add(addStudent);
            addStudent.BringToFront();
            addStudent.Show();
        }

        private void BtnFee_Click(object sender, EventArgs e)
        {
            FeeDeposit feeDeposit = new FeeDeposit();
            feeDeposit.TopLevel = false;
            feeDeposit.Dock = DockStyle.Fill;
            PanelDashboard.Controls.Add(feeDeposit);
            feeDeposit.BringToFront();
            feeDeposit.Show();
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.TopLevel = false;
            addDepartment.Dock = DockStyle.Fill;
            PanelDashboard.Controls.Add(addDepartment);
            addDepartment.Show();
            addDepartment.BringToFront();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void PBStudent_Click(object sender, EventArgs e)
        {
            studentDetails.Show();
            studentDetails.BringToFront();
            teacherDetails.Hide();
            feeDetails.Hide();
            departmentDetails.Hide();
        }

        private void PBTeacher_Click(object sender, EventArgs e)
        {
            studentDetails.Hide();
            teacherDetails.BringToFront();
            teacherDetails.Show();
            feeDetails.Hide();
            departmentDetails.Hide();
        }

        private void PBDepartment_Click(object sender, EventArgs e)
        {
            studentDetails.Hide();
            teacherDetails.Hide();
            feeDetails.Hide();
            departmentDetails.Show();
            departmentDetails.BringToFront();

        }

        private void PBFeeCollect_Click(object sender, EventArgs e)
        {
            studentDetails.Hide();
            teacherDetails.Hide();
            feeDetails.Show();
            feeDetails.BringToFront();
            departmentDetails.Hide();
        }
    }
}
