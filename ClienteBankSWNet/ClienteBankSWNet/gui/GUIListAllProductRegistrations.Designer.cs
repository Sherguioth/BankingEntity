namespace ClienteBankSWNet.gui
{
    partial class GUIListAllProductRegistrations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTitle = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.dataGridProductRegistrations = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labProductType = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.labState = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductRegistrations)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(239, 12);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(284, 41);
            this.labTitle.TabIndex = 59;
            this.labTitle.Text = "Registro cliente";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.dataGridProductRegistrations);
            this.panelPrincipal.Controls.Add(this.btnReload);
            this.panelPrincipal.Controls.Add(this.panelFilters);
            this.panelPrincipal.Controls.Add(this.btnFilter);
            this.panelPrincipal.Controls.Add(this.labTitle);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(776, 426);
            this.panelPrincipal.TabIndex = 60;
            // 
            // dataGridProductRegistrations
            // 
            this.dataGridProductRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductRegistrations.Location = new System.Drawing.Point(3, 156);
            this.dataGridProductRegistrations.Name = "dataGridProductRegistrations";
            this.dataGridProductRegistrations.Size = new System.Drawing.Size(766, 263);
            this.dataGridProductRegistrations.TabIndex = 67;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(567, 108);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(149, 33);
            this.btnReload.TabIndex = 66;
            this.btnReload.Text = "Recargar Registros";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panelFilters
            // 
            this.panelFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilters.Controls.Add(this.comboBoxState);
            this.panelFilters.Controls.Add(this.labProductType);
            this.panelFilters.Controls.Add(this.comboBoxProductType);
            this.panelFilters.Controls.Add(this.labState);
            this.panelFilters.Location = new System.Drawing.Point(45, 69);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(494, 72);
            this.panelFilters.TabIndex = 65;
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxState.Location = new System.Drawing.Point(356, 26);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 63;
            // 
            // labProductType
            // 
            this.labProductType.AutoSize = true;
            this.labProductType.Location = new System.Drawing.Point(12, 29);
            this.labProductType.Name = "labProductType";
            this.labProductType.Size = new System.Drawing.Size(91, 13);
            this.labProductType.TabIndex = 60;
            this.labProductType.Text = "Tipo de producto:";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(109, 26);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductType.TabIndex = 61;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(253, 29);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(97, 13);
            this.labState.TabIndex = 62;
            this.labState.Text = "Estado del registro:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(567, 69);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(149, 32);
            this.btnFilter.TabIndex = 64;
            this.btnFilter.Text = "Filtrar Registros";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // GUIListAllProductRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "GUIListAllProductRegistrations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar registro de produtos";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductRegistrations)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.DataGridView dataGridProductRegistrations;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labProductType;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Button btnFilter;
    }
}