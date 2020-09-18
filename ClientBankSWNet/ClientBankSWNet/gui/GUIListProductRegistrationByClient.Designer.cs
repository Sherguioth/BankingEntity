namespace ClientBankSWNet.gui
{
    partial class GUIListProductRegistrationByClient
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.dataGridProductRegistrations = new System.Windows.Forms.DataGridView();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.labIdClient = new System.Windows.Forms.Label();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.btnGetBalance);
            this.groupBoxData.Controls.Add(this.dataGridProductRegistrations);
            this.groupBoxData.Controls.Add(this.btnFindClient);
            this.groupBoxData.Controls.Add(this.txtClientId);
            this.groupBoxData.Controls.Add(this.labIdClient);
            this.groupBoxData.Location = new System.Drawing.Point(13, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(758, 370);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Registros";
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Location = new System.Drawing.Point(535, 21);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(150, 24);
            this.btnGetBalance.TabIndex = 5;
            this.btnGetBalance.Text = "Dar balance de cliente";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            // 
            // dataGridProductRegistrations
            // 
            this.dataGridProductRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductRegistrations.Location = new System.Drawing.Point(6, 63);
            this.dataGridProductRegistrations.Name = "dataGridProductRegistrations";
            this.dataGridProductRegistrations.Size = new System.Drawing.Size(746, 301);
            this.dataGridProductRegistrations.TabIndex = 3;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(374, 23);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(25, 20);
            this.btnFindClient.TabIndex = 2;
            this.btnFindClient.Text = "...";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(141, 23);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(227, 20);
            this.txtClientId.TabIndex = 1;
            // 
            // labIdClient
            // 
            this.labIdClient.AutoSize = true;
            this.labIdClient.Location = new System.Drawing.Point(15, 26);
            this.labIdClient.Name = "labIdClient";
            this.labIdClient.Size = new System.Drawing.Size(120, 13);
            this.labIdClient.TabIndex = 0;
            this.labIdClient.Text = "Documento del Cliente: ";
            // 
            // GUIListProductRegistrationByClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 394);
            this.Controls.Add(this.groupBoxData);
            this.Name = "GUIListProductRegistrationByClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Productos";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductRegistrations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridProductRegistrations;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label labIdClient;
        private System.Windows.Forms.Button btnGetBalance;
    }
}