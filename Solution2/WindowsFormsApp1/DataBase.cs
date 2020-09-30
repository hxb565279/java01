using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class DataBase
    {
        public MySqlConnection getConn()
        {
            String strConnection = "server=localhost;User id = root;password=123456;Database=c#;Charset=utf8;";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}