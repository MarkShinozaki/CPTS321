// <copyright file="TransferStatus.cs" company="PlaceholderCompany">
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
    /// Handles the processing and updating of transfer status.
    /// </summary>
    public class TransferStatus
    {
        /// <summary>
        /// Checks and updates the status of transfers based on elapsed time since initiation.
        /// </summary>
        /// <param name="transferXmlFilePath">The file path of the XML file containing transfer data.</param>
        public void CheckAndUpdateTransfers(string transferXmlFilePath)
        {
            // Load the XML document containing the transfers.
            var transferXmlDoc = XDocument.Load(transferXmlFilePath);

            // Load the XML document for completed transfers.
            var completedTransfersXmlDoc = XDocument.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\CompletedTransfers.xml");

            // Retrieve all transfer elements from the XML document.
            var transfers = transferXmlDoc.Root.Elements("Transfer").ToList();

            // Iterate over each transfer to check and update their status.
            foreach (var transfer in transfers)
            {
                // Parse the transfer date and retrieve the current status.
                DateTime transferDate = DateTime.Parse(transfer.Element("Date").Value);
                string status = transfer.Element("Status").Value;

                // Check if the transfer is pending and if the time elapsed since the transfer date is more than 5 minutes.
                if (status == "Pending" && (DateTime.Now - transferDate).TotalMinutes > 5)
                {
                    // Update the status to 'Completed'.
                    transfer.SetElementValue("Status", "Completed");

                    // Add the completed transfer to the CompletedTransfers.xml document.
                    completedTransfersXmlDoc.Root.Add(new XElement(transfer));

                    // Remove the transfer from the original Transfers.xml document.
                    transfer.Remove();
                }
            }

            // Save the updated transfers to the Transfers.xml file.
            transferXmlDoc.Save(transferXmlFilePath);

            // Save the updated completed transfers to the CompletedTransfers.xml file.
            completedTransfersXmlDoc.Save("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\CompletedTransfers.xml");
        }
    }
}