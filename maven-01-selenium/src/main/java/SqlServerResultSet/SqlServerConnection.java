package SqlServerResultSet;

import java.sql.*;
import java.time.Instant;

/**
 * Created by Mhamudul Hasan on 30/05/2016.
 */
public class SqlServerConnection {
    public static void main(String[] args) throws SQLException {
        Connection conn = null;
        ResultSet rs = null;
        String url = "jdbc:jtds:sqlserver://192.168.10.131;instance=MSSQLSERVER;DatabaseName=RBSYNERGY";
        String driver = "net.sourceforge.jtds.jdbc.Driver";
        String userName = "test";
        String password = "test";
        int count=0;
        Instant now = Instant.now();
        try {
            Class.forName(driver);
            conn = DriverManager.getConnection(url, userName, password);
            System.out.println("Connected to the database!!! Getting table list...");
            Statement stmt = conn.createStatement(
                    ResultSet.TYPE_SCROLL_INSENSITIVE,
                    ResultSet.CONCUR_UPDATABLE);
            //STEP 5: Execute a query
            String sql = "SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "  union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "    union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "    union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "    union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "    union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "    union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]\n" +
                    "    union all\n" +
                    "  SELECT *\n" +
                    "  FROM [RBSYNERGY].[dbo].[tblSMSInbox]";

            rs = stmt.executeQuery(sql);
            while (rs.next()){
                count++;
                System.out.println(rs.getString(1));
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            conn.close();
            rs.close();
        }
        System.out.println(count);
    }
}
