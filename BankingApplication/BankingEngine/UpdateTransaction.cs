// <copyright file="UpdateTransaction.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    /// <summary>
    /// Provides methods for processing and updating transactions in banking accounts.
    /// </summary>
    public class UpdateTransaction
    {
        // This method processes transactions for both checking and savings accounts
        public static void ProcessTransactions(
            string checkingAccountNumber,
            string savingsAccountNumber,
            ref double checkingBalance,
            ref double savingsBalance,
            int transactionCount)
        {
            Random random = new Random(); // Create a single Random instance

            // Generate transactions for the checking account
            var checkingTransactions = Transaction.GenerateRandomTransactions(
                checkingAccountNumber,
                transactionCount,
                checkingBalance,
                random,
                isSavingsAccount: false);
            checkingBalance = UpdateBalanceAndAddTransactionsToXml(checkingTransactions);

            // Generate transactions for the savings account
            var savingsTransactions = Transaction.GenerateRandomTransactions(
                savingsAccountNumber,
                transactionCount,
                savingsBalance,
                random,
                isSavingsAccount: true);
            savingsBalance = UpdateBalanceAndAddTransactionsToXml(savingsTransactions);
        }

        /// <summary>
        /// Updates the account balance and adds the transactions to an XML file.
        /// </summary>
        /// <param name="transactions">The list of transactions to process.</param>
        /// <returns>The updated account balance after processing the transactions.</returns>
        public static double UpdateBalanceAndAddTransactionsToXml(List<Transaction> transactions)
        {
            double balance = transactions.FirstOrDefault()?.BalanceBeforeTransaction ?? 0;

            foreach (var transaction in transactions)
            {
                balance += transaction.Amount;
                transaction.BalanceAfterTransaction = balance;
            }

            AddTransactionsToXml(transactions);
            return balance;
        }

        /// <summary>
        /// Adds a list of transactions to an XML file.
        /// </summary>
        /// <param name="transactions">The list of transactions to add to the XML file.</param>
        private static void AddTransactionsToXml(List<Transaction> transactions)
        {
            XmlDocument doc = new XmlDocument();
            string filePath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Transactions.xml";

            try
            {
                doc.Load(filePath);
            }
            catch (System.IO.FileNotFoundException)
            {
                XmlNode declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(declaration);

                XmlNode root = doc.CreateElement("Transactions");
                doc.AppendChild(root);
            }

            XmlNode transactionsRoot = doc.DocumentElement;

            foreach (var transaction in transactions)
            {
                XmlComment comment = doc.CreateComment($"Transaction for Account: {transaction.AccountNumber}");
                transactionsRoot.AppendChild(comment);

                XmlNode transactionNode = doc.CreateElement("Transaction");
                AddChildElement(doc, transactionNode, "AccountNumber", transaction.AccountNumber);
                AddChildElement(doc, transactionNode, "Timestamp", transaction.Timestamp.ToString("o"));
                AddChildElement(doc, transactionNode, "Amount", transaction.Amount.ToString("F2"));
                AddChildElement(doc, transactionNode, "BalanceAfterTransaction", transaction.BalanceAfterTransaction.ToString("F2"));

                transactionsRoot.AppendChild(transactionNode);
            }

            doc.Save(filePath);
        }

        /// <summary>
        /// Adds a child element to a given XML node.
        /// </summary>
        /// <param name="doc">The XML document to modify.</param>
        /// <param name="parent">The parent node to which the child element will be added.</param>
        /// <param name="elementName">The name of the child element to add.</param>
        /// <param name="elementValue">The value of the child element to add.</param>
        private static void AddChildElement(XmlDocument doc, XmlNode parent, string elementName, string elementValue)
        {
            XmlNode newNode = doc.CreateElement(elementName);
            newNode.InnerText = elementValue;
            parent.AppendChild(newNode);
        }
    }
}
