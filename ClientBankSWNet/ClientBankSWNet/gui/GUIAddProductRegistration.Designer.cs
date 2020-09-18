namespace ClientBankSWNet.gui
{
    partial class GUIAddProductRegistration
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
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnAddProductRegistration = new System.Windows.Forms.Button();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
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
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(450, 65);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(35, 23);
            this.btnFindClient.TabIndex = 94;
            this.btnFindClient.Text = "...";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnAddProductRegistration
            // 
            this.btnAddProductRegistration.Location = new System.Drawing.Point(205, 263);
            this.btnAddProductRegistration.Name = "btnAddProductRegistration";
            this.btnAddProductRegistration.Size = new System.Drawing.Size(84, 35);
            this.btnAddProductRegistration.TabIndex = 93;
            this.btnAddProductRegistration.Text = "Registrar";
            this.btnAddProductRegistration.UseVisualStyleBackColor = true;
            this.btnAddProductRegistration.Click += new System.EventHandler(this.btnAddProductRegistration_Click);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Location = new System.Drawing.Point(205, 230);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtnInactivo.TabIndex = 92;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Location = new System.Drawing.Point(144, 230);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnActivo.TabIndex = 91;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // datePickerExpiration
            // 
            this.datePickerExpiration.Location = new System.Drawing.Point(144, 199);
            this.datePickerExpiration.Name = "datePickerExpiration";
            this.datePickerExpiration.Size = new System.Drawing.Size(341, 20);
            this.datePickerExpiration.TabIndex = 90;
            // 
            // datePickerRegistration
            // 
            this.datePickerRegistration.Location = new System.Drawing.Point(144, 173);
            this.datePickerRegistration.Name = "datePickerRegistration";
            this.datePickerRegistration.Size = new System.Drawing.Size(341, 20);
            this.datePickerRegistration.TabIndex = 89;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(144, 147);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(341, 20);
            this.txtBalance.TabIndex = 88;
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(144, 120);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(341, 20);
            this.txtProductNumber.TabIndex = 87;
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.Location = new System.Drawing.Point(144, 93);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.Size = new System.Drawing.Size(341, 21);
            this.comboBoxProductCode.TabIndex = 86;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(144, 67);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(299, 20);
            this.txtClientId.TabIndex = 85;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(18, 232);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(46, 13);
            this.labState.TabIndex = 84;
            this.labState.Text = "Estado: ";
            // 
            // labDateExpiration
            // 
            this.labDateExpiration.AutoSize = true;
            this.labDateExpiration.Location = new System.Drawing.Point(18, 205);
            this.labDateExpiration.Name = "labDateExpiration";
            this.labDateExpiration.Size = new System.Drawing.Size(115, 13);
            this.labDateExpiration.TabIndex = 83;
            this.labDateExpiration.Text = "Fecha de vencimiento:";
            // 
            // labDateRegistration
            // 
            this.labDateRegistration.AutoSize = true;
            this.labDateRegistration.Location = new System.Drawing.Point(18, 179);
            this.labDateRegistration.Name = "labDateRegistration";
            this.labDateRegistration.Size = new System.Drawing.Size(109, 13);
            this.labDateRegistration.TabIndex = 82;
            this.labDateRegistration.Text = "Fecha de expedición:";
            // 
            // labBalance
            // 
            this.labBalance.AutoSize = true;
            this.labBalance.Location = new System.Drawing.Point(18, 150);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(40, 13);
            this.labBalance.TabIndex = 81;
            this.labBalance.Text = "Saldo: ";
            // 
            // labProductNumber
            // 
            this.labProductNumber.AutoSize = true;
            this.labProductNumber.Location = new System.Drawing.Point(18, 123);
            this.labProductNumber.Name = "labProductNumber";
            this.labProductNumber.Size = new System.Drawing.Size(107, 13);
            this.labProductNumber.TabIndex = 80;
            this.labProductNumber.Text = "Número de producto:";
            // 
            // labProductCode
            // 
            this.labProductCode.AutoSize = true;
            this.labProductCode.Location = new System.Drawing.Point(18, 96);
            this.labProductCode.Name = "labProductCode";
            this.labProductCode.Size = new System.Drawing.Size(56, 13);
            this.labProductCode.TabIndex = 79;
            this.labProductCode.Text = "Producto: ";
            // 
            // labClientId
            // 
            this.labClientId.AutoSize = true;
            this.labClientId.Location = new System.Drawing.Point(18, 70);
            this.labClientId.Name = "labClientId";
            this.labClientId.Size = new System.Drawing.Size(120, 13);
            this.labClientId.TabIndex = 78;
            this.labClientId.Text = "Documento del Cliente: ";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(98, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(327, 41);
            this.labTitle.TabIndex = 77;
            this.labTitle.Text = "Registro Producto";
            // 
            // GUIAddProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 311);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.btnAddProductRegistration);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
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
            this.Name = "GUIAddProductRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnAddProductRegistration;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
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