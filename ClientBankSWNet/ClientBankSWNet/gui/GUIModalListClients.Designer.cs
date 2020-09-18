namespace ClientBankSWNet.gui
{
    partial class GUIModalListClients
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.labTitle = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.dataGridViewClients);
            this.panelPrincipal.Controls.Add(this.labTitle);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(776, 426);
            this.panelPrincipal.TabIndex = 1;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.Size = new System.Drawing.Size(753, 344);
            this.dataGridViewClients.TabIndex = 60;
            this.dataGridViewClients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClients_CellMouseClick);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(249, 14);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(292, 41);
            this.labTitle.TabIndex = 59;
            this.labTitle.Text = "Lista de Clientes";
            // 
            // GUIModalListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "GUIModalListClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label labTitle;
    }
}