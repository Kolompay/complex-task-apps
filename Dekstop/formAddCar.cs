using Npgsql;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formAddCar : Form
    {
        String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
        private DataGridView dataGridViewListCars;
        private ComboBox comboBoxListCarsFirst;
        private Label labelInfo;
        public formAddCar(DataGridView dataGridViewListCars, ComboBox comboBoxListCarsFirst, Label labelInfo)
        {
            InitializeComponent();
            
            comboBoxRate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYearOfManufacture.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxRate_Click(comboBoxRate, null);
            comboBoxTransmission_Click(comboBoxTransmission, null);

            this.dataGridViewListCars = dataGridViewListCars;
            this.comboBoxListCarsFirst = comboBoxListCarsFirst;
            this.labelInfo = labelInfo;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    string strSQL = $"SELECT idrate from rate WHERE description = '{comboBoxRate.SelectedItem}'";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    string rate = null;
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rate = reader[0].ToString();
                        }
                    }
                    strSQL = $"INSERT INTO car(vinnumber, brand, classcar, name, transmission, color, yearofmanufacture, idlocationcar, rented, deleted, idrate) " +
                        $"VALUES ('{textBoxVINnumber.Text}', " +
                        $"'{textBoxBrand.Text}', " +
                        $"'{textBoxClass.Text}', " +
                        $"'{textBoxName.Text}', " +
                        $"'{comboBoxTransmission.SelectedItem}', " +
                        $"'{comboBoxColor.SelectedItem}', " +
                        $"'{comboBoxYearOfManufacture.SelectedItem}', " +
                        $"1, false, false, {rate})";
                    cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show($"Автомобиль {textBoxName.Text} успешно добавлен!", "Информация");
                        LoadData("select * from car where rented = false AND deleted = false", dataGridViewListCars, comboBoxListCarsFirst, labelInfo);
                        npgSqlConnection.Close();
                        Close();
                    }

                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBoxTransmission_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    string strSQL = $"SELECT * from car";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        ComboBoxAddItems(comboBoxTransmission, "transmission", reader);
                    }
                    comboBoxTransmission.SelectedItem = comboBoxTransmission.Items[0];
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBoxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.FillRectangle(new SolidBrush(Color.White), rect.X, rect.Y, rect.Width, rect.Height);
                g.DrawString(n, f, Brushes.Black, rect.X + 20, rect.Top);
                g.FillRectangle(b, rect.X, rect.Y, 20, 20);
            }

        }

        private void formAddCar_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 21; i--)
                comboBoxYearOfManufacture.Items.Add(i);
            comboBoxYearOfManufacture.SelectedItem = comboBoxYearOfManufacture.Items[0];

            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                comboBoxColor.Items.Add(c.Name);
            }
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxColor.DrawItem += new DrawItemEventHandler(comboBoxColor_DrawItem);
            comboBoxColor.SelectedItem = comboBoxColor.Items[45];
        }

        private void comboBoxRate_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    string strSQL = $"SELECT description from rate";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        ComboBoxAddItems(comboBoxRate, "description", reader);
                    }
                    comboBoxRate.SelectedItem = comboBoxRate.Items[0];
                    npgSqlConnection.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void formAddCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManager form = (formManager)Application.OpenForms[0];
            form.Show();
        }
    }
}
