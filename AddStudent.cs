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
        public AddStudent()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
                sqlConnection.Open();
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
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
