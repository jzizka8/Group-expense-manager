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
            this.LogedUserLbl = new System.Windows.Forms.Label();
            this.GroupSelectComb = new System.Windows.Forms.ComboBox();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.CreateGroupBtn = new System.Windows.Forms.Button();
            this.ExpensesLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogedUserLbl
            // 
            this.LogedUserLbl.AutoSize = true;
            this.LogedUserLbl.Location = new System.Drawing.Point(34, 26);
            this.LogedUserLbl.Name = "LogedUserLbl";
            this.LogedUserLbl.Size = new System.Drawing.Size(59, 25);
            this.LogedUserLbl.TabIndex = 0;
            this.LogedUserLbl.Text = "label1";
            // 
            // GroupSelectComb
            // 
            this.GroupSelectComb.FormattingEnabled = true;
            this.GroupSelectComb.Location = new System.Drawing.Point(270, 26);
            this.GroupSelectComb.Name = "GroupSelectComb";
            this.GroupSelectComb.Size = new System.Drawing.Size(182, 33);
            this.GroupSelectComb.TabIndex = 1;
            this.GroupSelectComb.SelectedIndexChanged += new System.EventHandler(this.GroupSelectComb_SelectedIndexChanged);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(1032, 58);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(59, 25);
            this.DebugLabel.TabIndex = 2;
            this.DebugLabel.Text = "label1";
            // 
            // CreateGroupBtn
            // 
            this.CreateGroupBtn.Location = new System.Drawing.Point(555, 24);
            this.CreateGroupBtn.Name = "CreateGroupBtn";
            this.CreateGroupBtn.Size = new System.Drawing.Size(188, 34);
            this.CreateGroupBtn.TabIndex = 3;
            this.CreateGroupBtn.Text = "Create new group";
            this.CreateGroupBtn.UseVisualStyleBackColor = true;
            this.CreateGroupBtn.Click += new System.EventHandler(this.CreateGroupBtn_Click);
            // 
            // ExpensesLbl
            // 
            this.ExpensesLbl.AutoSize = true;
            this.ExpensesLbl.Location = new System.Drawing.Point(38, 97);
            this.ExpensesLbl.Name = "ExpensesLbl";
            this.ExpensesLbl.Size = new System.Drawing.Size(139, 25);
            this.ExpensesLbl.TabIndex = 4;
            this.ExpensesLbl.Text = "Group Expenses";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(741, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 229);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 778);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ExpensesLbl);
            this.Controls.Add(this.CreateGroupBtn);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.GroupSelectComb);
            this.Controls.Add(this.LogedUserLbl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LogedUserLbl;
        private ComboBox GroupSelectComb;
        private Label DebugLabel;
        private Button CreateGroupBtn;
        private Label ExpensesLbl;
        private ListBox listBox1;
        private Label label1;
    }
}