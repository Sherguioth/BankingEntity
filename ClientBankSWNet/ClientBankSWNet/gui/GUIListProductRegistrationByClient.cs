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
    public partial class GUIListProductRegistrationByClient : Form
    {
        private ProductRegistrationController productRegistrationController;

        public GUIListProductRegistrationByClient()
        {
            InitializeComponent();
            this.productRegistrationController = ProductRegistrationController.Instance;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            GUIModalListClients guiModal = new GUIModalListClients();
            guiModal.ShowDialog();
            txtClientId.Text = guiModal.ClientIdSelected;
            loadTableData(guiModal.ClientIdSelected);
        }

        public async void loadTableData(String strClientId)
        {
            int clientId = Int32.Parse(strClientId);

            try
            {
                List<Dictionary<string, object>> productRegistrations = await this.productRegistrationController.ListAllProductRegistations();
                DataTable dataTable = new DataTable();
                DataRow row;

                dataTable.Columns.Add(new DataColumn("Código de producto"));
                dataTable.Columns.Add(new DataColumn("Cliente"));
                dataTable.Columns.Add(new DataColumn("Número de producto"));
                dataTable.Columns.Add(new DataColumn("Saldo"));
                dataTable.Columns.Add(new DataColumn("Fecha de registro"));
                dataTable.Columns.Add(new DataColumn("Fecha de expiración"));
                dataTable.Columns.Add(new DataColumn("Estado"));

                foreach (Dictionary<string, object> productRegistration in productRegistrations)
                {
                    if (productRegistration["clientId"].Equals(clientId))
                    {
                        row = dataTable.NewRow();
                        row["Código de producto"] = Convert.ToString(productRegistration["productCode"].ToString());
                        row["Cliente"] = productRegistration["clientId"].ToString();
                        row["Número de producto"] = productRegistration["productNumber"].ToString();
                        row["Saldo"] = productRegistration["balance"].ToString();
                        row["Fecha de registro"] = productRegistration["registrationDate"].ToString();
                        row["Fecha de expiración"] = productRegistration["expirationDate"].ToString();

                        if (productRegistration["state"].Equals(true))
                        {
                            row["Estado"] = "Activo";
                        }
                        else
                        {
                            row["Estado"] = "Inactivo";
                        }

                        dataTable.Rows.Add(row);
                    }
                }

                dataGridProductRegistrations.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }

        private async void btnGetBalance_Click(object sender, EventArgs e)
        {
            int clientId = Int32.Parse(txtClientId.Text);
            double suma = 0;
            List<Dictionary<string, object>> productRegistrations = await this.productRegistrationController.ListAllProductRegistations();

            foreach (Dictionary<string, object> productRegistration in productRegistrations)
            {
                if (productRegistration["clientId"].Equals(clientId))
                {
                    suma += double.Parse(productRegistration["banlance"].ToString());
                }
            }

            MessageBox.Show("La sumatroria de saldos es de: " + suma, "Información");
        }
    }
}
