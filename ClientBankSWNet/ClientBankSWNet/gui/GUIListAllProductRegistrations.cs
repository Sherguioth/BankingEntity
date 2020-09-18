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
    public partial class GUIListAllProductRegistrations : Form
    {
        private ProductController productController;
        private ProductRegistrationController productRegistrationController;

        public GUIListAllProductRegistrations()
        {
            InitializeComponent();

            this.productController = ProductController.Instance;
            this.productRegistrationController = ProductRegistrationController.Instance;

            this.loadDataTable();
            this.loadDataFilter();
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, object>> productRegistrations = await this.productRegistrationController.ListAllProductRegistations();

            if (comboBoxProductType.SelectedItem == null && comboBoxState.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccionar un parámetro de filtrado", "Advertencia");
            }
            else
            {
                DataTable dataTable = new DataTable();
                DataRow row;

                dataTable.Columns.Add(new DataColumn("Código de producto"));
                dataTable.Columns.Add(new DataColumn("Cliente"));
                dataTable.Columns.Add(new DataColumn("Número de producto"));
                dataTable.Columns.Add(new DataColumn("Saldo"));
                dataTable.Columns.Add(new DataColumn("Fecha de registro"));
                dataTable.Columns.Add(new DataColumn("Fecha de expiración"));
                dataTable.Columns.Add(new DataColumn("Estado"));

                if (comboBoxProductType.SelectedItem == null && !(comboBoxState.SelectedItem == null))
                {
                    bool state = comboBoxState.SelectedItem.ToString().Equals("Activo") ? true : false;

                    foreach (Dictionary<string, object> productRegistration in productRegistrations)
                    {
                        if (productRegistration["state"].Equals(state))
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
                }
                else if (!(comboBoxProductType.SelectedItem == null) && comboBoxState.SelectedItem == null)
                {
                    List<Dictionary<string, object>> products = await this.productController.ListAllProducts();
                    String strProductType = comboBoxProductType.SelectedItem.ToString();
                    int productCode = -1;

                    foreach (Dictionary<string, object> product in products)
                    {
                        if (product["name"].Equals(strProductType))
                        {
                            productCode = int.Parse(product["code"].ToString());
                            break;
                        }
                    }

                    foreach (Dictionary<string, object> productRegistration in productRegistrations)
                    {
                        int productCodeRegistration = int.Parse(productRegistration["productCode"].ToString());
                        if (productCodeRegistration == productCode)
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
                }
                else
                {
                    bool state = comboBoxState.SelectedItem.ToString().Equals("Activo") ? true : false;
                    List<Dictionary<string, object>> products = await this.productController.ListAllProducts();
                    String strProductType = comboBoxProductType.SelectedItem.ToString();
                    int productCode = -1;

                    foreach (Dictionary<string, object> product in products)
                    {
                        if (product["name"].Equals(strProductType))
                        {
                            productCode = int.Parse(product["code"].ToString());
                            break;
                        }
                    }

                    foreach (Dictionary<string, object> productRegistration in productRegistrations)
                    {
                        int productCodeRegistration = int.Parse(productRegistration["productCode"].ToString());
                        if (productCodeRegistration == productCode && productRegistration["state"].Equals(state))
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
                }

                dataGridProductRegistrations.DataSource = dataTable;
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.loadDataTable();
        }


        private async void loadDataFilter()
        {
            comboBoxProductType.Items.Clear();

            List<Dictionary<string, object>> products = await this.productController.ListAllProducts();
            foreach (Dictionary<string, object> product in products)
            {
                comboBoxProductType.Items.Add(product["name"].ToString());
            }
        }

        private async void loadDataTable()
        {
            try
            {
                comboBoxProductType.SelectedItem = null;
                comboBoxState.SelectedItem = null;

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

                dataGridProductRegistrations.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");
            }
        }
    }
}
