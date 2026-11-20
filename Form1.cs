using System.Text.Json;

namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        private readonly List<Expense> expenses = new List<Expense>();
        private string? currentFile = null;   // path of the file we are working on
        private bool isDirty = false;         // true when there are unsaved changes

        public frmMain()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------------
        // Form events
        // ---------------------------------------------------------------
        private void frmMain_Load(object sender, EventArgs e)
        {
            cboFilterCategory.Items.AddRange(new string[]
            {
                "All", "Food", "Transportation", "Bills", "School", "Entertainment", "Others"
            });
            cboFilterCategory.SelectedIndex = 0;

            DateTime today = DateTime.Today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = today;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;

            ShowClock();
            tmrClock.Start();

            ApplyFilter();
            UpdateTitle();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanProceed())
            {
                e.Cancel = true;   // user chose Cancel: stay open
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            ShowClock();
        }

        private void ShowClock()
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // ---------------------------------------------------------------
        // Filters (every filter control calls the same method)
        // ---------------------------------------------------------------
        private void Filter_Changed(object? sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = chkDateRange.Checked;
            dtpTo.Enabled = chkDateRange.Checked;
            ApplyFilter();
        }

        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemaining();
        }

        private void ApplyFilter()
        {
            IEnumerable<Expense> query = expenses;

            // Category
            if (cboFilterCategory.SelectedIndex > 0)
            {
                string category = cboFilterCategory.Text;
                query = query.Where(x => x.Category == category);
            }

            // Search in Description
            string keyword = txtSearch.Text.Trim().ToLower();
            if (keyword != "")
            {
                query = query.Where(x => x.Description.ToLower().Contains(keyword));
            }

            // Date range
            if (chkDateRange.Checked)
            {
                DateTime from = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;
                query = query.Where(x => x.Date.Date >= from && x.Date.Date <= to);
            }

            // Newest dates on top
            List<Expense> shown = query
                .OrderByDescending(x => x.Date)
                .ThenByDescending(x => x.Id)
                .ToList();

            dgvExpenses.DataSource = shown;
            FormatGrid();
            UpdateSummary(shown);
        }

        private void FormatGrid()
        {
            if (dgvExpenses.Columns["Id"] != null) dgvExpenses.Columns["Id"]!.Visible = false;
            if (dgvExpenses.Columns["Notes"] != null) dgvExpenses.Columns["Notes"]!.Visible = false;

            if (dgvExpenses.Columns["Amount"] != null)
            {
                dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Format = "N2";
                dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvExpenses.Columns["Date"] != null)
            {
                dgvExpenses.Columns["Date"]!.DefaultCellStyle.Format = "MM/dd/yyyy";
            }
        }

        private void UpdateSummary(List<Expense> shown)
        {
            decimal shownTotal = shown.Sum(x => x.Amount);

            lblCount.Text = $"Records: {shown.Count}";
            lblTotal.Text = $"Total: PHP {shownTotal:N2}";
            lblRecordCount.Text = $"Records: {shown.Count}";

            UpdateRemaining();
        }

        // Remaining = budget - THIS MONTH's spending (all expenses, not just the filtered ones)
        private void UpdateRemaining()
        {
            DateTime today = DateTime.Today;
            decimal spent = expenses
                .Where(x => x.Date.Year == today.Year && x.Date.Month == today.Month)
                .Sum(x => x.Amount);

            decimal remaining = nudBudget.Value - spent;

            lblRemaining.Text = $"Remaining: PHP {remaining:N2}";
            lblRemaining.ForeColor = spent > nudBudget.Value ? Color.Red : SystemColors.ControlText;
        }

        // ---------------------------------------------------------------
        // Add / Edit / Delete (menu items AND toolbar buttons use these)
        // ---------------------------------------------------------------
        private void addToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Expense newExpense = form.GetExpense();
                    newExpense.Id = NextId();
                    expenses.Add(newExpense);

                    SetDirty(true);
                    ApplyFilter();
                    lblStatus.Text = "Expense added.";
                }
            }
        }

        private void editToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Expense? selected = GetSelectedExpense();
            if (selected == null)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }

            using (frmExpense form = new frmExpense(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    SetDirty(true);
                    ApplyFilter();
                    lblStatus.Text = "Expense updated.";
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Expense? selected = GetSelectedExpense();
            if (selected == null)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Description}\"?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                expenses.Remove(selected);
                SetDirty(true);
                ApplyFilter();
                lblStatus.Text = "Expense deleted.";
            }
        }

        private void dgvExpenses_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) editToolStripMenuItem_Click(sender, e);
        }

        private Expense? GetSelectedExpense()
        {
            return dgvExpenses.CurrentRow?.DataBoundItem as Expense;
        }

        // Highest existing ID + 1 (or 1 if the list is empty)
        private int NextId()
        {
            return expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;
        }

        // ---------------------------------------------------------------
        // File menu
        // ---------------------------------------------------------------
        private void newToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (!CanProceed()) return;

            expenses.Clear();
            currentFile = null;
            SetDirty(false);
            ApplyFilter();
            lblStatus.Text = "New file started.";
        }

        private void openToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (!CanProceed()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);

                expenses.Clear();
                if (loaded != null) expenses.AddRange(loaded);

                currentFile = dialog.FileName;
                SetDirty(false);
                ApplyFilter();
                lblStatus.Text = "File opened.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.Close();   // FormClosing asks about unsaved changes
        }

        private void aboutToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Personal Expense Tracker v1.0\nCreated by: Nielo, Christian A.",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Saves to the current file. If there is none yet, asks for a file name (Save As).
        // Returns true when the file was saved.
        private bool SaveFile()
        {
            string? path = currentFile;

            if (path == null)
            {
                using SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                dialog.FileName = "expenses.json";
                if (dialog.ShowDialog(this) != DialogResult.OK) return false;
                path = dialog.FileName;
            }

            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(expenses, options);
                File.WriteAllText(path, json);

                currentFile = path;
                SetDirty(false);
                lblStatus.Text = "File saved.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ---------------------------------------------------------------
        // Unsaved changes + title bar
        // ---------------------------------------------------------------
        // Returns true if it is OK to continue (close / new / open).
        private bool CanProceed()
        {
            if (!isDirty) return true;

            DialogResult answer = MessageBox.Show(
                "You have unsaved changes. Save first?",
                "Unsaved Changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel) return false;   // stay
            if (answer == DialogResult.Yes) return SaveFile(); // save, then continue if it worked
            return true;                                       // No: discard
        }

        private void SetDirty(bool value)
        {
            isDirty = value;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string name = currentFile == null ? "Untitled" : Path.GetFileName(currentFile);
            this.Text = "Expense Tracker - " + name + (isDirty ? "*" : "");
        }
    }
}
