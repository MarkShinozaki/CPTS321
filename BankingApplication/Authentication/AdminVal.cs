// <copyright file="AdminVal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    /// <summary>
    /// Provides validation functionality for admin users.
    /// </summary>
    internal class AdminVal
    {
        /// <summary>
        /// Validates an admin's credentials.
        /// </summary>
        /// <param name="username">Username of the admin.</param>
        /// <param name="password">Password of the admin.</param>
        /// <returns>
        /// A tuple indicating whether the admin is authenticated, their role, and client number if applicable.
        /// </returns>
        public static (bool isAuthenticated, string role, string clientNumber) AdminCheck(string username, string password)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml");

            // Iterate through each user node in the XML document.
            foreach (XmlNode node in doc.SelectNodes("//User"))
            {
                string xmlUsername = node.SelectSingleNode("Username")?.InnerText;
                string xmlPasswordHash = node.SelectSingleNode("PasswordHash")?.InnerText;
                string xmlRole = node.SelectSingleNode("Role")?.InnerText;
                string xmlClientNumber = xmlRole == "client" ? node.SelectSingleNode("ClientNumber")?.InnerText : null;

                // Check if the provided credentials match the stored credentials.
                if (xmlUsername == username && VerifyHashedPassword(xmlPasswordHash, password))
                {
                    return (true, xmlRole, xmlClientNumber);
                }
            }
            return (false, null, null);
        }

        /// <summary>
        /// Verifies a hashed password against a plain text password.
        /// </summary>
        /// <param name="hashedPassword">Hashed password from the XML file.</param>
        /// <param name="password">Plain text password to verify.</param>
        /// <returns>True if the password matches, otherwise false.</returns>
        private static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            // Use BCrypt to verify the hashed password.
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
