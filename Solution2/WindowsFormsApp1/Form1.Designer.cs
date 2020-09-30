namespace WindowsFormsApp1
{
    partial class Form1
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
            this.ll = new System.Windows.Forms.Button();
            this.pwdlogin = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.userlabel1 = new System.Windows.Forms.Label();
            this.pwdlabel = new System.Windows.Forms.Label();
            this.userlogin = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ll
            // 
            this.ll.Location = new System.Drawing.Point(213, 306);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(135, 55);
            this.ll.TabIndex = 1;
            this.ll.Text = "连接";
            this.ll.UseVisualStyleBackColor = true;
            this.ll.Click += new System.EventHandler(this.连接_Click);
            // 
            // pwdlogin
            // 
            this.pwdlogin.Location = new System.Drawing.Point(246, 143);
            this.pwdlogin.Name = "pwdlogin";
            this.pwdlogin.Size = new System.Drawing.Size(173, 25);
            this.pwdlogin.TabIndex = 5;
            this.pwdlogin.TextChanged += new System.EventHandler(this.pwdlogin_TextChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(319, 209);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 48);
            this.login.TabIndex = 6;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // userlabel1
            // 
            this.userlabel1.Location = new System.Drawing.Point(172, 85);
            this.userlabel1.Name = "userlabel1";
            this.userlabel1.Size = new System.Drawing.Size(55, 25);
            this.userlabel1.TabIndex = 7;
            this.userlabel1.Text = "账号:";
            this.userlabel1.Click += new System.EventHandler(this.user1_Click);
            // 
            // pwdlabel
            // 
            this.pwdlabel.Location = new System.Drawing.Point(172, 146);
            this.pwdlabel.Name = "pwdlabel";
            this.pwdlabel.Size = new System.Drawing.Size(55, 21);
            this.pwdlabel.TabIndex = 9;
            this.pwdlabel.Text = "密码:";
            this.pwdlabel.Click += new System.EventHandler(this.pwdlabel_Click);
            // 
            // userlogin
            // 
            this.userlogin.Location = new System.Drawing.Point(243, 85);
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(176, 25);
            this.userlogin.TabIndex = 10;
            this.userlogin.TextChanged += new System.EventHandler(this.userlogin_TextChanged);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(184, 209);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(88, 48);
            this.register.TabIndex = 11;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pwdlogin);
            this.Controls.Add(this.pwdlabel);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Controls.Add(this.userlogin);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.userlabel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button register;

        private System.Windows.Forms.TextBox userlogin;

        private System.Windows.Forms.Label pwdlabel;
        private System.Windows.Forms.TextBox pwdlogin;
        private System.Windows.Forms.Label userlabel1;

        private System.Windows.Forms.Button login;

        private System.Windows.Forms.Button ll;

        #endregion
    }
}