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
    public partial class AddTeacher : Form
    {

        string connectionString = "Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True";
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TEACHER", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                TeacherTable.DataSource = dataTable;
                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error While Loading Data");
            }

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                if (TxtTeacherName.TextLength > 0 && TxtMobNumber.TextLength > 0 && TxtAddress.TextLength > 0 && TxtEmail.TextLength > 0)
                {
                    string query = "INSERT INTO TEACHER(tname, tgender, tdob, tphone, taddress, temail, tdepartment)VALUES(@tname,@tgender,@tdob,@tphone,@taddress,@temail,@tdepartment)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@tname", TxtTeacherName.Text);
                    sqlCommand.Parameters.AddWithValue("@tgender", ComboGender.Text);
                    sqlCommand.Parameters.AddWithValue("@tdob", PickerDateTime.Value.Date);
                    sqlCommand.Parameters.AddWithValue("@tphone", TxtMobNumber.Text);
                    sqlCommand.Parameters.AddWithValue("@taddress", TxtAddress.Text);
                    sqlCommand.Parameters.AddWithValue("@temail", TxtEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@tdepartment", ComboDepartment.Text);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TEACHER", sqlConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    TeacherTable.DataSource = dataTable;

                    MessageBox.Show("Teacher Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                    TxtTeacherName.Text = "";
                    TxtMobNumber.Text = "";
                    TxtAddress.Text = "";
                    TxtEmail.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Fill All Empty Field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Error Occur When Adding Teacher","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
