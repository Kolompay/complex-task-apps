using Npgsql;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formAddOrder : Form
    {
        private string nameForOrder;
        private int rowIndex;
        private DataGridView dataGridViewListCarsNotInRent;
        private ComboBox comboBoxAvailableCarsFirst;
        private Label labelInfo;
        String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";

        public formAddOrder(string nameForOrder, int rowIndex, DataGridView dataGridViewListCarsNotInRent, ComboBox comboBoxAvailableCarsFirst, Label labelInfo)
        {
            InitializeComponent();
            this.nameForOrder = nameForOrder;
            this.rowIndex = rowIndex;
            this.dataGridViewListCarsNotInRent = dataGridViewListCarsNotInRent;
            this.comboBoxAvailableCarsFirst = comboBoxAvailableCarsFirst;
            this.labelInfo = labelInfo;
            comboBoxCars.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRates.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Заполнение ComboBox данными
        /// </summary>
        private void ComboBoxAddItems(ComboBox combo, String read, NpgsqlDataReader reader)
        {
            while (reader.Read())
            {
                if (!combo.Items.Contains(reader[read].ToString()))
                    combo.Items.Add(reader[read].ToString());
            }
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataCombo(String strSQL, String attribut, ComboBox comboBox)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        ComboBoxAddItems(comboBox, attribut, reader);
                    }
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        /// <summary>
        /// Заполнение DataGridView данными
        /// </summary>
        private void DataGridViewAddCells(DataGridView dataGridView, NpgsqlDataReader reader, String[] parameters, Label labelInfo)
        {
            int rowNum = 0;
            if (dataGridView.RowCount != 0)
                dataGridView.RowCount = 0;
            while (reader.Read())
            {
                dataGridView.RowCount++;
                for (int i = 0; i < parameters.Length; i++)
                {
                    dataGridView.Rows[rowNum].Cells[i].Value = reader[parameters[i]].ToString();
                }
                if (labelInfo != null)
                {
                    labelInfo.Text = "Количество машин в таблице: " + dataGridView.Rows.Count.ToString();
                }
                rowNum++;
            }
            dataGridView.ClearSelection();
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadData(String strSQL, DataGridView dataGridView, ComboBox comboBoxFirst, Label labelInfo)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataGridViewAddCells(dataGridView, reader, new String[] { "name", "brand", "classcar", "transmission", "color" }, labelInfo);
                    }

                    if (comboBoxFirst.Items.Count == 0)
                    {
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            comboBoxFirst.Items.Add(dataGridView.Columns[i].HeaderText);
                        }
                    }
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxRates_Click(object sender, EventArgs e)
        {
            LoadDataCombo($"select description from rate join car ON car.idrate = rate.idrate WHERE car.rented = false AND car.deleted = false and car.name = '{comboBoxCars.SelectedItem.ToString()}'", "description", comboBoxRates);
            if (comboBoxRates.Items.Count > 0)
                comboBoxRates.SelectedItem = comboBoxRates.Items[0];
        }

        private void comboBoxRates_SelectedValueChanged(object sender, EventArgs e)
        {
            costGo();
        }

        private void formAddOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManager form = (formManager)Application.OpenForms[0];
            form.Show();            
        }

        private void formAddOrder_Load(object sender, EventArgs e)
        {
            LoadDataCombo("select name from car WHERE rented = false AND deleted = false", "name", comboBoxCars);
            comboBoxCars.SelectedItem = nameForOrder;
            if (comboBoxCars.Items.Count > 0)
                comboBoxRates_Click(comboBoxRates, null);
        }

        private void comboBoxCars_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCars_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxRates.SelectedItem != null)
            {
                comboBoxRates.Items.Clear();
                LoadDataCombo($"select description from rate join car ON car.idrate = rate.idrate WHERE car.rented = false AND car.deleted = false and car.name = '{comboBoxCars.SelectedItem.ToString()}'", "description", comboBoxRates);
                if (comboBoxRates.Items.Count > 0)
                {
                    comboBoxRates.SelectedItem = comboBoxRates.Items[0];
                    costGo();
                }
            }
        }

        private void numericUpDownCountDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
                numericUpDownCountDays.Value = numericUpDownCountDays.Minimum;
        }

        private void textBoxFamilyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockAddCharToTextBox(textBoxFamilyName, 50, e);
        }

        private void numericUpDownCountDays_ValueChanged(object sender, EventArgs e)
        {
            costGo();

        }

        private void costGo()
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    String strSQL = $"select cost from rate where description = '{comboBoxRates.SelectedItem}'";
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBoxResultCost.Text = (Convert.ToInt32(numericUpDownCountDays.Value) * Convert.ToInt32(reader["cost"].ToString())).ToString() + " руб.";
                        }
                    }
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LockAddCharToTextBox(TextBox textBox, uint length, KeyPressEventArgs e)
        {
            if (textBox.TextLength > length - 1)
                e.Handled = true;
            else return;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockAddCharToTextBox(textBoxName, 50, e);
        }

        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockAddCharToTextBox(textBoxPatronymic, 50, e);
        }

        private void textBoxPassportData_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockAddCharToTextBox(textBoxPassportData, 25, e);
        }

        private void textBoxDriversLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockAddCharToTextBox(textBoxDriversLicense, 25, e);
        }

        private void textBoxNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            LockAddCharToTextBox(textBoxNumberPhone, 25, e);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    String strSQL = $"SELECT passportdata, driverslicense from client where blocked = false AND passportdata = '{textBoxPassportData.Text}'";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader npgsqlDataReader = cmd.ExecuteReader())
                    {
                        while (npgsqlDataReader.Read())
                        {
                            textBoxDriversLicense.Text = npgsqlDataReader[1].ToString();
                        }
                    }
                    
                    if (cmd.ExecuteReader().HasRows == false)
                    {
                        npgSqlConnection.Close();
                        npgSqlConnection.Open();
                        strSQL = $"INSERT INTO client(login, password, familyname, name, patronymic, passportdata, driverslicense, numberofphone, idbonussystem, blocked) " +
                        $"VALUES ('{textBoxFamilyName.Text}', " +
                        $"'{textBoxDriversLicense.Text}', " +
                        $"'{textBoxFamilyName.Text}', " +
                        $"'{textBoxName.Text}', " +
                        $"'{textBoxPatronymic.Text}', " +
                        $"'{textBoxPassportData.Text}', " +
                        $"'{textBoxDriversLicense.Text}', " +
                        $"'{textBoxNumberPhone.Text}', 1, false)";
                        cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            npgSqlConnection.Close();
                            npgSqlConnection.Open();
                            strSQL = $"SELECT idcar, idclient from car, client WHERE car.name = '{comboBoxCars.SelectedItem}' and client.driverslicense = '{textBoxDriversLicense.Text}'";
                            cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                            String[] mass = new String[2];
                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    mass[0] = reader[0].ToString();
                                    mass[1] = reader[1].ToString();
                                }
                            }

                            strSQL = $"INSERT INTO rentcar(cost, dateofissue, idcar, idclient, countdaysrent, deleted) " +
                            $"VALUES ('{textBoxResultCost.Text}', " +
                            $"'{DateTime.Now}', " +
                            $"'{mass[0]}', " +
                            $"'{mass[1]}', " +
                            $"'{numericUpDownCountDays.Value}', false)";
                            cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show($"Заказ аренды автомобиля {comboBoxCars.SelectedItem} оформлен!", "Информация");
                            }
                            strSQL = $"UPDATE car SET rented = true WHERE idcar = '{mass[0]}'";

                            cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                            cmd.ExecuteNonQuery();
                            Close();
                        }
                    }
                    else
                    {
                        npgSqlConnection.Close();
                        npgSqlConnection.Open();
                        strSQL = $"SELECT idcar, idclient from car, client WHERE car.name = '{comboBoxCars.SelectedItem}' and client.driverslicense = '{textBoxDriversLicense.Text}'";
                        cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                        String[] mass = new String[2];
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mass[0] = reader[0].ToString();
                                mass[1] = reader[1].ToString();
                            }
                        }

                        strSQL = $"INSERT INTO rentcar(cost, dateofissue, idcar, idclient, countdaysrent, deleted) " +
                        $"VALUES ('{textBoxResultCost.Text}', " +
                        $"'{DateTime.Now.ToShortDateString()}', " +
                        $"'{mass[0]}', " +
                        $"'{mass[1]}', " +
                        $"'{numericUpDownCountDays.Value}', false)";
                        cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show($"Заказ аренды автомобиля {comboBoxCars.SelectedItem} оформлен!", "Информация");
                        }
                        strSQL = $"UPDATE car SET rented = true WHERE idcar = '{mass[0]}'";

                        cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData("select * from car where rented = false AND deleted = false", dataGridViewListCarsNotInRent, comboBoxAvailableCarsFirst, labelInfo);
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
