package com.hxb.jdbc;

import java.sql.*;

/**
 * The type Jdbc.
 */
public class Jdbc {

    /**
     * Gets .
     *
     * @return the
     * @throws ClassNotFoundException the class not found exception
     * @throws SQLException           the sql exception
     */
    public static Connection getcollection() throws ClassNotFoundException,
            SQLException {
        Class.forName("com.hxb.jdbc.Jdbc.Driver");
        Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306" +
                "/ks?useUnicode=true&characterEncoding=UTF-8", "root", "123456");
        if (conn == null) {
            System.out.println("连接失败");
        } else {
            System.out.println("连接成功");
        }
        return conn;
    }


    /**
     * Edit.
     *
     * @param sql    the sql
     * @param params the params
     * @throws SQLException           the sql exception
     * @throws ClassNotFoundException the class not found exception
     */
    public static void edit(String sql, Object[] params) throws SQLException,
            ClassNotFoundException {
        PreparedStatement pstmt = getcollection().prepareStatement(sql);
        for (int i = 0; i < params.length; i++) {
            pstmt.setString(i + 1, params[i].toString());
        }
        pstmt.executeUpdate();
    }

    /**
     * Query result set.
     *
     * @param sql    the sql
     * @param params the params
     * @return the result set
     * @throws SQLException           the sql exception
     * @throws ClassNotFoundException the class not found exception
     */
    public static ResultSet query(String sql, Object[] params) throws SQLException
            , ClassNotFoundException {
        PreparedStatement pstmt = getcollection().prepareStatement(sql);
        for (int i = 0; i < params.length; i++) {
            pstmt.setString(i + 1, params[i].toString());
        }
        ResultSet rs = pstmt.executeQuery();
        return rs;
    }
}