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

namespace ClienteBankSWNet.gui
{
    public partial class GUIFindClient : Form
    {
        private ClientController clientController;

        public GUIFindClient()
        {
            InitializeComponent();
            this.clientController = ClientController.Instance;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            String strIdNumber = txtIdentificationNumber.Text.Trim();

            try
            {
                client client = this.clientController.FindClient(strIdNumber);

                txtIdentificationNumber.Text = Convert.ToString(client.identificationNumber);
                txtDocType.Text = client.documetType;
                txtName.Text = client.name;
                datePickerBirthday.Value = client.birthday;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia");
            }
        }
    }
}
