namespace ClientBankSWNet.gui
{
    partial class GUIFindClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIFindClient));
            this.pictureBoxFindClient = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFindClient
            // 
            this.pictureBoxFindClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFindClient.Image")));
            this.pictureBoxFindClient.Location = new System.Drawing.Point(23, 141);
            this.pictureBoxFindClient.Name = "pictureBoxFindClient";
            this.pictureBoxFindClient.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxFindClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFindClient.TabIndex = 77;
            this.pictureBoxFindClient.TabStop = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(158, 39);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(258, 41);
            this.labTitle.TabIndex = 76;
            this.labTitle.Text = "Buscar cliente";
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(444, 92);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 23);
            this.btnFindClient.TabIndex = 75;
            this.btnFindClient.Text = "Buscar";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // txtIdentificationNumber
            // 
            this.txtIdentificationNumber.Location = new System.Drawing.Point(217, 94);
            this.txtIdentificationNumber.Name = "txtIdentificationNumber";
            this.txtIdentificationNumber.Size = new System.Drawing.Size(211, 20);
            this.txtIdentificationNumber.TabIndex = 74;
            // 
            // labIdNumber
            // 
            this.labIdNumber.AutoSize = true;
            this.labIdNumber.Location = new System.Drawing.Point(81, 97);
            this.labIdNumber.Name = "labIdNumber";
            this.labIdNumber.Size = new System.Drawing.Size(130, 13);
            this.labIdNumber.TabIndex = 73;
            this.labIdNumber.Text = "Número de identificación: ";
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(358, 193);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(204, 20);
            this.datePickerBirthday.TabIndex = 72;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(358, 273);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(204, 20);
            this.txtGender.TabIndex = 71;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(358, 247);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(204, 20);
            this.txtPhoneNumber.TabIndex = 70;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(358, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 69;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(358, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 68;
            // 
            // txtDocType
            // 
            this.txtDocType.Location = new System.Drawing.Point(358, 141);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Size = new System.Drawing.Size(204, 20);
            this.txtDocType.TabIndex = 67;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(237, 276);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(42, 13);
            this.labGender.TabIndex = 66;
            this.labGender.Text = "Género";
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(237, 250);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labPhoneNumber.TabIndex = 65;
            this.labPhoneNumber.Text = "Telefono:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(237, 224);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(38, 13);
            this.labEmail.TabIndex = 64;
            this.labEmail.Text = "E-mail:";
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Location = new System.Drawing.Point(237, 199);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(109, 13);
            this.labBirthday.TabIndex = 63;
            this.labBirthday.Text = "Fecha de nacimiento:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(237, 170);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 13);
            this.labName.TabIndex = 62;
            this.labName.Text = "Nombre:";
            // 
            // labDocType
            // 
            this.labDocType.AutoSize = true;
            this.labDocType.Location = new System.Drawing.Point(237, 144);
            this.labDocType.Name = "labDocType";
            this.labDocType.Size = new System.Drawing.Size(102, 13);
            this.labDocType.TabIndex = 61;
            this.labDocType.Text = "Tipo de documento:";
            // 
            // GUIFindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.pictureBoxFindClient);
            this.Controls.Add(this.labTitle);
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
            this.Name = "GUIFindClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFindClient;
        private System.Windows.Forms.Label labTitle;
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
    }
}