
namespace WindowsFormsApp1
{
    partial class formEditCar
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelTransmission = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxTransmission = new System.Windows.Forms.ComboBox();
            this.labelIDInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(267, 222);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 33);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(117, 222);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 33);
            this.buttonUpdate.TabIndex = 50;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(117, 167);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(271, 24);
            this.comboBoxColor.TabIndex = 49;
            this.comboBoxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxColor_DrawItem);
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(117, 96);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClass.Multiline = true;
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(271, 29);
            this.textBoxClass.TabIndex = 47;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(117, 61);
            this.textBoxBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBrand.Multiline = true;
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(271, 29);
            this.textBoxBrand.TabIndex = 46;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 24);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(271, 29);
            this.textBoxName.TabIndex = 45;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(63, 167);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 17);
            this.labelColor.TabIndex = 44;
            this.labelColor.Text = "Цвет:";
            // 
            // labelTransmission
            // 
            this.labelTransmission.AutoSize = true;
            this.labelTransmission.Location = new System.Drawing.Point(14, 134);
            this.labelTransmission.Name = "labelTransmission";
            this.labelTransmission.Size = new System.Drawing.Size(99, 17);
            this.labelTransmission.TabIndex = 43;
            this.labelTransmission.Text = "Трансмиссия:";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(58, 101);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(51, 17);
            this.labelClass.TabIndex = 42;
            this.labelClass.Text = "Класс:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(55, 64);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(53, 17);
            this.labelBrand.TabIndex = 41;
            this.labelBrand.Text = "Бренд:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 17);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Название:";
            // 
            // comboBoxTransmission
            // 
            this.comboBoxTransmission.FormattingEnabled = true;
            this.comboBoxTransmission.Location = new System.Drawing.Point(117, 131);
            this.comboBoxTransmission.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTransmission.Name = "comboBoxTransmission";
            this.comboBoxTransmission.Size = new System.Drawing.Size(271, 24);
            this.comboBoxTransmission.TabIndex = 52;
            // 
            // labelIDInfo
            // 
            this.labelIDInfo.AutoSize = true;
            this.labelIDInfo.Location = new System.Drawing.Point(117, 199);
            this.labelIDInfo.Name = "labelIDInfo";
            this.labelIDInfo.Size = new System.Drawing.Size(0, 17);
            this.labelIDInfo.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Для справки ID:";
            // 
            // formEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIDInfo);
            this.Controls.Add(this.comboBoxTransmission);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelTransmission);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelName);
            this.Name = "formEditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных автомобиля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formEditCar_FormClosed);
            this.Load += new System.EventHandler(this.formEditCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelTransmission;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxTransmission;
        private System.Windows.Forms.Label labelIDInfo;
        private System.Windows.Forms.Label label1;
    }
}