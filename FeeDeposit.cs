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
        }

        void ShowData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT fid as Fee_Id, sname as Student_Name, semail as Student_Email, sdepartment as Department, dop as Date_of_Payment, payment as Amount FROM FEE", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            PaymentTable.DataSource = dataTable;

            SqlCommand sqlCommand = new SqlCommand("SELECT department FROM DEPARTMENT", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ComboDepartment.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();

        }

        private void FeeDeposit_Load(object sender, EventArgs e)
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
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "INSERT INTO FEE(sname, semail, sdepartment, dop, payment)VALUES(@sname, @semail, @sdepartment, @dop, @payment)";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@sname", TxtStdName.Text);
                        sqlCommand.Parameters.AddWithValue("@semail", TxtEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@sdepartment", ComboDepartment.Text);
                        sqlCommand.Parameters.AddWithValue("@dop", PickerPaymentDate.Value.Date);
                        sqlCommand.Parameters.AddWithValue("@payment", TxtSemFee.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Fee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlConnection.Close();
                        TxtStdName.Text = "";
                        TxtEmail.Text = "";
                        TxtSemFee.Text = "";
                        sqlConnection.Close();
                    }
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
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "UPDATE FEE SET sname=@sname, semail=@semail, sdepartment=@sdepartment, dop=@dop, payment=@payment WHERE fid=@fid";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@fid", TxtId.Text);
                        sqlCommand.Parameters.AddWithValue("@sname", TxtStdName.Text);
                        sqlCommand.Parameters.AddWithValue("@semail", TxtEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@sdepartment", ComboDepartment.Text);
                        sqlCommand.Parameters.AddWithValue("@dop", PickerPaymentDate.Value.Date);
                        sqlCommand.Parameters.AddWithValue("@payment", TxtSemFee.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Student Payment Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
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
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "DELETE FROM FEE WHERE fid=@fid";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@fid", TxtId.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Student Fee Details Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
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
