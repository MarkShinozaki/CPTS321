// <copyright file="ClientVal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Represents the main form for administrative actions within the banking application.
    /// </summary>
    public partial class AdminForm : Form
    {
        private string adminName;
        private Button btnManageTransfers;
        private Button btnAccountOverview;
        private Button btnRemoveUser;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminForm"/> class.
        /// </summary>
        /// <param name="adminName">Name of the admin.</param>
        public AdminForm(string adminName)
        {
            this.adminName = adminName;
            InitializeComponent();
        }

        /// <summary>
        /// Sets up the form layout, control elements, and event handlers.
        /// </summary>
        private void InitializeComponent()
        {
            this.Size = new System.Drawing.Size(300, 300); // Adjust the size as needed
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.BackColor = Color.LightBlue;

            // Manage Transfers Button
            btnManageTransfers = new Button
            {
                Text = "Manage Transfers",
                Location = new Point(50, 20),
                Size = new Size(200, 30)
            };
            btnManageTransfers.Click += BtnManageTransfers_Click;

            // Account Overview Button
            btnAccountOverview = new Button
            {
                Text = "Account Overview",
                Location = new Point(50, btnManageTransfers.Bottom + 10),
                Size = new Size(200, 30)
            };
            btnAccountOverview.Click += BtnAccountOverview_Click;

            // Remove User Button
            btnRemoveUser = new Button
            {
                Text = "Remove User",
                Location = new Point(50, btnAccountOverview.Bottom + 10),
                Size = new Size(200, 30)
            };
            btnRemoveUser.Click += BtnRemoveUser_Click;

            // Adding buttons to the form
            this.Controls.Add(btnManageTransfers);
            this.Controls.Add(btnAccountOverview);
            this.Controls.Add(btnRemoveUser);
        }

        /// <summary>
        /// Handles the click event of the Manage Transfers button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnManageTransfers_Click(object sender, EventArgs e)
        {
            AdminManageTransfers manageTransfersForm = new AdminManageTransfers();
            manageTransfersForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the Account Overview button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnAccountOverview_Click(object sender, EventArgs e)
        {
            AdminAccountOverview accountOverviewForm = new AdminAccountOverview();
            accountOverviewForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the Remove User button.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            AdminRemoveUser removeUserForm = new AdminRemoveUser();
            removeUserForm.ShowDialog();
        }
    }
}
