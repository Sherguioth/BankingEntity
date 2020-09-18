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
    public partial class GUIAddProductRegistration : Form
    {
        private ProductController productController;
        private ProductRegistrationController productRegistrationController;

        public GUIAddProductRegistration()
        {
            InitializeComponent();

            this.productController = ProductController.Instance;
            this.productRegistrationController = ProductRegistrationController.Instance;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            GUIModalListClients guiModal = new GUIModalListClients();
            guiModal.ShowDialog();
            txtClientId.Text = guiModal.ClientIdSelected;
            loadProductCodes();
        }

        private async void btnAddProductRegistration_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();
            String strProductNumber = txtProductNumber.Text;
            String strBalance = txtBalance.Text;
            DateTime registrationDate = datePickerRegistration.Value;
            DateTime expirationDate = datePickerExpiration.Value;
            bool state = rbtnActivo.Checked;

            List<Dictionary<string, object>> products = await this.productController.ListAllProducts();
            int productCode = -1;
            foreach (Dictionary<string, object> product in products)
            {
                if (product["name"].Equals(strProductCode))
                {
                    productCode = int.Parse(product["code"].ToString());
                }
            }

            try
            {
                if (await this.productRegistrationController.AddProductRegistration(strClientId, productCode, strProductNumber,
                    strBalance, registrationDate, expirationDate, state))
                {
                    MessageBox.Show("El producto ha sido registrado correctamente.", "Producto Registrado");

                    txtClientId.Text = "";
                    comboBoxProductCode.SelectedItem = null;
                    txtProductNumber.Text = "";
                    txtBalance.Text = "";
                    datePickerRegistration.Value = DateTime.Today;
                    datePickerExpiration.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("No se ha podido hacer el registro del producto.", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }

        private async void loadProductCodes()
        {
            List<Dictionary<string, object>> products = await this.productController.ListAllProducts();

            comboBoxProductCode.Items.Clear();
            foreach (Dictionary<string, object> product in products)
            {
                comboBoxProductCode.Items.Add(product["name"].ToString());
            }
        }
    }
}
