namespace Project.UI.Authorized.GroupManaging
{
    partial class CreateGroupForm
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
            this.GroupNameLbl = new System.Windows.Forms.Label();
            this.GroupNameTxt = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupNameLbl
            // 
            this.GroupNameLbl.AutoSize = true;
            this.GroupNameLbl.Location = new System.Drawing.Point(150, 9);
            this.GroupNameLbl.Name = "GroupNameLbl";
            this.GroupNameLbl.Size = new System.Drawing.Size(155, 25);
            this.GroupNameLbl.TabIndex = 0;
            this.GroupNameLbl.Text = "Enter group name";
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.Location = new System.Drawing.Point(94, 52);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(259, 31);
            this.GroupNameTxt.TabIndex = 1;
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
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(241, 99);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(112, 34);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 160);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.GroupNameTxt);
            this.Controls.Add(this.GroupNameLbl);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GroupNameLbl;
        private TextBox GroupNameTxt;
        private Button CancelBtn;
        private Button CreateBtn;
    }
}