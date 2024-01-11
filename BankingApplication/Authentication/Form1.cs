// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Main entry form for the authentication application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// Sets up the form and event handlers for buttons.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Event handler for client login button click
            this.btnLogin.Click += new EventHandler(this.BtnClientLogin_Click);

            // Event handler for create account button click
            this.btnCreateAccount.Click += new EventHandler(this.BtnCreateAccount_Click);

            // Event handler for admin login button click
            this.btnAdminLogin.Click += new EventHandler(this.BtnAdminLogin_Click);
        }

        /// <summary>
        /// Handles the client login button click event.
        /// Opens the client login form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnClientLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("client");
            loginForm.ShowDialog(); // Show the client login form as a modal dialog
        }

        /// <summary>
        /// Handles the admin login button click event.
        /// Opens the admin login form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("admin");
            loginForm.ShowDialog(); // Show the admin login form as a modal dialog
        }

        /// <summary>
        /// Handles the create account button click event.
        /// Opens the create account form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.ShowDialog(); // Show the create account form as a modal dialog
        }
    }
}
