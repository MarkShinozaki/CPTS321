// <copyright file="ClientView.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Windows.Forms;
    using System.Xml;
    using static System.Windows.Forms.AxHost;

    /// <summary>
    /// Represents the client view form in the banking application, allowing clients to interact with their accounts.
    /// </summary>
    public partial class ClientView : Form
    {
        private string clientNumber;
        private string clientName; // Variable to store client's name
        private Label lblClientNumber;
        private Label lblWelcome; // Label for the welcome message
        private Button btnCheckStatus;
        private Button btnTransfers;
        private Button btnSignOut;

        /// <summary>
        /// Loads data related to a specific account and displays it in a DataGridView.
        /// This method is responsible for retrieving account-specific information and presenting it in a user-friendly format.
        /// </summary>
        /// <param name="accountNumber">The account number for which data is to be loaded and displayed.</param>
        private void SomeMethodToLoadData(string accountNumber)
        {
            XmlUpdate xmlUpdater = new XmlUpdate();
            DataGridView gridView = xmlUpdater.SetupClientViewForm(accountNumber);
            Controls.Add(gridView);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientView"/> class.
        /// Initializes a new instance of the ClientView form with specific client information.
        /// This constructor sets up the form to display information and functionalities relevant to the specified client.
        /// </summary>
        /// <param name="clientName">The name of the client, used for personalized greetings and display purposes.</param>
        /// <param name="clientNumber">The client's unique number, used for identifying and fetching specific account details.</param>
        public ClientView(string clientName ,string clientNumber)
        {
            this.clientNumber = clientNumber;
            this.clientName = clientName;
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientView"/> class.
        /// Default constructor for the ClientView form.
        /// This constructor initializes the form with default settings and is typically used for design-time support.
        /// </summary>
        public ClientView()
        {
            InitializeComponent();
            //SetupClientViewForm();
        }

        // <summary>
        // Sets up the form layout and other UI components.
        // </summary>
        private void InitializeComponent()
        {
            this.Size = new System.Drawing.Size(600, 400);
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Set the form background color to beige
            this.BackColor = System.Drawing.Color.Beige;

            // Initialize your form components here
            this.Text = "Account"; // Set the form's title to "Account"

            // Welcome Label
            lblWelcome = new Label();
            lblWelcome.Text = $"Welcome, {clientName}";
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(10, 10); // Top-left corner

            // Client Number Label
            lblClientNumber = new Label();
            lblClientNumber.Text = $"Client #: {clientNumber}";
            lblClientNumber.AutoSize = true;
            lblClientNumber.Location = new System.Drawing.Point(10, lblWelcome.Bottom + 5); // Adjusted X-position
            lblClientNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left; // Anchor to the top and left

            // Initialize controls
            btnCheckStatus = new Button();
            btnTransfers = new Button();
            btnSignOut = new Button();

            // Check Status Button
            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.Location = new System.Drawing.Point(centerX - 100, lblClientNumber.Bottom + 30);
            btnCheckStatus.Size = new System.Drawing.Size(200, 30);
            btnCheckStatus.Click += new EventHandler(BtnCheckStatus_Click);

            // Transfers Button
            btnTransfers.Text = "Transfers";
            btnTransfers.Location = new System.Drawing.Point(centerX - 100, btnCheckStatus.Bottom + 10);
            btnTransfers.Size = new System.Drawing.Size(200, 30);
            btnTransfers.Click += new EventHandler(BtnTransfers_Click);

            // Sign Out Button
            btnSignOut.Text = "Sign Out";
            btnSignOut.Location = new System.Drawing.Point(centerX - 100, btnTransfers.Bottom + 10);
            btnSignOut.Size = new System.Drawing.Size(200, 30);
            btnSignOut.Click += new EventHandler(BtnSignOut_Click);

            // Add controls to the form
            Controls.Add(lblWelcome);
            Controls.Add(lblClientNumber);
            Controls.Add(btnCheckStatus);
            Controls.Add(btnTransfers);
            Controls.Add(btnSignOut);
        }

        /// <summary>
        /// Sets up the form for viewing client transactions and account details.
        /// </summary>
        /// <param name="accountNumber">The account number associated with the client.</param>
        public void SetupClientViewForm(string accountNumber)
        {
            DataGridView transactionsGridView = new DataGridView
            {
                Location = new System.Drawing.Point(10, 20),
                Size = new System.Drawing.Size(760, 200),
                ReadOnly = true,
                AutoGenerateColumns = true,
            };
            Controls.Add(transactionsGridView);
            int centerX = this.ClientSize.Width / 2;

            transactionsGridView = new DataGridView
            {
                Location = new System.Drawing.Point(10, 100), // Adjust as needed
                Size = new System.Drawing.Size(680, 300), // Adjust as needed
                ReadOnly = true,
                AutoGenerateColumns = true
            };
            Controls.Add(transactionsGridView);
        }

        /// <summary>
        /// Event handler for the 'Check Status' button click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnCheckStatus_Click(object sender, EventArgs e)
        {
            CheckStatusForm checkStatusForm = new CheckStatusForm(clientName, clientNumber);
            checkStatusForm.ShowDialog();
        }

        /// <summary>
        /// Event handler for the 'Transfers' button click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnTransfers_Click(object sender, EventArgs e)
        {
            TransferForm transfersForm = new TransferForm();
            transfersForm.ShowDialog();
        }

        /// <summary>
        /// Event handler for the 'Sign Out' button click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to sign out
        }

        // Other methods and event handlers as needed
    }
}
