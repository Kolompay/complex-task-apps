
namespace WindowsFormsApp1
{
    partial class formAddOrder
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
            this.labelNameCar = new System.Windows.Forms.Label();
            this.labelFamilyName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelPassportData = new System.Windows.Forms.Label();
            this.labelDriversLicense = new System.Windows.Forms.Label();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelRates = new System.Windows.Forms.Label();
            this.labelResultCost = new System.Windows.Forms.Label();
            this.labelCountDays = new System.Windows.Forms.Label();
            this.comboBoxRates = new System.Windows.Forms.ComboBox();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.numericUpDownCountDays = new System.Windows.Forms.NumericUpDown();
            this.textBoxFamilyName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxPassportData = new System.Windows.Forms.TextBox();
            this.textBoxDriversLicense = new System.Windows.Forms.TextBox();
            this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.groupBoxAboutRent = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResultCost = new System.Windows.Forms.TextBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDays)).BeginInit();
            this.groupBoxAboutRent.SuspendLayout();
            this.groupBoxPersonalData.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameCar
            // 
            this.labelNameCar.AutoSize = true;
            this.labelNameCar.Location = new System.Drawing.Point(79, 43);
            this.labelNameCar.Name = "labelNameCar";
            this.labelNameCar.Size = new System.Drawing.Size(91, 17);
            this.labelNameCar.TabIndex = 0;
            this.labelNameCar.Text = "Автомобиль:";
            // 
            // labelFamilyName
            // 
            this.labelFamilyName.AutoSize = true;
            this.labelFamilyName.Location = new System.Drawing.Point(97, 50);
            this.labelFamilyName.Name = "labelFamilyName";
            this.labelFamilyName.Size = new System.Drawing.Size(74, 17);
            this.labelFamilyName.TabIndex = 1;
            this.labelFamilyName.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(132, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(96, 118);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(75, 17);
            this.labelPatronymic.TabIndex = 3;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // labelPassportData
            // 
            this.labelPassportData.AutoSize = true;
            this.labelPassportData.Location = new System.Drawing.Point(81, 150);
            this.labelPassportData.Name = "labelPassportData";
            this.labelPassportData.Size = new System.Drawing.Size(90, 34);
            this.labelPassportData.TabIndex = 4;
            this.labelPassportData.Text = "Паспортные\r\nданные:";
            this.labelPassportData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDriversLicense
            // 
            this.labelDriversLicense.AutoSize = true;
            this.labelDriversLicense.Location = new System.Drawing.Point(59, 188);
            this.labelDriversLicense.Name = "labelDriversLicense";
            this.labelDriversLicense.Size = new System.Drawing.Size(112, 34);
            this.labelDriversLicense.TabIndex = 5;
            this.labelDriversLicense.Text = "Водительское \r\nудостоверение:";
            this.labelDriversLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(46, 232);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(125, 17);
            this.labelNumberPhone.TabIndex = 6;
            this.labelNumberPhone.Text = "Номер телефона:";
            // 
            // labelRates
            // 
            this.labelRates.AutoSize = true;
            this.labelRates.Location = new System.Drawing.Point(112, 83);
            this.labelRates.Name = "labelRates";
            this.labelRates.Size = new System.Drawing.Size(56, 17);
            this.labelRates.TabIndex = 8;
            this.labelRates.Text = "Тариф:";
            // 
            // labelResultCost
            // 
            this.labelResultCost.AutoSize = true;
            this.labelResultCost.Location = new System.Drawing.Point(26, 30);
            this.labelResultCost.Name = "labelResultCost";
            this.labelResultCost.Size = new System.Drawing.Size(145, 17);
            this.labelResultCost.TabIndex = 9;
            this.labelResultCost.Text = "Итоговая стоимость:";
            // 
            // labelCountDays
            // 
            this.labelCountDays.AutoSize = true;
            this.labelCountDays.Location = new System.Drawing.Point(42, 123);
            this.labelCountDays.Name = "labelCountDays";
            this.labelCountDays.Size = new System.Drawing.Size(126, 17);
            this.labelCountDays.TabIndex = 10;
            this.labelCountDays.Text = "Количество дней:";
            // 
            // comboBoxRates
            // 
            this.comboBoxRates.FormattingEnabled = true;
            this.comboBoxRates.Location = new System.Drawing.Point(176, 82);
            this.comboBoxRates.Name = "comboBoxRates";
            this.comboBoxRates.Size = new System.Drawing.Size(238, 24);
            this.comboBoxRates.TabIndex = 11;
            this.comboBoxRates.SelectedValueChanged += new System.EventHandler(this.comboBoxRates_SelectedValueChanged);
            this.comboBoxRates.Click += new System.EventHandler(this.comboBoxRates_Click);
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(176, 42);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(238, 24);
            this.comboBoxCars.TabIndex = 12;
            this.comboBoxCars.SelectedValueChanged += new System.EventHandler(this.comboBoxCars_SelectedValueChanged);
            this.comboBoxCars.Click += new System.EventHandler(this.comboBoxCars_Click);
            // 
            // numericUpDownCountDays
            // 
            this.numericUpDownCountDays.Location = new System.Drawing.Point(176, 123);
            this.numericUpDownCountDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountDays.Name = "numericUpDownCountDays";
            this.numericUpDownCountDays.Size = new System.Drawing.Size(238, 22);
            this.numericUpDownCountDays.TabIndex = 13;
            this.numericUpDownCountDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountDays.ValueChanged += new System.EventHandler(this.numericUpDownCountDays_ValueChanged);
            this.numericUpDownCountDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownCountDays_KeyPress);
            // 
            // textBoxFamilyName
            // 
            this.textBoxFamilyName.Location = new System.Drawing.Point(176, 47);
            this.textBoxFamilyName.Name = "textBoxFamilyName";
            this.textBoxFamilyName.ShortcutsEnabled = false;
            this.textBoxFamilyName.Size = new System.Drawing.Size(238, 22);
            this.textBoxFamilyName.TabIndex = 14;
            this.textBoxFamilyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFamilyName_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(176, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ShortcutsEnabled = false;
            this.textBoxName.Size = new System.Drawing.Size(238, 22);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(176, 118);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.ShortcutsEnabled = false;
            this.textBoxPatronymic.Size = new System.Drawing.Size(238, 22);
            this.textBoxPatronymic.TabIndex = 16;
            this.textBoxPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatronymic_KeyPress);
            // 
            // textBoxPassportData
            // 
            this.textBoxPassportData.Location = new System.Drawing.Point(176, 156);
            this.textBoxPassportData.Name = "textBoxPassportData";
            this.textBoxPassportData.ShortcutsEnabled = false;
            this.textBoxPassportData.Size = new System.Drawing.Size(238, 22);
            this.textBoxPassportData.TabIndex = 17;
            this.textBoxPassportData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassportData_KeyPress);
            // 
            // textBoxDriversLicense
            // 
            this.textBoxDriversLicense.Location = new System.Drawing.Point(176, 194);
            this.textBoxDriversLicense.Name = "textBoxDriversLicense";
            this.textBoxDriversLicense.ShortcutsEnabled = false;
            this.textBoxDriversLicense.Size = new System.Drawing.Size(238, 22);
            this.textBoxDriversLicense.TabIndex = 18;
            this.textBoxDriversLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDriversLicense_KeyPress);
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.Location = new System.Drawing.Point(176, 232);
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.ShortcutsEnabled = false;
            this.textBoxNumberPhone.Size = new System.Drawing.Size(238, 22);
            this.textBoxNumberPhone.TabIndex = 19;
            this.textBoxNumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberPhone_KeyPress);
            // 
            // groupBoxAboutRent
            // 
            this.groupBoxAboutRent.Controls.Add(this.comboBoxCars);
            this.groupBoxAboutRent.Controls.Add(this.labelNameCar);
            this.groupBoxAboutRent.Controls.Add(this.labelRates);
            this.groupBoxAboutRent.Controls.Add(this.labelCountDays);
            this.groupBoxAboutRent.Controls.Add(this.comboBoxRates);
            this.groupBoxAboutRent.Controls.Add(this.numericUpDownCountDays);
            this.groupBoxAboutRent.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAboutRent.Name = "groupBoxAboutRent";
            this.groupBoxAboutRent.Size = new System.Drawing.Size(432, 180);
            this.groupBoxAboutRent.TabIndex = 20;
            this.groupBoxAboutRent.TabStop = false;
            this.groupBoxAboutRent.Text = "Об аренде";
            // 
            // groupBoxPersonalData
            // 
            this.groupBoxPersonalData.Controls.Add(this.textBoxNumberPhone);
            this.groupBoxPersonalData.Controls.Add(this.labelFamilyName);
            this.groupBoxPersonalData.Controls.Add(this.labelName);
            this.groupBoxPersonalData.Controls.Add(this.labelNumberPhone);
            this.groupBoxPersonalData.Controls.Add(this.textBoxDriversLicense);
            this.groupBoxPersonalData.Controls.Add(this.labelDriversLicense);
            this.groupBoxPersonalData.Controls.Add(this.textBoxFamilyName);
            this.groupBoxPersonalData.Controls.Add(this.labelPassportData);
            this.groupBoxPersonalData.Controls.Add(this.textBoxPassportData);
            this.groupBoxPersonalData.Controls.Add(this.labelPatronymic);
            this.groupBoxPersonalData.Controls.Add(this.textBoxName);
            this.groupBoxPersonalData.Controls.Add(this.textBoxPatronymic);
            this.groupBoxPersonalData.Location = new System.Drawing.Point(12, 207);
            this.groupBoxPersonalData.Name = "groupBoxPersonalData";
            this.groupBoxPersonalData.Size = new System.Drawing.Size(432, 299);
            this.groupBoxPersonalData.TabIndex = 21;
            this.groupBoxPersonalData.TabStop = false;
            this.groupBoxPersonalData.Text = "Персональные данные";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResultCost);
            this.groupBoxResult.Controls.Add(this.labelResultCost);
            this.groupBoxResult.Location = new System.Drawing.Point(453, 207);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(432, 81);
            this.groupBoxResult.TabIndex = 22;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Итог";
            // 
            // textBoxResultCost
            // 
            this.textBoxResultCost.Location = new System.Drawing.Point(177, 30);
            this.textBoxResultCost.Name = "textBoxResultCost";
            this.textBoxResultCost.ReadOnly = true;
            this.textBoxResultCost.Size = new System.Drawing.Size(238, 22);
            this.textBoxResultCost.TabIndex = 20;
            this.textBoxResultCost.Text = "руб.";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(584, 320);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(214, 36);
            this.buttonAddOrder.TabIndex = 23;
            this.buttonAddOrder.Text = "Оформить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(584, 363);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(214, 36);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // formAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(897, 523);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxPersonalData);
            this.Controls.Add(this.groupBoxAboutRent);
            this.MaximizeBox = false;
            this.Name = "formAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAddOrder_FormClosed);
            this.Load += new System.EventHandler(this.formAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDays)).EndInit();
            this.groupBoxAboutRent.ResumeLayout(false);
            this.groupBoxAboutRent.PerformLayout();
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNameCar;
        private System.Windows.Forms.Label labelFamilyName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelPassportData;
        private System.Windows.Forms.Label labelDriversLicense;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelRates;
        private System.Windows.Forms.Label labelResultCost;
        private System.Windows.Forms.Label labelCountDays;
        private System.Windows.Forms.ComboBox comboBoxRates;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.NumericUpDown numericUpDownCountDays;
        private System.Windows.Forms.TextBox textBoxFamilyName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxPassportData;
        private System.Windows.Forms.TextBox textBoxDriversLicense;
        private System.Windows.Forms.TextBox textBoxNumberPhone;
        private System.Windows.Forms.GroupBox groupBoxAboutRent;
        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxResultCost;
    }
}