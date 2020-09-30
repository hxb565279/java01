using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class D1 : Form
    {
        public D1()
        {
            InitializeComponent();
            select_all_Click(null, null);
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void username_box1_TextChanged(object sender, EventArgs e)
        {
        }

        private void shopname_box1_TextChanged(object sender, EventArgs e)
        {
        }

        private void price_box1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

//添加
        private void insert_button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            String username1 = this.username_box1.Text;
            String shopname1 = this.shopname_box1.Text;
            String price1 = this.price_box1.Text;
            String number1 = this.number_box1.Text;
            conn.Open();
            String sql1 =
                String.Format("insert into customer (username,shopname,price,number) values('{0}','{1}','{2}','{3}')",
                    username1, shopname1, price1, number1);
            MySqlCommand comm = new MySqlCommand(sql1, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("添加成功");
            select_all_Click(null, null);
            conn.Close();
        }

//全查询
        private void select_all_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            conn.Open();
            String sql2 = String.Format("select * from customer");
            MySqlCommand comm = new MySqlCommand(sql2, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comm;
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet, "customer");
            dataGridView2.DataSource = dataSet.Tables[0];
            conn.Close();
        }

//删除
        private void delete_box1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            conn.Open();
            int rowindex = dataGridView2.CurrentRow.Index;
            String value = dataGridView2.Rows[rowindex].Cells[0].Value.ToString();
            String sql3 = String.Format("delete from customer where id = '{0}'", value);
            MySqlCommand comm = new MySqlCommand(sql3, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("删除成功");
            select_all_Click(null, null);
            conn.Close();
        }

//修改
        private void update_box1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            conn.Open();
            int index = dataGridView2.CurrentRow.Index;
            String value0 = dataGridView2.Rows[index].Cells[0].Value.ToString();
            String value1 = dataGridView2.Rows[index].Cells[1].Value.ToString();
            String value2 = dataGridView2.Rows[index].Cells[2].Value.ToString();
            String value3 = dataGridView2.Rows[index].Cells[3].Value.ToString();
            String value4 = dataGridView2.Rows[index].Cells[4].Value.ToString();
            String sql =
                String.Format(
                    "update customer set username='{0}',shopname='{1}',price='{2}',number='{3}' where id= '{4}' ",
                    value1, value2, value3, value4, value0);
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("修改成功");
            conn.Close();
        }
    }
}