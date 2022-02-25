using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleManeyApp
{
    public partial class PopupForm : Form
    {
        private string _title;
        private decimal _cost;

        public PopupForm()
        {
            InitializeComponent();
        }

        public PopupForm(string title, decimal cost)
        {
            InitializeComponent();
            try
            {
                _title = title;
                _cost = cost;
                tbTitle.Text = _title;
                tbCost.Text = _cost.ToString();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost = 0;
            if (string.IsNullOrEmpty(tbCost.Text))
            {
                MessageBox.Show("Fill cost");
                tbCost.Focus();
            }
            else
            {
                bool isNumber = decimal.TryParse(tbCost.Text, out cost);
                if (!isNumber)
                {
                    MessageBox.Show("Write a valid number");
                }
            }
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                MessageBox.Show("Fill title");
                tbTitle.Focus();
            }
            else
            {
                var operation = new Operation(1, tbTitle.Text, cost);
                MessageBox.Show(operation.Title + " " + operation.Cost);
            }
        }
    }
}
