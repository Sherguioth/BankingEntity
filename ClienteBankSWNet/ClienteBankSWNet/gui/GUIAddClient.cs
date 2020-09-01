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
    public partial class GUIAddClient : Form
    {
        private ClientController clientController;
        public GUIAddClient()
        {
            InitializeComponent();
            this.clientController = ClientController.Instance;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
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
                if (this.clientController.AddClient(strIdNumber, docType, name, birthday, email, phoneNumber, gender))
                {
                    MessageBox.Show("El cliente " + name + " ha sido agregado correctamente.", "Cliente agregado");

                    txtIdentificationNumber.Text = "";
                    comboBoxDocType.SelectedItem = null;
                    txtName.Text = "";
                    datePickerBirthday.Value = DateTime.Today;
                    txtEmail.Text = "";
                    txtPhoneNumber.Text = ""; 
                    comboBoxGender.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar el cliente", "Advertencia");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }
    }
}
