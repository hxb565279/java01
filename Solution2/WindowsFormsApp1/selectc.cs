using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class selectc : Form
    {
        public selectc()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void userbox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pwdBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void idBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void id_user_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            String id = idBox1.Text;
            String user1 = userbox1.Text;
            conn.Open();
            String sql = String.Format("select * from users where id = '{0}' and userid like '%{1}%'  ",id,user1);
            MySqlCommand comm = new MySqlCommand(sql,conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comm;
            //数据集
            DataSet ds = new DataSet();
            sda.Fill(ds, "users");
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void user_pwd_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            String user2 = userbox1.Text;
            String pwd = pwdBox1.Text;
            conn.Open();
            String sql = String.Format("select * from users where userid like '%{0}%' and userpwd like'%{1}%'",user2,pwd);
            MySqlCommand comm = new MySqlCommand(sql,conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comm;
            //数据集
            DataSet ds = new DataSet();
            sda.Fill(ds, "users");
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void select_user_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            String user3 = userbox1.Text;
            conn.Open();
            String sql = String.Format("select * from users where userid like '%{0}%' ",user3);
            MySqlCommand comm = new MySqlCommand(sql,conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comm;
            //数据集
            DataSet ds = new DataSet();
            sda.Fill(ds, "users");
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void select_id_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            String id = idBox1.Text;
            conn.Open();
            String sql = String.Format("select * from users where id = '{0}'   ",id);
            MySqlCommand comm = new MySqlCommand(sql,conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comm;
            //数据集
            DataSet ds = new DataSet();
            sda.Fill(ds, "users");
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}