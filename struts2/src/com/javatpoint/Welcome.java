package com.javatpoint;

import com.opensymphony.xwork2.ActionSupport;

public class Welcome extends ActionSupport {
    public String execute(){
       // return "success";
        return SUCCESS;
    }
}