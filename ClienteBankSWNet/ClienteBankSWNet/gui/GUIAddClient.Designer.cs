namespace ClienteBankSWNet.gui
{
    partial class GUIAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIAddClient));
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.labPhoneNumber = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labBirthday = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labDocType = new System.Windows.Forms.Label();
            this.labIdNumber = new System.Windows.Forms.Label();
            this.txtIdentificationNumber = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.pictureBoxAddClient = new System.Windows.Forms.PictureBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddClient)).BeginInit();
            this.SuspendLayout();
            // 
            // datePikerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(334, 151);
            this.datePickerBirthday.Name = "datePikerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(204, 20);
            this.datePickerBirthday.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(334, 206);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(334, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(334, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 19;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(197, 236);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(45, 13);
            this.labGender.TabIndex = 17;
            this.labGender.Text = "Género:";
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(198, 209);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labPhoneNumber.TabIndex = 16;
            this.labPhoneNumber.Text = "Telefono:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(197, 180);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(38, 13);
            this.labEmail.TabIndex = 15;
            this.labEmail.Text = "E-mail:";
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Location = new System.Drawing.Point(197, 157);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(109, 13);
            this.labBirthday.TabIndex = 14;
            this.labBirthday.Text = "Fecha de nacimiento:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(198, 128);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 13);
            this.labName.TabIndex = 13;
            this.labName.Text = "Nombre:";
            // 
            // labDocType
            // 
            this.labDocType.AutoSize = true;
            this.labDocType.Location = new System.Drawing.Point(197, 101);
            this.labDocType.Name = "labDocType";
            this.labDocType.Size = new System.Drawing.Size(102, 13);
            this.labDocType.TabIndex = 12;
            this.labDocType.Text = "Tipo de documento:";
            // 
            // labIdNumber
            // 
            this.labIdNumber.AutoSize = true;
            this.labIdNumber.Location = new System.Drawing.Point(197, 75);
            this.labIdNumber.Name = "labIdNumber";
            this.labIdNumber.Size = new System.Drawing.Size(131, 13);
            this.labIdNumber.TabIndex = 24;
            this.labIdNumber.Text = "Número de Identificación: ";
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Location = new System.Drawing.Point(334, 72);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(204, 20);
            this.txtIdentificationNumber.TabIndex = 25;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(181, 274);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(161, 23);
            this.btnAddClient.TabIndex = 26;
            this.btnAddClient.Text = "Agregar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(136, 18);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(284, 41);
            this.labTitle.TabIndex = 58;
            this.labTitle.Text = "Registro cliente";
            // 
            // pictureBoxAddClient
            // 
            this.pictureBoxAddClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddClient.Image")));
            this.pictureBoxAddClient.Location = new System.Drawing.Point(22, 89);
            this.pictureBoxAddClient.Name = "pictureBoxAddClient";
            this.pictureBoxAddClient.Size = new System.Drawing.Size(147, 147);
            this.pictureBoxAddClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAddClient.TabIndex = 59;
            this.pictureBoxAddClient.TabStop = false;
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.Items.AddRange(new object[] {
            "Cédula de ciudadanía",
            "Tarjeta de identidad",
            "Cédula de extranjería"});
            this.comboBoxDocType.Location = new System.Drawing.Point(334, 98);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(204, 21);
            this.comboBoxDocType.TabIndex = 60;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.comboBoxGender.Location = new System.Drawing.Point(334, 233);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(204, 21);
            this.comboBoxGender.TabIndex = 61;
            // 
            // GUIAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 322);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.pictureBoxAddClient);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtIdentificationNumber);
            this.Controls.Add(this.labIdNumber);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labPhoneNumber);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labBirthday);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labDocType);
            this.Name = "GUIAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labPhoneNumber;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labBirthday;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDocType;
        private System.Windows.Forms.Label labIdNumber;
        private System.Windows.Forms.TextBox txtIdentificationNumber;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.PictureBox pictureBoxAddClient;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.ComboBox comboBoxGender;
    }
}