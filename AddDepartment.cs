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
    public partial class AddDepartment : Form
    {
            SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
        public AddDepartment()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT did as Department_Id, department as Department FROM DEPARTMENT", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            DepartmentTable.DataSource = dataTable;
        }

        private void DepartmentTable_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                ShowData();
                sqlConnection.Close();
                    
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            BtnVisibility();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (TxtDepartment.TextLength>0)
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "INSERT INTO DEPARTMENT(department)VALUES(@department)";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@department", TxtDepartment.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Department Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlConnection.Close();
                        TxtDepartment.Text = "";
                        sqlConnection.Close();
                    }


                    
                    
                }
                else
                {
                    MessageBox.Show("Department Field Cannot Be Empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            Reset();
        }

        void BtnVisibility()
        {
            if (TxtId.TextLength == 0)
            {
                BtnUpdate.Enabled = false;
                BtnSave.Enabled = true;
            }
            else if (TxtId.TextLength != 0)
            {
                BtnUpdate.Enabled = true;
                BtnSave.Enabled = false;
            }
        }

        void Reset()
        {
            TxtId.Clear();
            TxtDepartment.Clear();
            TxtDepartment.Focus();
            BtnVisibility();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtId.TextLength>0 && TxtDepartment.TextLength>0)
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "UPDATE DEPARTMENT SET department=@department WHERE did=@did";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@did", TxtId.Text);
                        sqlCommand.Parameters.AddWithValue("@department", TxtDepartment.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Department Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Anyone Data to Update","Attention",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            Reset();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtId.TextLength > 0 && TxtDepartment.TextLength > 0)
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "DELETE FROM DEPARTMENT WHERE did=@did";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@did", TxtId.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Department Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Select Anyone Data to Delete", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DepartmentTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow departmentTable = DepartmentTable.Rows[e.RowIndex];
                TxtId.Text = departmentTable.Cells[0].Value.ToString();
                TxtDepartment.Text = departmentTable.Cells[1].Value.ToString();
            }
            BtnVisibility();
        }
    }
}
