// <copyright file="TransferForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// Mark Shinozaki
// 11672355

namespace BankingEngine
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Represents a form that allows the user to choose between different types of transfer options.
    /// </summary>
    public class TransferForm : Form
    {
        private Button btnInternalTransfer;
        private Button btnExternalTransfer;
        private Button btnCancelTransfer;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferForm"/> class.
        /// </summary>
        public TransferForm()
        {
            SetupTransferForm();
        }

        /// <summary>
        /// Sets up the transfer form with necessary UI elements.
        /// </summary>
        private void SetupTransferForm()
        {

            this.BackColor = Color.Beige;
            this.Text = "Transfer Options";
            this.Size = new Size(300, 200);
           
            // Internal Transfer Button
            btnInternalTransfer = new Button
            {
                Text = "Internal Transfer",
                Location = new Point(50, 20),
                Size = new Size(200, 30)
            };
            //btnInternalTransfer.Click += (sender, e) => new InternalTransferLogic(xmlFilePath).ShowDialog();

            // Outgoing Transfer Button
            btnExternalTransfer = new Button
            {
                Text = "External Transfer",
                Location = new Point(50, 100),
                Size = new Size(200, 30)
            };
            btnExternalTransfer.Click += (sender, e) => new ExternalTransferForm().ShowDialog();

            // Cancel Transfer Button
            btnCancelTransfer = new Button
            {
                Text = "Cancel Transfer",
                Location = new Point(50, 140),
                Size = new Size(200, 30)
            };
            btnCancelTransfer.Click += (sender, e) => new CancelTransferForm().ShowDialog();

            // Adding buttons to the form
            this.Controls.Add(btnInternalTransfer);
            this.Controls.Add(btnExternalTransfer);
            this.Controls.Add(btnCancelTransfer);
        }
    }
}
