namespace Project.UI.Authorized.ExpenseManaging
{
    partial class AddExpenseForm
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
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.ConsumersChListBox = new System.Windows.Forms.CheckedListBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.PayerLbl = new System.Windows.Forms.Label();
            this.PayerComb = new System.Windows.Forms.ComboBox();
            this.ConsumerLabel = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.AmountNum = new System.Windows.Forms.NumericUpDown();
            this.Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Layout.Controls.Add(this.AmountLbl, 0, 2);
            this.Layout.Controls.Add(this.ConsumersChListBox, 1, 3);
            this.Layout.Controls.Add(this.DescriptionLbl, 0, 1);
            this.Layout.Controls.Add(this.DescriptionTxt, 1, 1);
            this.Layout.Controls.Add(this.PayerLbl, 0, 0);
            this.Layout.Controls.Add(this.PayerComb, 1, 0);
            this.Layout.Controls.Add(this.ConsumerLabel, 0, 3);
            this.Layout.Controls.Add(this.SubmitBtn, 1, 4);
            this.Layout.Controls.Add(this.AmountNum, 1, 2);
            this.Layout.Location = new System.Drawing.Point(40, 37);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 5;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Layout.Size = new System.Drawing.Size(584, 512);
            this.Layout.TabIndex = 0;
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(3, 100);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(106, 25);
            this.AmountLbl.TabIndex = 1;
            this.AmountLbl.Text = "How much?";
            // 
            // ConsumersChListBox
            // 
            this.ConsumersChListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsumersChListBox.FormattingEnabled = true;
            this.ConsumersChListBox.Location = new System.Drawing.Point(236, 153);
            this.ConsumersChListBox.Name = "ConsumersChListBox";
            this.ConsumersChListBox.Size = new System.Drawing.Size(345, 306);
            this.ConsumersChListBox.TabIndex = 7;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(3, 50);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(89, 25);
            this.DescriptionLbl.TabIndex = 0;
            this.DescriptionLbl.Text = "For what?";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTxt.Location = new System.Drawing.Point(236, 53);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(345, 31);
            this.DescriptionTxt.TabIndex = 2;
            // 
            // PayerLbl
            // 
            this.PayerLbl.AutoSize = true;
            this.PayerLbl.Location = new System.Drawing.Point(3, 0);
            this.PayerLbl.Name = "PayerLbl";
            this.PayerLbl.Size = new System.Drawing.Size(98, 25);
            this.PayerLbl.TabIndex = 4;
            this.PayerLbl.Text = "Who paid?";
            // 
            // PayerComb
            // 
            this.PayerComb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayerComb.FormattingEnabled = true;
            this.PayerComb.Location = new System.Drawing.Point(236, 3);
            this.PayerComb.Name = "PayerComb";
            this.PayerComb.Size = new System.Drawing.Size(345, 33);
            this.PayerComb.TabIndex = 5;
            // 
            // ConsumerLabel
            // 
            this.ConsumerLabel.AutoSize = true;
            this.ConsumerLabel.Location = new System.Drawing.Point(3, 150);
            this.ConsumerLabel.Name = "ConsumerLabel";
            this.ConsumerLabel.Size = new System.Drawing.Size(101, 25);
            this.ConsumerLabel.TabIndex = 8;
            this.ConsumerLabel.Text = "For whom?";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitBtn.Location = new System.Drawing.Point(236, 465);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(345, 44);
            this.SubmitBtn.TabIndex = 9;
            this.SubmitBtn.Text = "Add expense";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // AmountNum
            // 
            this.AmountNum.DecimalPlaces = 2;
            this.AmountNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AmountNum.Location = new System.Drawing.Point(236, 103);
            this.AmountNum.Name = "AmountNum";
            this.AmountNum.Size = new System.Drawing.Size(345, 31);
            this.AmountNum.TabIndex = 10;
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 582);
            this.Controls.Add(this.Layout);
            this.Name = "AddExpenseForm";
            this.Text = "AddExpenseForm";
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel Layout;
        private Label DescriptionLbl;
        private Label AmountLbl;
        private TextBox DescriptionTxt;
        private Label PayerLbl;
        private ComboBox PayerComb;
        private CheckedListBox ConsumersChListBox;
        private Label ConsumerLabel;
        private Button SubmitBtn;
        private NumericUpDown AmountNum;
    }
}