namespace ClientBankSWNet.gui
{
    partial class GUIDeleteClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIDeleteClient));
            this.pictureBoxDeleteClient = new System.Windows.Forms.PictureBox();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.txtIdentificationNumber = new System.Windows.Forms.TextBox();
            this.labIdNumber = new System.Windows.Forms.Label();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDocType = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.labPhoneNumber = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labBirthday = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labDocType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDeleteClient
            // 
            this.pictureBoxDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDeleteClient.Image")));
            this.pictureBoxDeleteClient.Location = new System.Drawing.Point(29, 127);
            this.pictureBoxDeleteClient.Name = "pictureBoxDeleteClient";
            this.pictureBoxDeleteClient.Size = new System.Drawing.Size(154, 154);
            this.pictureBoxDeleteClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDeleteClient.TabIndex = 94;
            this.pictureBoxDeleteClient.TabStop = false;
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(437, 78);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 23);
            this.btnFindClient.TabIndex = 93;
            this.btnFindClient.Text = "Buscar";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click_1);
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Location = new System.Drawing.Point(210, 80);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(211, 20);
            this.txtIdentificationNumber.TabIndex = 92;
            // 
            // labIdNumber
            // 
            this.labIdNumber.AutoSize = true;
            this.labIdNumber.Location = new System.Drawing.Point(74, 83);
            this.labIdNumber.Name = "labIdNumber";
            this.labIdNumber.Size = new System.Drawing.Size(130, 13);
            this.labIdNumber.TabIndex = 91;
            this.labIdNumber.Text = "Número de identificación: ";
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(351, 179);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(204, 20);
            this.datePickerBirthday.TabIndex = 90;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(351, 259);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(204, 20);
            this.txtGender.TabIndex = 89;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(351, 233);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNumber.TabIndex = 88;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(351, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 87;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(351, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 86;
            // 
            // txtDocType
            // 
            this.txtDocType.Location = new System.Drawing.Point(351, 127);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Size = new System.Drawing.Size(204, 20);
            this.txtDocType.TabIndex = 85;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(230, 262);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(42, 13);
            this.labGender.TabIndex = 84;
            this.labGender.Text = "Género";
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(230, 236);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labPhoneNumber.TabIndex = 83;
            this.labPhoneNumber.Text = "Telefono:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(230, 210);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(38, 13);
            this.labEmail.TabIndex = 82;
            this.labEmail.Text = "E-mail:";
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Location = new System.Drawing.Point(230, 185);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(109, 13);
            this.labBirthday.TabIndex = 81;
            this.labBirthday.Text = "Fecha de nacimiento:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(230, 156);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 13);
            this.labName.TabIndex = 80;
            this.labName.Text = "Nombre:";
            // 
            // labDocType
            // 
            this.labDocType.AutoSize = true;
            this.labDocType.Location = new System.Drawing.Point(230, 130);
            this.labDocType.Name = "labDocType";
            this.labDocType.Size = new System.Drawing.Size(102, 13);
            this.labDocType.TabIndex = 79;
            this.labDocType.Text = "Tipo de documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 41);
            this.label8.TabIndex = 78;
            this.label8.Text = "Eliminar cliente";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(224, 300);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(131, 23);
            this.btnDeleteClient.TabIndex = 77;
            this.btnDeleteClient.Text = "Eliminar Cliente";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click_1);
            // 
            // GUIDeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.pictureBoxDeleteClient);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.txtIdentificationNumber);
            this.Controls.Add(this.labIdNumber);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDocType);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labPhoneNumber);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labBirthday);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labDocType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteClient);
            this.Name = "GUIDeleteClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDeleteClient;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.TextBox txtIdentificationNumber;
        private System.Windows.Forms.Label labIdNumber;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDocType;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labPhoneNumber;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labBirthday;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDocType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteClient;
    }
}