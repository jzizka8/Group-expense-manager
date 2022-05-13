namespace Project.UI.Authorized.GroupManaging
{
    partial class AddGroupMemberForm
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
            this.UsernamesLbl = new System.Windows.Forms.Label();
            this.UsernamesTxt = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernamesLbl
            // 
            this.UsernamesLbl.AutoSize = true;
            this.UsernamesLbl.Location = new System.Drawing.Point(98, 9);
            this.UsernamesLbl.Name = "UsernamesLbl";
            this.UsernamesLbl.Size = new System.Drawing.Size(255, 25);
            this.UsernamesLbl.TabIndex = 0;
            this.UsernamesLbl.Text = "Enter usernames split by space";
            // 
            // UsernamesTxt
            // 
            this.UsernamesTxt.Location = new System.Drawing.Point(94, 52);
            this.UsernamesTxt.Name = "UsernamesTxt";
            this.UsernamesTxt.Size = new System.Drawing.Size(259, 31);
            this.UsernamesTxt.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(94, 99);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 34);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(241, 99);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 34);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AddGroupMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 160);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UsernamesTxt);
            this.Controls.Add(this.UsernamesLbl);
            this.Name = "AddGroupMemberForm";
            this.Text = "CreateGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UsernamesLbl;
        private TextBox UsernamesTxt;
        private Button CancelBtn;
        private Button AddBtn;
    }
}