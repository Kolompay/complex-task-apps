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
    public partial class formAddOrder : Form
    {
        private string nameForOrder;
        private int rowIndex;
        private DataGridView dataGridViewListCarsNotInRent;
        private ComboBox comboBoxAvailableCarsFirst;

        public formAddOrder(string nameForOrder, int rowIndex, DataGridView dataGridViewListCarsNotInRent, ComboBox comboBoxAvailableCarsFirst)
        {
            InitializeComponent();
            this.nameForOrder = nameForOrder;
            this.rowIndex = rowIndex;
            this.dataGridViewListCarsNotInRent = dataGridViewListCarsNotInRent;
            this.comboBoxAvailableCarsFirst = comboBoxAvailableCarsFirst;
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

        private void buttonAddOrder_Click(object sender, EventArgs e)
        { }

        private void formAddOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManager form = (formManager)Application.OpenForms[0];
            form.Show();
        }
    }
}
