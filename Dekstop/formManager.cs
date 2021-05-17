using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formManager : Form
    {
        String attribut;
        public formManager()
        {
            InitializeComponent();
            comboBoxSearchAvailable.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchAvailableList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchRent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchRentList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCarList.DropDownStyle = ComboBoxStyle.DropDownList;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            comboBoxSearchAvailableList.Visible = false;
            comboBoxSearchRentList.Visible = false;
            comboBoxSearchCarList.Visible = false;
        }

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
                rowNum++;
            }
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

        private void LoadData(String strSQL, DataGridView dataGrid, ComboBox comboBox)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);                    
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataGridViewAddCells(dataGrid, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });                        
                    }
                    if (comboBox.Items.Count == 0)
                    {
                        for (int i = 0; i < dataGrid.Columns.Count; i++)
                        {
                            comboBox.Items.Add(dataGrid.Columns[i].HeaderText);
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

        private void buttonAddBonus_Click(object sender, EventArgs e)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboBoxSearchAvailableList.Visible = true;
            comboBoxSearchAvailableList.Items.Clear();
            String strSQL = "SELECT * FROM car";
            DataGridView dataGrid = dataGridViewListCarsNotInRent;
            ComboBox comboBox = comboBoxSearchAvailable;
            LoadData(strSQL, dataGrid, comboBox);
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    attribut = null;
                    if (comboBoxSearchAvailable.SelectedItem.ToString() == "Название")
                    {
                        ComboBoxAddItems(comboBoxSearchAvailableList, "name", reader);
                        attribut = "name";
                    }
                    else if (comboBoxSearchAvailable.SelectedItem.ToString() == "Бренд")
                    {
                        ComboBoxAddItems(comboBoxSearchAvailableList, "brand", reader);
                        attribut = "brand";
                    }
                    else if (comboBoxSearchAvailable.SelectedItem.ToString() == "Класс")
                    {
                        ComboBoxAddItems(comboBoxSearchAvailableList, "classcar", reader);
                        attribut = "classcar";
                    }
                    else if (comboBoxSearchAvailable.SelectedItem.ToString() == "Коробка передач")
                    {
                        ComboBoxAddItems(comboBoxSearchAvailableList, "transmission", reader);
                        attribut = "transmission";
                    }
                    else if (comboBoxSearchAvailable.SelectedItem.ToString() == "Цвет")
                    {
                        ComboBoxAddItems(comboBoxSearchAvailableList, "color", reader);
                        attribut = "color";
                    }                    
                }
                npgSqlConnection.Close();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBoxSearchAvailableList.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car WHERE " + attribut + " LIKE '" + comboBoxSearchAvailableList.SelectedItem.ToString()+ "'";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataGridViewAddCells(dataGridViewListCarsNotInRent, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
                }
                npgSqlConnection.Close();
            }
        }

        private void comboBoxSearchCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            comboBoxSearchCarList.Visible = true;
            comboBoxSearchCarList.Items.Clear();
            String strSQL = "SELECT * FROM car";
            DataGridView dataGrid = dataGridViewCarList;
            ComboBox comboBox = comboBoxSearchCar;
            LoadData(strSQL, dataGrid, comboBox);
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    attribut = null;
                    if (comboBoxSearchCar.SelectedItem.ToString() == "Название")
                    {
                        ComboBoxAddItems(comboBoxSearchCarList, "name", reader);
                        attribut = "name";
                    }
                    else if (comboBoxSearchCar.SelectedItem.ToString() == "Бренд")
                    {
                        ComboBoxAddItems(comboBoxSearchCarList, "brand", reader);
                        attribut = "brand";
                    }
                    else if (comboBoxSearchCar.SelectedItem.ToString() == "Класс")
                    {
                        ComboBoxAddItems(comboBoxSearchCarList, "classcar", reader);
                        attribut = "classcar";
                    }
                    else if (comboBoxSearchCar.SelectedItem.ToString() == "Коробка передач")
                    {
                        ComboBoxAddItems(comboBoxSearchCarList, "transmission", reader);
                        attribut = "transmission";
                    }
                    else if (comboBoxSearchCar.SelectedItem.ToString() == "Цвет")
                    {
                        ComboBoxAddItems(comboBoxSearchCarList, "color", reader);
                        attribut = "color";
                    }
                }
                npgSqlConnection.Close();
            }
        }

        private void comboBoxSearchCar_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            comboBoxSearchCarList.Visible = false;
        }

        private void comboBoxSearchCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car WHERE " + attribut + " LIKE '" + comboBoxSearchCarList.SelectedItem.ToString() + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataGridViewAddCells(dataGridViewCarList, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
                }
                npgSqlConnection.Close();
            }
        }

        private void buttonUpdateListNotInRent_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT * FROM car";
            DataGridView dataGrid = dataGridViewListCarsNotInRent;
            ComboBox comboBox = comboBoxSearchAvailable;
            LoadData(strSQL, dataGrid, comboBox);
        }

        private void buttonUpdateCarList_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT * FROM car";
            DataGridView dataGrid = dataGridViewCarList;
            ComboBox comboBox = comboBoxSearchCar;
            LoadData(strSQL, dataGrid, comboBox);
        }

        private void formManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            formAddCar formAddCars = new formAddCar();
            formAddCars.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDelCar_Click(object sender, EventArgs e)
        {

        }
    }
}
