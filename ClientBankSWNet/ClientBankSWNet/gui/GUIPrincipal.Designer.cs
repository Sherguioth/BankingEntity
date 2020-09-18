namespace ClientBankSWNet
{
    partial class GUIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIPrincipal));
            this.pictureBoxPrincipal = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.menuPrincipalOptions = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClients = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListClients = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFindClient = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProductRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListAllProductRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListProductRegistrationByClient = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAddProductRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFindProductRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUpdateProductRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeleteProductRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrincipal)).BeginInit();
            this.menuPrincipalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPrincipal
            // 
            this.pictureBoxPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrincipal.Image")));
            this.pictureBoxPrincipal.Location = new System.Drawing.Point(22, 85);
            this.pictureBoxPrincipal.Name = "pictureBoxPrincipal";
            this.pictureBoxPrincipal.Size = new System.Drawing.Size(493, 465);
            this.pictureBoxPrincipal.TabIndex = 62;
            this.pictureBoxPrincipal.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(184, 41);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(179, 41);
            this.labTitle.TabIndex = 61;
            this.labTitle.Text = "The Bank";
            // 
            // menuPrincipalOptions
            // 
            this.menuPrincipalOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemClients,
            this.menuItemProductRegistration,
            this.menuItemHelp});
            this.menuPrincipalOptions.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipalOptions.Name = "menuPrincipalOptions";
            this.menuPrincipalOptions.Size = new System.Drawing.Size(540, 24);
            this.menuPrincipalOptions.TabIndex = 60;
            this.menuPrincipalOptions.Text = "menuStrip2";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(60, 20);
            this.menuItemFile.Text = "Archivo";
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(96, 22);
            this.itemExit.Text = "Salir";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // menuItemClients
            // 
            this.menuItemClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemListClients,
            this.itemAddClient,
            this.itemFindClient,
            this.itemUpdateClient,
            this.itemDeleteClient});
            this.menuItemClients.Name = "menuItemClients";
            this.menuItemClients.Size = new System.Drawing.Size(61, 20);
            this.menuItemClients.Text = "Clientes";
            // 
            // itemListClients
            // 
            this.itemListClients.Name = "itemListClients";
            this.itemListClients.Size = new System.Drawing.Size(180, 22);
            this.itemListClients.Text = "Listar clientes";
            this.itemListClients.Click += new System.EventHandler(this.itemListClients_Click);
            // 
            // itemAddClient
            // 
            this.itemAddClient.Name = "itemAddClient";
            this.itemAddClient.Size = new System.Drawing.Size(180, 22);
            this.itemAddClient.Text = "Agregar cliente";
            this.itemAddClient.Click += new System.EventHandler(this.itemAddClient_Click);
            // 
            // itemFindClient
            // 
            this.itemFindClient.Name = "itemFindClient";
            this.itemFindClient.Size = new System.Drawing.Size(180, 22);
            this.itemFindClient.Text = "Buscar cliente";
            this.itemFindClient.Click += new System.EventHandler(this.itemFindClient_Click);
            // 
            // itemUpdateClient
            // 
            this.itemUpdateClient.Name = "itemUpdateClient";
            this.itemUpdateClient.Size = new System.Drawing.Size(180, 22);
            this.itemUpdateClient.Text = "Actualizar cliente";
            this.itemUpdateClient.Click += new System.EventHandler(this.itemUpdateClient_Click);
            // 
            // itemDeleteClient
            // 
            this.itemDeleteClient.Name = "itemDeleteClient";
            this.itemDeleteClient.Size = new System.Drawing.Size(180, 22);
            this.itemDeleteClient.Text = "Eliminar cliente";
            this.itemDeleteClient.Click += new System.EventHandler(this.itemDeleteClient_Click);
            // 
            // menuItemProductRegistration
            // 
            this.menuItemProductRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemListAllProductRegistration,
            this.itemListProductRegistrationByClient,
            this.itemAddProductRegistration,
            this.itemFindProductRegistration,
            this.itemUpdateProductRegistration,
            this.itemDeleteProductRegistration});
            this.menuItemProductRegistration.Name = "menuItemProductRegistration";
            this.menuItemProductRegistration.Size = new System.Drawing.Size(67, 20);
            this.menuItemProductRegistration.Text = "Registros";
            // 
            // itemListAllProductRegistration
            // 
            this.itemListAllProductRegistration.Name = "itemListAllProductRegistration";
            this.itemListAllProductRegistration.Size = new System.Drawing.Size(236, 22);
            this.itemListAllProductRegistration.Text = "Listar todos los registros";
            this.itemListAllProductRegistration.Click += new System.EventHandler(this.itemListAllProductRegistration_Click);
            // 
            // itemListProductRegistrationByClient
            // 
            this.itemListProductRegistrationByClient.Name = "itemListProductRegistrationByClient";
            this.itemListProductRegistrationByClient.Size = new System.Drawing.Size(236, 22);
            this.itemListProductRegistrationByClient.Text = "Listar registros por cliente";
            this.itemListProductRegistrationByClient.Click += new System.EventHandler(this.itemListProductRegistrationByClient_Click);
            // 
            // itemAddProductRegistration
            // 
            this.itemAddProductRegistration.Name = "itemAddProductRegistration";
            this.itemAddProductRegistration.Size = new System.Drawing.Size(236, 22);
            this.itemAddProductRegistration.Text = "Registrar producto a un cliente";
            this.itemAddProductRegistration.Click += new System.EventHandler(this.itemAddProductRegistration_Click);
            // 
            // itemFindProductRegistration
            // 
            this.itemFindProductRegistration.Name = "itemFindProductRegistration";
            this.itemFindProductRegistration.Size = new System.Drawing.Size(236, 22);
            this.itemFindProductRegistration.Text = "Buscar registro";
            this.itemFindProductRegistration.Click += new System.EventHandler(this.itemFindProductRegistration_Click);
            // 
            // itemUpdateProductRegistration
            // 
            this.itemUpdateProductRegistration.Name = "itemUpdateProductRegistration";
            this.itemUpdateProductRegistration.Size = new System.Drawing.Size(236, 22);
            this.itemUpdateProductRegistration.Text = "Actualizar registro";
            this.itemUpdateProductRegistration.Click += new System.EventHandler(this.itemUpdateProductRegistration_Click);
            // 
            // itemDeleteProductRegistration
            // 
            this.itemDeleteProductRegistration.Name = "itemDeleteProductRegistration";
            this.itemDeleteProductRegistration.Size = new System.Drawing.Size(236, 22);
            this.itemDeleteProductRegistration.Text = "Eliminar Registro";
            this.itemDeleteProductRegistration.Click += new System.EventHandler(this.itemDeleteProductRegistration_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(53, 20);
            this.menuItemHelp.Text = "Ayuda";
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(180, 22);
            this.itemAbout.Text = "Acerca de...";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 556);
            this.Controls.Add(this.pictureBoxPrincipal);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.menuPrincipalOptions);
            this.Name = "GUIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankEntity ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrincipal)).EndInit();
            this.menuPrincipalOptions.ResumeLayout(false);
            this.menuPrincipalOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPrincipal;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.MenuStrip menuPrincipalOptions;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemClients;
        private System.Windows.Forms.ToolStripMenuItem itemListClients;
        private System.Windows.Forms.ToolStripMenuItem itemAddClient;
        private System.Windows.Forms.ToolStripMenuItem itemFindClient;
        private System.Windows.Forms.ToolStripMenuItem itemUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteClient;
        private System.Windows.Forms.ToolStripMenuItem menuItemProductRegistration;
        private System.Windows.Forms.ToolStripMenuItem itemListAllProductRegistration;
        private System.Windows.Forms.ToolStripMenuItem itemListProductRegistrationByClient;
        private System.Windows.Forms.ToolStripMenuItem itemAddProductRegistration;
        private System.Windows.Forms.ToolStripMenuItem itemFindProductRegistration;
        private System.Windows.Forms.ToolStripMenuItem itemUpdateProductRegistration;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteProductRegistration;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
    }
}

