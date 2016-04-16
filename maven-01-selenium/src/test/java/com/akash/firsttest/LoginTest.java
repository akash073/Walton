package com.akash.firsttest;

import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
//https://www.youtube.com/watch?v=VZxpv5l5JvY
public class LoginTest {

    @Test
    public void startLoginPage()
    {
        WebDriver driver=new FirefoxDriver();
        driver.navigate().to("http://localhost:8080/");
        Assert.assertTrue("Sign In",driver.getTitle().startsWith("HI"));
      //  driver.close();
        driver.quit();
    }

}
