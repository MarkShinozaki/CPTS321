// <copyright file="LoginForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System;
    using BankingEngine;
    using System.Windows.Forms;

    /// <summary>
    /// Represents the login form for both admin and client users.
    /// </summary>
    public partial class LoginForm : Form
    {
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSubmit;
        private string loginType;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        /// <param name="loginType">The type of login (admin/client).</param>
        public LoginForm(string loginType)
        {
            this.loginType = loginType;
            InitializeComponent();
            SetupLoginForm();
        }

        /// <summary>
        /// Initializes the form's components.
        /// </summary>
        private void InitializeComponent()
        {
            // Initialize the form size and center coordinates
            this.Size = new System.Drawing.Size(400, 300);
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Initialize controls
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSubmit = new Button();

            // Username Label
            lblUsername.Text = "Username:";
            lblUsername.Location = new System.Drawing.Point(centerX - 100, centerY - 70); // Adjusted Y-position
            lblUsername.AutoSize = true;

            // Username Entry TextBox
            txtUsername.Location = new System.Drawing.Point(centerX - 100, centerY - 45); // Adjusted Y-position
            txtUsername.Size = new System.Drawing.Size(200, 25);

            // Password label
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(centerX - 100, centerY - 10); // Adjusted Y-position
            lblPassword.AutoSize = true;

            // Password Entry TextBox
            txtPassword.Location = new System.Drawing.Point(centerX - 100, centerY + 15); // Adjusted Y-position
            txtPassword.Size = new System.Drawing.Size(200, 25);
            txtPassword.PasswordChar = '*';

            // Submit Button
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new System.Drawing.Point(centerX - 50, centerY + 50); // Adjusted Y-position
            btnSubmit.Size = new System.Drawing.Size(100, 30);
            btnSubmit.Click += new EventHandler(BtnSubmit_Click);

            // Add controls to the form
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSubmit);

            // Set form background color
        }

        /// <summary>
        /// Sets up additional properties for the login form.
        /// </summary>
        private void SetupLoginForm()
        {
            this.Text = $"{loginType} Login";
            this.BackColor = Color.Beige;
        }

        /// <summary>
        /// Handles the submit button click event for login.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (loginType == "client")
                {
                    var (isAuthenticated, role, clientNumber) = ClientVal.ClientCheck(username, password);
                    if (isAuthenticated && role == "client")
                    {
                        ClientView clientViewForm = new ClientView(username, clientNumber);
                        clientViewForm.Show(); // Show the client dashboard
                        MessageBox.Show($"Welcome {username}, Client Number: {clientNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close the login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid client credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close(); // Close the login form
                    }
                }
                else if (loginType == "admin")
                {
                    var (isAuthenticated, role, adminNumber) = AdminVal.AdminCheck(username, password); // Role and client number are not used for admins
                    if (isAuthenticated && loginType == "admin")
                    {
                        AdminForm adminViewForm = new AdminForm(username);
                        adminViewForm.Show();
                        this.Close();  // Close the login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close(); // Close the login form
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Close the login form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the login form
            }
        }
    }
}
