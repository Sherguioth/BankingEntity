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
    public partial class GUIModalListClients : Form
    {
        private ClientController clientController;
        private String clientId;

        public GUIModalListClients()
        {
            InitializeComponent();
            clientController = ClientController.Instance;
            loadDataTable();
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
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
        }

        private void dataGridViewClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClientIdSelected = dataGridViewClients.Rows[e.RowIndex].Cells[0].Value.ToString();
            Dispose();
        }

        public String ClientIdSelected
        {
            get => clientId;
            set => clientId = value;
        }
    }
}
