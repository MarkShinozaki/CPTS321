// <copyright file="InternalTransfer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// Represents a form for performing internal transfers between a client's accounts.
    /// </summary>
    public class InternalTransferForm : Form
    {
        private Button btnInternalTransfer;
        // UI Controls Declaration 
        private ComboBox cmbFromAccount;
        private ComboBox cmbToAccount;
        private TextBox txtTransferAmount;
        private Button btnTransfer;
        private Label lblFromAccountBalance;
        private Label lblToAccountBalance;

        public InternalTransferLogic transferLogic;
        private readonly string clientNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTransferForm"/> class.
        /// </summary>
        /// <param name="clientNumber">The client number for whom the transfer is being made.</param>
        public InternalTransferForm(string clientNumber)
        {
            this.clientNumber = clientNumber;
            InitializeComponent();
            string xmlFilePath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml";
            transferLogic = new InternalTransferLogic(xmlFilePath);
            //ShowAccountBalances();
        }

        /// <summary>
        /// Sets up the form's user interface components.
        /// </summary>
        public void InitializeComponent()
        {
            /// <summary>
            /// Sets up and configures form controls.
            /// </summary>
            // Form setup
            this.Text = "Internal Transfer";
            this.Size = new System.Drawing.Size(500, 350);
            this.BackColor = System.Drawing.Color.Beige;

            Label lblDollarSign = new Label
            {
                Text = "$",
                Location = new System.Drawing.Point(80, 130),
                Size = new System.Drawing.Size(20, 20),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };

            Label lblFrom = new Label
            {
                Text = "From:",
                Location = new System.Drawing.Point(10, 50), // Adjust the location as needed
                Size = new System.Drawing.Size(40, 20),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };
            // From Account Dropdown
            cmbFromAccount = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(300, 20)
            };
            // Populate with account options
            cmbFromAccount.Items.Add("Checking");
            cmbFromAccount.Items.Add("Savings");
            cmbFromAccount.SelectedIndex = 0;


            // To Label
            Label lblTo = new Label
            {
                Text = "To:",
                Location = new System.Drawing.Point(10, 90), // Adjust the location as needed
                Size = new System.Drawing.Size(40, 20),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };
            // To Account Dropdown
            cmbToAccount = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(50, 90),
                Size = new System.Drawing.Size(300, 20)
            };
            // Populate with account options
            cmbToAccount.Items.Add("Checking");
            cmbToAccount.Items.Add("Savings");
            cmbToAccount.SelectedIndex = 1;

            // Transfer Amount TextBox
            txtTransferAmount = new TextBox
            {
                Location = new System.Drawing.Point(50, 130),
                Size = new System.Drawing.Size(300, 20)
            };

            // Transfer Button
            btnTransfer = new Button
            {
                Text = "Transfer",
                Location = new System.Drawing.Point(50, 170),
                Size = new System.Drawing.Size(300, 30)
            };
            btnTransfer.Click += new EventHandler(BtnTransfer_Click);

            lblFromAccountBalance = new Label
            {
                Location = new System.Drawing.Point(360, 50),
                Size = new System.Drawing.Size(100, 20),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };

            // To Account Balance Label
            lblToAccountBalance = new Label
            {
                Location = new System.Drawing.Point(360, 90),
                Size = new System.Drawing.Size(100, 20),
                TextAlign = System.Drawing.ContentAlignment.MiddleRight
            };
            // Adjust the positions and sizes of the controls for a better layout
            cmbFromAccount.Location = new System.Drawing.Point(100, 50);
            cmbToAccount.Location = new System.Drawing.Point(100, 90);
            txtTransferAmount.Location = new System.Drawing.Point(100, 130);
            btnTransfer.Location = new System.Drawing.Point(100, 170);
            lblFromAccountBalance.Location = new System.Drawing.Point(350, 50);
            lblToAccountBalance.Location = new System.Drawing.Point(350, 90);

            // Add controls to the form
            Controls.Add(cmbFromAccount);
            Controls.Add(cmbToAccount);
            Controls.Add(txtTransferAmount);
            Controls.Add(btnTransfer);
            Controls.Add(lblFromAccountBalance);
            Controls.Add(lblToAccountBalance);
            Controls.Add(lblFrom);
            Controls.Add(lblTo);
            Controls.Add(lblDollarSign);
        }

        /// <summary>
        /// Handles the transfer button click event to perform the internal transfer.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            string fromAccount = cmbFromAccount.SelectedItem.ToString();
            string toAccount = cmbToAccount.SelectedItem.ToString();

            if (fromAccount == toAccount)
            {
                MessageBox.Show("Cannot transfer within the same account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(txtTransferAmount.Text, out decimal amount) && amount > 0)
            {
                bool success = transferLogic.PerformInternalTransfer(clientNumber, fromAccount, toAccount, amount);
                if (success)
                {
                    MessageBox.Show("Transfer successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transfer failed. Please check the amounts and accounts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}