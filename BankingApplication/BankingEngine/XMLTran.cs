// <copyright file="XMLTran.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

/// <summary>
/// Class to handle loading and displaying XML data in a DataGridView.
/// </summary>
public class XmlUpdate
{
    /// <summary>
    /// Sets up the DataGridView for displaying client data.
    /// </summary>
    /// <param name="accountNumber">The account number to load data for.</param>
    /// <returns>A configured DataGridView instance.</returns>
    public DataGridView SetupClientViewForm(string accountNumber)
    {
        // Create and configure DataGridView
        DataGridView transactionsGridView = new DataGridView
        {
            Location = new System.Drawing.Point(10, 100), // Adjust as needed
            Size = new System.Drawing.Size(680, 300), // Adjust as needed
            ReadOnly = true,
            AutoGenerateColumns = true
        };

        // Load XML data
        DataTable dataTable = LoadXmlData(accountNumber);

        // Bind the data to the DataGridView
        transactionsGridView.DataSource = dataTable;

        return transactionsGridView;
    }

    /// <summary>
    /// Loads XML data into a DataTable based on the specified account number.
    /// </summary>
    /// <param name="accountNumber">The account number to filter data by.</param>
    /// <returns>A DataTable with the loaded XML data.</returns>
    private DataTable LoadXmlData(string accountNumber)
    {
        DataTable dataTable = new DataTable();

        // Load your XML file here - adjust the path as needed
        string xmlFilePath = "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml";

        // Read and parse the XML file
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        // Create columns in DataTable - adjust according to your XML structure
        dataTable.Columns.Add("Column1", typeof(string));
        dataTable.Columns.Add("Column2", typeof(string));
        // Add more columns as needed

        // Iterate through the XML to populate the DataTable
        foreach (XmlNode node in xmlDoc.DocumentElement)
        {
            DataRow row = dataTable.NewRow();

            // Adjust these lines to match your XML structure and desired data
            row["Column1"] = node["SubElement1"].InnerText;
            row["Column2"] = node["SubElement2"].InnerText;
            // Populate more columns as needed

            dataTable.Rows.Add(row);
        }

        return dataTable;
    }
}
