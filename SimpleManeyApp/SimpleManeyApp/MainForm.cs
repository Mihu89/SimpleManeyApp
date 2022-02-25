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
    public partial class MainForm : Form
    {
        List<Operation> Expenses = new List<Operation>();
        List<Operation> Incomes = new List<Operation>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lBalance.Text = "0";
            lBalance.BackColor = Color.Green;
            panelExpenses.Controls.Add(new OperationControl("Buy T-shirt", 50, "red"));


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var popupForm = new PopupForm();
            popupForm.ShowDialog();
        }
    }
}
