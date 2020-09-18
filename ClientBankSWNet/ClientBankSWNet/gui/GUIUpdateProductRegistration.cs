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
                    rbtnActivo.Checked = true;
                else
                    rbtnInactivo.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
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
                if (await this.productRegistrationController.UpdateProductRegistration(strClientId, strProductCode, strProductNumber,
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
