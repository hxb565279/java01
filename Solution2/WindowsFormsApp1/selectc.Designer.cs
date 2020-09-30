using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class selectc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.userbox1 = new System.Windows.Forms.TextBox();
            this.pwdBox1 = new System.Windows.Forms.TextBox();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_user = new System.Windows.Forms.Button();
            this.user_pwd = new System.Windows.Forms.Button();
            this.select_user = new System.Windows.Forms.Button();
            this.select_id = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(482, 359);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // userbox1
            // 
            this.userbox1.Location = new System.Drawing.Point(566, 116);
            this.userbox1.Name = "userbox1";
            this.userbox1.Size = new System.Drawing.Size(111, 25);
            this.userbox1.TabIndex = 1;
            this.userbox1.TextChanged += new System.EventHandler(this.userbox1_TextChanged);
            // 
            // pwdBox1
            // 
            this.pwdBox1.Location = new System.Drawing.Point(566, 161);
            this.pwdBox1.Name = "pwdBox1";
            this.pwdBox1.Size = new System.Drawing.Size(111, 25);
            this.pwdBox1.TabIndex = 2;
            this.pwdBox1.TextChanged += new System.EventHandler(this.pwdBox1_TextChanged);
            // 
            // idBox1
            // 
            this.idBox1.Location = new System.Drawing.Point(566, 71);
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(111, 25);
            this.idBox1.TabIndex = 3;
            this.idBox1.TextChanged += new System.EventHandler(this.idBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(509, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(509, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "user";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(509, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "pwd";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // id_user
            // 
            this.id_user.Location = new System.Drawing.Point(509, 307);
            this.id_user.Name = "id_user";
            this.id_user.Size = new System.Drawing.Size(104, 43);
            this.id_user.TabIndex = 7;
            this.id_user.Text = "id/user查询";
            this.id_user.UseVisualStyleBackColor = true;
            this.id_user.Click += new System.EventHandler(this.id_user_Click);
            // 
            // user_pwd
            // 
            this.user_pwd.Location = new System.Drawing.Point(508, 356);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.Size = new System.Drawing.Size(104, 43);
            this.user_pwd.TabIndex = 8;
            this.user_pwd.Text = "user/pwd查询";
            this.user_pwd.UseVisualStyleBackColor = true;
            this.user_pwd.Click += new System.EventHandler(this.user_pwd_Click);
            // 
            // select_user
            // 
            this.select_user.Location = new System.Drawing.Point(508, 260);
            this.select_user.Name = "select_user";
            this.select_user.Size = new System.Drawing.Size(104, 41);
            this.select_user.TabIndex = 9;
            this.select_user.Text = "user查询";
            this.select_user.UseVisualStyleBackColor = true;
            this.select_user.Click += new System.EventHandler(this.select_user_Click);
            // 
            // select_id
            // 
            this.select_id.Location = new System.Drawing.Point(508, 222);
            this.select_id.Name = "select_id";
            this.select_id.Size = new System.Drawing.Size(103, 32);
            this.select_id.TabIndex = 10;
            this.select_id.Text = "id查询";
            this.select_id.UseVisualStyleBackColor = true;
            this.select_id.Click += new System.EventHandler(this.select_id_Click);
            // 
            // selectc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.select_id);
            this.Controls.Add(this.select_user);
            this.Controls.Add(this.user_pwd);
            this.Controls.Add(this.id_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox1);
            this.Controls.Add(this.pwdBox1);
            this.Controls.Add(this.userbox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "selectc";
            this.Text = "selectc";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button select_id;

        private System.Windows.Forms.Button select_user;

        private System.Windows.Forms.Button user_pwd;

        private System.Windows.Forms.Button id_user;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox idBox1;

        private System.Windows.Forms.TextBox pwdBox1;

        private System.Windows.Forms.TextBox userbox1;

        private System.Windows.Forms.DataGridView dataGridView2;

        #endregion
    }
}