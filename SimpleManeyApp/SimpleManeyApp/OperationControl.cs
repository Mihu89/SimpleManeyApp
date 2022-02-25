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
    public partial class OperationControl : UserControl
    {
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string ColorForm { get; set; }
        public OperationControl()
        {
            InitializeComponent();
        }

        public OperationControl(string title, decimal cost, string color)
        {
            InitializeComponent();
            Title = title;
            Cost = cost;
            ColorForm = color;
        }

        private void OperationControl_Load(object sender, EventArgs e)
        {
            pbDelete.Visible = false;
            tbTitle.Text = Title;
            tbCost.Text = Cost.ToString();
            if (ColorForm == "red")
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Green;
            }
            

        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete record");
        }

        private void pbDelete_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Visible = true;
        }

        private void pbDelete_MouseLeave(object sender, EventArgs e)
        {
            pbDelete.Visible = false;
        }

        private void OperationControl_MouseHover(object sender, EventArgs e)
        {
            pbDelete.Visible = true;
        }
    }
}
