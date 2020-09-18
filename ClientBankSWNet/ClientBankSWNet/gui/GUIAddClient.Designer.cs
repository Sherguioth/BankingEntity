namespace ClientBankSWNet.gui
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
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.pictureBoxAddClient = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtIdentificationNumber = new System.Windows.Forms.TextBox();
            this.labIdNumber = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddClient)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.comboBoxGender.Location = new System.Drawing.Point(346, 246);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(204, 21);
            this.comboBoxGender.TabIndex = 78;
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.Items.AddRange(new object[] {
            "Cedula de ciudadania",
            "Tarjeta de identidad",
            "Cedula de extranjeria"});
            this.comboBoxDocType.Location = new System.Drawing.Point(346, 111);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(204, 21);
            this.comboBoxDocType.TabIndex = 77;
            // 
            // pictureBoxAddClient
            // 
            this.pictureBoxAddClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddClient.Image")));
            this.pictureBoxAddClient.Location = new System.Drawing.Point(34, 102);
            this.pictureBoxAddClient.Name = "pictureBoxAddClient";
            this.pictureBoxAddClient.Size = new System.Drawing.Size(147, 147);
            this.pictureBoxAddClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAddClient.TabIndex = 76;
            this.pictureBoxAddClient.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(148, 31);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(284, 41);
            this.labTitle.TabIndex = 75;
            this.labTitle.Text = "Registro cliente";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(193, 287);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(161, 23);
            this.btnAddClient.TabIndex = 74;
            this.btnAddClient.Text = "Agregar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Location = new System.Drawing.Point(346, 85);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(204, 20);
            this.txtIdentificationNumber.TabIndex = 73;
            // 
            // labIdNumber
            // 
            this.labIdNumber.AutoSize = true;
            this.labIdNumber.Location = new System.Drawing.Point(209, 88);
            this.labIdNumber.Name = "labIdNumber";
            this.labIdNumber.Size = new System.Drawing.Size(131, 13);
            this.labIdNumber.TabIndex = 72;
            this.labIdNumber.Text = "Número de Identificación: ";
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(346, 164);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(204, 20);
            this.datePickerBirthday.TabIndex = 71;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(346, 219);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNumber.TabIndex = 70;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 69;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(346, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 68;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(209, 249);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(45, 13);
            this.labGender.TabIndex = 67;
            this.labGender.Text = "Género:";
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(210, 222);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labPhoneNumber.TabIndex = 66;
            this.labPhoneNumber.Text = "Telefono:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(209, 193);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(38, 13);
            this.labEmail.TabIndex = 65;
            this.labEmail.Text = "E-mail:";
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Location = new System.Drawing.Point(209, 170);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(109, 13);
            this.labBirthday.TabIndex = 64;
            this.labBirthday.Text = "Fecha de nacimiento:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(210, 141);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 13);
            this.labName.TabIndex = 63;
            this.labName.Text = "Nombre:";
            // 
            // labDocType
            // 
            this.labDocType.AutoSize = true;
            this.labDocType.Location = new System.Drawing.Point(209, 114);
            this.labDocType.Name = "labDocType";
            this.labDocType.Size = new System.Drawing.Size(102, 13);
            this.labDocType.TabIndex = 62;
            this.labDocType.Text = "Tipo de documento:";
            // 
            // GUIAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
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

        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.PictureBox pictureBoxAddClient;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtIdentificationNumber;
        private System.Windows.Forms.Label labIdNumber;
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
    }
}