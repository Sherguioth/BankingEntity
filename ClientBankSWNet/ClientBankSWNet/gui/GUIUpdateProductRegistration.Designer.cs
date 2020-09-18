namespace ClientBankSWNet.gui
{
    partial class GUIUpdateProductRegistration
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
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.labClientId = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.labProductCode = new System.Windows.Forms.Label();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.labProductNumber = new System.Windows.Forms.Label();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.labBalance = new System.Windows.Forms.Label();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.labDateRegistration = new System.Windows.Forms.Label();
            this.datePickerExpiration = new System.Windows.Forms.DateTimePicker();
            this.labDateExpiration = new System.Windows.Forms.Label();
            this.datePickerRegistration = new System.Windows.Forms.DateTimePicker();
            this.labState = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.comboBoxProductCode = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.labClientId);
            this.groupBoxForm.Controls.Add(this.btnFind);
            this.groupBoxForm.Controls.Add(this.labProductCode);
            this.groupBoxForm.Controls.Add(this.btnFindClient);
            this.groupBoxForm.Controls.Add(this.labProductNumber);
            this.groupBoxForm.Controls.Add(this.rbtnInactivo);
            this.groupBoxForm.Controls.Add(this.labBalance);
            this.groupBoxForm.Controls.Add(this.rbtnActivo);
            this.groupBoxForm.Controls.Add(this.labDateRegistration);
            this.groupBoxForm.Controls.Add(this.datePickerExpiration);
            this.groupBoxForm.Controls.Add(this.labDateExpiration);
            this.groupBoxForm.Controls.Add(this.datePickerRegistration);
            this.groupBoxForm.Controls.Add(this.labState);
            this.groupBoxForm.Controls.Add(this.txtBalance);
            this.groupBoxForm.Controls.Add(this.txtClientId);
            this.groupBoxForm.Controls.Add(this.txtProductNumber);
            this.groupBoxForm.Controls.Add(this.comboBoxProductCode);
            this.groupBoxForm.Location = new System.Drawing.Point(11, 57);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(482, 213);
            this.groupBoxForm.TabIndex = 117;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Formulario";
            // 
            // labClientId
            // 
            this.labClientId.AutoSize = true;
            this.labClientId.Location = new System.Drawing.Point(5, 22);
            this.labClientId.Name = "labClientId";
            this.labClientId.Size = new System.Drawing.Size(120, 13);
            this.labClientId.TabIndex = 94;
            this.labClientId.Text = "Documento del Cliente: ";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(383, 43);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 23);
            this.btnFind.TabIndex = 113;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // labProductCode
            // 
            this.labProductCode.AutoSize = true;
            this.labProductCode.Location = new System.Drawing.Point(5, 48);
            this.labProductCode.Name = "labProductCode";
            this.labProductCode.Size = new System.Drawing.Size(56, 13);
            this.labProductCode.TabIndex = 95;
            this.labProductCode.Text = "Producto: ";
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(437, 17);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(35, 23);
            this.btnFindClient.TabIndex = 109;
            this.btnFindClient.Text = "...";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // labProductNumber
            // 
            this.labProductNumber.AutoSize = true;
            this.labProductNumber.Location = new System.Drawing.Point(5, 75);
            this.labProductNumber.Name = "labProductNumber";
            this.labProductNumber.Size = new System.Drawing.Size(107, 13);
            this.labProductNumber.TabIndex = 96;
            this.labProductNumber.Text = "Número de producto:";
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Location = new System.Drawing.Point(192, 182);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtnInactivo.TabIndex = 108;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // labBalance
            // 
            this.labBalance.AutoSize = true;
            this.labBalance.Location = new System.Drawing.Point(5, 102);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(40, 13);
            this.labBalance.TabIndex = 97;
            this.labBalance.Text = "Saldo: ";
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Location = new System.Drawing.Point(131, 182);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnActivo.TabIndex = 107;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // labDateRegistration
            // 
            this.labDateRegistration.AutoSize = true;
            this.labDateRegistration.Location = new System.Drawing.Point(5, 131);
            this.labDateRegistration.Name = "labDateRegistration";
            this.labDateRegistration.Size = new System.Drawing.Size(109, 13);
            this.labDateRegistration.TabIndex = 98;
            this.labDateRegistration.Text = "Fecha de expedición:";
            // 
            // datePickerExpiration
            // 
            this.datePickerExpiration.Location = new System.Drawing.Point(131, 151);
            this.datePickerExpiration.Name = "datePickerExpiration";
            this.datePickerExpiration.Size = new System.Drawing.Size(341, 20);
            this.datePickerExpiration.TabIndex = 106;
            // 
            // labDateExpiration
            // 
            this.labDateExpiration.AutoSize = true;
            this.labDateExpiration.Location = new System.Drawing.Point(5, 157);
            this.labDateExpiration.Name = "labDateExpiration";
            this.labDateExpiration.Size = new System.Drawing.Size(115, 13);
            this.labDateExpiration.TabIndex = 99;
            this.labDateExpiration.Text = "Fecha de vencimiento:";
            // 
            // datePickerRegistration
            // 
            this.datePickerRegistration.Location = new System.Drawing.Point(131, 125);
            this.datePickerRegistration.Name = "datePickerRegistration";
            this.datePickerRegistration.Size = new System.Drawing.Size(341, 20);
            this.datePickerRegistration.TabIndex = 105;
            // 
            // labState
            // 
            this.labState.AutoSize = true;
            this.labState.Location = new System.Drawing.Point(5, 184);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(46, 13);
            this.labState.TabIndex = 100;
            this.labState.Text = "Estado: ";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(131, 99);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(341, 20);
            this.txtBalance.TabIndex = 104;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(131, 19);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(299, 20);
            this.txtClientId.TabIndex = 101;
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(131, 72);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(341, 20);
            this.txtProductNumber.TabIndex = 103;
            // 
            // comboBoxProductCode
            // 
            this.comboBoxProductCode.FormattingEnabled = true;
            this.comboBoxProductCode.Location = new System.Drawing.Point(131, 45);
            this.comboBoxProductCode.Name = "comboBoxProductCode";
            this.comboBoxProductCode.Size = new System.Drawing.Size(246, 21);
            this.comboBoxProductCode.TabIndex = 102;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(204, 276);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 32);
            this.btnActualizar.TabIndex = 116;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 41);
            this.label8.TabIndex = 115;
            this.label8.Text = "Actualizar Producto";
            // 
            // GUIUpdateProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label8);
            this.Name = "GUIUpdateProductRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Registro";
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label labClientId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label labProductCode;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Label labProductNumber;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.Label labBalance;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label labDateRegistration;
        private System.Windows.Forms.DateTimePicker datePickerExpiration;
        private System.Windows.Forms.Label labDateExpiration;
        private System.Windows.Forms.DateTimePicker datePickerRegistration;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.ComboBox comboBoxProductCode;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label8;
    }
}