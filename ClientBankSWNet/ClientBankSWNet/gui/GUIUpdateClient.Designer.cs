namespace ClientBankSWNet.gui
{
    partial class GUIUpdateClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIUpdateClient));
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.pictureBoxUpdateClient = new System.Windows.Forms.PictureBox();
            this.btnFindClient = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdateClient)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.comboBoxGender.Location = new System.Drawing.Point(343, 256);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(204, 21);
            this.comboBoxGender.TabIndex = 94;
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.Items.AddRange(new object[] {
            "Cedula de ciudadania",
            "Tarjeta de identidad",
            "Cedula de extranjeria"});
            this.comboBoxDocType.Location = new System.Drawing.Point(343, 124);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(204, 21);
            this.comboBoxDocType.TabIndex = 93;
            // 
            // pictureBoxUpdateClient
            // 
            this.pictureBoxUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdateClient.Image")));
            this.pictureBoxUpdateClient.Location = new System.Drawing.Point(37, 141);
            this.pictureBoxUpdateClient.Name = "pictureBoxUpdateClient";
            this.pictureBoxUpdateClient.Size = new System.Drawing.Size(159, 118);
            this.pictureBoxUpdateClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUpdateClient.TabIndex = 92;
            this.pictureBoxUpdateClient.TabStop = false;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(419, 75);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 23);
            this.btnFindClient.TabIndex = 91;
            this.btnFindClient.Text = "Buscar";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Location = new System.Drawing.Point(202, 77);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(211, 20);
            this.txtIdentificationNumber.TabIndex = 90;
            // 
            // labIdNumber
            // 
            this.labIdNumber.AutoSize = true;
            this.labIdNumber.Location = new System.Drawing.Point(66, 80);
            this.labIdNumber.Name = "labIdNumber";
            this.labIdNumber.Size = new System.Drawing.Size(130, 13);
            this.labIdNumber.TabIndex = 89;
            this.labIdNumber.Text = "Número de identificación: ";
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(343, 176);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(204, 20);
            this.datePickerBirthday.TabIndex = 88;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(343, 230);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNumber.TabIndex = 87;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(343, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 86;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(343, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 85;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(222, 259);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(42, 13);
            this.labGender.TabIndex = 84;
            this.labGender.Text = "Género";
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(222, 233);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labPhoneNumber.TabIndex = 83;
            this.labPhoneNumber.Text = "Telefono:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(222, 207);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(38, 13);
            this.labEmail.TabIndex = 82;
            this.labEmail.Text = "E-mail:";
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Location = new System.Drawing.Point(222, 182);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(109, 13);
            this.labBirthday.TabIndex = 81;
            this.labBirthday.Text = "Fecha de nacimiento:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(222, 153);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 13);
            this.labName.TabIndex = 80;
            this.labName.Text = "Nombre:";
            // 
            // labDocType
            // 
            this.labDocType.AutoSize = true;
            this.labDocType.Location = new System.Drawing.Point(222, 127);
            this.labDocType.Name = "labDocType";
            this.labDocType.Size = new System.Drawing.Size(102, 13);
            this.labDocType.TabIndex = 79;
            this.labDocType.Text = "Tipo de documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 41);
            this.label8.TabIndex = 78;
            this.label8.Text = "Actualizar cliente";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(214, 296);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(131, 23);
            this.btnUpdateClient.TabIndex = 77;
            this.btnUpdateClient.Text = "Actualizar datos";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // GUIUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.pictureBoxUpdateClient);
            this.Controls.Add(this.btnFindClient);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdateClient);
            this.Name = "GUIUpdateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdateClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.PictureBox pictureBoxUpdateClient;
        private System.Windows.Forms.Button btnFindClient;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateClient;
    }
}