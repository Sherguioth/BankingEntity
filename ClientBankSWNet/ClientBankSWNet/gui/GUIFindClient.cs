﻿using ClientBankSWNet.controller;
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
    public partial class GUIFindClient : Form
    {
        private ClientController clientController;

        public GUIFindClient()
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
                txtDocType.Text = client["documetType"].ToString();
                txtName.Text = client["name"].ToString();
                datePickerBirthday.Value = DateTime.Parse(client["birthday"].ToString());
                txtEmail.Text = client["email"].ToString();
                txtPhoneNumber.Text = client["phoneNumber"].ToString();
                txtGender.Text = client["gender"].ToString();

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
    }
}
