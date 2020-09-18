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
    public partial class GUIListClients : Form
    {
        private ClientController clientController;
        public GUIListClients()
        {
            InitializeComponent();

            this.clientController = ClientController.Instance;
            this.loadDataTable();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            this.loadDataTable();
        }

        private async void loadDataTable()
        {
            List<Dictionary<string, object>> clients = await this.clientController.ListAllClients();

            DataTable dataTable = new DataTable();
            DataRow row;

            dataTable.Columns.Add(new DataColumn("Número de Identificación"));
            dataTable.Columns.Add(new DataColumn("Tipo de documento"));
            dataTable.Columns.Add(new DataColumn("Nombre"));
            dataTable.Columns.Add(new DataColumn("Fecha de Nacimiento"));
            dataTable.Columns.Add(new DataColumn("E-mail"));
            dataTable.Columns.Add(new DataColumn("Telefono"));
            dataTable.Columns.Add(new DataColumn("Género"));

            foreach (Dictionary<string, object> dict in clients)
            {
                row = dataTable.NewRow();
                row["Número de Identificación"] = Convert.ToString(dict["identificationNumber"].ToString());
                row["Tipo de documento"] = dict["documetType"].ToString();
                row["Nombre"] = dict["name"].ToString();
                row["Fecha de Nacimiento"] = dict["birthday"].ToString();
                row["E-mail"] = dict["email"].ToString();
                row["Telefono"] = dict["phoneNumber"].ToString();
                row["Género"] = dict["gender"].ToString();

                dataTable.Rows.Add(row);
            }

            dataGridViewClients.DataSource = dataTable;
        }
    }
}
