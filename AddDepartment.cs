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
        string connectionString = "Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True";
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void DepartmentTable_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DEPARTMENT", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                DepartmentTable.DataSource = dataTable;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error While Loading Data.");
            }

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
                sqlConnection.Open();
                if (TxtDepartment.TextLength>0)
                {
                    string query = "INSERT INTO DEPARTMENT(department)VALUES(@department)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@department", TxtDepartment.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM DEPARTMENT", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    DepartmentTable.DataSource = dataTable;

                    MessageBox.Show("Department Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                    TxtDepartment.Text = "";
                }
                else
                {
                    MessageBox.Show("Department Field Cannot Be Empty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
