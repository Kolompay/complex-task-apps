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
    public partial class formAddCar : Form
    {
        public formAddCar()
        {
            InitializeComponent();
            comboBoxYears.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formAddCars_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 21; i--)
                comboBoxYears.Items.Add(i);
            comboBoxYears.SelectedItem = comboBoxYears.Items[0];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=pass;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    //String strSQL = $"INSERT INTO car(vinnumber, brand, classcar, name, transmission, color, yearofmanufacture, idlocationcar) VALUES ({textBox1.Text}, {textBox2.Text}, {textBox3.Text}, {textBox4.Text}, {textBox5.Text}, {textBox6.Text}, {comboBoxYears.SelectedItem}, 1)";
                    String strSQL = "INSERT INTO car(vinnumber, brand, classcar, name, transmission, color, yearofmanufacture, idlocationcar) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + comboBoxYears.SelectedItem + "', 1)";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно добавлена!");                    
                    npgSqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
