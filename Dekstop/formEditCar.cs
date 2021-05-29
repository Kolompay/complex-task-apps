using Npgsql;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formEditCar : Form
    {
        private string nameForUpdate;
        private DataGridView dataGridViewListCars;
        private ComboBox comboBoxListCarsFirst;
        private Label labelInfo;
        String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
        private int rowIndex;

        public formEditCar(string nameForUpdate, int rowIndex, DataGridView dataGridViewListCars, ComboBox comboBoxListCarsFirst, Label labelInfo)
        {
            InitializeComponent();
            this.nameForUpdate = nameForUpdate;
            this.rowIndex = rowIndex;
            this.dataGridViewListCars = dataGridViewListCars;
            this.comboBoxListCarsFirst = comboBoxListCarsFirst;
            this.labelInfo = labelInfo;
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransmission.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadTransmission();
        }

        private void LoadTransmission()
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    string querystring = "select * from car";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(querystring, connectionString);
                    DataSet1 ds = new DataSet1();
                    
                    adapter.Fill(ds, "car");

                    comboBoxTransmission.DataSource = ds.Tables["car"];
                    comboBoxTransmission.DisplayMember = "transmission";
                    comboBoxTransmission.ValueMember = "transmission";
                    npgSqlConnection.Close();
                }
                catch (Exception ex)
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string name = nameForUpdate;
                    npgSqlConnection.Open();
                    String strSQL = $"UPDATE car SET name='{textBoxName.Text}', brand='{textBoxBrand.Text}', classcar='{textBoxClass.Text}', transmission='{comboBoxTransmission.SelectedValue}', color='{comboBoxColor.SelectedItem}' WHERE name = '{name}'";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        String str = "SELECT * FROM car WHERE deleted = false ORDER BY idcar";
                        DataGridView dataGrid = dataGridViewListCars;
                        ComboBox comboBox = comboBoxListCarsFirst;
                        LoadData(str, dataGrid, comboBox, labelInfo);
                        Close();
                        MessageBox.Show("Данные успешно обновлены!");
                    }
                    npgSqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void formEditCar_Load(object sender, EventArgs e)
        {
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


            textBoxName.Text = (string)dataGridViewListCars.Rows[rowIndex].Cells[0].Value;


            string querystring = "select * from car where name = '" + textBoxName.Text + "'";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(querystring, connectionString);
            DataSet1 ds = new DataSet1();

            adapter.Fill(ds, "car");
            textBoxBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "car.brand"));

            //textBoxBrand.Text = (string)dataGridViewListCars.Rows[rowIndex].Cells[1].Value;


            textBoxClass.Text = (string)dataGridViewListCars.Rows[rowIndex].Cells[2].Value;
            comboBoxTransmission.SelectedItem = (string)dataGridViewListCars.Rows[rowIndex].Cells[3].Value;
            comboBoxColor.SelectedItem = (string)dataGridViewListCars.Rows[rowIndex].Cells[4].Value;


            querystring = "select * from car where name = '" + textBoxName.Text + "'";
            adapter = new NpgsqlDataAdapter(querystring, connectionString);
            ds = new DataSet1();

            adapter.Fill(ds, "car");
            labelIDInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", ds, "car.idcar"));


            
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

        private void formEditCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManager form = (formManager)Application.OpenForms[0];
            form.Show();
        }
    }
}
