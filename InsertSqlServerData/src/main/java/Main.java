import java.sql.*;

public class Main {

    public static void main(String[] args) throws SQLException {
        // write your code here
        Connection conn = null;
        ResultSet rs = null;
        String url = "jdbc:jtds:sqlserver://localhost:1433/RBSYNERGY";
        String driver = "net.sourceforge.jtds.jdbc.Driver";
        String userName = "sa";
        String password = "a123456789A";
        try {
            Class.forName(driver);
            conn = DriverManager.getConnection(url, userName, password);
           // System.out.println("Connected to the database!!! Getting table list...");
            Statement stmt = conn.createStatement();

            String sql = "INSERT INTO MyTableJava(Text) VALUES ('AKASH')";
            // ResultSet resultSet = stmt.executeQuery(sql);

            //  String selectSQL = "SELECT USER_ID, USERNAME FROM DBUSER WHERE USER_ID = ?";
            //Statement stmt = conn.createStatement();
            stmt.execute(sql);


        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            conn.close();

        }

    }
}
