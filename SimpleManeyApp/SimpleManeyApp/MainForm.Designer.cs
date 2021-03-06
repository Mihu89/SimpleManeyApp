
namespace SimpleManeyApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBalance = new System.Windows.Forms.Label();
            this.lExpenses = new System.Windows.Forms.Label();
            this.panelExpenses = new System.Windows.Forms.Panel();
            this.panelIncomes = new System.Windows.Forms.Panel();
            this.lIncome = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBalance
            // 
            this.lBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBalance.AutoSize = true;
            this.lBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBalance.Location = new System.Drawing.Point(364, 26);
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(0, 37);
            this.lBalance.TabIndex = 0;
            // 
            // lExpenses
            // 
            this.lExpenses.AutoSize = true;
            this.lExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExpenses.Location = new System.Drawing.Point(75, 93);
            this.lExpenses.Name = "lExpenses";
            this.lExpenses.Size = new System.Drawing.Size(108, 26);
            this.lExpenses.TabIndex = 1;
            this.lExpenses.Text = "Expenses";
            // 
            // panelExpenses
            // 
            this.panelExpenses.Location = new System.Drawing.Point(12, 122);
            this.panelExpenses.Name = "panelExpenses";
            this.panelExpenses.Size = new System.Drawing.Size(331, 318);
            this.panelExpenses.TabIndex = 2;
            // 
            // panelIncomes
            // 
            this.panelIncomes.Location = new System.Drawing.Point(457, 122);
            this.panelIncomes.Name = "panelIncomes";
            this.panelIncomes.Size = new System.Drawing.Size(331, 318);
            this.panelIncomes.TabIndex = 3;
            // 
            // lIncome
            // 
            this.lIncome.AutoSize = true;
            this.lIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncome.Location = new System.Drawing.Point(507, 93);
            this.lIncome.Name = "lIncome";
            this.lIncome.Size = new System.Drawing.Size(95, 26);
            this.lIncome.TabIndex = 4;
            this.lIncome.Text = "Incomes";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(687, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 72);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lIncome);
            this.Controls.Add(this.panelIncomes);
            this.Controls.Add(this.panelExpenses);
            this.Controls.Add(this.lExpenses);
            this.Controls.Add(this.lBalance);
            this.Name = "MainForm";
            this.Text = "Simple Maney App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBalance;
        private System.Windows.Forms.Label lExpenses;
        private System.Windows.Forms.Panel panelExpenses;
        private System.Windows.Forms.Panel panelIncomes;
        private System.Windows.Forms.Label lIncome;
        private System.Windows.Forms.Button btnAdd;
    }
}

