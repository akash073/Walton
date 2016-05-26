import org.codehaus.jackson.map.ObjectMapper;

import java.io.IOException;

/**
 * Created by Mhamudul Hasan on 26/05/2016.
 */
public class App {
    public static void main(String[] args) throws IOException {
        System.out.println("Hello World!");
        String myJsonString="{\n" +
                "  \"email\": \"email@gmail.com\",\n" +
                "  \"googleId\": \"43243243242432\",\n" +
                "  \"name\": \"some name\"\n" +
                "}";
        System.out.println(myJsonString);
        ObjectMapper mapper = new ObjectMapper();
        User user = mapper.readValue(myJsonString, User.class);
        String name = user.getName(); // some name
        String email = user.getEmail(); // email@gmail.com


    }
}
