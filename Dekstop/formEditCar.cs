﻿using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class formEditCar : Form
    {
        private int indexForUpdate;
        private DataGridView dataGridViewCarList;
        private ComboBox comboBoxSearchCar;
        private string nameForUpdate;
        private int rowIndex;

        public formEditCar(int indexForUpdate, DataGridView dataGridViewCarList, ComboBox comboBoxSearchCar, string nameForUpdate, int rowIndex)
        {
            InitializeComponent();
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.indexForUpdate = indexForUpdate;
            this.dataGridViewCarList = dataGridViewCarList;
            this.comboBoxSearchCar = comboBoxSearchCar;
            this.nameForUpdate = nameForUpdate;
            this.rowIndex = rowIndex;
        }
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
        private void LoadData(String strSQL, DataGridView dataGrid, ComboBox comboBox)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=password;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    npgSqlConnection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataGridViewAddCells(dataGrid, reader, new String[] { "idcar", "name", "brand", "classcar", "transmission", "color" });
                    }
                    if (comboBox.Items.Count == 0)
                    {
                        for (int i = 1; i < dataGrid.Columns.Count; i++)
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            String connectionString = "database=rentcarsdb;server=localhost;port=5432;uid=postgres;password=password;";
            using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string name = nameForUpdate;
                    npgSqlConnection.Open();
                    String strSQL = $"UPDATE car SET name='{textBox1.Text}', brand='{textBox2.Text}', classcar='{textBox3.Text}', transmission='{textBox4.Text}', color='{comboBoxColor.SelectedItem}' WHERE idcar={name}";
                    NpgsqlCommand cmd = new NpgsqlCommand(strSQL, npgSqlConnection);
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Данные успешно обнвлены!");
                    npgSqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            String str = "SELECT * FROM car ORDER BY idcar DESC";
            DataGridView dataGrid = dataGridViewCarList;
            ComboBox comboBox = comboBoxSearchCar;
            LoadData(str, dataGrid, comboBox);
            Close();
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


            textBox1.Text = (string)dataGridViewCarList.Rows[rowIndex].Cells[1].Value;
            textBox2.Text = (string)dataGridViewCarList.Rows[rowIndex].Cells[2].Value;
            textBox3.Text = (string)dataGridViewCarList.Rows[rowIndex].Cells[3].Value;
            textBox4.Text = (string)dataGridViewCarList.Rows[rowIndex].Cells[4].Value;
            comboBoxColor.SelectedItem = (string)dataGridViewCarList.Rows[rowIndex].Cells[5].Value;
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
    }
}
