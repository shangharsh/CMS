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
        SqlConnection sqlConnection = new SqlConnection("Data Source = SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
        public AddTeacher()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT  tid as Teacher_Id, tname as Name, tgender as Gender, tdob as Date_of_Birth, tphone as Contact_Number, temail as Email, tdepartment as Department , taddress as Address FROM TEACHER", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            TeacherTable.DataSource = dataTable;

            SqlCommand sqlCommand = new SqlCommand("SELECT department FROM DEPARTMENT", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ComboDepartment.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

            BtnVisibility();
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

        }

        void BtnVisibility()
        {
            if (TxtId.TextLength == 0)
            {
                BtnUpdate.Enabled = false;          
                BtnSave.Enabled = true;
            }   
            else if(TxtId.TextLength != 0)
            {
                BtnUpdate.Enabled = true;
                BtnSave.Enabled = false;
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtTeacherName.TextLength > 0 && TxtMobNumber.TextLength > 0 && TxtAddress.TextLength > 0 && TxtEmail.TextLength > 0)
                {
                    if (sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
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

                        ShowData();

                        MessageBox.Show("Teacher Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
                                   
                }
                else
                {
                    MessageBox.Show("Please Fill All Empty Field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            BtnVisibility();

        }

        void Reset()
        {
            TxtTeacherName.Clear();
            TxtEmail.Clear();
            TxtMobNumber.Clear();
            TxtAddress.Clear();
            TxtId.Clear();
            TxtTeacherName.Focus();
            BtnVisibility();
        }

        private void TeacherTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex != -1)   
                    {
                        DataGridViewRow teacherTable = TeacherTable.Rows[e.RowIndex];
                        TxtId.Text = teacherTable.Cells[0].Value.ToString();
                        TxtTeacherName.Text = teacherTable.Cells[1].Value.ToString();
                        ComboGender.Text = teacherTable.Cells[2].Value.ToString();
                        PickerDateTime.Text = teacherTable.Cells[3].Value.ToString();
                        TxtMobNumber.Text= teacherTable.Cells[4].Value.ToString();
                        TxtEmail.Text = teacherTable.Cells[5].Value.ToString();
                        ComboDepartment.Text = teacherTable.Cells[6].Value.ToString();
                        TxtAddress.Text = teacherTable.Cells[7].Value.ToString();  
                    }
                    BtnVisibility();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtId.TextLength > 0 && TxtTeacherName.TextLength > 0 && TxtMobNumber.TextLength > 0 && TxtAddress.TextLength > 0 && TxtEmail.TextLength > 0)
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "UPDATE TEACHER SET tname=@name, tgender=@gender, tdob=@dob, tphone=@phone, temail=@email, tdepartment=@department, taddress=@address WHERE tid = @id";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@id", TxtId.Text);
                        sqlCommand.Parameters.AddWithValue("@name", TxtTeacherName.Text);
                        sqlCommand.Parameters.AddWithValue("@gender", ComboGender.Text);
                        sqlCommand.Parameters.AddWithValue("@dob", PickerDateTime.Value.Date);
                        sqlCommand.Parameters.AddWithValue("@phone", TxtMobNumber.Text);
                        sqlCommand.Parameters.AddWithValue("@email", TxtEmail.Text);
                        sqlCommand.Parameters.AddWithValue("@department", ComboDepartment.Text);
                        sqlCommand.Parameters.AddWithValue("@address", TxtAddress.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Teacher Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Data From Below Table.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BtnVisibility();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtId.TextLength > 0 && TxtTeacherName.TextLength > 0 && TxtMobNumber.TextLength > 0 && TxtAddress.TextLength > 0 && TxtEmail.TextLength > 0)
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                        string query = "DELETE FROM TEACHER WHERE tid=@id";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@id", TxtId.Text);
                        sqlCommand.ExecuteNonQuery();

                        ShowData();

                        MessageBox.Show("Teacher Data Deleted Successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose The Data From Below Table.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
