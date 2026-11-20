namespace ExpenseTracker
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            pnlFilter = new Panel();
            lblFilterCategory = new Label();
            cboFilterCategory = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkDateRange = new CheckBox();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            dgvExpenses = new DataGridView();
            pnlSummary = new Panel();
            lblCount = new Label();
            lblTotal = new Label();
            lblBudget = new Label();
            nudBudget = new NumericUpDown();
            lblRemaining = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblRecordCount = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            tmrClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 0;
            //
            // fileToolStripMenuItem
            //
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Text = "&File";
            //
            // newToolStripMenuItem
            //
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            //
            // openToolStripMenuItem
            //
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            //
            // saveToolStripMenuItem
            //
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            //
            // toolStripSeparator1
            //
            toolStripSeparator1.Name = "toolStripSeparator1";
            //
            // exitToolStripMenuItem
            //
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            //
            // expenseToolStripMenuItem
            //
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Text = "&Expense";
            //
            // addToolStripMenuItem
            //
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            //
            // editToolStripMenuItem
            //
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            //
            // deleteToolStripMenuItem
            //
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            //
            // helpToolStripMenuItem
            //
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Text = "&Help";
            //
            // aboutToolStripMenuItem
            //
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            //
            // toolStrip1  (buttons share the SAME handlers as the menu items)
            //
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 25);
            toolStrip1.TabIndex = 1;
            //
            // tsbAdd
            //
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Text = "Add";
            tsbAdd.Click += addToolStripMenuItem_Click;
            //
            // tsbEdit
            //
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Text = "Edit";
            tsbEdit.Click += editToolStripMenuItem_Click;
            //
            // tsbDelete
            //
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Text = "Delete";
            tsbDelete.Click += deleteToolStripMenuItem_Click;
            //
            // pnlFilter
            //
            pnlFilter.Controls.Add(lblFilterCategory);
            pnlFilter.Controls.Add(cboFilterCategory);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(chkDateRange);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 49);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(900, 45);
            pnlFilter.TabIndex = 2;
            //
            // lblFilterCategory
            //
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(10, 14);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Text = "Category:";
            //
            // cboFilterCategory
            //
            cboFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCategory.FormattingEnabled = true;
            cboFilterCategory.Location = new Point(75, 10);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(130, 23);
            cboFilterCategory.TabIndex = 0;
            cboFilterCategory.SelectedIndexChanged += Filter_Changed;
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(220, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Search:";
            //
            // txtSearch
            //
            txtSearch.Location = new Point(275, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Description";
            txtSearch.Size = new Size(160, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += Filter_Changed;
            //
            // chkDateRange
            //
            chkDateRange.AutoSize = true;
            chkDateRange.Location = new Point(455, 12);
            chkDateRange.Name = "chkDateRange";
            chkDateRange.Text = "Date range";
            chkDateRange.UseVisualStyleBackColor = true;
            chkDateRange.TabIndex = 2;
            chkDateRange.CheckedChanged += chkDateRange_CheckedChanged;
            //
            // dtpFrom
            //
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(550, 10);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(100, 23);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += Filter_Changed;
            //
            // lblTo
            //
            lblTo.AutoSize = true;
            lblTo.Location = new Point(658, 14);
            lblTo.Name = "lblTo";
            lblTo.Text = "to";
            //
            // dtpTo
            //
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(680, 10);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(100, 23);
            dtpTo.TabIndex = 4;
            dtpTo.ValueChanged += Filter_Changed;
            //
            // dgvExpenses
            //
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 94);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(900, 340);
            dgvExpenses.TabIndex = 3;
            dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
            //
            // pnlSummary
            //
            pnlSummary.Controls.Add(lblCount);
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(lblBudget);
            pnlSummary.Controls.Add(nudBudget);
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 434);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(900, 45);
            pnlSummary.TabIndex = 4;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.Location = new Point(10, 15);
            lblCount.Name = "lblCount";
            lblCount.Text = "Records: 0";
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(130, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total: PHP 0.00";
            //
            // lblBudget
            //
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(320, 15);
            lblBudget.Name = "lblBudget";
            lblBudget.Text = "Monthly budget (PHP):";
            //
            // nudBudget
            //
            nudBudget.DecimalPlaces = 2;
            nudBudget.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudBudget.Location = new Point(460, 11);
            nudBudget.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(110, 23);
            nudBudget.TabIndex = 0;
            nudBudget.ThousandsSeparator = true;
            nudBudget.ValueChanged += nudBudget_ValueChanged;
            //
            // lblRemaining
            //
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRemaining.Location = new Point(590, 15);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Text = "Remaining: PHP 0.00";
            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblRecordCount, lblClock });
            statusStrip1.Location = new Point(0, 479);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 22);
            statusStrip1.TabIndex = 5;
            //
            // lblStatus
            //
            lblStatus.Name = "lblStatus";
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblRecordCount
            //
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Text = "Records: 0";
            //
            // lblClock
            //
            lblClock.Name = "lblClock";
            lblClock.Text = "00:00:00 AM";
            //
            // tmrClock
            //
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            //
            // frmMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 501);
            Controls.Add(dgvExpenses);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(820, 480);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private Panel pnlFilter;
        private Label lblFilterCategory;
        private ComboBox cboFilterCategory;
        private Label lblSearch;
        private TextBox txtSearch;
        private CheckBox chkDateRange;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private DataGridView dgvExpenses;
        private Panel pnlSummary;
        private Label lblCount;
        private Label lblTotal;
        private Label lblBudget;
        private NumericUpDown nudBudget;
        private Label lblRemaining;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblRecordCount;
        private ToolStripStatusLabel lblClock;
        private System.Windows.Forms.Timer tmrClock;
    }
}
