package com.javatpoint;

import java.sql.*;

public class LoginDao {

    public static boolean validate(String username,String userpass){
        boolean status=false;
        try{
            /*Class.forName("oracle.jdbc.driver.OracleDriver");
            Connection con=DriverManager.getConnection(
                    "jdbc:oracle:thin:@localhost:1521:xe","system","oracle");

            PreparedStatement ps=con.prepareStatement(
                    "select * from user3333 where name=? and password=?");
            ps.setString(1,username);
            ps.setString(2,userpass);
            ResultSet rs=ps.executeQuery();
            status=rs.next();*/
            System.out.println("-------- PostgreSQL "
                    + "JDBC Connection Testing ------------");

            try {

                Class.forName("org.postgresql.Driver");

            } catch (ClassNotFoundException e) {

                System.out.println("Where is your PostgreSQL JDBC Driver? "
                        + "Include in your library path!");
                e.printStackTrace();
               // return;

            }

            System.out.println("PostgreSQL JDBC Driver Registered!");

            Connection connection = null;

            try {

                connection = DriverManager.getConnection(
                        "jdbc:postgresql://127.0.0.1:5432/postgres", "postgres",
                        "abc");
                PreparedStatement ps=connection.prepareStatement(
                        "select * from \"USER3333\" where \"NAME\"=? and \"PASSWORD\"=?");
                ps.setString(1,username);
                ps.setString(2,userpass);
                ResultSet rs=ps.executeQuery();
                status=rs.next();

            } catch (SQLException e) {

                System.out.println("Connection Failed! Check output console");
                e.printStackTrace();
               // return;

            }

            if (connection != null) {
                System.out.println("You made it, take control your database now!");
            } else {
                System.out.println("Failed to make connection!");
            }

        }catch(Exception e){e.printStackTrace();}
        return status;
    }
}