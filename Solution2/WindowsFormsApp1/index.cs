using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Image = System.Drawing.Image;

namespace WindowsFormsApp1
{
    public partial class index : Form
    {
        public index()
        {
            object sender;
            EventArgs e;
            InitializeComponent();
            this.BackgroundImage =
                Image.FromFile("D:\\Users\\windows\\RiderProjects\\Solution2\\WindowsFormsApp1\\images\\1.jpg");
         select1_Click(null,null);
        }

        private void register1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }


        private void check1_Click(object sender, EventArgs e)
        {
            String connection = "server=localhost;User id = root;password=123456;Database=c#;Charset=utf8;";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("连接成功");
                String sql = "select * from users";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        MessageBox.Show("查询成功");
                        MessageBox.Show(mySqlDataReader[0] + "  " + mySqlDataReader[1] + "  " + mySqlDataReader[2]);
                    }
                }
                else
                {
                    MessageBox.Show("查询失败");
                }

                mySqlDataReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("打开数据库失败");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //增加
        private void add1_Click(object sender, EventArgs e)
        {
            add1  ad = new add1();
            ad.ShowDialog();

        }

        //删除
        private void delete1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            conn.Open();
            int rowindex = dataGridView1.CurrentRow.Index;
            String value = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            String sql = String.Format("delete from users where id= '{0}'",value);
            MySqlCommand comm = new MySqlCommand(sql,conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("删除成功");
            select1_Click(sender,e);
            conn.Close();
        }
//更新
        private void update1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            conn.Open();
            int index = dataGridView1.CurrentRow.Index;
            String value0 = dataGridView1.Rows[index].Cells[0].Value.ToString();
            String value1 = dataGridView1.Rows[index].Cells[1].Value.ToString();
            String value2 = dataGridView1.Rows[index].Cells[2].Value.ToString();
            String sql = String.Format("update users set userid='{0}',userpwd='{1}' where id= '{2}' ",value1,value2,value0);
           MySqlCommand comm = new MySqlCommand(sql,conn);
           comm.ExecuteNonQuery();
           MessageBox.Show("修改成功");
           select1_Click(sender,e);
               conn.Close();
        }

//查询
        public void select1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlConnection conn = db.getConn();
            //打开连接
            conn.Open();
            //定义sql语句
            String sql = "select * from users";
            //创建sql 执行对象
            MySqlCommand comm = new MySqlCommand(sql, conn);
            //数据适配器
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comm;
            //数据集
            DataSet ds = new DataSet();
            sda.Fill(ds, "users");
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void selectc_Click(object sender, EventArgs e)
        {
            selectc s = new selectc();
            s.ShowDialog();
        }

        private void D1_Click(object sender, EventArgs e)
        {
            D1 d = new D1();
            this.Hide();
            d.ShowDialog();
        }
    }
}