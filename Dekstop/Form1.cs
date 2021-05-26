using Npgsql;
using System;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //formLogin formLogin = new formLogin();
            //formLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "eXtensible Markup Language file |*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(dialog.FileName);
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/configuration/connectionStrings/add");
                    string connectionString = node.Attributes["connectionString"].InnerText;
                    using (NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString))
                    {
                        npgSqlConnection.Open();                        
                        label1.Text = "Выполнено подключение к базе данных!\nНазвание: " + npgSqlConnection.Database;
                        npgSqlConnection.Close();
                                              
                    }
                }
                else
                {
                    label1.Text = "Выберите конфигурационный файл базы данных:";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formManager formManager = new formManager();
            formManager.Show();
        }
    }
}
