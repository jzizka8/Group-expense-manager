namespace Project.UI
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
            this.LoginStatusLbl = new System.Windows.Forms.Label();
            this.LoginProgress = new System.Windows.Forms.ProgressBar();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(407, 202);
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
            this.UsernameLoginLbl.Location = new System.Drawing.Point(240, 95);
            this.UsernameLoginLbl.Name = "UsernameLoginLbl";
            this.UsernameLoginLbl.Size = new System.Drawing.Size(91, 25);
            this.UsernameLoginLbl.TabIndex = 1;
            this.UsernameLoginLbl.Text = "Username";
            // 
            // PasswordLoginLbl
            // 
            this.PasswordLoginLbl.AutoSize = true;
            this.PasswordLoginLbl.Location = new System.Drawing.Point(240, 149);
            this.PasswordLoginLbl.Name = "PasswordLoginLbl";
            this.PasswordLoginLbl.Size = new System.Drawing.Size(87, 25);
            this.PasswordLoginLbl.TabIndex = 2;
            this.PasswordLoginLbl.Text = "Password";
            // 
            // UsernameLoginTxt
            // 
            this.UsernameLoginTxt.Location = new System.Drawing.Point(407, 97);
            this.UsernameLoginTxt.Name = "UsernameLoginTxt";
            this.UsernameLoginTxt.Size = new System.Drawing.Size(150, 31);
            this.UsernameLoginTxt.TabIndex = 3;
            // 
            // PasswordLoginTxt
            // 
            this.PasswordLoginTxt.Location = new System.Drawing.Point(407, 149);
            this.PasswordLoginTxt.Name = "PasswordLoginTxt";
            this.PasswordLoginTxt.PasswordChar = '*';
            this.PasswordLoginTxt.Size = new System.Drawing.Size(150, 31);
            this.PasswordLoginTxt.TabIndex = 4;
            // 
            // LoginStatusLbl
            // 
            this.LoginStatusLbl.AutoSize = true;
            this.LoginStatusLbl.ForeColor = System.Drawing.Color.Black;
            this.LoginStatusLbl.Location = new System.Drawing.Point(372, 306);
            this.LoginStatusLbl.Name = "LoginStatusLbl";
            this.LoginStatusLbl.Size = new System.Drawing.Size(0, 25);
            this.LoginStatusLbl.TabIndex = 6;
            // 
            // LoginProgress
            // 
            this.LoginProgress.Location = new System.Drawing.Point(224, 359);
            this.LoginProgress.MarqueeAnimationSpeed = 15;
            this.LoginProgress.Maximum = 10;
            this.LoginProgress.Name = "LoginProgress";
            this.LoginProgress.Size = new System.Drawing.Size(333, 34);
            this.LoginProgress.Step = 5;
            this.LoginProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoginProgress.TabIndex = 7;
            this.LoginProgress.Visible = false;
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Location = new System.Drawing.Point(224, 261);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(345, 25);
            this.RegisterLink.TabIndex = 8;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Do not have an account yet? Register here";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.LoginProgress);
            this.Controls.Add(this.LoginStatusLbl);
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
        private Label LoginStatusLbl;
        private ProgressBar LoginProgress;
        private LinkLabel RegisterLink;
    }
}