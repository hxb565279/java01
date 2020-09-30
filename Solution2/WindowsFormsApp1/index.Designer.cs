using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class index
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
            this.register1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check1 = new System.Windows.Forms.Button();
            this.add1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.update1 = new System.Windows.Forms.Button();
            this.select1 = new System.Windows.Forms.Button();
            this.selectc = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(12, 12);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(59, 28);
            this.register1.TabIndex = 0;
            this.register1.Text = "注册";
            this.register1.UseVisualStyleBackColor = true;
            this.register1.Click += new System.EventHandler(this.register1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 686);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(446, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // check1
            // 
            this.check1.Location = new System.Drawing.Point(77, 31);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(128, 30);
            this.check1.TabIndex = 6;
            this.check1.Text = "查询用户/弹出";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.Click += new System.EventHandler(this.check1_Click);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(211, 11);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(71, 30);
            this.add1.TabIndex = 8;
            this.add1.Text = "增加";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(288, 1);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(69, 30);
            this.delete1.TabIndex = 10;
            this.delete1.Text = "删除";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(288, 37);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(70, 28);
            this.update1.TabIndex = 12;
            this.update1.Text = "更改";
            this.update1.UseVisualStyleBackColor = true;
            this.update1.Click += new System.EventHandler(this.update1_Click);
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(364, 13);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(112, 28);
            this.select1.TabIndex = 14;
            this.select1.Text = "刷新/全查询";
            this.select1.UseVisualStyleBackColor = true;
            this.select1.Click += new System.EventHandler(this.select1_Click);
            // 
            // selectc
            // 
            this.selectc.Location = new System.Drawing.Point(500, 34);
            this.selectc.Name = "selectc";
            this.selectc.Size = new System.Drawing.Size(86, 26);
            this.selectc.TabIndex = 16;
            this.selectc.Text = "条件查询";
            this.selectc.UseVisualStyleBackColor = true;
            this.selectc.Click += new System.EventHandler(this.selectc_Click);
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(629, 35);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(72, 24);
            this.D1.TabIndex = 18;
            this.D1.Text = "订单";
            this.D1.UseVisualStyleBackColor = true;
            this.D1.Click += new System.EventHandler(this.D1_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 753);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.selectc);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.update1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register1);
            this.IsMdiContainer = true;
            this.Name = "index";
            this.Text = "主页";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button D1;

        private System.Windows.Forms.Button selectc;

        private System.Windows.Forms.Button select1;

        private System.Windows.Forms.Button update1;

        private System.Windows.Forms.Button delete1;

        private System.Windows.Forms.Button add1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button check1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button register1;

        #endregion
    }
}