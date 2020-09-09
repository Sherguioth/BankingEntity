using ClienteBankSWNet.controller;
using ClienteBankSWNet.ClientWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteBankSWNet.structural;

namespace ClienteBankSWNet.gui
{
    public partial class GUIDeleteClient : Form
    {
        private ClientController clientController;

        public GUIDeleteClient()
        {
            InitializeComponent();
            this.clientController = ClientController.Instance;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            string strIdNumber = txtIdentificationNumber.Text.Trim();

            try
            {
                Client client = this.clientController.FindClient(strIdNumber);

                txtIdentificationNumber.Text = Convert.ToString(client.identificationNumber);
                txtDocType.Text = client.documetType;
                txtName.Text = client.name;
                datePickerBirthday.Value = DateTime.Parse(client.birthday);
                txtEmail.Text = client.email;
                txtPhoneNumber.Text = client.phoneNumber;
                txtGender.Text = client.gender;

                txtDocType.Enabled = false;
                txtName.Enabled = false;
                datePickerBirthday.Enabled = false;
                txtEmail.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtGender.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia");
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            string strIdNumber = txtIdentificationNumber.Text.Trim();

            try
            {
                if (this.clientController.DeleteClient(strIdNumber))
                {
                    MessageBox.Show("El cliente ha sido eliminado correctamente.", "Cofirmación");

                    txtIdentificationNumber.Text = "";
                    txtDocType.Text = "";
                    txtName.Text = "";
                    datePickerBirthday.Value = DateTime.Today;
                    txtEmail.Text = "";
                    txtPhoneNumber.Text = "";
                    txtGender.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia");
            }
        }
    }
}
