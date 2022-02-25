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
            
            // load incomes and expenses from db or api
            Expenses.Add(new Operation(1, "Buy T-shirt", 50));
            Incomes.Add(new Operation(1, "Install Windows 10", 200));
            foreach (var expense in Expenses)
            {
                panelExpenses.Controls.Add(new OperationControl(expense.Title, expense.Cost, "red"));
            }

            foreach (var income in Incomes)
            {
                panelIncomes.Controls.Add(new OperationControl(income.Title, income.Cost, "green"));
            }

            // Calculate current balance
            var balance = Incomes.Sum(x => x.Cost) - Expenses.Sum(x => x.Cost);
            lBalance.Text = balance.ToString();
            if (balance> -0.01m)
            {
                lBalance.BackColor = Color.Green;
            }
            else
            {
                lBalance.BackColor = Color.Red;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var popupForm = new PopupForm();
            popupForm.ShowDialog();
        }
    }
}
