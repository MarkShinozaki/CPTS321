// <copyright file="Formq.Designer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security.Principal;
    using System.Text;
    using System.Threading.Tasks;
    using System.Transactions;
    using System.Windows.Forms;

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLoginInformation;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Welcome Header
            this.lblWelcome = new Label();
            this.lblWelcome.Text = "Welcome to the Banking App";
            this.lblWelcome.Location = new Point(centerX - 100, 20);
            this.lblWelcome.Size = new Size(200, 20);

            // Login Information Label
            this.lblLoginInformation = new Label();
            this.lblLoginInformation.Text = "Login Information";
            this.lblLoginInformation.Location = new Point(centerX - 100, 50);
            this.lblLoginInformation.Size = new Size(200, 20);


            // Login Button
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogin.Text = "Login";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.Location = new System.Drawing.Point(centerX - this.btnLogin.Size.Width / 2, centerY - this.btnLogin.Size.Height - 5);
            this.btnLogin.Visible = true;

            // Create Account Button
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.Size = new System.Drawing.Size(120, 30);
            this.btnCreateAccount.Location = new System.Drawing.Point(centerX - this.btnCreateAccount.Size.Width / 2, btnLogin.Bottom + 10);
            this.btnCreateAccount.Visible = true;

            // Username Label
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(centerX - 150, centerY - 60);
            this.lblUsername.Size = new System.Drawing.Size(70, 20);
            this.lblUsername.Visible = false;

            // Username Entry TextBox
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.usernameEntry.Location = new System.Drawing.Point(centerX - 150, centerY - 40);
            this.usernameEntry.Size = new System.Drawing.Size(200, 20);
            this.usernameEntry.Visible = false;

            // Password Label
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(centerX - 150, centerY - 15);
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.Visible = false;

            // Password Entry TextBox
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry.Location = new System.Drawing.Point(centerX - 150, centerY + 5);
            this.passwordEntry.Size = new System.Drawing.Size(200, 20);
            this.passwordEntry.PasswordChar = '*';
            this.passwordEntry.Visible = false;


            // Admin Login Button
            this.btnAdminLogin = new Button();
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.Size = new Size(120, 30);
            this.btnAdminLogin.Location = new Point(centerX - this.btnAdminLogin.Size.Width / 2, btnCreateAccount.Bottom + 10);
            // this.btnAdminLogin.Click += new EventHandler(this.BtnAdminLogin_Click); // Attach event handler                                                                                 



            // Adding controls to the form
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblLoginInformation);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.usernameEntry);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.btnAdminLogin);

            // Form initialization
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500); // Adjust form size as needed
            this.Name = "CPTS321 - Banking Application";
            this.Text = "Login Form";

        }

        #endregion
    }
}