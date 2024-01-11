// <copyright file="AdminAccountOverview.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Windows.Forms;
    using System.Data;
    using System.Xml.Linq;
    using System.Linq;

    /// <summary>
    /// Represents the form for displaying an overview of all client accounts in the banking application.
    /// </summary>
    internal class AdminAccountOverview : Form
    {
        private DataGridView dgvAccounts;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAccountOverview"/> class.
        /// </summary>
        public AdminAccountOverview()
        {
            InitializeComponent();
            LoadAccountsData();
        }

        /// <summary>
        /// Sets up the form layout and the DataGridView for displaying account information.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = "Account Overview";
            this.Size = new System.Drawing.Size(800, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.LightBlue;

            dgvAccounts = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            this.Controls.Add(dgvAccounts);
        }

        /// <summary>
        /// Loads and displays account data from XML files into the DataGridView.
        /// </summary>
        private void LoadAccountsData()
        {
            try
            {
                // Paths to the XML files - replace with actual file paths
                string clientsXmlPath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml";
                string usersXmlPath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml";

                // Load the XML documents
                var clientsXml = XDocument.Load(clientsXmlPath);
                var usersXml = XDocument.Load(usersXmlPath);

                // Query clients data
                var clientsQuery = from client in clientsXml.Descendants("Client")
                                   select new
                                   {
                                       Username = client.Element("Username").Value,
                                       ClientNumber = client.Element("ClientNumber").Value,
                                       CheckingAccountNumber = client.Element("CheckingAccount")?.Element("AccountNumber")?.Value,
                                       CheckingBalance = client.Element("CheckingAccount")?.Element("Balance")?.Value,
                                       SavingsAccountNumber = client.Element("SavingsAccount")?.Element("AccountNumber")?.Value,
                                       SavingsBalance = client.Element("SavingsAccount")?.Element("Balance")?.Value,
                                       InterestRate = client.Element("SavingsAccount")?.Element("InterestRate")?.Value,
                                       InterestGainedYearly = client.Element("SavingsAccount")?.Element("InterestGainedYearly")?.Value,
                                       TotalBalance = client.Element("TotalBalance")?.Value
                                   };

                // Query users data
                var usersQuery = from user in usersXml.Descendants("User")
                                 select new
                                 {
                                     Username = user.Element("Username").Value,
                                     PasswordHash = user.Element("PasswordHash").Value,
                                     Role = user.Element("Role").Value,
                                     ClientNumber = user.Element("ClientNumber")?.Value
                                 };

                // Join the data based on ClientNumber
                var query = from client in clientsQuery
                            join user in usersQuery
                            on client.ClientNumber equals user.ClientNumber into userGroup
                            from user in userGroup.DefaultIfEmpty()
                            select new
                            {
                                Username = client.Username,
                                PasswordHash = user != null ? user.PasswordHash : "N/A",
                                Role = user != null ? user.Role : "N/A",
                                ClientNumber = client.ClientNumber,
                                CheckingAccountNumber = client.CheckingAccountNumber,
                                CheckingBalance = client.CheckingBalance != null ? decimal.Parse(client.CheckingBalance) : 0,
                                SavingsAccountNumber = client.SavingsAccountNumber,
                                SavingsBalance = client.SavingsBalance != null ? decimal.Parse(client.SavingsBalance) : 0,
                                InterestRate = client.InterestRate != null ? decimal.Parse(client.InterestRate) : 0,
                                InterestGainedYearly = client.InterestGainedYearly != null ? decimal.Parse(client.InterestGainedYearly) : 0,
                                TotalBalance = client.TotalBalance != null ? decimal.Parse(client.TotalBalance) : 0
                            };

                // Create and fill the DataTable
                DataTable dataTable = new DataTable("Clients");
                dataTable.Columns.Add("Username", typeof(string));
                dataTable.Columns.Add("PasswordHash", typeof(string));
                dataTable.Columns.Add("Role", typeof(string));
                dataTable.Columns.Add("ClientNumber", typeof(string));
                dataTable.Columns.Add("CheckingAccountNumber", typeof(string));
                dataTable.Columns.Add("CheckingBalance", typeof(decimal));
                dataTable.Columns.Add("SavingsAccountNumber", typeof(string));
                dataTable.Columns.Add("SavingsBalance", typeof(decimal));
                dataTable.Columns.Add("InterestRate", typeof(decimal));
                dataTable.Columns.Add("InterestGainedYearly", typeof(decimal));
                dataTable.Columns.Add("TotalBalance", typeof(decimal));

                foreach (var item in query)
                {
                    dataTable.Rows.Add(
                        item.Username,
                        item.PasswordHash,
                        item.Role,
                        item.ClientNumber,
                        item.CheckingAccountNumber,
                        item.CheckingBalance,
                        item.SavingsAccountNumber,
                        item.SavingsBalance,
                        item.InterestRate,
                        item.InterestGainedYearly,
                        item.TotalBalance
                    );
                }

                // Set the DataSource of the DataGridView
                dgvAccounts.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading XML data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

