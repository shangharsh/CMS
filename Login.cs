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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=SHANGHARSH\\SQLEXPRESS; Initial Catalog = CIS; Integrated Security = True; TrustServerCertificate = True");
                sqlConnection.Open();
                if (TxtUsername.TextLength > 0 && TxtPassword.TextLength > 0)
                {
                    string query = "Select * from USERS WHERE USERNAME = @username AND PASSWORD = @password";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@username", TxtUsername.Text);
                    sqlCommand.Parameters.AddWithValue("@password", TxtPassword.Text);

                    int count = (int)sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                    if (count > 0)
                    {
                        Dashboard dashboard = new Dashboard()
                        {
                            username = TxtUsername.Text
                        };

                        dashboard.Show();
                        this.Close();
                        MessageBox.Show("Login Success", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                else
                {
                    MessageBox.Show("Please enter Username and Password.", "Attention!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Failed");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckShow_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = CheckShow.Checked ? '\0' :'*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar =  '*';
        }
    }
}
