// <copyright file="AdminRemoveUser.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Linq;

    /// <summary>
    /// Represents a form for administrators to remove users from the system.
    /// </summary>
    internal class AdminRemoveUser : Form
    {
        private Label lblClientID;
        private TextBox txtClientNumber;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnSearchAndRemove;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRemoveUser"/> class.
        /// </summary>
        public AdminRemoveUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up the form's UI components.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = "Remove User";
            this.BackColor = Color.LightBlue;
            this.Size = new Size(400, 200); // Adjusted for additional input field
            this.StartPosition = FormStartPosition.CenterScreen;

            lblClientID = new Label { Text = "Client ID:", Location = new Point(20, 20), Size = new Size(80, 20) };
            txtClientNumber = new TextBox { Location = new Point(110, 20), Size = new Size(180, 20) };

            lblUsername = new Label { Text = "Username:", Location = new Point(20, 50), Size = new Size(80, 20) };
            txtUsername = new TextBox { Location = new Point(110, 50), Size = new Size(180, 20) };

            btnSearchAndRemove = new Button { Text = "Remove User", Location = new Point(110, 90), Size = new Size(180, 30) };
            btnSearchAndRemove.Click += BtnSearchAndRemove_Click;

            this.Controls.Add(lblClientID);
            this.Controls.Add(txtClientNumber);
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(btnSearchAndRemove);
        }

        /// <summary>
        /// Handles the click event of the search and remove button.
        /// Validates input and initiates the user removal process.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnSearchAndRemove_Click(object sender, EventArgs e)
        {
            string clientNumber = txtClientNumber.Text.Trim();
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(clientNumber) && string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a client number or username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool userExistsInAuth = UserExists(clientNumber, username, "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml");
            bool userExistsInClients = UserExists(clientNumber, username, "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml");

            if (userExistsInAuth || userExistsInClients)
            {
                var confirmationResult = MessageBox.Show($"Are you sure you want to remove the user?",
                                                         "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmationResult == DialogResult.Yes)
                {
                    if (userExistsInAuth)
                        RemoveUserFromXml(clientNumber, username, "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml");
                    if (userExistsInClients)
                        RemoveUserFromXml(clientNumber, username, "C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml");
                    MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("User not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Checks if a user exists in the specified XML file.
        /// </summary>
        /// <param name="clientNumber">The client number to search for.</param>
        /// <param name="username">The username to search for.</param>
        /// <param name="filePath">The path to the XML file.</param>
        /// <returns>True if the user exists, otherwise false.</returns>
        private bool UserExists(string clientNumber, string username, string filePath)
        {
            var xmlDoc = XDocument.Load(filePath);
            return xmlDoc.Descendants("User")
                         .Any(user => (string)user.Element("ClientNumber") == clientNumber || (string)user.Element("Username") == username);
        }

        /// <summary>
        /// Removes a user from the specified XML file.
        /// </summary>
        /// <param name="clientNumber">The client number of the user to remove.</param>
        /// <param name="username">The username of the user to remove.</param>
        /// <param name="filePath">The path to the XML file where the user is stored.</param>
        private void RemoveUserFromXml(string clientNumber, string username, string filePath)
        {
            try
            {
                var xmlDoc = XDocument.Load(filePath);

                IEnumerable<XElement> elementsToRemove;

                if (filePath.EndsWith("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml"))
                {
                    // For Auth.xml, remove User elements
                    elementsToRemove = xmlDoc.Descendants("User")
                                             .Where(user => (string)user.Element("ClientNumber") == clientNumber || (string)user.Element("Username") == username);
                }
                else if (filePath.EndsWith("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\BankingEngine\\Clients.xml"))
                {
                    // For Clients.xml, remove Client elements
                    elementsToRemove = xmlDoc.Descendants("Client")
                                             .Where(client => (string)client.Element("ClientNumber") == clientNumber || (string)client.Element("Username") == username);
                }
                else
                {
                    MessageBox.Show("Invalid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!elementsToRemove.Any())
                {
                    MessageBox.Show("No matching user found in the file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var element in elementsToRemove)
                {
                    element.Remove();
                }

                xmlDoc.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
