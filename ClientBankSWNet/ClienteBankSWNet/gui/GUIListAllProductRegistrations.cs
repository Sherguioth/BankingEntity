using ClienteBankSWNet.controller;
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ProductRegistration[] productRegistrations = this.productRegistrationController.ListAllProductRegistations();

            if(comboBoxProductType.SelectedItem == null && comboBoxState.SelectedItem == null)
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

                    for (int i = 0; i < productRegistrations.Length; i++)
                    {
                        if (productRegistrations[i].state == state)
                        {
                            row = dataTable.NewRow();
                            row["Código de producto"] = Convert.ToString(productRegistrations[i].productCode);
                            row["Cliente"] = productRegistrations[i].clientId;
                            row["Número de producto"] = productRegistrations[i].productNumber;
                            row["Saldo"] = productRegistrations[i].balance;
                            row["Fecha de registro"] = productRegistrations[i].registrationDate;
                            row["Fecha de expiración"] = productRegistrations[i].expirationDate;
                            row["Estado"] = productRegistrations[i].state ? "Activo" : "Inactivo";

                            dataTable.Rows.Add(row);
                        }
                    }
                }
                else if (!(comboBoxProductType.SelectedItem == null) && comboBoxState.SelectedItem == null)
                {
                    Product[] products = this.productController.ListAllProducts();
                    String strProductType = comboBoxProductType.SelectedItem.ToString();
                    int productCode = -1;

                    bool found = false;
                    for (int i = 0; i < products.Length && !found; i++)
                    {
                        if (products[i].name.Equals(strProductType))
                        {
                            productCode = products[i].code;
                            found = true;
                        }
                    }

                    for (int i = 0; i < productRegistrations.Length; i++)
                    {
                        if (productRegistrations[i].productCode == productCode)
                        {
                            row = dataTable.NewRow();
                            row["Código de producto"] = Convert.ToString(productRegistrations[i].productCode);
                            row["Cliente"] = productRegistrations[i].clientId;
                            row["Número de producto"] = productRegistrations[i].productNumber;
                            row["Saldo"] = productRegistrations[i].balance;
                            row["Fecha de registro"] = productRegistrations[i].registrationDate;
                            row["Fecha de expiración"] = productRegistrations[i].expirationDate;
                            row["Estado"] = productRegistrations[i].state ? "Activo" : "Inactivo";

                            dataTable.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    bool state = comboBoxState.SelectedItem.ToString().Equals("Activo") ? true : false;
                    Product[] products = this.productController.ListAllProducts();
                    String strProductType = comboBoxProductType.SelectedItem.ToString();
                    int productCode = -1;

                    bool found = false;
                    for (int i = 0; i < products.Length && !found; i++)
                    {
                        if (products[i].name.Equals(strProductType))
                        {
                            productCode = products[i].code;
                            found = true;
                        }
                    }

                    for (int i = 0; i < productRegistrations.Length; i++)
                    {
                        if (productRegistrations[i].productCode == productCode && productRegistrations[i].state == state)
                        {
                            row = dataTable.NewRow();
                            row["Código de producto"] = Convert.ToString(productRegistrations[i].productCode);
                            row["Cliente"] = productRegistrations[i].clientId;
                            row["Número de producto"] = productRegistrations[i].productNumber;
                            row["Saldo"] = productRegistrations[i].balance;
                            row["Fecha de registro"] = productRegistrations[i].registrationDate;
                            row["Fecha de expiración"] = productRegistrations[i].expirationDate;
                            row["Estado"] = productRegistrations[i].state ? "Activo" : "Inactivo";

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


        private void loadDataFilter()
        {
            comboBoxProductType.Items.Clear();

            Product[] products = this.productController.ListAllProducts();
            for (int i = 0; i < products.Length; i++)
            {
                comboBoxProductType.Items.Add(products[i].name);
            }
        }

        private void loadDataTable()
        {
            try
            {
                comboBoxProductType.SelectedItem = null;
                comboBoxState.SelectedItem = null;

                ProductRegistration[] productRegistrations = this.productRegistrationController.ListAllProductRegistations();

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
                    row = dataTable.NewRow();
                    row["Código de producto"] = Convert.ToString(productRegistrations[i].productCode);
                    row["Cliente"] = productRegistrations[i].clientId;
                    row["Número de producto"] = productRegistrations[i].productNumber;
                    row["Saldo"] = productRegistrations[i].balance;
                    row["Fecha de registro"] = productRegistrations[i].registrationDate;
                    row["Fecha de expiración"] = productRegistrations[i].expirationDate;
                    row["Estado"] = productRegistrations[i].state ? "Activo" : "Inactivo";

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
