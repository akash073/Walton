import com.datastax.driver.core.Cluster;
import com.datastax.driver.core.ResultSet;
import com.datastax.driver.core.Row;
import com.datastax.driver.core.Session;

import java.util.List;


/**
 * Created by Mhamudul on 01/04/2016.
 */
public class App {
   public  static void main(String []arg){
        System.out.println("Hi");
       String serverIP = "127.0.0.1";
       String keyspace = "people";

       Cluster cluster = Cluster.builder()
               .addContactPoints(serverIP)
               .build();

       Session session = cluster.connect(keyspace);
       String cqlStatement = "SELECT * FROM messages";
       ResultSet results=session.execute(cqlStatement);
       List<Row> rows = results.all();
       for (Row row : rows) {
          // Row row = row.;
           System.out.println(row.getLong("id")+"->"+row.getString("message")+"->"+row.getObject("sender")+"->"+row.getObject("timestamp"));
          // System.out.println(row.getString(1));
       }
    }

}
