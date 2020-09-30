using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class add1 : Form
    {
        public add1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user1 = this.textBox1.Text;
            String user2 = this.textBox2.Text;
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            conn.Open();
            String sql = String.Format("insert into users (userid,userpwd) values ('{0}','{1}')",user1,user2);
            MySqlCommand comm = new MySqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("保存成功");
            conn.Close();
        }

        private void index_Click(object sender, EventArgs e)
        {
            index i = new index();
            this.Hide();
            i.ShowDialog();


        }
    }
}