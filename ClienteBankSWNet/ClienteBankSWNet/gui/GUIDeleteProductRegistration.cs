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
    public partial class GUIDeleteProductRegistration : Form
    {
        private ClientController clientController;
        private ProductRegistrationController productRegistrationController;

        public GUIDeleteProductRegistration()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();

            try
            {
                if(this.productRegistrationController.DeleteProductRegistration(strClientId, strProductCode))
                {
                    MessageBox.Show("El registro del producto ha sido eliminado correctamente.", "Cofirmación");

                    txtClientId.Text = "";
                    comboBoxProductCode.SelectedItem = null;
                    txtProductNumber.Text = "";
                    txtBalance.Text = "";
                    datePickerRegistration.Value = DateTime.Today;
                    datePickerExpiration.Value = DateTime.Today;
                    txtState.Text = "";
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
