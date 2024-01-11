// <copyright file="CheckStatus.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

using System.Xml;
using System.Windows.Forms;
using System;


namespace BankingEngine
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CheckStatusForm"/> class.
    /// </summary>
    /// <param name="username">The username of the client.</param>
    /// <param name="clientNumber">The client number associated with the user.</param>
    public partial class CheckStatusForm : Form
    {
        private readonly string clientNumber;
        private readonly string username;
        private double checkingBalance;
        private double savingsBalance;
        private string checkingAccountNumber;
        private string savingsAccountNumber;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="clientNumber"></param>
        public CheckStatusForm(string username, string clientNumber)
        {
            this.username = username;
            this.clientNumber = clientNumber;
            InitializeComponent();
            LoadAccountStatus();
            
        }

        /// <summary>
        /// Sets up the form layout and other UI components.
        /// </summary>
        private void InitializeComponent()
        {
            
            // Form setup
            this.Text = $"Account Status";
            this.Size = new System.Drawing.Size(800, 800); // Increased resolution
            // Add any other UI components needed to display the account status
            
        }


        /// <summary>
        /// Loads the account status from the XML file and displays it on the form.
        /// </summary>
        private void LoadAccountStatus()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml");

            var clientNode = doc.SelectSingleNode($"//Client[Username='{username}']");
            if (clientNode != null)
            {
                DisplayAccountDetails(clientNode);
            }
            else
            {
                MessageBox.Show("Client information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates and returns a new label with specified properties.
        /// </summary>
        /// <param name="text">The text to display on the label.</param>
        /// <param name="x">The X-coordinate of the label.</param>
        /// <param name="y">The Y-coordinate of the label.</param>
        /// <returns>A new instance of a label with the specified properties.</returns>
        private Label CreateLabel(string text, int x, int y)
        {
            Label label = new Label
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            };

            return label;
        }


        /// <summary>
        /// Displays the account details on the form.
        /// </summary>
        /// <param name="clientNode">The XML node containing the client's account details.</param>
        private void DisplayAccountDetails(XmlNode clientNode)
        {

            // Position for transaction tables
            int checkingTransactionsStartY = 320; // Adjust this value as needed
            int savingsTransactionsStartY = checkingTransactionsStartY + 230; // Add enough space to avoid overlap
            // Extract checking account details
            string checkingAccountNumber = clientNode.SelectSingleNode("CheckingAccount/AccountNumber")?.InnerText ?? "N/A";
            string checkingBalance = clientNode.SelectSingleNode("CheckingAccount/Balance")?.InnerText ?? "0.00";

            // Extract savings account details
            string savingsAccountNumber = clientNode.SelectSingleNode("SavingsAccount/AccountNumber")?.InnerText ?? "N/A";
            string savingsBalance = clientNode.SelectSingleNode("SavingsAccount/Balance")?.InnerText ?? "0.00";
            string interestRate = clientNode.SelectSingleNode("SavingsAccount/InterestRate")?.InnerText ?? "0.00";
            string interestGainedYearly = clientNode.SelectSingleNode("SavingsAccount/InterestGainedYearly")?.InnerText ?? "0.00";

            // Add the details to labels and place them on the form
            Label lblCheckingAccountDetails = CreateLabel($"Checking Account:\nNumber: {checkingAccountNumber}\nBalance: ${checkingBalance}", 10, 30);
            Label lblSavingsAccountDetails = CreateLabel($"Savings Account:\nNumber: {savingsAccountNumber}\nBalance: ${savingsBalance}\nInterest Rate: {interestRate}\nInterest Gained Yearly: ${interestGainedYearly}", 10, 120);


            // Display transactions for checking and savings accounts

            checkingAccountNumber = clientNode.SelectSingleNode("CheckingAccount/AccountNumber").InnerText;
            savingsAccountNumber = clientNode.SelectSingleNode("SavingsAccount/AccountNumber").InnerText;

            // Display transactions tables
            DisplayTransactionsTable(checkingAccountNumber, "Checking Account Transactions", checkingTransactionsStartY);
            DisplayTransactionsTable(savingsAccountNumber, "Savings Account Transactions", savingsTransactionsStartY);

            // Add labels to the form's controls
            Controls.Add(lblCheckingAccountDetails);
            Controls.Add(lblSavingsAccountDetails);
        }

        /// <summary>
        /// Displays a table of transactions for a specific account.
        /// </summary>
        /// <param name="accountNumber">The account number for which to display transactions.</param>
        /// <param name="title">The title of the transactions table.</param>
        /// <param name="startY">The Y-coordinate at which to start the table.</param>
        private void DisplayTransactionsTable(string accountNumber, string title, int startY)
        {
            
            Label titleLabel = CreateLabel(title, 10, startY);
            Controls.Add(titleLabel);

            DataGridView transactionsGrid = new DataGridView
            {
                Location = new System.Drawing.Point(10, startY + 20),
                Size = new System.Drawing.Size(760, 200),
                ReadOnly = true,
                AutoGenerateColumns = true,
                DataSource = GetTransactionsForAccount(accountNumber) // This should return a binding source or a list
            };
            Controls.Add(transactionsGrid);
        }


        /// <summary>
        /// Retrieves a list of transactions for a specific account number.
        /// </summary>
        /// <param name="accountNumber">The account number for which to retrieve transactions.</param>
        /// <returns>A list of transactions for the specified account number.</returns>
        private List<Transaction> GetTransactionsForAccount(string accountNumber)
        {

            List<Transaction> transactionsList = new List<Transaction>();
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Transactions.xml");
                XmlNodeList transactionNodes = doc.SelectNodes($"//Transaction[AccountNumber='{accountNumber}']");

                foreach (XmlNode node in transactionNodes)
                {
                    string accountNum = node.SelectSingleNode("AccountNumber")?.InnerText ?? "N/A";
                    DateTime timestamp = DateTime.Parse(node.SelectSingleNode("Timestamp")?.InnerText ?? DateTime.MinValue.ToString());
                    double amount = double.Parse(node.SelectSingleNode("Amount")?.InnerText ?? "0");
                    double balanceAfterTransaction = double.Parse(node.SelectSingleNode("BalanceAfterTransaction")?.InnerText ?? "0");

                    transactionsList.Add(new Transaction(accountNum, timestamp, amount, balanceAfterTransaction));
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as file not found or XML parsing errors
                Console.WriteLine("Error in fetching transactions: " + ex.Message);
            }

            return transactionsList;
        }

        /// <summary>
        /// Retrieves the current balance for a specific account number.
        /// </summary>
        /// <param name="accountNumber">The account number for which to retrieve the balance.</param>
        /// <returns>The current balance of the specified account.</returns>
        private double GetCurrentBalanceForAccount(string accountNumber)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml");

                // Try to find the checking account with the given account number
                XmlNode checkingAccountNode = doc.SelectSingleNode($"//Client/CheckingAccount[AccountNumber='{accountNumber}']/Balance");
                if (checkingAccountNode != null)
                {
                    return double.Parse(checkingAccountNode.InnerText);
                }

                // If not found in checking accounts, try savings accounts
                XmlNode savingsAccountNode = doc.SelectSingleNode($"//Client/SavingsAccount[AccountNumber='{accountNumber}']/Balance");
                if (savingsAccountNode != null)
                {
                    return double.Parse(savingsAccountNode.InnerText);
                }

                // Account not found
                return 0.00;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, parse errors)
                Console.WriteLine("Error fetching balance: " + ex.Message);
                return 0.00;
            }
        }

        /// <summary>
        /// Adds a child XML element to a parent XML node.
        /// </summary>
        /// <param name="doc">The XML document.</param>
        /// <param name="parent">The parent XML node.</param>
        /// <param name="elementName">The name of the child element to add.</param>
        /// <param name="elementValue">The value of the child element to add.</param>
        private void AddChildElement(XmlDocument doc, XmlNode parent, string elementName, string elementValue)
        {
            XmlNode newNode = doc.CreateElement(elementName);
            newNode.InnerText = elementValue;
            parent.AppendChild(newNode);
        }

    }
}
