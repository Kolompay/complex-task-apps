using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formManager : Form
    {
        String attribut;
        String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
        public static String nameForUpdate = String.Empty;
        public static String nameForOrder = String.Empty;
        public static int rowIndex;
        public formManager()
        {
            InitializeComponent();

            // Для вкладки "Доступные автомобили"
            //buttonUpdateListNotInRent_Click(buttonUpdateListNotInRent, null);
            dataGridViewListCarsNotInRent.ClearSelection();
            comboBoxAvailableCarsFirst.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAvailableCarsSecond.DropDownStyle = ComboBoxStyle.DropDownList;
            labelSelectCriterionAvailableCarsSecond.Visible = false;
            comboBoxAvailableCarsSecond.Visible = false;
            buttonAddOrder.Enabled = false;


            // Для вкладки "Автомобили в прокате"
            comboBoxRentedCarsFirst.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRentedCarsSecond.DropDownStyle = ComboBoxStyle.DropDownList;
            labelSelectCriterionRentedCarsSecond.Visible = false;
            comboBoxRentedCarsSecond.Visible = false;

            // Для вкладки "Список автомобилей"
            comboBoxListCarsFirst.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxListCarsSecond.DropDownStyle = ComboBoxStyle.DropDownList;
            labelSelectCriterionListCarsSecond.Visible = false;
            comboBoxListCarsSecond.Visible = false;

            ToolTip t = new ToolTip();
            t.SetToolTip(buttonListCarsEdit, "Для изменения выберите автомобиль!");

            buttonListCarsEdit.Enabled = false;

            //tabPageAutopark.Font.Bold = new Font("Microsoft Sans Serif", 7.8F, Font.Bold, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))); ;
        }


        // Общие функции

        /// <summary>
        /// Заполнение DataGridView данными
        /// </summary>
        private void DataGridViewAddCells(DataGridView dataGridView, NpgsqlDataReader reader, String[] parameters)
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
                labelListCarsInfo.Text = "Количество машин в таблице: " + dataGridView.Rows.Count.ToString();
                rowNum++;
            }
            dataGridView.ClearSelection();
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
        private void LoadData(String strSQL, DataGridView dataGridView, ComboBox comboBoxFirst)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataGridViewAddCells(dataGridView, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
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


        // Для вкладки "Доступные автомобили"

        private void tabPageCarsNotInRent_Enter(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM car WHERE car.rented = false AND car.deleted = false", dataGridViewListCarsNotInRent, comboBoxListCarsFirst);
            dataGridViewListCarsNotInRent.ClearSelection();
        }

        private void tabPageCarsNotInRent_Leave(object sender, EventArgs e)
        {
            dataGridViewListCarsNotInRent.Rows.Clear();
            comboBoxAvailableCarsFirst.SelectedItem = null;
            labelSelectCriterionAvailableCarsSecond.Visible = false;
            comboBoxAvailableCarsSecond.Visible = false;
            comboBoxAvailableCarsSecond.Items.Clear();
        }

        private void comboBoxAvailableCarsFirst_Click(object sender, EventArgs e)
        {
            labelSelectCriterionAvailableCarsSecond.Visible = false;
            comboBoxAvailableCarsSecond.Visible = false;
        }

        private void comboBoxAvailableCarsFirst_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxAvailableCarsFirst.SelectedItem != null)
            {
                comboBoxAvailableCarsSecond.Items.Clear();
                LoadData("SELECT * FROM car WHERE rented = false and deleted = false", dataGridViewListCarsNotInRent, comboBoxAvailableCarsFirst);
                
                using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgSqlConnection.Open();
                    String strSQL = "SELECT * FROM car WHERE rented = false";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        attribut = null;
                        if (comboBoxAvailableCarsFirst.SelectedItem.ToString() == "Название")
                        {
                            ComboBoxAddItems(comboBoxAvailableCarsSecond, "name", reader);
                            attribut = "name";
                        }
                        else if (comboBoxAvailableCarsFirst.SelectedItem.ToString() == "Бренд")
                        {
                            ComboBoxAddItems(comboBoxAvailableCarsSecond, "brand", reader);
                            attribut = "brand";
                        }
                        else if (comboBoxAvailableCarsFirst.SelectedItem.ToString() == "Класс")
                        {
                            ComboBoxAddItems(comboBoxAvailableCarsSecond, "classcar", reader);
                            attribut = "classcar";
                        }
                        else if (comboBoxAvailableCarsFirst.SelectedItem.ToString() == "Коробка передач")
                        {
                            ComboBoxAddItems(comboBoxAvailableCarsSecond, "transmission", reader);
                            attribut = "transmission";
                        }
                        else if (comboBoxAvailableCarsFirst.SelectedItem.ToString() == "Цвет")
                        {
                            ComboBoxAddItems(comboBoxAvailableCarsSecond, "color", reader);
                            attribut = "color";
                        }
                    }
                    npgSqlConnection.Close();
                }
                labelSelectCriterionAvailableCarsSecond.Visible = true;
                comboBoxAvailableCarsSecond.Visible = true;
            }
        }

        private void comboBoxAvailableCarsSecond_SelectedValueChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car WHERE " + attribut + " LIKE '" + comboBoxAvailableCarsSecond.SelectedItem.ToString() + "' AND rented = false";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataGridViewAddCells(dataGridViewListCarsNotInRent, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
                }
                dataGridViewListCarsNotInRent.ClearSelection();
                npgSqlConnection.Close();
            }
        }

        private void buttonUpdateListNotInRent_Click(object sender, EventArgs e)
        {
            if (attribut!=null)
                LoadData($"SELECT * FROM car WHERE rented = false AND deleted = false AND {attribut} = '{comboBoxAvailableCarsSecond.SelectedItem}'", dataGridViewListCarsNotInRent, comboBoxAvailableCarsFirst);
            else
                LoadData($"SELECT * FROM car WHERE rented = false AND deleted = false", dataGridViewListCarsNotInRent, comboBoxAvailableCarsFirst);
            buttonAddOrder.Enabled = false;
            dataGridViewListCarsNotInRent.ClearSelection();
        }


        // Для вкладки "Автомобили в прокате"

        private void tabPageCarsInRent_Enter(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM car  WHERE rented = true AND deleted = false", dataGridViewListCarsInRent, comboBoxRentedCarsFirst);
            dataGridViewListCarsInRent.ClearSelection();
        }

        private void tabPageCarsInRent_Leave(object sender, EventArgs e)
        {
            dataGridViewListCarsInRent.Rows.Clear();
            comboBoxRentedCarsFirst.SelectedItem = null;
            labelSelectCriterionRentedCarsSecond.Visible = false;
            comboBoxRentedCarsSecond.Visible = false;
            comboBoxRentedCarsSecond.Items.Clear();
        }

        private void comboBoxRentedCarsFirst_Click(object sender, EventArgs e)
        {
            labelSelectCriterionRentedCarsSecond.Visible = false;
            comboBoxRentedCarsSecond.Visible = false;
        }

        private void comboBoxRentedCarsFirst_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxRentedCarsFirst.SelectedItem != null)
            {
                comboBoxRentedCarsSecond.Items.Clear();
                LoadData("SELECT * FROM car WHERE rented = true AND deleted = false", dataGridViewListCarsInRent, comboBoxRentedCarsFirst);
                using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgSqlConnection.Open();
                    String strSQL = "SELECT * FROM car WHERE rented = true AND deleted = false";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        attribut = null;
                        if (comboBoxRentedCarsFirst.SelectedItem.ToString() == "Название")
                        {
                            ComboBoxAddItems(comboBoxRentedCarsSecond, "name", reader);
                            attribut = "name";
                        }
                        else if (comboBoxRentedCarsFirst.SelectedItem.ToString() == "Бренд")
                        {
                            ComboBoxAddItems(comboBoxRentedCarsSecond, "brand", reader);
                            attribut = "brand";
                        }
                        else if (comboBoxRentedCarsFirst.SelectedItem.ToString() == "Класс")
                        {
                            ComboBoxAddItems(comboBoxRentedCarsSecond, "classcar", reader);
                            attribut = "classcar";
                        }
                        else if (comboBoxRentedCarsFirst.SelectedItem.ToString() == "Коробка передач")
                        {
                            ComboBoxAddItems(comboBoxRentedCarsSecond, "transmission", reader);
                            attribut = "transmission";
                        }
                        else if (comboBoxRentedCarsFirst.SelectedItem.ToString() == "Цвет")
                        {
                            ComboBoxAddItems(comboBoxRentedCarsSecond, "color", reader);
                            attribut = "color";
                        }
                    }
                    npgSqlConnection.Close();
                }
                labelSelectCriterionRentedCarsSecond.Visible = true;
                comboBoxRentedCarsSecond.Visible = true;
            }
        }

        private void comboBoxRentedCarsSecond_SelectedValueChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car WHERE " + attribut + " LIKE '" + comboBoxRentedCarsSecond.SelectedItem.ToString() + "' AND rented = true AND deleted = false";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataGridViewAddCells(dataGridViewListCarsInRent, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
                }
                npgSqlConnection.Close();
            }
        }

        private void buttonUpdateListCarsInRent_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM car WHERE rented = true AND deleted = false", dataGridViewListCarsInRent, comboBoxRentedCarsFirst);
            dataGridViewListCarsInRent.ClearSelection();
        }


        // Для вкладки "Список автомобилей"

        private void tabPageListCars_Enter(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM car WHERE deleted = false", dataGridViewListCars, comboBoxListCarsFirst);
            dataGridViewListCars.ClearSelection();
        }

        private void tabPageListCars_Leave(object sender, EventArgs e)
        {
            dataGridViewListCars.Rows.Clear();
            comboBoxListCarsFirst.SelectedItem = null;
            labelSelectCriterionListCarsSecond.Visible = false;
            comboBoxListCarsSecond.Visible = false;
            comboBoxListCarsSecond.Items.Clear();
        }

        private void comboBoxListCarsFirst_Click(object sender, EventArgs e)
        {
            labelSelectCriterionListCarsSecond.Visible = false;
            comboBoxListCarsSecond.Visible = false;
        }

        private void comboBoxListCarsFirst_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxListCarsFirst.SelectedItem != null)
            {
                comboBoxListCarsSecond.Items.Clear();
                LoadData("SELECT * FROM car WHERE deleted = false", dataGridViewListCars, comboBoxListCarsFirst);
                using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgSqlConnection.Open();
                    String strSQL = "SELECT * FROM car WHERE deleted = false";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        attribut = null;
                        if (comboBoxListCarsFirst.SelectedItem.ToString() == "Название")
                        {
                            ComboBoxAddItems(comboBoxListCarsSecond, "name", reader);
                            attribut = "name";
                        }
                        else if (comboBoxListCarsFirst.SelectedItem.ToString() == "Бренд")
                        {
                            ComboBoxAddItems(comboBoxListCarsSecond, "brand", reader);
                            attribut = "brand";
                        }
                        else if (comboBoxListCarsFirst.SelectedItem.ToString() == "Класс")
                        {
                            ComboBoxAddItems(comboBoxListCarsSecond, "classcar", reader);
                            attribut = "classcar";
                        }
                        else if (comboBoxListCarsFirst.SelectedItem.ToString() == "Коробка передач")
                        {
                            ComboBoxAddItems(comboBoxListCarsSecond, "transmission", reader);
                            attribut = "transmission";
                        }
                        else if (comboBoxListCarsFirst.SelectedItem.ToString() == "Цвет")
                        {
                            ComboBoxAddItems(comboBoxListCarsSecond, "color", reader);
                            attribut = "color";
                        }
                    }
                    npgSqlConnection.Close();
                }
                labelSelectCriterionListCarsSecond.Visible = true;
                comboBoxListCarsSecond.Visible = true;
            }
        }
        private void comboBoxListCarsSecond_SelectedValueChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car WHERE " + attribut + " LIKE '" + comboBoxListCarsSecond.SelectedItem.ToString() + "' AND deleted = false";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataGridViewAddCells(dataGridViewListCars, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
                }
                npgSqlConnection.Close();
            }
        }

        private void buttonListCarsUpdate_Click(object sender, EventArgs e)
        {
            //LoadData("SELECT * FROM car WHERE deleted = false", dataGridViewListCars, comboBoxListCarsFirst);

            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    string querystring = "select name, brand, classcar, transmission, color from car where deleted = false";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(querystring, connectionString);
                    DataTable t = new DataTable();

                    var result = adapter.Fill(t);
                    labelListCarsInfo.Text = "Количество машин в таблице: " + result.ToString();

                    LoadData("SELECT * FROM car WHERE deleted = false", dataGridViewListCars, comboBoxListCarsFirst);
                    npgSqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Для вкладки справочник

        private void buttonAddBonus_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    String strSQL = "INSERT INTO bonussystem (description, discountpercent) VALUES ('" + textBoxDescription.Text + "', '" + textBoxCoef.Text + "')";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно добавлена!");
                    strSQL = "SELECT * FROM bonussystem";
                    cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(rdr);
                    dataGridView4.DataSource = t.DefaultView;
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonListCarsEdit_Click(object sender, EventArgs e)
        {
            formEditCar formEditCar = new formEditCar(nameForUpdate, rowIndex, dataGridViewListCars, comboBoxListCarsFirst);
            formEditCar.Show();
        }

        private void dataGridViewListCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            var name = dataGridViewListCars.Rows[e.RowIndex].Cells[0].Value;
            nameForUpdate = Convert.ToString(name);

            buttonListCarsEdit.Enabled = true;
        }

        private void buttonListCarsDel_Click(object sender, EventArgs e)
        {
            if (rowIndex != -1)
            {
                using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        string name = nameForUpdate;
                        npgSqlConnection.Open();
                        String strSQL = $"UPDATE car SET deleted=true WHERE name = '{name}'";
                        NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            String str = "SELECT * FROM car WHERE deleted = false ORDER BY idcar";
                            DataGridView dataGrid = dataGridViewListCars;
                            ComboBox comboBox = comboBoxListCarsFirst;
                            LoadData(str, dataGrid, comboBox);
                            MessageBox.Show($"Автомобиль {name} удалён!");
                        }
                        npgSqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonListCarsEdit_MouseEnter(object sender, EventArgs e)
        {
            if (buttonListCarsEdit.Enabled == false)
            {
                ToolTip t = new ToolTip();
                t.SetToolTip(buttonListCarsEdit, "Для изменения выберите автомобиль!");
            }
        }

        private void buttonListCarsEdit_MouseHover(object sender, EventArgs e)
        {
            if (buttonListCarsEdit.Enabled == false)
            {
                ToolTip t = new ToolTip();
                t.SetToolTip(buttonListCarsEdit, "Для изменения выберите автомобиль!");
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            formAddOrder formAddOrder = new formAddOrder(nameForOrder, rowIndex, dataGridViewListCarsNotInRent, comboBoxAvailableCarsFirst);
            formAddOrder.Show();
            this.Hide();
        }

        private void dataGridViewListCarsNotInRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                rowIndex = e.RowIndex;
                var name = dataGridViewListCarsNotInRent.Rows[e.RowIndex].Cells[0].Value;
                nameForOrder = Convert.ToString(name);
                dataGridViewListCarsNotInRent.CurrentRow.DefaultCellStyle.BackColor = dataGridViewListCarsNotInRent.RowsDefaultCellStyle.SelectionBackColor;
                dataGridViewListCarsNotInRent.CurrentRow.DefaultCellStyle.ForeColor = dataGridViewListCarsNotInRent.RowsDefaultCellStyle.SelectionForeColor;
                buttonAddOrder.Enabled = true;
            }
        }

        private void dataGridViewListCarsNotInRent_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListCarsNotInRent.Rows.Count != 0)
            {
                dataGridViewListCarsNotInRent.CurrentRow.DefaultCellStyle.BackColor = dataGridViewListCarsNotInRent.RowsDefaultCellStyle.BackColor;
                dataGridViewListCarsNotInRent.CurrentRow.DefaultCellStyle.ForeColor = dataGridViewListCarsNotInRent.RowsDefaultCellStyle.ForeColor;
            }
        }

        private void formManager_Shown(object sender, EventArgs e)
        {
            buttonUpdateListNotInRent_Click(buttonUpdateListNotInRent, null);
            dataGridViewListCarsInRent.ClearSelection();
            dataGridViewListCars.ClearSelection();
        }

        private void dataGridViewListCars_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dataGridViewListCars.ClearSelection();
        }

        private void buttonListCarsAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditRentCar_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateRentCar_Click(object sender, EventArgs e)
        {

        }

        private void buttonComplateOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {

        }
    }
}
