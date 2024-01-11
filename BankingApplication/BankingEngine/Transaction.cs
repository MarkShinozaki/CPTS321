// <copyright file="Transaction.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// Represents a banking transaction with relevant details.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// The account number associated with the transaction.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// The date and time when the transaction was made.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The amount of money involved in the transaction.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// The account balance before the transaction occurred.
        /// </summary>
        public double BalanceBeforeTransaction { get; set; }

        /// <summary>
        /// The account balance after the transaction has been processed.
        /// </summary>
        public double BalanceAfterTransaction { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction"/> class with specified details.
        /// </summary>
        /// <param name="accountNumber">Account number associated with the transaction.</param>
        /// <param name="timestamp">Date and time when the transaction occurred.</param>
        /// <param name="amount">Transaction amount.</param>
        /// <param name="balanceBeforeTransaction">Account balance before the transaction.</param>
        public Transaction(string accountNumber, DateTime timestamp, double amount, double balanceBeforeTransaction)
        {
            AccountNumber = accountNumber;
            Timestamp = timestamp;
            Amount = amount;
            BalanceBeforeTransaction = balanceBeforeTransaction;
            BalanceAfterTransaction = balanceBeforeTransaction + amount + 50;
        }

        /// <summary>
        /// Generates a list of random transactions for demonstration or testing purposes.
        /// </summary>
        /// <param name="accountNumber">Account number for which transactions are generated.</param>
        /// <param name="count">Number of transactions to generate.</param>
        /// <param name="startingBalance">Starting balance before transactions.</param>
        /// <param name="random">Random number generator.</param>
        /// <param name="isSavingsAccount">Indicates whether the account is a savings account.</param>
        /// <returns>A list of randomly generated transactions.</returns>
        public static List<Transaction> GenerateRandomTransactions(
            string accountNumber,
            int count,
            double startingBalance,
            Random random,
            bool isSavingsAccount = false)
        {
            List<Transaction> transactions = new List<Transaction>();
            double currentBalance = startingBalance;

            for (int i = 0; i < count; i++)
            {
                double amount = isSavingsAccount
                    ? random.NextDouble() * 2000 // Savings account range, e.g., 0 to 2000
                    : random.NextDouble() * 500; // Checking account range, e.g., 0 to 500

                DateTime timestamp = DateTime.Now.AddDays(-random.Next(365));

                // Here we calculate the balance before the current transaction
                double balanceBeforeTransaction = currentBalance;

                // Here we update the current balance with the transaction amount
                currentBalance += amount;

                // Now we round the current balance to 2 decimal places
                currentBalance = Math.Round(currentBalance, 2);

                // And we create a new Transaction with the updated information
                transactions.Add(new Transaction(accountNumber, timestamp, amount, balanceBeforeTransaction));
            }

            // Sort transactions by date with most recent first
            transactions = transactions.OrderByDescending(t => t.Timestamp).ToList();

            return transactions;
        }
    }

}
