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
        private void LoadDataCombo(String strSQL)
        {
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        ComboBoxAddItems(comboBoxCars, "name", reader);
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
            this.Close();
        }

        private void comboBoxRates_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRates_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void formAddOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManager form = (formManager)Application.OpenForms[0];
            form.Show();
        }

        private void formAddOrder_Load(object sender, EventArgs e)
        {
            LoadDataCombo("select name from car WHERE rented = false AND deleted = false");
            comboBoxCars.SelectedItem = nameForOrder;
        }

        private void comboBoxCars_Click(object sender, EventArgs e)
        {

        }
    }
}
