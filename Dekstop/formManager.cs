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
            LoadData();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            label1.Visible = false;
            comboBox2.Visible = false;
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

        private void LoadData()
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    String strSQL = "SELECT * FROM car";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);                    
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataGridViewAddCells(dataGridViewListCarsNotInRent, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });                        
                    }
                    if (comboBox1.Items.Count == 0)
                    {
                        for (int i = 0; i < dataGridViewListCarsNotInRent.Columns.Count; i++)
                        {
                            comboBox1.Items.Add(dataGridViewListCarsNotInRent.Columns[i].HeaderText);
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
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            LoadData();
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    attribut = null;
                    if (comboBox1.SelectedItem.ToString() == "Название")
                    {
                        ComboBoxAddItems(comboBox2, "name", reader);
                        attribut = "name";
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Бренд")
                    {
                        ComboBoxAddItems(comboBox2, "brand", reader);
                        attribut = "brand";
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Класс")
                    {
                        ComboBoxAddItems(comboBox2, "classcar", reader);
                        attribut = "classcar";
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Коробка передач")
                    {
                        ComboBoxAddItems(comboBox2, "transmission", reader);
                        attribut = "transmission";
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Цвет")
                    {
                        ComboBoxAddItems(comboBox2, "color", reader);
                        attribut = "color";
                    }                    
                }
                npgSqlConnection.Close();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox2.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                npgSqlConnection.Open();
                String strSQL = "SELECT * FROM car WHERE " + attribut + " LIKE '" + comboBox2.SelectedItem.ToString()+ "'";
                NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    DataGridViewAddCells(dataGridViewListCarsNotInRent, reader, new String[] { "name", "brand", "classcar", "transmission", "color" });
                }
                npgSqlConnection.Close();
            }
        }
    }
}
