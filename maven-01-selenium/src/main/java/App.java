import com.google.gson.Gson;
import org.codehaus.jackson.map.ObjectMapper;
import org.dozer.DozerBeanMapper;
import org.dozer.Mapper;


import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Mhamudul Hasan on 26/05/2016.
 */
public class App {
    public static ArrayList<Product> objectReader(String fileName)throws Exception{
        ArrayList<Product>pro=null;
        BufferedInputStream bfInput;
        bfInput=new BufferedInputStream(new FileInputStream(fileName));
        ObjectInputStream obj=new ObjectInputStream(bfInput);
        pro=(ArrayList<Product>) obj.readObject();

        //            the probelm when i try to output it
        //System.out.println(pro);
        obj.close();
        return pro;

    }
    public static void main(String[] args) throws Exception {
        System.out.println("😃".length());
        System.out.println("Hello World!");
        //List<Product> productList=objectReader("E:\\p.txt");

        Product product=new Product();
        product.name="akash";
        Mapper mapper = new DozerBeanMapper();
        SearchResult destObject =
                mapper.map(product, SearchResult.class);


        /*String myJsonString="[\n" +
                "  {\n" +
                "    \"source\": \"Gank.io #145 (2015-12-24)\",\n" +
                "    \"title\": \"view\",\n" +
                "    \"url\": \"https://github.com/florent37/ViewAnimator\"\n" +
                "  },\n" +
                "  {\n" +
                "    \"source\": \"Gank.io #42 (2015-07-23)\",\n" +
                "    \"title\": \"android\",\n" +
                "    \"url\": \"https://github.com/kevinzhow/NaughtyImageView\"\n" +
                "  },\n" +
                "  {\n" +
                "    \"source\": \"Gank.io #28 (2015-07-02)\",\n" +
                "    \"title\": \"iOS UIView\",\n" +
                "    \"url\": \"http://www.devtalking.com/articles/uiview-spring-animation/\"\n" +
                "  }\n" +
                "\n" +
                "]";
        System.out.println(myJsonString);
        ObjectMapper mapper = new ObjectMapper();
        *//*User user = mapper.readValue(myJsonString, User.class);
        String name = user.getName(); // some name
        String email = user.getEmail(); // email@gmail.com*//*

        SearchResult[] searchResult=mapper.readValue(myJsonString,SearchResult[].class);
        String Name=searchResult[0].url;

       *//* Gson gson = new Gson();
        SearchResultData searchResultData = gson.fromJson(json,SearchResultData.class);
        List<SearchResult> searchResults = searchResultData.getResults();
*/

    }
}
