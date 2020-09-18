namespace ClientBankSWNet.gui
{
    partial class GUIListClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIListClients));
            this.panelData = new System.Windows.Forms.Panel();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelData.Controls.Add(this.pictureBoxList);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.dataGridViewClients);
            this.panelData.Location = new System.Drawing.Point(12, 12);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(750, 411);
            this.panelData.TabIndex = 63;
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxList.Image")));
            this.pictureBoxList.Location = new System.Drawing.Point(130, 19);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxList.TabIndex = 60;
            this.pictureBoxList.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 41);
            this.label8.TabIndex = 59;
            this.label8.Text = "Lista de clientes";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 171);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.Size = new System.Drawing.Size(731, 233);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(303, 431);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(146, 23);
            this.btnRefreshData.TabIndex = 62;
            this.btnRefreshData.Text = "Recargar Datos";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // GUIListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 466);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnRefreshData);
            this.Name = "GUIListClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Clientes";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button btnRefreshData;
    }
}