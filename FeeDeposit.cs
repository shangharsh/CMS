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
    public partial class FeeDeposit : Form
    {
        string connectionString = "Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True";
        public FeeDeposit()
        {
            InitializeComponent();
        }

        private void FeeDeposit_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM FEE", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                PaymentTable.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error While Loading Data.");
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
                sqlConnection.Open();
                if (TxtStdName.TextLength>0 && TxtEmail.TextLength>0 && TxtSemFee.TextLength>0)
                {
                    string query = "INSERT INTO FEE(sname, semail, sdepartment, dop, payment)VALUES(@sname, @semail, @sdepartment, @dop, @payment)";
                    SqlCommand  sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@sname", TxtStdName.Text);
                    sqlCommand.Parameters.AddWithValue("@semail", TxtEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@sdepartment", ComboDepartment.Text);
                    sqlCommand.Parameters.AddWithValue("@dop", PickerPaymentDate.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@payment", TxtSemFee.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM FEE", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    PaymentTable.DataSource = dataTable;

                    MessageBox.Show("Fee Added Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                    TxtStdName.Text = "";
                    TxtEmail.Text = "";
                    TxtSemFee.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Fill All Field", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
