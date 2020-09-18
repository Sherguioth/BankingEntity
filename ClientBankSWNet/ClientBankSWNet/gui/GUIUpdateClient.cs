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
    public partial class GUIUpdateClient : Form
    {
        private ClientController clientController;

        public GUIUpdateClient()
        {
            InitializeComponent();

            this.clientController = ClientController.Instance;
        }

        private async void btnFindClient_Click(object sender, EventArgs e)
        {
            string strIdNumber = txtIdentificationNumber.Text.Trim();

            try
            {
                Dictionary<string, object> client = await this.clientController.FindClient(strIdNumber);

                txtIdentificationNumber.Text = Convert.ToString(client["identificationNumber"].ToString());
                comboBoxDocType.SelectedItem = client["documetType"].ToString();
                txtName.Text = client["name"].ToString();
                datePickerBirthday.Value = DateTime.Parse(client["birthday"].ToString());
                txtEmail.Text = client["email"].ToString();
                txtPhoneNumber.Text = client["phoneNumber"].ToString();
                comboBoxGender.SelectedItem = client["gender"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia");
            }
        }

        private async void btnUpdateClient_Click(object sender, EventArgs e)
        {
            String strIdNumber = txtIdentificationNumber.Text.Trim();
            String docType = comboBoxDocType.SelectedItem.ToString().Trim();
            String name = txtName.Text.Trim();
            DateTime birthday = datePickerBirthday.Value;
            String email = txtEmail.Text.Trim();
            String phoneNumber = txtPhoneNumber.Text.Trim();
            String gender = comboBoxGender.SelectedItem.ToString().Trim();

            try
            {
                if (await this.clientController.UpdateClient(strIdNumber, docType, name, birthday, email, phoneNumber, gender))
                {
                    MessageBox.Show("Los datos del cliente han sido actualizados correctamente.", "Datos actualizados");
                }
                else
                {
                    MessageBox.Show("No se han podido acutlizar los datos del cliente", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }
    }
}
