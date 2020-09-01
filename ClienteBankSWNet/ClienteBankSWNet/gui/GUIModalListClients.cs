using ClienteBankSWNet.ClientWebService;
using ClienteBankSWNet.controller;
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

        private void loadDataTable()
        {
            client[] clients = this.clientController.ListAllClients();

            DataTable dataTable = new DataTable();
            DataRow row;

            dataTable.Columns.Add(new DataColumn("Número de Identificación"));
            dataTable.Columns.Add(new DataColumn("Tipo de documento"));
            dataTable.Columns.Add(new DataColumn("Nombre"));
            dataTable.Columns.Add(new DataColumn("Fecha de Nacimiento"));
            dataTable.Columns.Add(new DataColumn("E-mail"));
            dataTable.Columns.Add(new DataColumn("Telefono"));
            dataTable.Columns.Add(new DataColumn("Género"));

            for (int i = 0; i < clients.Length; i++)
            {
                row = dataTable.NewRow();
                row["Número de Identificación"] = Convert.ToString(clients[i].identificationNumber);
                row["Tipo de documento"] = clients[i].documetType;
                row["Nombre"] = clients[i].name;
                row["Fecha de Nacimiento"] = clients[i].birthday;
                row["E-mail"] = clients[i].email;
                row["Telefono"] = clients[i].phoneNumber;
                row["Género"] = clients[i].gender;

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
