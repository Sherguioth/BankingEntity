﻿using ClienteBankSWNet.controller;
using ClienteBankSWNet.structural;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteBankSWNet.gui
{
    public partial class GUIFindProductRegistration : Form
    {
        private ClientController clientController;
        private ProductRegistrationController productRegistrationController;

        public GUIFindProductRegistration()
        {
            InitializeComponent();

            this.clientController = ClientController.Instance;
            this.productRegistrationController = ProductRegistrationController.Instance;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();
            try
            {
                ProductRegistration productRegistration = this.productRegistrationController.FindProductRegistration(strClientId, strProductCode);

                txtProductNumber.Text = productRegistration.productNumber.ToString();
                txtBalance.Text = productRegistration.balance.ToString();
                datePickerRegistration.Value = DateTime.Parse(productRegistration.registrationDate);
                datePickerExpiration.Value = DateTime.Parse(productRegistration.expirationDate);
                txtState.Text = productRegistration.state ? "Activo" : "Inactivo";

                txtProductNumber.Enabled = false;
                txtBalance.Enabled = false;
                datePickerRegistration.Enabled = false;
                datePickerExpiration.Enabled = false;
                txtState.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            GUIModalListClients guiModal = new GUIModalListClients();
            guiModal.ShowDialog();
            txtClientId.Text = guiModal.ClientIdSelected;
            loadData();
        }

        private void loadData()
        {
            comboBoxProductCode.Items.Clear();

            ProductRegistration[] allProductRegistrations = this.productRegistrationController.ListAllProductRegistations();
            Client client = this.clientController.FindClient(txtClientId.Text);

            foreach (ProductRegistration productRegistration in allProductRegistrations)
            {
                if (productRegistration.clientId == client.identificationNumber)
                {
                    comboBoxProductCode.Items.Add(productRegistration.productCode.ToString());
                }
            }
            comboBoxProductCode.SelectedItem = null;
        }
    }
}
