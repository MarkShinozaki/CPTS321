// <copyright file="NewClient.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System;
    using System.Xml;
    using System.Linq;
    using System.Transactions;
    using BankingEngine;

    /// <summary>
    /// Class responsible for creating new client accounts.
    /// </summary>
    internal class NewClientToSystem
    {
        /// <summary>
        /// Creates a new client account with provided username and password.
        /// </summary>
        /// <param name="username">The username for the new account.</param>
        /// <param name="password">The password for the new account.</param>
        /// <param name="clientNumber">Out parameter for the new client's unique number.</param>
        /// <param name="checkingAccountNumber">Out parameter for the new checking account number.</param>
        /// <param name="savingsAccountNumber">Out parameter for the new savings account number.</param>
        /// <param name="totalBalance">Out parameter for the total balance across all accounts.</param>
        /// <param name="timestamp">The timestamp of the account creation.</param>
        /// <returns>A boolean value indicating whether the account creation was successful.</returns>
        public static bool CreateClientAccount(string username, string password, out string clientNumber, out string checkingAccountNumber, out string savingsAccountNumber, out double totalBalance, DateTime timestamp)
        {
            // Check if username already exists in Auth.xml
            if (UsernameExists("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml", username))
            {
                clientNumber = null;
                checkingAccountNumber = null;
                savingsAccountNumber = null;
                totalBalance = 0.00;
                return false;
            }

            clientNumber = GenerateClientNumber(); // Generate client number once for both files
            checkingAccountNumber = GenerateAccountNumber();
            savingsAccountNumber = GenerateAccountNumber();
            double checkingBalance = GetRandomInitialBalance();
            double savingsBalance = GetRandomInitialBalance();
            totalBalance = checkingBalance + savingsBalance;
            double interestRate = 0.05; // Fixed interest rate
            double interestGainedYearly = savingsBalance * interestRate;

            // Update Auth.xml with new user
            AddUserToAuthXml("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml", username, password, "client", clientNumber);

            // Update Clients.xml with new client information
            AddClientToClientsXml("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml", username, clientNumber, checkingAccountNumber, savingsAccountNumber, checkingBalance, savingsBalance, interestRate, interestGainedYearly, totalBalance);

            return true;

            // Inside NewClientToSystem.CreateClientAccount method, after setting up account details
            UpdateTransaction.ProcessTransactions(checkingAccountNumber, savingsAccountNumber, ref checkingBalance, ref savingsBalance, 5);
        }

        /// <summary>
        /// Adds a new client to the Clients.xml file.
        /// </summary>
        /// <param name="filePath">Path to the Clients.xml file.</param>
        /// <param name="username">Username for the new client.</param>
        /// <param name="clientNumber">Client number for the new client.</param>
        /// <param name="checkingAccountNumber">Checking account number for the new client.</param>
        /// <param name="savingsAccountNumber">Savings account number for the new client.</param>
        /// <param name="checkingBalance">Checking account balance for the new client.</param>
        /// <param name="savingsBalance">Savings account balance for the new client.</param>
        /// <param name="interestRate">Interest rate for the savings account.</param>
        /// <param name="interestGainedYearly">Yearly interest gained for the savings account.</param>
        /// <param name="totalBalance">Total balance of the new client.</param>
        private static void AddClientToClientsXml(string filePath, string username, string clientNumber, string checkingAccountNumber, string savingsAccountNumber, double checkingBalance, double savingsBalance, double interestRate, double interestGainedYearly, double totalBalance)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode newClient = doc.CreateElement("Client");
            AddChildElement(doc, newClient, "Username", username);
            AddChildElement(doc, newClient, "ClientNumber", clientNumber);

            XmlNode checkingAccount = doc.CreateElement("CheckingAccount");
            AddChildElement(doc, checkingAccount, "AccountNumber", checkingAccountNumber);
            AddChildElement(doc, checkingAccount, "Balance", checkingBalance.ToString());
            newClient.AppendChild(checkingAccount);

            XmlNode savingsAccount = doc.CreateElement("SavingsAccount");
            AddChildElement(doc, savingsAccount, "AccountNumber", savingsAccountNumber);
            AddChildElement(doc, savingsAccount, "Balance", savingsBalance.ToString());
            AddChildElement(doc, savingsAccount, "InterestRate", interestRate.ToString("F2"));
            AddChildElement(doc, savingsAccount, "InterestGainedYearly", interestGainedYearly.ToString("F2"));
            newClient.AppendChild(savingsAccount);

            AddChildElement(doc, newClient, "TotalBalance", totalBalance.ToString());

            doc.DocumentElement.AppendChild(newClient);
            doc.Save(filePath);
        }

        /// <summary>
        /// Checks if a given username already exists in the Auth.xml.
        /// </summary>
        /// <param name="filePath">Path to the Auth.xml file.</param>
        /// <param name="username">Username to check for existence.</param>
        /// <returns>True if the username exists, otherwise false.</returns>
        private static bool UsernameExists(string filePath, string username)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            var userNodes = doc.SelectNodes("//User");
            foreach (XmlNode node in userNodes)
            {
                if (node.SelectSingleNode("Username")?.InnerText == username)
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Adds a new user to the Auth.xml file.
        /// </summary>
        /// <param name="filePath">Path to the Auth.xml file.</param>
        /// <param name="username">Username for the new user.</param>
        /// <param name="password">Password for the new user.</param>
        /// <param name="role">Role of the new user.</param>
        /// <param name="clientNumber">Client number for the new user.</param>
        private static void AddUserToAuthXml(string filePath, string username, string password, string role, string clientNumber)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode newUser = doc.CreateElement("User");
            AddChildElement(doc, newUser, "Username", username);
            AddChildElement(doc, newUser, "PasswordHash", BCrypt.Net.BCrypt.HashPassword(password));
            AddChildElement(doc, newUser, "Role", role);

            if (!string.IsNullOrWhiteSpace(clientNumber))
            {
                AddChildElement(doc, newUser, "ClientNumber", clientNumber);
            }

            doc.DocumentElement.AppendChild(newUser);
            doc.Save(filePath);
        }


        /// <summary>
        /// Generates a new unique client number.
        /// </summary>
        /// <returns>A unique client number.</returns>
        private static string GenerateClientNumber()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Generates a new account number.
        /// </summary>
        /// <returns>A new account number.</returns>
        private static string GenerateAccountNumber()
        {
            return Guid.NewGuid().ToString().Substring(0, 10);
        }

        /// <summary>
        /// Generates a random initial balance for an account.
        /// </summary>
        /// <returns>A random initial balance value.</returns>
        private static double GetRandomInitialBalance()
        {
            Random random = new Random();
            return random.Next(1000, 5000); // Random balance between 1000 and 5000, for example
        }

        /// <summary>
        /// Adds a child XML element to a specified parent node.
        /// </summary>
        /// <param name="doc">The XmlDocument to which the element is to be added.</param>
        /// <param name="parent">The parent XmlNode to which the child element is added.</param>
        /// <param name="elementName">The name of the child element to be created.</param>
        /// <param name="elementValue">The text value of the child element.</param>
        private static void AddChildElement(XmlDocument doc, XmlNode parent, string elementName, string elementValue)
        {
            // Create a new XML node with the specified name
            XmlNode newNode = doc.CreateElement(elementName);
            // Set the text value of the new node
            newNode.InnerText = elementValue;
            // Append the new node as a child of the parent node
            parent.AppendChild(newNode);
        }

    }

}
