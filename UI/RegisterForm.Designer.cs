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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLbl.Location = new System.Drawing.Point(117, 72);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(249, 67);
            this.UserNameLbl.TabIndex = 0;
            this.UserNameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLbl.Location = new System.Drawing.Point(117, 179);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(233, 67);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTxt.Location = new System.Drawing.Point(395, 72);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(258, 74);
            this.UserNameTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxt.Location = new System.Drawing.Point(395, 179);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(258, 74);
            this.PasswordTxt.TabIndex = 3;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterBtn.Location = new System.Drawing.Point(133, 272);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(520, 72);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ErrReportLbl
            // 
            this.ErrReportLbl.AutoSize = true;
            this.ErrReportLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrReportLbl.Location = new System.Drawing.Point(121, 377);
            this.ErrReportLbl.Name = "ErrReportLbl";
            this.ErrReportLbl.Size = new System.Drawing.Size(0, 32);
            this.ErrReportLbl.TabIndex = 5;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(39, 389);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(136, 34);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login instead";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ErrReportLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Name = "RegisterForm";
            this.Text = "Register";
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
        private Button LoginBtn;
    }
}