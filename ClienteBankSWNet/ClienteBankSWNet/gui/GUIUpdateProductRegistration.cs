using ClienteBankSWNet.ClientWebService;
using ClienteBankSWNet.controller;
using ClienteBankSWNet.ProductRegistrationWebService;
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
    public partial class GUIUpdateProductRegistration : Form
    {
        private ClientController clientController;
        private ProductRegistrationController productRegistrationController;

        public GUIUpdateProductRegistration()
        {
            InitializeComponent();

            this.clientController = ClientController.Instance;
            this.productRegistrationController = ProductRegistrationController.Instance;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            GUIModalListClients guiModal = new GUIModalListClients();
            guiModal.ShowDialog();
            txtClientId.Text = guiModal.ClientIdSelected;
            loadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();
            try
            {
                productRegistration productRegistration = this.productRegistrationController.FindProductRegistration(strClientId, strProductCode);

                txtProductNumber.Text = productRegistration.productNumber.ToString();
                txtBalance.Text = productRegistration.balance.ToString();
                datePickerRegistration.Value = productRegistration.registratioDate;
                datePickerExpiration.Value = productRegistration.expirationDate;
                if (productRegistration.state)
                    rbtnActivo.Checked = true;
                else
                    rbtnInactivo.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();
            String strProductNumber = txtProductNumber.Text;
            String strBalance = txtBalance.Text;
            DateTime registrationDate = datePickerRegistration.Value;
            DateTime expirationDate = datePickerExpiration.Value;
            bool state = rbtnActivo.Checked;

            try
            {
                if (this.productRegistrationController.UpdateProductRegistration(strClientId, strProductCode, strProductNumber,
                    strBalance, registrationDate, expirationDate, state))
                {
                    MessageBox.Show("El registro del produto ha sido actualizado correctamente.", "Producto Registrado");
                }
                else
                {
                    MessageBox.Show("No se ha podido hacer la actualización del registro del producto.", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }

        private void loadData()
        {
            comboBoxProductCode.Items.Clear();

            productRegistration[] allProductRegistrations = this.productRegistrationController.ListAllProductRegistations();
            client client = this.clientController.FindClient(txtClientId.Text);

            foreach (productRegistration productRegistration in allProductRegistrations)
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
