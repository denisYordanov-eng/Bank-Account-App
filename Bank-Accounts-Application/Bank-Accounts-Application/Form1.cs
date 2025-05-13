namespace Bank_Accounts_Application
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {

                return;
            }
            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);

            BankAccounts.Add(bankAccount);

            RefreshGrid();
            OwnerTxt.Text = string.Empty;
        }
        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = BankAccounts;
        }

        private void BankAccountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountGrid.SelectedRows[0]
                    .DataBoundItem as BankAccount;

              string message = selectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if(BankAccountGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountGrid.SelectedRows[0]
                    .DataBoundItem as BankAccount;

              string message = selectedBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
