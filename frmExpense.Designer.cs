namespace ExpenseTracker
{
    partial class frmExpense
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
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAmount = new Label();
            nudAmount = new NumericUpDown();
            grpPayment = new GroupBox();
            rdoCash = new RadioButton();
            rdoGCash = new RadioButton();
            rdoCard = new RadioButton();
            chkRecurring = new CheckBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            //
            // lblDate
            //
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 24);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date:";
            //
            // dtpDate
            //
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(120, 20);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 23);
            dtpDate.TabIndex = 1;
            //
            // lblDescription
            //
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 64);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            //
            // txtDescription
            //
            txtDescription.Location = new Point(120, 60);
            txtDescription.MaxLength = 50;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 23);
            txtDescription.TabIndex = 3;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 104);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            //
            // cboCategory
            //
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(120, 100);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(250, 23);
            cboCategory.TabIndex = 5;
            //
            // lblAmount
            //
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 144);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "Amount:";
            //
            // nudAmount
            //
            nudAmount.DecimalPlaces = 2;
            nudAmount.Location = new Point(120, 140);
            nudAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(250, 23);
            nudAmount.TabIndex = 7;
            nudAmount.ThousandsSeparator = true;
            //
            // grpPayment
            //
            grpPayment.Controls.Add(rdoCash);
            grpPayment.Controls.Add(rdoGCash);
            grpPayment.Controls.Add(rdoCard);
            grpPayment.Location = new Point(20, 180);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(350, 60);
            grpPayment.TabIndex = 8;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment";
            //
            // rdoCash
            //
            rdoCash.AutoSize = true;
            rdoCash.Checked = true;
            rdoCash.Location = new Point(15, 25);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(51, 19);
            rdoCash.TabIndex = 0;
            rdoCash.TabStop = true;
            rdoCash.Text = "Cash";
            rdoCash.UseVisualStyleBackColor = true;
            //
            // rdoGCash
            //
            rdoGCash.AutoSize = true;
            rdoGCash.Location = new Point(120, 25);
            rdoGCash.Name = "rdoGCash";
            rdoGCash.Size = new Size(59, 19);
            rdoGCash.TabIndex = 1;
            rdoGCash.Text = "GCash";
            rdoGCash.UseVisualStyleBackColor = true;
            //
            // rdoCard
            //
            rdoCard.AutoSize = true;
            rdoCard.Location = new Point(225, 25);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(50, 19);
            rdoCard.TabIndex = 2;
            rdoCard.Text = "Card";
            rdoCard.UseVisualStyleBackColor = true;
            //
            // chkRecurring
            //
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(120, 255);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(77, 19);
            chkRecurring.TabIndex = 9;
            chkRecurring.Text = "Recurring";
            chkRecurring.UseVisualStyleBackColor = true;
            //
            // lblNotes
            //
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(20, 294);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(41, 15);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Notes:";
            //
            // txtNotes
            //
            txtNotes.Location = new Point(120, 290);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(250, 80);
            txtNotes.TabIndex = 11;
            //
            // btnSave
            //
            btnSave.Location = new Point(205, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(290, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            //
            // errProvider
            //
            errProvider.ContainerControl = this;
            //
            // frmExpense
            //
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(394, 441);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAmount);
            Controls.Add(nudAmount);
            Controls.Add(grpPayment);
            Controls.Add(chkRecurring);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExpense";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAmount;
        private NumericUpDown nudAmount;
        private GroupBox grpPayment;
        private RadioButton rdoCash;
        private RadioButton rdoGCash;
        private RadioButton rdoCard;
        private CheckBox chkRecurring;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errProvider;
    }
}
