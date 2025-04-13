using System;
using System.Windows.Forms;

namespace ATM_Simulation
{
    public partial class MainMenuForm : Form
    {
        private int customerId;

        public MainMenuForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm(customerId);
            balanceForm.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(customerId);
            withdrawForm.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(customerId);
            transferForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
