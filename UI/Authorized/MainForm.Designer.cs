namespace Project.UI.Authorized
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ContextMenuStrip DebtListBoxContextMS;
            this.toolStripMenuItemSettle = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpensesLbl = new System.Windows.Forms.Label();
            this.MembersLbl = new System.Windows.Forms.Label();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.DebtsListBox = new System.Windows.Forms.ListBox();
            this.DebtsLbl = new System.Windows.Forms.Label();
            this.ExportDebtsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExpensesBtnsTLP = new System.Windows.Forms.TableLayoutPanel();
            this.AddExpenseBtn = new System.Windows.Forms.Button();
            this.ImportExpensesBtn = new System.Windows.Forms.Button();
            this.ExportExpensesBtn = new System.Windows.Forms.Button();
            this.MembersListBox = new System.Windows.Forms.ListBox();
            this.MembersListBoxContextMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpensesListBox = new System.Windows.Forms.ListBox();
            this.LogedUserLbl = new System.Windows.Forms.Label();
            this.GroupSelectComb = new System.Windows.Forms.ComboBox();
            this.CreateGroupBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.importExpensesOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportExpensesSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportDebtsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            DebtListBoxContextMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            DebtListBoxContextMS.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ExpensesBtnsTLP.SuspendLayout();
            this.MembersListBoxContextMS.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebtListBoxContextMS
            // 
            DebtListBoxContextMS.ImageScalingSize = new System.Drawing.Size(24, 24);
            DebtListBoxContextMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettle});
            DebtListBoxContextMS.Name = "DebtContextMenuStrip";
            DebtListBoxContextMS.Size = new System.Drawing.Size(171, 36);
            // 
            // toolStripMenuItemSettle
            // 
            this.toolStripMenuItemSettle.Name = "toolStripMenuItemSettle";
            this.toolStripMenuItemSettle.Size = new System.Drawing.Size(170, 32);
            this.toolStripMenuItemSettle.Text = "Settle debt";
            this.toolStripMenuItemSettle.Click += new System.EventHandler(this.DebtStripMenuItemSettle_Click);
            // 
            // ExpensesLbl
            // 
            this.ExpensesLbl.AutoSize = true;
            this.ExpensesLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExpensesLbl.Location = new System.Drawing.Point(5, 0);
            this.ExpensesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.ExpensesLbl.Name = "ExpensesLbl";
            this.ExpensesLbl.Size = new System.Drawing.Size(139, 32);
            this.ExpensesLbl.TabIndex = 4;
            this.ExpensesLbl.Text = "Group Expenses";
            // 
            // MembersLbl
            // 
            this.MembersLbl.AutoSize = true;
            this.MembersLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MembersLbl.Location = new System.Drawing.Point(683, 0);
            this.MembersLbl.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.MembersLbl.Name = "MembersLbl";
            this.MembersLbl.Size = new System.Drawing.Size(87, 32);
            this.MembersLbl.TabIndex = 7;
            this.MembersLbl.Text = "Members";
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMemberBtn.Enabled = false;
            this.AddMemberBtn.Location = new System.Drawing.Point(688, 552);
            this.AddMemberBtn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(204, 56);
            this.AddMemberBtn.TabIndex = 9;
            this.AddMemberBtn.Text = "Add member";
            this.AddMemberBtn.UseVisualStyleBackColor = true;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // DebtsListBox
            // 
            this.DebtsListBox.ContextMenuStrip = DebtListBoxContextMS;
            this.DebtsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebtsListBox.FormattingEnabled = true;
            this.DebtsListBox.ItemHeight = 25;
            this.DebtsListBox.Location = new System.Drawing.Point(912, 42);
            this.DebtsListBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.DebtsListBox.Name = "DebtsListBox";
            this.DebtsListBox.Size = new System.Drawing.Size(316, 510);
            this.DebtsListBox.TabIndex = 10;
            this.DebtsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectListBoxItemOnRightClick);
            this.DebtsListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowContextMSOnSelectedIndex);
            // 
            // DebtsLbl
            // 
            this.DebtsLbl.AutoSize = true;
            this.DebtsLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.DebtsLbl.Location = new System.Drawing.Point(907, 0);
            this.DebtsLbl.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.DebtsLbl.Name = "DebtsLbl";
            this.DebtsLbl.Size = new System.Drawing.Size(59, 32);
            this.DebtsLbl.TabIndex = 11;
            this.DebtsLbl.Text = "Debts";
            // 
            // ExportDebtsBtn
            // 
            this.ExportDebtsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportDebtsBtn.Enabled = false;
            this.ExportDebtsBtn.Location = new System.Drawing.Point(912, 552);
            this.ExportDebtsBtn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ExportDebtsBtn.Name = "ExportDebtsBtn";
            this.ExportDebtsBtn.Size = new System.Drawing.Size(316, 56);
            this.ExportDebtsBtn.TabIndex = 12;
            this.ExportDebtsBtn.Text = "Export Debts";
            this.ExportDebtsBtn.UseVisualStyleBackColor = true;
            this.ExportDebtsBtn.Click += new System.EventHandler(this.ExportDebtsBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.83604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.12267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0413F));
            this.tableLayoutPanel1.Controls.Add(this.ExpensesBtnsTLP, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MembersListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MembersLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DebtsLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExpensesLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DebtsListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddMemberBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ExportDebtsBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ExpensesListBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1238, 618);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // ExpensesBtnsTLP
            // 
            this.ExpensesBtnsTLP.ColumnCount = 3;
            this.ExpensesBtnsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ExpensesBtnsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ExpensesBtnsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ExpensesBtnsTLP.Controls.Add(this.AddExpenseBtn, 0, 0);
            this.ExpensesBtnsTLP.Controls.Add(this.ImportExpensesBtn, 1, 0);
            this.ExpensesBtnsTLP.Controls.Add(this.ExportExpensesBtn, 2, 0);
            this.ExpensesBtnsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensesBtnsTLP.Location = new System.Drawing.Point(0, 552);
            this.ExpensesBtnsTLP.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ExpensesBtnsTLP.Name = "ExpensesBtnsTLP";
            this.ExpensesBtnsTLP.RowCount = 1;
            this.ExpensesBtnsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ExpensesBtnsTLP.Size = new System.Drawing.Size(678, 56);
            this.ExpensesBtnsTLP.TabIndex = 15;
            // 
            // AddExpenseBtn
            // 
            this.AddExpenseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddExpenseBtn.Enabled = false;
            this.AddExpenseBtn.Location = new System.Drawing.Point(10, 0);
            this.AddExpenseBtn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AddExpenseBtn.Name = "AddExpenseBtn";
            this.AddExpenseBtn.Size = new System.Drawing.Size(206, 56);
            this.AddExpenseBtn.TabIndex = 14;
            this.AddExpenseBtn.Text = "Add new expense";
            this.AddExpenseBtn.UseVisualStyleBackColor = true;
            this.AddExpenseBtn.Click += new System.EventHandler(this.AddExpenseBtn_Click);
            // 
            // ImportExpensesBtn
            // 
            this.ImportExpensesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportExpensesBtn.Enabled = false;
            this.ImportExpensesBtn.Location = new System.Drawing.Point(236, 0);
            this.ImportExpensesBtn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ImportExpensesBtn.Name = "ImportExpensesBtn";
            this.ImportExpensesBtn.Size = new System.Drawing.Size(206, 56);
            this.ImportExpensesBtn.TabIndex = 15;
            this.ImportExpensesBtn.Text = "Import Expenses";
            this.ImportExpensesBtn.UseVisualStyleBackColor = true;
            this.ImportExpensesBtn.Click += new System.EventHandler(this.ImportExpensesBtn_Click);
            // 
            // ExportExpensesBtn
            // 
            this.ExportExpensesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportExpensesBtn.Enabled = false;
            this.ExportExpensesBtn.Location = new System.Drawing.Point(462, 0);
            this.ExportExpensesBtn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ExportExpensesBtn.Name = "ExportExpensesBtn";
            this.ExportExpensesBtn.Size = new System.Drawing.Size(206, 56);
            this.ExportExpensesBtn.TabIndex = 16;
            this.ExportExpensesBtn.Text = "Export Expenses";
            this.ExportExpensesBtn.UseVisualStyleBackColor = true;
            this.ExportExpensesBtn.Click += new System.EventHandler(this.ExportExpensesBtn_Click);
            // 
            // MembersListBox
            // 
            this.MembersListBox.ContextMenuStrip = this.MembersListBoxContextMS;
            this.MembersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembersListBox.FormattingEnabled = true;
            this.MembersListBox.HorizontalScrollbar = true;
            this.MembersListBox.ItemHeight = 25;
            this.MembersListBox.Location = new System.Drawing.Point(688, 42);
            this.MembersListBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.MembersListBox.Name = "MembersListBox";
            this.MembersListBox.Size = new System.Drawing.Size(204, 510);
            this.MembersListBox.TabIndex = 14;
            this.MembersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectListBoxItemOnRightClick);
            this.MembersListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MembersListBox_MouseUp);
            // 
            // MembersListBoxContextMS
            // 
            this.MembersListBoxContextMS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MembersListBoxContextMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRemove});
            this.MembersListBoxContextMS.Name = "MembersListBoxContextMS";
            this.MembersListBoxContextMS.Size = new System.Drawing.Size(221, 36);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(220, 32);
            this.toolStripMenuItemRemove.Text = "Remove member";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.MembersStripMenuItemRemove_Click);
            // 
            // ExpensesListBox
            // 
            this.ExpensesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensesListBox.FormattingEnabled = true;
            this.ExpensesListBox.ItemHeight = 25;
            this.ExpensesListBox.Location = new System.Drawing.Point(10, 42);
            this.ExpensesListBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ExpensesListBox.Name = "ExpensesListBox";
            this.ExpensesListBox.Size = new System.Drawing.Size(658, 510);
            this.ExpensesListBox.TabIndex = 15;
            // 
            // LogedUserLbl
            // 
            this.LogedUserLbl.AutoSize = true;
            this.LogedUserLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogedUserLbl.Location = new System.Drawing.Point(3, 0);
            this.LogedUserLbl.Name = "LogedUserLbl";
            this.LogedUserLbl.Size = new System.Drawing.Size(220, 25);
            this.LogedUserLbl.TabIndex = 0;
            this.LogedUserLbl.Text = "label1";
            // 
            // GroupSelectComb
            // 
            this.GroupSelectComb.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupSelectComb.FormattingEnabled = true;
            this.GroupSelectComb.Location = new System.Drawing.Point(229, 3);
            this.GroupSelectComb.Name = "GroupSelectComb";
            this.GroupSelectComb.Size = new System.Drawing.Size(220, 33);
            this.GroupSelectComb.TabIndex = 1;
            this.GroupSelectComb.SelectedIndexChanged += new System.EventHandler(this.GroupSelectComb_SelectedIndexChanged);
            // 
            // CreateGroupBtn
            // 
            this.CreateGroupBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateGroupBtn.Location = new System.Drawing.Point(455, 3);
            this.CreateGroupBtn.Name = "CreateGroupBtn";
            this.CreateGroupBtn.Size = new System.Drawing.Size(220, 33);
            this.CreateGroupBtn.TabIndex = 3;
            this.CreateGroupBtn.Text = "Create new group";
            this.CreateGroupBtn.UseVisualStyleBackColor = true;
            this.CreateGroupBtn.Click += new System.EventHandler(this.CreateGroupBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.CreateGroupBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.GroupSelectComb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LogedUserLbl, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 48);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 714);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1333, 770);
            this.Name = "MainForm";
            this.Text = "GEM - Group Expense Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            DebtListBoxContextMS.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ExpensesBtnsTLP.ResumeLayout(false);
            this.MembersListBoxContextMS.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label ExpensesLbl;
        private Label MembersLbl;
        private Button AddMemberBtn;
        private ListBox DebtsListBox;
        private Label DebtsLbl;
        private Button ExportDebtsBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox MembersListBox;
        private ListBox ExpensesListBox;
        private TableLayoutPanel ExpensesBtnsTLP;
        private Button AddExpenseBtn;
        private Button ImportExpensesBtn;
        private Label LogedUserLbl;
        private ComboBox GroupSelectComb;
        private Button CreateGroupBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStripMenuItem toolStripMenuItemSettle;
        private OpenFileDialog importExpensesOpenFileDialog;
        private Button ExportExpensesBtn;
        private SaveFileDialog exportExpensesSaveFileDialog;
        private SaveFileDialog exportDebtsSaveFileDialog;
        private ContextMenuStrip MembersListBoxContextMS;
        private ToolStripMenuItem toolStripMenuItemRemove;
    }
}