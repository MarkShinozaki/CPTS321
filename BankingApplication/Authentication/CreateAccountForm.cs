// <copyright file="CreateAccountForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System.Windows.Forms;

    /// <summary>
    /// Form for creating a new account.
    /// </summary>
    public partial class CreateAccountForm : Form
    {
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnCreate;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountForm"/> class.
        /// </summary>
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the form's components.
        /// </summary>
        private void InitializeComponent()
        {
            // Form setup
            this.Size = new System.Drawing.Size(400, 300);
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            this.BackColor = System.Drawing.Color.Beige;

            // Initialize controls for username
            lblUsername = new Label
            {
                Text = "Username:",
                Location = new System.Drawing.Point(centerX - 100, centerY - 70),
                AutoSize = true
            };

            txtUsername = new TextBox
            {
                Location = new System.Drawing.Point(centerX - 100, centerY - 45),
                Size = new System.Drawing.Size(200, 25)
            };

            // Initialize controls for password
            lblPassword = new Label
            {
                Text = "Password:",
                Location = new System.Drawing.Point(centerX - 100, centerY - 10),
                AutoSize = true
            };

            txtPassword = new TextBox
            {
                Location = new System.Drawing.Point(centerX - 100, centerY + 15),
                Size = new System.Drawing.Size(200, 25),
                PasswordChar = '*'
            };

            // Create Account Button
            btnCreate = new Button
            {
                Text = "Create Account",
                Location = new System.Drawing.Point(centerX - 50, centerY + 50),
                Size = new System.Drawing.Size(120, 30)
            };
            btnCreate.Click += new EventHandler(BtnCreate_Click);

            // Add controls to the form
            Controls.AddRange(new Control[] { lblUsername, txtUsername, lblPassword, txtPassword, btnCreate });
        }

        /// <summary>
        /// Event handler for the Create Account button click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text; // Consider hashing the password for security.

            // Attempt to create a new client account using the provided credentials.
            if (NewClientToSystem.CreateClientAccount(username, password, out string clientNumber, out string checkingAccountNumber, out string savingsAccountNumber, out double totalBalance, DateTime.Now))
            {
                MessageBox.Show($"Account created successfully.\nClient Number: {clientNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Optionally close the form after successful account creation.
            }
            else
            {
                MessageBox.Show("Account creation failed. The username might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
