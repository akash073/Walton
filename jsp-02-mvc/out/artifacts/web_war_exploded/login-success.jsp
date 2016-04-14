<%@page import="com.javatpoint.LoginBean"%>
<%@ page import="java.lang.reflect.Type" %>
<%@ page import="com.CookieStoreCustomObject.CustomObject" %>
<%@ page import="java.util.List" %>
<%@ page import="com.google.gson.reflect.TypeToken" %>
<%@ page import="com.google.gson.Gson" %>

<p>You are successfully logged in!</p>
<%
  LoginBean bean=(LoginBean)request.getAttribute("bean");
  out.print("Welcome, "+bean.getName());
%>

<html>
<body>
<%
  Cookie cookie = null;
  Cookie[] cookies = null;
  // Get an array of Cookies associated with this domain
  cookies = request.getCookies();
  if( cookies != null ){
    out.println("<h2> Found Cookies Name and Value</h2>");
    for (int i = 0; i < cookies.length; i++){
      cookie = cookies[1];
    //  if(cookie.getName( ).equals("authorizeCookieWithCustomObjectList")) {
      break;
       /* out.print("Name : " + cookie.getName() + ",  ");
        out.print("Value: " + cookie.getValue() + " <br/>");*/
      //}
    }

    Gson gson = new Gson();
    Type type = new TypeToken<List<CustomObject>>(){}.getType();
    List<CustomObject> prodList = gson.fromJson(cookie.getValue(), type);
    for (CustomObject object : prodList) {
      //do something
      out.print("Name : " + object.getName() + ",  ");
      out.print("Age : " + object.getAge() + ",  ");
      out.print("<br/>");
    }

  }else{
    out.println(
            "<h2>No cookies founds</h2>");
  }
%>
</body>
</html>
