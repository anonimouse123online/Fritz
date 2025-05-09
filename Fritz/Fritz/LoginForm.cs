using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Fritz
{
    public partial class LoginForm : Form
    {
        // Connection string to the Access database
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\FritzDb1.accdb;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // SQL query to check if the user exists
                    string query = "SELECT * FROM Users WHERE Username = ? AND Password = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("?", username);
                        command.Parameters.AddWithValue("?", password);

                        // Execute the query
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Login successful
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Redirect to QuestionnaireForm
                                QuestionnaireForm questionnaireForm = new QuestionnaireForm();
                                questionnaireForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Login failed
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            // Navigate to the registration form
            RegisterForm registrationForm = new RegisterForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}