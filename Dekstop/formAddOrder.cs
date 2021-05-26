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
        String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";


        public formAddOrder(string nameForOrder, int rowIndex, DataGridView dataGridViewListCarsNotInRent, ComboBox comboBoxAvailableCarsFirst)
        {
            InitializeComponent();
            this.nameForOrder = nameForOrder;
            this.rowIndex = rowIndex;
            this.dataGridViewListCarsNotInRent = dataGridViewListCarsNotInRent;
            this.comboBoxAvailableCarsFirst = comboBoxAvailableCarsFirst;
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
            if (textBoxFamilyName.TextLength > 5)
            {
                ToolTip toolTipFamilyName = new ToolTip();
                toolTipFamilyName.SetToolTip(textBoxFamilyName, "Макс. длинна 50 символов");
                //toolTipFamilyName.Active = true;
                //toolTipFamilyName.ForeColor = Color.Red;
                //toolTipFamilyName.Show("Ку", textBoxFamilyName, 10);
                e.Handled = true;
            }
            else
            {
                return;
            }
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
    }
}
