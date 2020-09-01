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

        public void loadTableData(String strClientId)
        {
            int clientId = Int32.Parse(strClientId);

            try
            {
                productRegistration[] productRegistrations = this.productRegistrationController.ListAllProductRegistations();

                DataTable dataTable = new DataTable();
                DataRow row;

                dataTable.Columns.Add(new DataColumn("Código de producto"));
                dataTable.Columns.Add(new DataColumn("Cliente"));
                dataTable.Columns.Add(new DataColumn("Número de producto"));
                dataTable.Columns.Add(new DataColumn("Saldo"));
                dataTable.Columns.Add(new DataColumn("Fecha de registro"));
                dataTable.Columns.Add(new DataColumn("Fecha de expiración"));
                dataTable.Columns.Add(new DataColumn("Estado"));

                for (int i = 0; i < productRegistrations.Length; i++)
                {
                    if (productRegistrations[i].clientId == clientId)
                    {
                        row = dataTable.NewRow();
                        row["Código de producto"] = Convert.ToString(productRegistrations[i].productCode);
                        row["Cliente"] = productRegistrations[i].clientId;
                        row["Número de producto"] = productRegistrations[i].productNumber;
                        row["Saldo"] = productRegistrations[i].balance;
                        row["Fecha de registro"] = productRegistrations[i].registratioDate;
                        row["Fecha de expiración"] = productRegistrations[i].expirationDate;
                        row["Estado"] = productRegistrations[i].state ? "Activo" : "Inactivo";

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

    }
}
