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
using ClienteBankSWNet.structural;

namespace ClienteBankSWNet.gui
{
    public partial class GUIUpdateClient : Form
    {
        private ClientController clientController;

        public GUIUpdateClient()
        {
            InitializeComponent();

            this.clientController = ClientController.Instance;
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            String strIdNumber = txtIdentificationNumber.Text.Trim();

            try
            {
                Client client = this.clientController.FindClient(strIdNumber);

                txtIdentificationNumber.Text = Convert.ToString(client.identificationNumber);
                comboBoxDocType.SelectedItem = client.documetType;
                txtName.Text = client.name;
                datePickerBirthday.Value = DateTime.Parse(client.birthday);
                txtEmail.Text = client.email;
                txtPhoneNumber.Text = client.phoneNumber;
                comboBoxGender.SelectedItem = client.gender;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia");
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
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
                if (this.clientController.UpdateClient(strIdNumber, docType, name, birthday, email, phoneNumber, gender))
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
