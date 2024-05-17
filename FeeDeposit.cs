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
        SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
        public FeeDeposit()
        {
            InitializeComponent();
            sqlConnection.Open();
        }

        private void FeeDeposit_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM FEE", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                PaymentTable.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error While Loading Data.");
            }
            BtnVisibility();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            TxtStdName.Clear();
            TxtEmail.Clear();
            TxtSemFee.Clear();
            TxtStdName.Focus();
            BtnVisibility();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtId.TextLength>0 && TxtStdName.TextLength>0 && TxtEmail.TextLength>0 && TxtSemFee.TextLength>0)
                {
                    string query = "UPDATE FEE SET sname=@sname, semail=@semail, sdepartment=@sdepartment, dop=@dop, payment=@payment WHERE fid=@fid";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@fid", TxtId.Text);
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
                    MessageBox.Show("Student Payment Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Please Select Minimum One Data From Below Table.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtId.TextLength > 0 && TxtStdName.TextLength > 0 && TxtEmail.TextLength > 0 && TxtSemFee.TextLength > 0)
                {
                    string query = "DELETE FROM FEE WHERE fid=@fid";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@fid", TxtId.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM FEE", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    PaymentTable.DataSource = dataTable;
                    MessageBox.Show("Student Fee Details Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Please Choose The Data From Below Table", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void PaymentTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow paymenttable = PaymentTable.Rows[e.RowIndex];
                TxtId.Text = paymenttable.Cells[0].Value.ToString();
                TxtStdName.Text = paymenttable.Cells[1].Value.ToString();
                TxtEmail.Text = paymenttable.Cells[2].Value.ToString();
                ComboDepartment.Text = paymenttable.Cells[3].Value.ToString();
                PickerPaymentDate.Text = paymenttable.Cells[4].Value.ToString();
                TxtSemFee.Text = paymenttable.Cells[5].Value.ToString();
            }
            BtnVisibility();
        }
    }
}
