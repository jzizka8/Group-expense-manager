namespace Project
{
    partial class RegisterForm
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
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ErrReportLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginLinkLbl = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserNameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLbl.Location = new System.Drawing.Point(3, 5);
            this.UserNameLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(91, 51);
            this.UserNameLbl.TabIndex = 0;
            this.UserNameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLbl.Location = new System.Drawing.Point(3, 61);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(87, 51);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTxt.Location = new System.Drawing.Point(168, 3);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(272, 31);
            this.UserNameTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxt.Location = new System.Drawing.Point(170, 61);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(268, 31);
            this.PasswordTxt.TabIndex = 3;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.Location = new System.Drawing.Point(170, 117);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(268, 46);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ErrReportLbl
            // 
            this.ErrReportLbl.AutoSize = true;
            this.ErrReportLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrReportLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrReportLbl.Location = new System.Drawing.Point(301, 330);
            this.ErrReportLbl.Name = "ErrReportLbl";
            this.ErrReportLbl.Size = new System.Drawing.Size(0, 25);
            this.ErrReportLbl.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.24605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.75395F));
            this.tableLayoutPanel1.Controls.Add(this.UserNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RegisterBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserNameTxt, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(161, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 168);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // LoginLinkLbl
            // 
            this.LoginLinkLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLinkLbl.AutoSize = true;
            this.LoginLinkLbl.Location = new System.Drawing.Point(253, 281);
            this.LoginLinkLbl.Name = "LoginLinkLbl";
            this.LoginLinkLbl.Size = new System.Drawing.Size(272, 25);
            this.LoginLinkLbl.TabIndex = 7;
            this.LoginLinkLbl.TabStop = true;
            this.LoginLinkLbl.Text = "Already have an account? Log in!";
            this.LoginLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkLbl_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ErrReportLbl);
            this.Controls.Add(this.LoginLinkLbl);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserNameLbl;
        private Label PasswordLbl;
        private TextBox UserNameTxt;
        private TextBox PasswordTxt;
        private Button RegisterBtn;
        private Label ErrReportLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel LoginLinkLbl;
    }
}