using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Fritz
{
    public partial class RegisterForm : Form
    {
        // Connection string to Access Database
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Documents\FritzDb1.accdb;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Input validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE [Username] = ?";
                    using (OleDbCommand checkCommand = new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("?", username);
                        int userCount = (int)checkCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("This username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert the new user into the database
                    string insertQuery = "INSERT INTO Users ([Username], [Password], [Email]) VALUES (?, ?, ?)";
                    using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("?", username); // Matches Text type
                        insertCommand.Parameters.AddWithValue("?", password); // Matches Text type
                        insertCommand.Parameters.AddWithValue("?", email);    // Matches Text type

                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form fields
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtEmail.Text = "";

                    // Navigate back to login form
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            // Navigate to Login Form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}