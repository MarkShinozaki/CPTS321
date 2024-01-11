// <copyright file="ExterternalTransfer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Represents a form for performing external transfers to other accounts.
    /// </summary>
    public class ExternalTransferForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtAccountNumber;
        private TextBox txtAmount;
        private Button btnTransfer;
        private Label lblStatus;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTransferForm"/> class.
        /// </summary>
        public ExternalTransferForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up the form's user interface components.
        /// </summary>
        private void InitializeComponent()
        {
            /// <summary>
            /// Sets up and configures form controls.
            /// </summary>
            this.Text = "External Transfer";
            this.Size = new System.Drawing.Size(400, 300); // Increased form size
            this.BackColor = System.Drawing.Color.Beige; // Set a background color

            // Header Label
            Label lblHeader = new Label
            {
                Text = "External Transfer",
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(50, 20), // Adjusted position
                Size = new System.Drawing.Size(300, 30) // Adjusted size
            };

            // Username Label and TextBox
            Label lblUsername = new Label { Text = "Username:", Location = new System.Drawing.Point(20, 70), Width = 100 };
            txtUsername = new TextBox { Location = new System.Drawing.Point(130, 70), Width = 200 };

            // Account Number Label and TextBox
            Label lblAccountNumber = new Label { Text = "Account Number:", Location = new System.Drawing.Point(20, 110), Width = 100 };
            txtAccountNumber = new TextBox { Location = new System.Drawing.Point(130, 110), Width = 200 };

            // Amount Label and TextBox
            Label lblAmount = new Label { Text = "Amount:", Location = new System.Drawing.Point(20, 150), Width = 100 };
            txtAmount = new TextBox { Location = new System.Drawing.Point(130, 150), Width = 200 };

            // Transfer Button
            btnTransfer = new Button { Text = "Transfer", Location = new System.Drawing.Point(130, 190), Size = new System.Drawing.Size(100, 30) };

            // Status Label
            lblStatus = new Label { Location = new System.Drawing.Point(20, 230), Width = 360, Height = 40 };

            btnTransfer.Click += BtnTransfer_Click;

            // Add controls to the form
            Controls.Add(lblHeader);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblAccountNumber);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(btnTransfer);
            Controls.Add(lblStatus);
        }

        /// <summary>
        /// Handles the transfer button click event to perform the external transfer.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string accountNumber = txtAccountNumber.Text;

            // Clear previous status message
            lblStatus.Text = "";

            // Validate the amount entered
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                if (amount <= 0)
                {
                    lblStatus.Text = "Please enter a positive amount.";
                    return;
                }

                string clientFilePath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml";
                string transferFilePath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Transfers.xml";

                // Create an instance of ExternalTransferService
                ExternalTransferService transferService = new ExternalTransferService();

                // Call the instance method
                string result = transferService.PerformTransfer(username, accountNumber, amount, clientFilePath, transferFilePath);
                lblStatus.Text = result;
            }
            else
            {
                lblStatus.Text = "Please enter a valid amount.";
            }
        }

    }
}