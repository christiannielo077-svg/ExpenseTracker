namespace ExpenseTracker
{
    public partial class frmExpense : Form
    {
        private readonly Expense expense;

        // existing == null  -> Add mode
        // existing != null  -> Edit mode
        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();

            // Starting values for the controls
            cboCategory.Items.AddRange(new string[]
            {
                "Food", "Transportation", "Bills", "School", "Entertainment", "Others"
            });

            dtpDate.MaxDate = DateTime.Today;        // no future dates
            txtDescription.MaxLength = 50;           // max 50 characters
            nudAmount.DecimalPlaces = 2;
            nudAmount.Minimum = 0;
            nudAmount.Maximum = 1000000;

            if (existing == null)
            {
                expense = new Expense();
                this.Text = "Add Expense";
                dtpDate.Value = DateTime.Today;
                cboCategory.SelectedIndex = 0;
                rdoCash.Checked = true;              // Cash by default
            }
            else
            {
                expense = existing;
                this.Text = "Edit Expense";

                dtpDate.Value = existing.Date > DateTime.Today ? DateTime.Today : existing.Date;
                txtDescription.Text = existing.Description;
                cboCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;

                if (existing.PaymentMethod == "GCash") rdoGCash.Checked = true;
                else if (existing.PaymentMethod == "Card") rdoCard.Checked = true;
                else rdoCash.Checked = true;

                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;
            }
        }

        // The main form calls this after ShowDialog() returns OK
        public Expense GetExpense() => expense;

        private bool ValidateInputs()
        {
            bool isValid = true;
            errProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errProvider.SetError(txtDescription, "Description is required.");
                isValid = false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                errProvider.SetError(cboCategory, "Please choose a category.");
                isValid = false;
            }

            if (nudAmount.Value <= 0)
            {
                errProvider.SetError(nudAmount, "Amount must be greater than 0.");
                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;

            if (rdoGCash.Checked) expense.PaymentMethod = "GCash";
            else if (rdoCard.Checked) expense.PaymentMethod = "Card";
            else expense.PaymentMethod = "Cash";

            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            this.DialogResult = DialogResult.OK;     // closes the form and returns OK
        }
    }
}
