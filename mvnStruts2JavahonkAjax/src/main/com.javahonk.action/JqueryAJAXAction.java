package com.javahonk.action;

import org.apache.struts2.convention.annotation.Action;
import org.apache.struts2.convention.annotation.ParentPackage;
import org.apache.struts2.convention.annotation.Result;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import com.opensymphony.xwork2.ActionSupport;

@ParentPackage("json-default")
public class JqueryAJAXAction extends ActionSupport {

    private static final long serialVersionUID = 1L;
    private String firstName;
    private String lastName;
    private String location;
    private String jsonRequestdata;

    @Override
    @Action(value = "/jqueryAJAXAction",
            results = { @Result(name = "success", type = "json") })
    public String execute() throws Exception {

        //Pull request data
        JSONObject json = (JSONObject)new JSONParser()
                .parse(jsonRequestdata);
       // System.out.println("First Name=" + json.get("firstName"));
       // System.out.println("Last Name=" + json.get("lastName"));
       // System.out.println("Location=" + json.get("location"));

        //Set data in response
        setFirstName(json.get("firstName").toString());
        setLastName(json.get("lastName").toString());
        setLocation(json.get("location").toString());
        return ActionSupport.SUCCESS;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public String getJsonRequestdata() {
        return jsonRequestdata;
    }

    public void setJsonRequestdata(String jsonRequestdata) {
        this.jsonRequestdata = jsonRequestdata;
    }

}
