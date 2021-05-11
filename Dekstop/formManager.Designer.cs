
namespace WindowsFormsApp1
{
    partial class formManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManager));
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageAutopark = new System.Windows.Forms.TabPage();
            this.tabControlAutopark = new System.Windows.Forms.TabControl();
            this.tabPageCarsNotInRent = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelSelectCriterion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUpdateListNotInRent = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.dataGridViewListCarsNotInRent = new System.Windows.Forms.DataGridView();
            this.tabPageCarsInRent = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.buttonUpdateListCarsInRent = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.dataGridViewListCarsInRent = new System.Windows.Forms.DataGridView();
            this.tabPageListCars = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddBonus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCoef = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.rentcarsdbDataSet = new WindowsFormsApp1.rentcarsdbDataSet();
            this.rentcarsdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransmisson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageAutopark.SuspendLayout();
            this.tabControlAutopark.SuspendLayout();
            this.tabPageCarsNotInRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCarsNotInRent)).BeginInit();
            this.tabPageCarsInRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCarsInRent)).BeginInit();
            this.tabPageListCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarsdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarsdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.button8);
            this.tabPageClients.Controls.Add(this.button9);
            this.tabPageClients.Controls.Add(this.button10);
            this.tabPageClients.Controls.Add(this.dataGridView3);
            this.tabPageClients.Location = new System.Drawing.Point(4, 27);
            this.tabPageClients.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageClients.Size = new System.Drawing.Size(954, 537);
            this.tabPageClients.TabIndex = 2;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(400, 476);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(261, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "Завершить заказ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(400, 434);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(261, 35);
            this.button9.TabIndex = 11;
            this.button9.Text = "Изменить данные заказа";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(679, 434);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(261, 35);
            this.button10.TabIndex = 10;
            this.button10.Text = "Обновить данные";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(10, 7);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(932, 421);
            this.dataGridView3.TabIndex = 3;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.button5);
            this.tabPageOrders.Controls.Add(this.button6);
            this.tabPageOrders.Controls.Add(this.button7);
            this.tabPageOrders.Controls.Add(this.dataGridView2);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 27);
            this.tabPageOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Size = new System.Drawing.Size(954, 537);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(404, 482);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Завершить заказ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(404, 441);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(261, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "Изменить данные заказа";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(682, 441);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 35);
            this.button7.TabIndex = 7;
            this.button7.Text = "Обновить данные";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 7);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(932, 421);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabPageAutopark
            // 
            this.tabPageAutopark.Controls.Add(this.tabControlAutopark);
            this.tabPageAutopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageAutopark.Location = new System.Drawing.Point(4, 27);
            this.tabPageAutopark.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAutopark.Name = "tabPageAutopark";
            this.tabPageAutopark.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAutopark.Size = new System.Drawing.Size(954, 537);
            this.tabPageAutopark.TabIndex = 0;
            this.tabPageAutopark.Text = "Автопарк";
            this.tabPageAutopark.UseVisualStyleBackColor = true;
            // 
            // tabControlAutopark
            // 
            this.tabControlAutopark.Controls.Add(this.tabPageCarsNotInRent);
            this.tabControlAutopark.Controls.Add(this.tabPageCarsInRent);
            this.tabControlAutopark.Controls.Add(this.tabPageListCars);
            this.tabControlAutopark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlAutopark.Location = new System.Drawing.Point(-4, 0);
            this.tabControlAutopark.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAutopark.Name = "tabControlAutopark";
            this.tabControlAutopark.SelectedIndex = 0;
            this.tabControlAutopark.Size = new System.Drawing.Size(962, 540);
            this.tabControlAutopark.TabIndex = 0;
            // 
            // tabPageCarsNotInRent
            // 
            this.tabPageCarsNotInRent.Controls.Add(this.label1);
            this.tabPageCarsNotInRent.Controls.Add(this.comboBox2);
            this.tabPageCarsNotInRent.Controls.Add(this.labelSelectCriterion);
            this.tabPageCarsNotInRent.Controls.Add(this.comboBox1);
            this.tabPageCarsNotInRent.Controls.Add(this.buttonUpdateListNotInRent);
            this.tabPageCarsNotInRent.Controls.Add(this.buttonAddOrder);
            this.tabPageCarsNotInRent.Controls.Add(this.dataGridViewListCarsNotInRent);
            this.tabPageCarsNotInRent.Location = new System.Drawing.Point(4, 27);
            this.tabPageCarsNotInRent.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCarsNotInRent.Name = "tabPageCarsNotInRent";
            this.tabPageCarsNotInRent.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCarsNotInRent.Size = new System.Drawing.Size(954, 509);
            this.tabPageCarsNotInRent.TabIndex = 0;
            this.tabPageCarsNotInRent.Text = "Доступные автомобили";
            this.tabPageCarsNotInRent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите из списка:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(235, 63);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 26);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelSelectCriterion
            // 
            this.labelSelectCriterion.AutoSize = true;
            this.labelSelectCriterion.Location = new System.Drawing.Point(10, 25);
            this.labelSelectCriterion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectCriterion.Name = "labelSelectCriterion";
            this.labelSelectCriterion.Size = new System.Drawing.Size(201, 18);
            this.labelSelectCriterion.TabIndex = 4;
            this.labelSelectCriterion.Text = "Выберите критерий поиска:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // buttonUpdateListNotInRent
            // 
            this.buttonUpdateListNotInRent.Location = new System.Drawing.Point(682, 67);
            this.buttonUpdateListNotInRent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateListNotInRent.Name = "buttonUpdateListNotInRent";
            this.buttonUpdateListNotInRent.Size = new System.Drawing.Size(261, 35);
            this.buttonUpdateListNotInRent.TabIndex = 2;
            this.buttonUpdateListNotInRent.Text = "Обновить список автомобилей";
            this.buttonUpdateListNotInRent.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(682, 25);
            this.buttonAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(261, 35);
            this.buttonAddOrder.TabIndex = 1;
            this.buttonAddOrder.Text = "Оформить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListCarsNotInRent
            // 
            this.dataGridViewListCarsNotInRent.AllowUserToAddRows = false;
            this.dataGridViewListCarsNotInRent.AllowUserToDeleteRows = false;
            this.dataGridViewListCarsNotInRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListCarsNotInRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCarsNotInRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnBrand,
            this.ColumnClassCar,
            this.ColumnTransmisson,
            this.ColumnColor});
            this.dataGridViewListCarsNotInRent.Location = new System.Drawing.Point(10, 118);
            this.dataGridViewListCarsNotInRent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListCarsNotInRent.Name = "dataGridViewListCarsNotInRent";
            this.dataGridViewListCarsNotInRent.ReadOnly = true;
            this.dataGridViewListCarsNotInRent.RowHeadersWidth = 51;
            this.dataGridViewListCarsNotInRent.RowTemplate.Height = 24;
            this.dataGridViewListCarsNotInRent.Size = new System.Drawing.Size(932, 382);
            this.dataGridViewListCarsNotInRent.TabIndex = 0;
            // 
            // tabPageCarsInRent
            // 
            this.tabPageCarsInRent.Controls.Add(this.label2);
            this.tabPageCarsInRent.Controls.Add(this.comboBox3);
            this.tabPageCarsInRent.Controls.Add(this.label3);
            this.tabPageCarsInRent.Controls.Add(this.comboBox4);
            this.tabPageCarsInRent.Controls.Add(this.buttonUpdateListCarsInRent);
            this.tabPageCarsInRent.Controls.Add(this.buttonCancelOrder);
            this.tabPageCarsInRent.Controls.Add(this.dataGridViewListCarsInRent);
            this.tabPageCarsInRent.Location = new System.Drawing.Point(4, 27);
            this.tabPageCarsInRent.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCarsInRent.Name = "tabPageCarsInRent";
            this.tabPageCarsInRent.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCarsInRent.Size = new System.Drawing.Size(954, 509);
            this.tabPageCarsInRent.TabIndex = 1;
            this.tabPageCarsInRent.Text = "Автомобили в прокате";
            this.tabPageCarsInRent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите из списка:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(235, 67);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 26);
            this.comboBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите критерий поиска:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(235, 25);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(233, 26);
            this.comboBox4.TabIndex = 9;
            // 
            // buttonUpdateListCarsInRent
            // 
            this.buttonUpdateListCarsInRent.Location = new System.Drawing.Point(682, 62);
            this.buttonUpdateListCarsInRent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateListCarsInRent.Name = "buttonUpdateListCarsInRent";
            this.buttonUpdateListCarsInRent.Size = new System.Drawing.Size(261, 35);
            this.buttonUpdateListCarsInRent.TabIndex = 8;
            this.buttonUpdateListCarsInRent.Text = "Обновить список автомобилей";
            this.buttonUpdateListCarsInRent.UseVisualStyleBackColor = true;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(682, 20);
            this.buttonCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(261, 35);
            this.buttonCancelOrder.TabIndex = 7;
            this.buttonCancelOrder.Text = "Завершить заказ";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListCarsInRent
            // 
            this.dataGridViewListCarsInRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCarsInRent.Location = new System.Drawing.Point(10, 112);
            this.dataGridViewListCarsInRent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListCarsInRent.Name = "dataGridViewListCarsInRent";
            this.dataGridViewListCarsInRent.RowHeadersWidth = 51;
            this.dataGridViewListCarsInRent.RowTemplate.Height = 24;
            this.dataGridViewListCarsInRent.Size = new System.Drawing.Size(932, 389);
            this.dataGridViewListCarsInRent.TabIndex = 1;
            // 
            // tabPageListCars
            // 
            this.tabPageListCars.Controls.Add(this.label4);
            this.tabPageListCars.Controls.Add(this.comboBox5);
            this.tabPageListCars.Controls.Add(this.label5);
            this.tabPageListCars.Controls.Add(this.comboBox6);
            this.tabPageListCars.Controls.Add(this.button3);
            this.tabPageListCars.Controls.Add(this.button4);
            this.tabPageListCars.Controls.Add(this.button1);
            this.tabPageListCars.Controls.Add(this.button2);
            this.tabPageListCars.Controls.Add(this.dataGridView1);
            this.tabPageListCars.Location = new System.Drawing.Point(4, 27);
            this.tabPageListCars.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageListCars.Name = "tabPageListCars";
            this.tabPageListCars.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageListCars.Size = new System.Drawing.Size(954, 509);
            this.tabPageListCars.TabIndex = 2;
            this.tabPageListCars.Text = "Список автомобилей";
            this.tabPageListCars.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите из списка:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(424, 68);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(233, 26);
            this.comboBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите критерий поиска:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(424, 27);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(233, 26);
            this.comboBox6.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(682, 106);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить автомобиль из списка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 106);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Изменить данные автомобиля";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить автомобиль";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAutopark);
            this.tabControlMain.Controls.Add(this.tabPageOrders);
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Location = new System.Drawing.Point(-1, -1);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(962, 568);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddBonus);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxCoef);
            this.tabPage1.Controls.Add(this.textBoxDescription);
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(954, 537);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Справочник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddBonus
            // 
            this.buttonAddBonus.Location = new System.Drawing.Point(197, 99);
            this.buttonAddBonus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddBonus.Name = "buttonAddBonus";
            this.buttonAddBonus.Size = new System.Drawing.Size(198, 26);
            this.buttonAddBonus.TabIndex = 5;
            this.buttonAddBonus.Text = "Добавить информацию";
            this.buttonAddBonus.UseVisualStyleBackColor = true;
            this.buttonAddBonus.Click += new System.EventHandler(this.buttonAddBonus_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Коэффициент скидки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Описание:";
            // 
            // textBoxCoef
            // 
            this.textBoxCoef.Location = new System.Drawing.Point(197, 59);
            this.textBoxCoef.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoef.Name = "textBoxCoef";
            this.textBoxCoef.Size = new System.Drawing.Size(197, 24);
            this.textBoxCoef.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(197, 22);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(197, 24);
            this.textBoxDescription.TabIndex = 1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(10, 143);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(932, 386);
            this.dataGridView4.TabIndex = 0;
            // 
            // rentcarsdbDataSet
            // 
            this.rentcarsdbDataSet.DataSetName = "rentcarsdbDataSet";
            this.rentcarsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentcarsdbDataSetBindingSource
            // 
            this.rentcarsdbDataSetBindingSource.DataSource = this.rentcarsdbDataSet;
            this.rentcarsdbDataSetBindingSource.Position = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnBrand
            // 
            this.ColumnBrand.HeaderText = "Бренд";
            this.ColumnBrand.MinimumWidth = 6;
            this.ColumnBrand.Name = "ColumnBrand";
            this.ColumnBrand.ReadOnly = true;
            // 
            // ColumnClassCar
            // 
            this.ColumnClassCar.HeaderText = "Класс";
            this.ColumnClassCar.MinimumWidth = 6;
            this.ColumnClassCar.Name = "ColumnClassCar";
            this.ColumnClassCar.ReadOnly = true;
            // 
            // ColumnTransmisson
            // 
            this.ColumnTransmisson.HeaderText = "Коробка передач";
            this.ColumnTransmisson.MinimumWidth = 6;
            this.ColumnTransmisson.Name = "ColumnTransmisson";
            this.ColumnTransmisson.ReadOnly = true;
            // 
            // ColumnColor
            // 
            this.ColumnColor.HeaderText = "Цвет";
            this.ColumnColor.MinimumWidth = 6;
            this.ColumnColor.Name = "ColumnColor";
            this.ColumnColor.ReadOnly = true;
            // 
            // formManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(959, 571);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прокат автомобилей";
            this.tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageAutopark.ResumeLayout(false);
            this.tabControlAutopark.ResumeLayout(false);
            this.tabPageCarsNotInRent.ResumeLayout(false);
            this.tabPageCarsNotInRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCarsNotInRent)).EndInit();
            this.tabPageCarsInRent.ResumeLayout(false);
            this.tabPageCarsInRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCarsInRent)).EndInit();
            this.tabPageListCars.ResumeLayout(false);
            this.tabPageListCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarsdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarsdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageAutopark;
        private System.Windows.Forms.TabControl tabControlAutopark;
        private System.Windows.Forms.TabPage tabPageCarsNotInRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelSelectCriterion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUpdateListNotInRent;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.DataGridView dataGridViewListCarsNotInRent;
        private System.Windows.Forms.TabPage tabPageCarsInRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button buttonUpdateListCarsInRent;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.DataGridView dataGridViewListCarsInRent;
        private System.Windows.Forms.TabPage tabPageListCars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonAddBonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCoef;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransmisson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.BindingSource rentcarsdbDataSetBindingSource;
        private rentcarsdbDataSet rentcarsdbDataSet;
    }
}