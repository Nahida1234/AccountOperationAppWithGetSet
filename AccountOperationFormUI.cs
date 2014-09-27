using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationFormUI : Form

    {
        Account anAccount=new Account();
        public AccountOperationFormUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.accountNumber = accountNumberTextBox.Text;
            anAccount.customerName = customerNameTextBox.Text;

            MessageBox.Show(@"Account Create successfully");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount.accountNumber != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Deposit(amount);
                MessageBox.Show(@"Amount Deposited Successfully");
            }
            else
            {
                MessageBox.Show(@"Please Insert Account Number and Customer Name");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)

        {
            if (anAccount.accountNumber != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Withdraw(amount);
                MessageBox.Show(@"Amount Withdrawl Successfully");
            }
            else
            {
                MessageBox.Show(@"Please Insert Account Number and Customer Name");
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.customerName+ "Your Balance is :" + anAccount.balance);
        }


    }
}
