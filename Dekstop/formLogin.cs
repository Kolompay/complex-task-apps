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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string cod = "admin";
            if (textBoxLogin.Text == cod && textBoxPassword.Text == cod)
            {
                formManager formManager = new formManager();
                formManager.Show();
            }
            else if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Одно или несколько полей не заполнены!");
            }
            else
            {
                MessageBox.Show("Данные введены неверно, повторите попытку!");
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxPassword.Checked ? '\0' : '*';
        }
    }
}
