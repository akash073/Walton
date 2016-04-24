package com.javatpoint;

public class ProductAction{

    public Product getProduct() {
        return product;
    }

    public void setProduct(Product product) {
        this.product = product;
    }

    private Product product;

    public String execute(){
       return "success";
    }



}