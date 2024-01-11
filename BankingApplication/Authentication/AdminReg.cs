// <copyright file="AdminReg.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace Authentication
{
    using System;
    using System.Xml;

    internal class AdminReg
    {
        private const string adminUsername = "Mark";
        private const string adminPassword = "Shin"; // Non-hashed password
        private const string adminID = "1"; // Admin ID or Employee Number

        /// <summary>
        /// Verifies the hashed password.
        /// </summary>
        /// <param name="hashedPassword">HashedPassword.</param>
        /// <param name="password">password.</param>
        /// <returns>Hashed passwords.</returns>
        private static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        /// <summary>
        /// This is a check that the admin currently exists within the system.
        /// </summary>
        /// <param name="doc">doc.</param>
        /// <param name="username">username.</param>
        /// <returns>It simply checks if users in the system.</returns>
        private static bool AdminExists(XmlDocument doc, string username)
        {
            XmlNodeList users = doc.SelectNodes("//User[Username='" + username + "']");
            return users.Count > 0;
        }

        /// <summary>
        /// This creates an admin in the system but was only used once to create main admin.
        /// </summary>
        public static void CreatingAdminAccount()
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(adminPassword);

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml");

            if (!AdminExists(doc, adminUsername))
            {
                XmlNode newUser = doc.CreateElement("User");
                AddChildElement(doc, newUser, "Username", adminUsername);
                AddChildElement(doc, newUser, "PasswordHash", hashedPassword);
                AddChildElement(doc, newUser, "Role", "admin");
                AddChildElement(doc, newUser, "EmployeeNumber", adminID); // Adding Admin ID

                XmlNode root = doc.DocumentElement;
                root.AppendChild(newUser);

                doc.Save("C:\\Users\\mark-\\OneDrive\\LapTop - Desktop\\CPTS321-ClassExercises\\BankingApplication\\Authentication\\Auth.xml");
            }
            else
            {
                MessageBox.Show("Invalid client credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /// <summary>
       /// This adds the element to the system
       /// </summary>
       /// <param name="doc">doc.</param>
       /// <param name="parent">parent.</param>
       /// <param name="elementName">elementName.</param>
       /// <param name="elementValue">elementVal.</param>
        private static void AddChildElement(XmlDocument doc, XmlNode parent, string elementName, string elementValue)
        {
            XmlNode newNode = doc.CreateElement(elementName);
            newNode.InnerText = elementValue;
            parent.AppendChild(newNode);
        }
    }
}
