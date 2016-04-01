import com.datastax.driver.core.Cluster;
import com.datastax.driver.core.Row;
import com.datastax.driver.core.Session;

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
       String cqlStatement = "SELECT * FROM employees ";
       for (Row row : session.execute(cqlStatement)) {
           System.out.println(row.toString());
       }
    }

}
