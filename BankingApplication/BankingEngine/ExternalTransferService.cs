// <copyright file="ExternalTransferService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    /// <summary>
    /// Provides services for performing external transfers between different accounts.
    /// </summary>
    public class ExternalTransferService
    {
        /// <summary>
        /// Performs an external transfer from a sender to a receiver.
        /// </summary>
        /// <param name="senderUsername">Username of the sender.</param>
        /// <param name="receiverAccountNumber">Account number of the receiver.</param>
        /// <param name="amount">Amount to be transferred.</param>
        /// <param name="clientXmlFilePath">Path to the clients XML file.</param>
        /// <param name="transferXmlFilePath">Path to the transfers XML file.</param>
        /// <returns>A message indicating the outcome of the transfer.</returns>
        public string PerformTransfer(string senderUsername, string receiverAccountNumber, decimal amount, string clientXmlFilePath, string transferXmlFilePath)
        {
            var clientXmlDoc = XDocument.Load(clientXmlFilePath);
            var senderAccount = clientXmlDoc.Root.Elements("Client")
                                                .FirstOrDefault(client => client.Element("Username")?.Value == senderUsername);
            var receiverAccount = clientXmlDoc.Root.Elements("Client")
                                                  .FirstOrDefault(client => client.Element("CheckingAccount")?.Element("AccountNumber")?.Value == receiverAccountNumber ||
                                                                            client.Element("SavingsAccount")?.Element("AccountNumber")?.Value == receiverAccountNumber);

            if (senderAccount == null || receiverAccount == null)
                return "Invalid username or account number.";

            decimal senderBalance = decimal.Parse(senderAccount.Element("CheckingAccount").Element("Balance").Value);
            if (senderBalance >= amount)
            {
                senderAccount.Element("CheckingAccount").SetElementValue("Balance", senderBalance - amount);
                decimal receiverBalance = decimal.Parse(receiverAccount.Element("CheckingAccount").Element("Balance").Value);
                receiverAccount.Element("CheckingAccount").SetElementValue("Balance", receiverBalance + amount);

                // Save changes to the clients XML file
                clientXmlDoc.Save(clientXmlFilePath);

                // Record the transfer in the external transfers XML file
                RecordExternalTransfer(senderUsername, receiverAccountNumber, amount, transferXmlFilePath);

                return "Transfer successful.";
            }
            else
            {
                return "Insufficient funds for the transfer.";
            }
        }

        /// <summary>
        /// Records the external transfer details in the XML file.
        /// </summary>
        /// <param name="senderUsername">Username of the sender.</param>
        /// <param name="receiverAccountNumber">Account number of the receiver.</param>
        /// <param name="amount">Amount transferred.</param>
        /// <param name="transferXmlFilePath">Path to the transfers XML file.</param>
        private void RecordExternalTransfer(string senderUsername, string receiverAccountNumber, decimal amount, string transferXmlFilePath)
        {
            var transferXmlDoc = XDocument.Load(transferXmlFilePath);
            var root = transferXmlDoc.Root;

            root.Add(new XElement("Transfer",
                new XElement("FromUsername", senderUsername),
                new XElement("ToAccountNumber", receiverAccountNumber),
                new XElement("Amount", amount),
                new XElement("Date", DateTime.Now.ToString("o")),
                new XElement("Status", "Pending")
            ));

            // Save the transfer details
            transferXmlDoc.Save(transferXmlFilePath);
        } 
    }
}
