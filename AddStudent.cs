using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class AddStudent : Form
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
        public AddStudent()
        {
            InitializeComponent();
            sqlConnection.Open();

        }

        void Btnvisibility()
        {
            if(TxtId.TextLength == 0)
            {
                BtnSave.Enabled = true;
                BtnUpdate.Enabled = false;
            }
            else if(TxtId.TextLength != 0)
            {
                BtnSave.Enabled = false;
                BtnUpdate.Enabled = true;
            }
        }

        void Reset()
        {
            TxtId.Clear();
            TxtStdName.Clear();
            TxtStdAddress.Clear();
            TxtStdEmail.Clear();
            TxtStdNum.Clear();
            TxtStdName.Focus();
            Btnvisibility();
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            try 
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM STUDENT", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                StudentTable.DataSource = dataTable;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Btnvisibility();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtStdAddress.TextLength>0 && TxtStdName.TextLength>0 && TxtStdEmail.TextLength>0 && TxtStdNum.TextLength>0)
                {
                    string query = "INSERT INTO STUDENT(sname, sgender, sdob, sphone, semail, sdepartment, saddress)VALUES(@sname, @sgender, @sdob, @sphone, @semail, @sdepartment, @saddress)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@sname", TxtStdName.Text);
                    sqlCommand.Parameters.AddWithValue("@sgender", ComboStdGender.Text);
                    sqlCommand.Parameters.AddWithValue("@sdob", PickerStdDateTime.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@sphone", TxtStdNum.Text);
                    sqlCommand.Parameters.AddWithValue("@semail", TxtStdEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@sdepartment", ComboStdDepartment.Text);
                    sqlCommand.Parameters.AddWithValue("@saddress", TxtStdAddress.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM STUDENT", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    StudentTable.DataSource = dataTable;

                    MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                    TxtStdName.Text = "";
                    TxtStdEmail.Text = "";
                    TxtStdNum.Text = "";
                    TxtStdAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Fill All Field.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void StudentTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow studentTable = StudentTable.Rows[e.RowIndex];
                TxtId.Text = studentTable.Cells[0].Value.ToString();
                TxtStdName.Text = studentTable.Cells[1].Value.ToString();
                ComboStdGender.Text = studentTable.Cells[2].Value.ToString();
                PickerStdDateTime.Text = studentTable.Cells[3].Value.ToString();
                TxtStdNum.Text = studentTable.Cells[4].Value.ToString();
                TxtStdEmail.Text = studentTable.Cells[5].Value.ToString();
                ComboStdDepartment.Text = studentTable.Cells[6].Value.ToString();
                TxtStdAddress.Text = studentTable.Cells[7].Value.ToString();
            }
            Btnvisibility();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtId.TextLength > 0 && TxtStdName.TextLength > 0 && TxtStdNum.TextLength > 0 && TxtStdEmail.TextLength > 0 && TxtStdAddress.TextLength > 0)
                {
                    string query = "UPDATE STUDENT SET sname=@sname, sgender=@sgender, sdob=@sdob, sphone=@sphone, semail=@semail, sdepartment=@sdepartment, saddress=@saddress WHERE sid=@sid";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@sid", TxtId.Text);
                    sqlCommand.Parameters.AddWithValue("@sname", TxtStdName.Text);
                    sqlCommand.Parameters.AddWithValue("@sgender", ComboStdGender.Text);
                    sqlCommand.Parameters.AddWithValue("@sdob", PickerStdDateTime.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@sphone", TxtStdNum.Text);
                    sqlCommand.Parameters.AddWithValue("@semail", TxtStdEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@sdepartment", ComboStdDepartment.Text);
                    sqlCommand.Parameters.AddWithValue("@saddress", TxtStdAddress.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM STUDENT", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    StudentTable.DataSource = dataTable;
                    MessageBox.Show("Student Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Please Select The Data From Below Table.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Btnvisibility();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtId.TextLength > 0 && TxtStdName.TextLength > 0 && TxtStdNum.TextLength > 0 && TxtStdEmail.TextLength > 0 && TxtStdAddress.TextLength > 0)
                {
                    string query = "DELETE FROM STUDENT WHERE sid=@sid";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@sid",TxtId.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM STUDENT", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    StudentTable.DataSource = dataTable;
                    MessageBox.Show("Student Updated Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Please Choose The Data From Below Table","Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
