namespace ClientBankSWNet.gui
{
    partial class GUIDeleteProductRegistration
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.datePickerExpiration = new System.Windows.Forms.DateTimePicker();
            this.datePickerRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.comboBoxProductCode = new System.Windows.Forms.ComboBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.labState = new System.Windows.Forms.Label();
            this.labDateExpiration = new System.Windows.Forms.Label();
            this.labDateRegistration = new System.Windows.Forms.Label();
            this.labBalance = new System.Windows.Forms.Label();
            this.labProductNumber = new System.Windows.Forms.Label();
            this.labProductCode = new System.Windows.Forms.Label();
            this.labClientId = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(396, 103);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 23);
            this.btnFind.TabIndex = 130;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 129;
            this.btnDelete.Text = "Eliminar registro";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(144, 236);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(341, 20);
            this.txtState.TabIndex = 128;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(450, 75);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(35, 23);
            this.btnFindClient.TabIndex = 127;
            this.btnFindClient.Text = "...";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // datePickerExpiration
            // 
            this.datePickerExpiration.Location = new System.Drawing.Point(144, 209);
            this.datePickerExpiration.Name = "datePickerExpiration";
            this.datePickerExpiration.Size = new System.Drawing.Size(341, 20);
            this.datePickerExpiration.TabIndex = 126;
            // 
            // datePickerRegistration
            // 
            this.datePickerRegistration.Location = new System.Drawing.Point(144, 183);
            this.datePickerRegistration.Name = "datePickerRegistration";
            this.datePickerRegistration.Size = new System.Drawing.Size(341, 20);
            this.datePickerRegistration.TabIndex = 125;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(144, 157);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(341, 20);
            this.txtBalance.TabIndex = 124;
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(144, 130);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(341, 20);
            this.txtProductNumber.TabIndex = 123;
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.Location = new System.Drawing.Point(144, 103);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.Size = new System.Drawing.Size(246, 21);
            this.comboBoxProductCode.TabIndex = 122;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(144, 77);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(299, 20);
            this.txtClientId.TabIndex = 121;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(18, 242);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(46, 13);
            this.labState.TabIndex = 120;
            this.labState.Text = "Estado: ";
            // 
            // labDateExpiration
            // 
            this.labDateExpiration.AutoSize = true;
            this.labDateExpiration.Location = new System.Drawing.Point(18, 215);
            this.labDateExpiration.Name = "labDateExpiration";
            this.labDateExpiration.Size = new System.Drawing.Size(115, 13);
            this.labDateExpiration.TabIndex = 119;
            this.labDateExpiration.Text = "Fecha de vencimiento:";
            // 
            // labDateRegistration
            // 
            this.labDateRegistration.AutoSize = true;
            this.labDateRegistration.Location = new System.Drawing.Point(18, 189);
            this.labDateRegistration.Name = "labDateRegistration";
            this.labDateRegistration.Size = new System.Drawing.Size(109, 13);
            this.labDateRegistration.TabIndex = 118;
            this.labDateRegistration.Text = "Fecha de expedición:";
            // 
            // labBalance
            // 
            this.labBalance.AutoSize = true;
            this.labBalance.Location = new System.Drawing.Point(18, 160);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(40, 13);
            this.labBalance.TabIndex = 117;
            this.labBalance.Text = "Saldo: ";
            // 
            // labProductNumber
            // 
            this.labProductNumber.AutoSize = true;
            this.labProductNumber.Location = new System.Drawing.Point(18, 133);
            this.labProductNumber.Name = "labProductNumber";
            this.labProductNumber.Size = new System.Drawing.Size(107, 13);
            this.labProductNumber.TabIndex = 116;
            this.labProductNumber.Text = "Número de producto:";
            // 
            // labProductCode
            // 
            this.labProductCode.AutoSize = true;
            this.labProductCode.Location = new System.Drawing.Point(18, 106);
            this.labProductCode.Name = "labProductCode";
            this.labProductCode.Size = new System.Drawing.Size(56, 13);
            this.labProductCode.TabIndex = 115;
            this.labProductCode.Text = "Producto: ";
            // 
            // labClientId
            // 
            this.labClientId.AutoSize = true;
            this.labClientId.Location = new System.Drawing.Point(18, 80);
            this.labClientId.Name = "labClientId";
            this.labClientId.Size = new System.Drawing.Size(120, 13);
            this.labClientId.TabIndex = 114;
            this.labClientId.Text = "Documento del Cliente: ";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(103, 24);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(326, 41);
            this.labTitle.TabIndex = 113;
            this.labTitle.Text = "Eliminar Registro";
            // 
            // GUIDeleteProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.datePickerExpiration);
            this.Controls.Add(this.datePickerRegistration);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtProductNumber);
            this.Controls.Add(this.comboBoxProductCode);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.labDateExpiration);
            this.Controls.Add(this.labDateRegistration);
            this.Controls.Add(this.labBalance);
            this.Controls.Add(this.labProductNumber);
            this.Controls.Add(this.labProductCode);
            this.Controls.Add(this.labClientId);
            this.Controls.Add(this.labTitle);
            this.Name = "GUIDeleteProductRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.DateTimePicker datePickerExpiration;
        private System.Windows.Forms.DateTimePicker datePickerRegistration;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.ComboBox comboBoxProductCode;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Label labDateExpiration;
        private System.Windows.Forms.Label labDateRegistration;
        private System.Windows.Forms.Label labBalance;
        private System.Windows.Forms.Label labProductNumber;
        private System.Windows.Forms.Label labProductCode;
        private System.Windows.Forms.Label labClientId;
        private System.Windows.Forms.Label labTitle;
    }
}