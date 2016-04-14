package com.javatpoint;

import com.CookieStoreCustomObject.CustomObject;
import com.google.gson.Gson;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
public class ControllerServlet extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html");
        PrintWriter out=response.getWriter();

        String name=request.getParameter("name");
        String password=request.getParameter("password");

        List<CustomObject> myList = new ArrayList<CustomObject>();
        CustomObject customObject1=new CustomObject();
        customObject1.setName("akash");
        customObject1.setAge(1);
        myList.add(customObject1);
        customObject1=new CustomObject();
        customObject1.setName("batash");
        customObject1.setAge(2);
        myList.add(customObject1);
        Gson gson = new Gson();
        // convert your list to json
        String jsonCartList = gson.toJson(myList);
        // print your generated json
        System.out.println("jsonCartList: " + jsonCartList);
        Cookie authorizeCookie = new Cookie("authorizeCookieWithCustomObjectList", jsonCartList);
        authorizeCookie.setMaxAge(1);

        // Adding cookies to the response header.
        response.addCookie(authorizeCookie);

        LoginBean bean=new LoginBean();
        bean.setName(name);
        bean.setPassword(password);
        request.setAttribute("bean",bean);

        boolean status=bean.validate();

        if(status){
            RequestDispatcher rd=request.getRequestDispatcher("login-success.jsp");
            rd.forward(request, response);
        }
        else{
            RequestDispatcher rd=request.getRequestDispatcher("login-error.jsp");
            rd.forward(request, response);
        }

    }

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp)
            throws ServletException, IOException {
        doPost(req, resp);
    }
}
