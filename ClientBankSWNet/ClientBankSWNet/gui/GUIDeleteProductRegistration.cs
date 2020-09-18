using ClientBankSWNet.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBankSWNet.gui
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

        private async void btnFind_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();
            try
            {
                Dictionary<string, object> productRegistration = await this.productRegistrationController.FindProductRegistration(strClientId, strProductCode);

                txtProductNumber.Text = productRegistration["productNumber"].ToString();
                txtBalance.Text = productRegistration["balance"].ToString();
                datePickerRegistration.Value = DateTime.Parse(productRegistration["registrationDate"].ToString());
                datePickerExpiration.Value = DateTime.Parse(productRegistration["expirationDate"].ToString());

                if (productRegistration["state"].Equals(true))
                {
                    txtState.Text = "Activo";
                }
                else
                {
                    txtState.Text = "Inactivo";
                }

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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();

            try
            {
                if (await this.productRegistrationController.DeleteProductRegistration(strClientId, strProductCode))
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

        private async void loadData()
        {
            comboBoxProductCode.Items.Clear();

            List<Dictionary<string, object>> allProductRegistrations = await this.productRegistrationController.ListAllProductRegistations();
            Dictionary<string, object> client = await this.clientController.FindClient(txtClientId.Text);

            foreach (Dictionary<string, object> productRegistration in allProductRegistrations)
            {
                if (productRegistration["clientId"].Equals(client["identificationNumber"]))
                {
                    comboBoxProductCode.Items.Add(productRegistration["productCode"].ToString());
                }
            }
            comboBoxProductCode.SelectedItem = null;
        }
    }
}
