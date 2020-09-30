using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\Users\\windows\\RiderProjects\\Solution2\\WindowsFormsApp1\\images\\q1.jpg");
        }


        private void 连接_Click(object sender, EventArgs e)
        {
            {
                String Constring = "server=localhost;User id=  root;password=123456;Database=c#form";
                MySqlConnection conn = new MySqlConnection(Constring);
                try
                {
                    conn.Open();
                    MessageBox.Show("连接成功");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("连接失败");
                }
                finally
                {
                    conn.Clone();
                }
            }
        }


        private void user1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pwdlogin_TextChanged(object sender, EventArgs e)
        {
            this.pwdlogin.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            String userid1 = this.userlogin.Text;
            String password = this.pwdlogin.Text;
            if (userid1.Equals(""))
            {
                MessageBox.Show("用户名为空");
            }
            else
            {
                if (password.Equals(""))
                {
                    MessageBox.Show("密码为空");
                }
                else
                {
                    String Constring = "server=localhost;User id=root;password=123456;Database=c# ;Charset=utf8;";
                    MySqlConnection mySqlConnection = new MySqlConnection(Constring);
                    try
                    {
                        mySqlConnection.Open();
                        String sql =
                            String.Format("select count(*) from users where userid = '{0}'  and userpwd =   '{1}' ",
                                userid1, password);
                        MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                        if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("登录成功");
                            index i = new index();
                            this.Hide();
                            i.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误");
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message.ToString() + "打开数据库失败");
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
        }

        private void pwdlabel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
            }
        }

        private void loginpanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void userlogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void register_Click(object sender, EventArgs e)
        {
            String userid1 = this.userlogin.Text;
            String password = this.pwdlogin.Text;
            if (userid1.Equals(""))
            {
                MessageBox.Show("用户名为空");
            }
            else
            {
                if (password.Equals(""))
                {
                    MessageBox.Show("密码为空");
                }
                else
                {
                    String Constring = "server=localhost;User id=root;password=123456;Database=c# ;Charset=utf8;";
                    MySqlConnection mySqlConnection = new MySqlConnection(Constring);
                    try
                    {
                        mySqlConnection.Open();
                        String sql1 = String.Format("select count(*) from users where userid = '{0}'", userid1);
                        String sql2 = String.Format("insert into users (userid,userpwd) values ('{0}','{1}' )", userid1,
                            password);
                        MySqlCommand mySqlCommand1 = new MySqlCommand(sql1, mySqlConnection);
                        MySqlCommand mySqlCommand2 = new MySqlCommand(sql2, mySqlConnection);
                        if ((Convert.ToInt32(mySqlCommand1.ExecuteScalar()) > 0))
                        {
                            MessageBox.Show("用户名存在");
                        }
                        else
                        {
                            if (mySqlCommand2.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("注册成功");
                            }
                            else
                            {
                                MessageBox.Show("注册失败");
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message.ToString() + "打开数据库失败");
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
        }
    }
}