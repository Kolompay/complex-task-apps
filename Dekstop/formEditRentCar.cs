using Npgsql;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formEditRentCar : Form
    {
        String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
        private string idForUpdateRentCar;
        private int rowIndexRentCar;
        private DataGridView dataGridViewRentCar;

        public formEditRentCar(string idForUpdateRentCar, int rowIndexRentCar, DataGridView dataGridViewRentCar)
        {
            InitializeComponent();
            this.idForUpdateRentCar = idForUpdateRentCar;
            this.rowIndexRentCar = rowIndexRentCar;
            this.dataGridViewRentCar = dataGridViewRentCar;
            dateTimePickerDateOfIssue.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePickerDateOfIssue.Format = DateTimePickerFormat.Custom;
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
        /// Загрузка данных
        /// </summary>
        private void LoadData(String strSQL, DataGridView dataGridView)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataGridViewAddCells(dataGridView, reader, new String[] { "idrentcar", "familyname", "name", "cost", "dateofissue", "countdaysrent" });
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
                    string idrentcar = idForUpdateRentCar;
                    npgSqlConnection.Open();
                    String strSQL = $"UPDATE rentcar SET cost='{textBoxCost.Text}', dateofissue='{dateTimePickerDateOfIssue.Text}', countdaysrent='{numericUpDownCountDaysRent.Text}' WHERE idrentcar='{idrentcar}'";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        String str = "SELECT * FROM rentcar";
                        DataGridView dataGrid = dataGridViewRentCar;
                        LoadData(str, dataGrid);
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

        private void formEditRentCar_Load(object sender, EventArgs e)
        {
            textBoxCost.Text = (string)dataGridViewRentCar.Rows[rowIndexRentCar].Cells[3].Value;
            dateTimePickerDateOfIssue.Text = (string)dataGridViewRentCar.Rows[rowIndexRentCar].Cells[4].Value;
            numericUpDownCountDaysRent.Text = (string)dataGridViewRentCar.Rows[rowIndexRentCar].Cells[5].Value;
        }
    }
}
