package com.CookieStoreCustomObject;

import java.io.Serializable;

/**
 * Created by Mhamudul on 14/04/2016.
 */
public class CustomObject implements Serializable {
    private String name;

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    private int age;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
