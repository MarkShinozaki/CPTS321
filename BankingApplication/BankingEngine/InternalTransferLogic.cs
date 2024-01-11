// <copyright file="InternalTransferLogic.cs" company="PlaceholderCompany">
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
    /// Handles the logic for performing internal transfers between different accounts of the same client.
    /// </summary>
    public class InternalTransferLogic
    {
        private readonly string xmlFilePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTransferLogic"/> class.
        /// </summary>
        /// <param name="xmlFilePath">Path to the XML file containing client and account data.</param>
        public InternalTransferLogic(string xmlFilePath)
        {
            this.xmlFilePath = xmlFilePath;
        }

        /// <summary>
        /// Performs an internal transfer between two accounts of the same client.
        /// </summary>
        /// <param name="clientNumber">Unique client number.</param>
        /// <param name="fromAccountType">Type of the account to transfer from (e.g., 'Checking').</param>
        /// <param name="toAccountType">Type of the account to transfer to (e.g., 'Savings').</param>
        /// <param name="amount">Amount to be transferred.</param>
        /// <returns>True if transfer is successful, otherwise false.</returns>
        public bool PerformInternalTransfer(string clientNumber, string fromAccountType, string toAccountType, decimal amount)
        {
            try
            {
                var xmlDoc = XDocument.Load(xmlFilePath);
                var clientElement = GetCurrentClientByClientNumber(xmlDoc, clientNumber);

                if (clientElement == null)
                    throw new InvalidOperationException("Client not found.");

                var fromAccountElement = clientElement.Element(fromAccountType + "Account");
                var toAccountElement = clientElement.Element(toAccountType + "Account");

                if (fromAccountElement == null || toAccountElement == null)
                    throw new InvalidOperationException("Account element not found.");

                if (decimal.TryParse(fromAccountElement.Element("Balance").Value, out decimal fromBalance) &&
                    decimal.TryParse(toAccountElement.Element("Balance").Value, out decimal toBalance))
                {
                    if (fromBalance >= amount)
                    {
                        fromAccountElement.SetElementValue("Balance", (fromBalance - amount).ToString());
                        toAccountElement.SetElementValue("Balance", (toBalance + amount).ToString());
                        xmlDoc.Save(xmlFilePath);
                        RecordTransaction(clientNumber, fromAccountType, toAccountType, amount);
                        return true;
                    }
                    else
                    {
                        throw new InvalidOperationException("Insufficient funds.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Invalid account balance.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during internal transfer: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Retrieves the XML element of a client based on the client number.
        /// </summary>
        /// <param name="xmlDoc">XML document containing client data.</param>
        /// <param name="clientNumber">Unique client number.</param>
        /// <returns>XML element of the client if found; otherwise, null.</returns>
        private XElement GetCurrentClientByClientNumber(XDocument xmlDoc, string clientNumber)
        {
            return xmlDoc.Root.Elements("Client").FirstOrDefault(client => client.Element("ClientNumber")?.Value == clientNumber);
        }

        // ... Other methods (GetCheckingAccountBalance, GetSavingsAccountBalance, RecordTransaction) ...

        /// <summary>
        /// Records a transaction in the Transfers XML file.
        /// </summary>
        /// <param name="clientNumber">Unique client number associated with the transfer.</param>
        /// <param name="fromAccountType">Type of the account the transfer is made from.</param>
        /// <param name="toAccountType">Type of the account the transfer is made to.</param>
        /// <param name="amount">Amount of money transferred.</param>
        private void RecordTransaction(string clientNumber, string fromAccountType, string toAccountType, decimal amount)
        {
            XDocument doc = XDocument.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Transfers.xml"); // Specify the path to your Transfers XML file

            XElement newTransfer = new XElement("Transfer",
                new XElement("ClientNumber", clientNumber),
                new XElement("SourceAccount", fromAccountType),
                new XElement("DestinationAccount", toAccountType),
                new XElement("Amount", amount.ToString("F2")), // Formats the amount to 2 decimal places
                new XElement("Timestamp", DateTime.Now.ToString("o")), // ISO 8601 format
                new XElement("Status", "Pending") // Assuming the transfer is successful at this point
            );

            doc.Root.Add(newTransfer);
            doc.Save("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Transfers.xml"); // Save the changes to the file
        }
    }
}