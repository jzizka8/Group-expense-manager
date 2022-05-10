namespace Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameLoginLbl = new System.Windows.Forms.Label();
            this.PasswordLoginLbl = new System.Windows.Forms.Label();
            this.UsernameLoginTxt = new System.Windows.Forms.TextBox();
            this.PasswordLoginTxt = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ErrLoginLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(380, 202);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(150, 34);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Log in";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameLoginLbl
            // 
            this.UsernameLoginLbl.AutoSize = true;
            this.UsernameLoginLbl.Location = new System.Drawing.Point(213, 95);
            this.UsernameLoginLbl.Name = "UsernameLoginLbl";
            this.UsernameLoginLbl.Size = new System.Drawing.Size(91, 25);
            this.UsernameLoginLbl.TabIndex = 1;
            this.UsernameLoginLbl.Text = "Username";
            // 
            // PasswordLoginLbl
            // 
            this.PasswordLoginLbl.AutoSize = true;
            this.PasswordLoginLbl.Location = new System.Drawing.Point(213, 149);
            this.PasswordLoginLbl.Name = "PasswordLoginLbl";
            this.PasswordLoginLbl.Size = new System.Drawing.Size(87, 25);
            this.PasswordLoginLbl.TabIndex = 2;
            this.PasswordLoginLbl.Text = "Password";
            // 
            // UsernameLoginTxt
            // 
            this.UsernameLoginTxt.Location = new System.Drawing.Point(380, 97);
            this.UsernameLoginTxt.Name = "UsernameLoginTxt";
            this.UsernameLoginTxt.Size = new System.Drawing.Size(150, 31);
            this.UsernameLoginTxt.TabIndex = 3;
            // 
            // PasswordLoginTxt
            // 
            this.PasswordLoginTxt.Location = new System.Drawing.Point(380, 149);
            this.PasswordLoginTxt.Name = "PasswordLoginTxt";
            this.PasswordLoginTxt.PasswordChar = '*';
            this.PasswordLoginTxt.Size = new System.Drawing.Size(150, 31);
            this.PasswordLoginTxt.TabIndex = 4;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(19, 376);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(163, 34);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Register instead";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ErrLoginLbl
            // 
            this.ErrLoginLbl.AutoSize = true;
            this.ErrLoginLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrLoginLbl.Location = new System.Drawing.Point(426, 395);
            this.ErrLoginLbl.Name = "ErrLoginLbl";
            this.ErrLoginLbl.Size = new System.Drawing.Size(0, 25);
            this.ErrLoginLbl.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrLoginLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PasswordLoginTxt);
            this.Controls.Add(this.UsernameLoginTxt);
            this.Controls.Add(this.PasswordLoginLbl);
            this.Controls.Add(this.UsernameLoginLbl);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginBtn;
        private Label UsernameLoginLbl;
        private Label PasswordLoginLbl;
        private TextBox UsernameLoginTxt;
        private TextBox PasswordLoginTxt;
        private Button RegisterBtn;
        private Label ErrLoginLbl;
    }
}