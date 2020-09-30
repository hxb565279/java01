using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class D1
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
            this.username_box1 = new System.Windows.Forms.TextBox();
            this.shopname_box1 = new System.Windows.Forms.TextBox();
            this.price_box1 = new System.Windows.Forms.TextBox();
            this.number_box1 = new System.Windows.Forms.TextBox();
            this.insert_button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.select_all = new System.Windows.Forms.Button();
            this.delete_box1 = new System.Windows.Forms.Button();
            this.update_box1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(800, 301);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // username_box1
            // 
            this.username_box1.Location = new System.Drawing.Point(76, 0);
            this.username_box1.Name = "username_box1";
            this.username_box1.Size = new System.Drawing.Size(86, 25);
            this.username_box1.TabIndex = 1;
            this.username_box1.TextChanged += new System.EventHandler(this.username_box1_TextChanged);
            // 
            // shopname_box1
            // 
            this.shopname_box1.Location = new System.Drawing.Point(240, 1);
            this.shopname_box1.Name = "shopname_box1";
            this.shopname_box1.Size = new System.Drawing.Size(89, 25);
            this.shopname_box1.TabIndex = 2;
            this.shopname_box1.TextChanged += new System.EventHandler(this.shopname_box1_TextChanged);
            // 
            // price_box1
            // 
            this.price_box1.Location = new System.Drawing.Point(391, 2);
            this.price_box1.Name = "price_box1";
            this.price_box1.Size = new System.Drawing.Size(91, 25);
            this.price_box1.TabIndex = 3;
            this.price_box1.TextChanged += new System.EventHandler(this.price_box1_TextChanged);
            // 
            // number_box1
            // 
            this.number_box1.Location = new System.Drawing.Point(566, 1);
            this.number_box1.Name = "number_box1";
            this.number_box1.Size = new System.Drawing.Size(94, 25);
            this.number_box1.TabIndex = 4;
            // 
            // insert_button1
            // 
            this.insert_button1.Location = new System.Drawing.Point(684, 1);
            this.insert_button1.Name = "insert_button1";
            this.insert_button1.Size = new System.Drawing.Size(74, 24);
            this.insert_button1.TabIndex = 5;
            this.insert_button1.Text = "添加";
            this.insert_button1.UseVisualStyleBackColor = true;
            this.insert_button1.Click += new System.EventHandler(this.insert_button1_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "用户";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(168, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "商品名 ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(335, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "价格";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(503, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "数量";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // select_all
            // 
            this.select_all.Location = new System.Drawing.Point(63, 116);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(67, 27);
            this.select_all.TabIndex = 10;
            this.select_all.Text = "全查询";
            this.select_all.UseVisualStyleBackColor = true;
            this.select_all.Click += new System.EventHandler(this.select_all_Click);
            // 
            // delete_box1
            // 
            this.delete_box1.Location = new System.Drawing.Point(166, 117);
            this.delete_box1.Name = "delete_box1";
            this.delete_box1.Size = new System.Drawing.Size(68, 26);
            this.delete_box1.TabIndex = 11;
            this.delete_box1.Text = "删除";
            this.delete_box1.UseVisualStyleBackColor = true;
            this.delete_box1.Click += new System.EventHandler(this.delete_box1_Click);
            // 
            // update_box1
            // 
            this.update_box1.Location = new System.Drawing.Point(267, 116);
            this.update_box1.Name = "update_box1";
            this.update_box1.Size = new System.Drawing.Size(62, 26);
            this.update_box1.TabIndex = 12;
            this.update_box1.Text = "修改";
            this.update_box1.UseVisualStyleBackColor = true;
            this.update_box1.Click += new System.EventHandler(this.update_box1_Click);
            // 
            // D1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_box1);
            this.Controls.Add(this.delete_box1);
            this.Controls.Add(this.select_all);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.insert_button1);
            this.Controls.Add(this.number_box1);
            this.Controls.Add(this.price_box1);
            this.Controls.Add(this.shopname_box1);
            this.Controls.Add(this.username_box1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "D1";
            this.Text = "D1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button update_box1;

        private System.Windows.Forms.Button delete_box1;

        private System.Windows.Forms.Button select_all;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Button insert_button1;
        private System.Windows.Forms.TextBox number_box1;

        private System.Windows.Forms.TextBox price_box1;

        private System.Windows.Forms.TextBox shopname_box1;

        private System.Windows.Forms.TextBox username_box1;

        private System.Windows.Forms.DataGridView dataGridView2;

        #endregion
    }
}