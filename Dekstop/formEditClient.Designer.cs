
namespace WindowsFormsApp1
{
    partial class formEditClient
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
            this.labelPassportData = new System.Windows.Forms.Label();
            this.labelDriversLicense = new System.Windows.Forms.Label();
            this.labelNumberOfPhone = new System.Windows.Forms.Label();
            this.textBoxPassportData = new System.Windows.Forms.TextBox();
            this.textBoxDriversLicense = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNumberofphone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPassportData
            // 
            this.labelPassportData.AutoSize = true;
            this.labelPassportData.Location = new System.Drawing.Point(53, 14);
            this.labelPassportData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassportData.Name = "labelPassportData";
            this.labelPassportData.Size = new System.Drawing.Size(114, 13);
            this.labelPassportData.TabIndex = 55;
            this.labelPassportData.Text = "Паспортные данные:";
            // 
            // labelDriversLicense
            // 
            this.labelDriversLicense.AutoSize = true;
            this.labelDriversLicense.Location = new System.Drawing.Point(6, 42);
            this.labelDriversLicense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDriversLicense.Name = "labelDriversLicense";
            this.labelDriversLicense.Size = new System.Drawing.Size(161, 13);
            this.labelDriversLicense.TabIndex = 56;
            this.labelDriversLicense.Text = "Водительское удостоверение:";
            // 
            // labelNumberOfPhone
            // 
            this.labelNumberOfPhone.AutoSize = true;
            this.labelNumberOfPhone.Location = new System.Drawing.Point(71, 70);
            this.labelNumberOfPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfPhone.Name = "labelNumberOfPhone";
            this.labelNumberOfPhone.Size = new System.Drawing.Size(96, 13);
            this.labelNumberOfPhone.TabIndex = 57;
            this.labelNumberOfPhone.Text = "Номер телефона:";
            // 
            // textBoxPassportData
            // 
            this.textBoxPassportData.Location = new System.Drawing.Point(171, 11);
            this.textBoxPassportData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassportData.Multiline = true;
            this.textBoxPassportData.Name = "textBoxPassportData";
            this.textBoxPassportData.Size = new System.Drawing.Size(204, 24);
            this.textBoxPassportData.TabIndex = 60;
            // 
            // textBoxDriversLicense
            // 
            this.textBoxDriversLicense.Location = new System.Drawing.Point(171, 39);
            this.textBoxDriversLicense.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDriversLicense.Multiline = true;
            this.textBoxDriversLicense.Name = "textBoxDriversLicense";
            this.textBoxDriversLicense.Size = new System.Drawing.Size(204, 24);
            this.textBoxDriversLicense.TabIndex = 61;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(172, 105);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 27);
            this.buttonUpdate.TabIndex = 64;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(284, 105);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 27);
            this.buttonCancel.TabIndex = 65;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNumberofphone
            // 
            this.textBoxNumberofphone.Location = new System.Drawing.Point(171, 67);
            this.textBoxNumberofphone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberofphone.Multiline = true;
            this.textBoxNumberofphone.Name = "textBoxNumberofphone";
            this.textBoxNumberofphone.Size = new System.Drawing.Size(204, 24);
            this.textBoxNumberofphone.TabIndex = 62;
            // 
            // formEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 144);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxNumberofphone);
            this.Controls.Add(this.textBoxDriversLicense);
            this.Controls.Add(this.textBoxPassportData);
            this.Controls.Add(this.labelNumberOfPhone);
            this.Controls.Add(this.labelDriversLicense);
            this.Controls.Add(this.labelPassportData);
            this.Name = "formEditClient";
            this.Text = "formEditClient";
            this.Load += new System.EventHandler(this.formEditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassportData;
        private System.Windows.Forms.Label labelDriversLicense;
        private System.Windows.Forms.Label labelNumberOfPhone;
        private System.Windows.Forms.TextBox textBoxPassportData;
        private System.Windows.Forms.TextBox textBoxDriversLicense;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxNumberofphone;
    }
}