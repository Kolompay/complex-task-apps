
namespace WindowsFormsApp1
{
    partial class formAddCar
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
            this.labelIDInfo = new System.Windows.Forms.Label();
            this.comboBoxTransmission = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelTransmission = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVINnumber = new System.Windows.Forms.Label();
            this.textBoxVINnumber = new System.Windows.Forms.TextBox();
            this.comboBoxYearOfManufacture = new System.Windows.Forms.ComboBox();
            this.labelYearOfManufacture = new System.Windows.Forms.Label();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIDInfo
            // 
            this.labelIDInfo.AutoSize = true;
            this.labelIDInfo.Location = new System.Drawing.Point(106, 289);
            this.labelIDInfo.Name = "labelIDInfo";
            this.labelIDInfo.Size = new System.Drawing.Size(0, 17);
            this.labelIDInfo.TabIndex = 67;
            // 
            // comboBoxTransmission
            // 
            this.comboBoxTransmission.FormattingEnabled = true;
            this.comboBoxTransmission.Location = new System.Drawing.Point(106, 175);
            this.comboBoxTransmission.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTransmission.Name = "comboBoxTransmission";
            this.comboBoxTransmission.Size = new System.Drawing.Size(271, 24);
            this.comboBoxTransmission.TabIndex = 66;
            this.comboBoxTransmission.Click += new System.EventHandler(this.comboBoxTransmission_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(256, 312);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 33);
            this.buttonCancel.TabIndex = 65;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(106, 312);
            this.buttonAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(121, 33);
            this.buttonAddCar.TabIndex = 64;
            this.buttonAddCar.Text = "Добавить";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(106, 211);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(271, 24);
            this.comboBoxColor.TabIndex = 63;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(106, 140);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClass.Multiline = true;
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(271, 29);
            this.textBoxClass.TabIndex = 62;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(106, 105);
            this.textBoxBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBrand.Multiline = true;
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(271, 29);
            this.textBoxBrand.TabIndex = 61;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 68);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(271, 29);
            this.textBoxName.TabIndex = 60;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(52, 211);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 17);
            this.labelColor.TabIndex = 59;
            this.labelColor.Text = "Цвет:";
            // 
            // labelTransmission
            // 
            this.labelTransmission.AutoSize = true;
            this.labelTransmission.Location = new System.Drawing.Point(3, 178);
            this.labelTransmission.Name = "labelTransmission";
            this.labelTransmission.Size = new System.Drawing.Size(99, 17);
            this.labelTransmission.TabIndex = 58;
            this.labelTransmission.Text = "Трансмиссия:";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(47, 145);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(51, 17);
            this.labelClass.TabIndex = 57;
            this.labelClass.Text = "Класс:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(44, 108);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(53, 17);
            this.labelBrand.TabIndex = 56;
            this.labelBrand.Text = "Бренд:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 17);
            this.labelName.TabIndex = 55;
            this.labelName.Text = "Название:";
            // 
            // labelVINnumber
            // 
            this.labelVINnumber.AutoSize = true;
            this.labelVINnumber.Location = new System.Drawing.Point(21, 29);
            this.labelVINnumber.Name = "labelVINnumber";
            this.labelVINnumber.Size = new System.Drawing.Size(79, 17);
            this.labelVINnumber.TabIndex = 69;
            this.labelVINnumber.Text = "VIN номер:";
            // 
            // textBoxVINnumber
            // 
            this.textBoxVINnumber.Location = new System.Drawing.Point(106, 26);
            this.textBoxVINnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVINnumber.Multiline = true;
            this.textBoxVINnumber.Name = "textBoxVINnumber";
            this.textBoxVINnumber.Size = new System.Drawing.Size(271, 29);
            this.textBoxVINnumber.TabIndex = 70;
            // 
            // comboBoxYearOfManufacture
            // 
            this.comboBoxYearOfManufacture.FormattingEnabled = true;
            this.comboBoxYearOfManufacture.Location = new System.Drawing.Point(106, 240);
            this.comboBoxYearOfManufacture.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxYearOfManufacture.Name = "comboBoxYearOfManufacture";
            this.comboBoxYearOfManufacture.Size = new System.Drawing.Size(271, 24);
            this.comboBoxYearOfManufacture.TabIndex = 72;
            // 
            // labelYearOfManufacture
            // 
            this.labelYearOfManufacture.AutoSize = true;
            this.labelYearOfManufacture.Location = new System.Drawing.Point(8, 240);
            this.labelYearOfManufacture.Name = "labelYearOfManufacture";
            this.labelYearOfManufacture.Size = new System.Drawing.Size(94, 17);
            this.labelYearOfManufacture.TabIndex = 71;
            this.labelYearOfManufacture.Text = "Год выпуска:";
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(106, 272);
            this.comboBoxRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(271, 24);
            this.comboBoxRate.TabIndex = 74;
            this.comboBoxRate.Click += new System.EventHandler(this.comboBoxRate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Тариф:";
            // 
            // formAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(393, 363);
            this.Controls.Add(this.comboBoxRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxYearOfManufacture);
            this.Controls.Add(this.labelYearOfManufacture);
            this.Controls.Add(this.textBoxVINnumber);
            this.Controls.Add(this.labelVINnumber);
            this.Controls.Add(this.labelIDInfo);
            this.Controls.Add(this.comboBoxTransmission);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelTransmission);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.Name = "formAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление автомобиля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAddCar_FormClosed);
            this.Load += new System.EventHandler(this.formAddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIDInfo;
        private System.Windows.Forms.ComboBox comboBoxTransmission;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelTransmission;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVINnumber;
        private System.Windows.Forms.TextBox textBoxVINnumber;
        private System.Windows.Forms.ComboBox comboBoxYearOfManufacture;
        private System.Windows.Forms.Label labelYearOfManufacture;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Label label3;
    }
}