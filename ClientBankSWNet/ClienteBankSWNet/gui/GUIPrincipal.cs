using ClienteBankSWNet.controller;
using ClienteBankSWNet.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteBankSWNet
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Ezequiel Melo & Andrés Novoa  v. 2.0", "Acerca de...");
        }

        private void itemListClients_Click(object sender, EventArgs e)
        {
            GUIListClients gui = new GUIListClients();
            gui.Show();
        }

        private void itemAddClient_Click(object sender, EventArgs e)
        {
            GUIAddClient gui = new GUIAddClient();
            gui.Show();
        }

        private void itemFindClient_Click(object sender, EventArgs e)
        {
            GUIFindClient gui = new GUIFindClient();
            gui.Show();
        }

        private void itemUpdateClient_Click(object sender, EventArgs e)
        {
            GUIUpdateClient gui = new GUIUpdateClient();
            gui.Show();
        }

        private void itemDeleteClient_Click(object sender, EventArgs e)
        {
            GUIDeleteClient gui = new GUIDeleteClient();
            gui.Show();
        }

        private void itemListAllProductRegistration_Click(object sender, EventArgs e)
        {
            GUIListAllProductRegistrations gui = new GUIListAllProductRegistrations();
            gui.Show();
        }

        private void itemListProductRegistrationByClient_Click(object sender, EventArgs e)
        {
            GUIListProductRegistrationByClient gui = new GUIListProductRegistrationByClient();
            gui.Show();
        }

        private void itemAddProductRegistration_Click(object sender, EventArgs e)
        {
            GUIAddProductRegistration gui = new GUIAddProductRegistration();
            gui.Show();
        }

        private void itemFindProductRegistration_Click(object sender, EventArgs e)
        {
            GUIFindProductRegistration gui = new GUIFindProductRegistration();
            gui.Show();
        }

        private void itemUpdateProductRegistration_Click(object sender, EventArgs e)
        {
            GUIUpdateProductRegistration gui = new GUIUpdateProductRegistration();
            gui.Show();
        }

        private void itemDeleteProductRegistration_Click(object sender, EventArgs e)
        {
            GUIDeleteProductRegistration gui = new GUIDeleteProductRegistration();
            gui.Show();
        }
    } 
}
