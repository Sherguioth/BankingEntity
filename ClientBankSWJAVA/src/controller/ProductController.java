package controller;

import java.util.List;

import webservices.Product;
import webservices.ProductWebService;
import webservices.ProductWebServiceSW;

public class ProductController {

    private ProductWebServiceSW productWebServiceSW;
    private ProductWebService productWebService;

    public ProductController() {
        this.productWebServiceSW = new ProductWebServiceSW();
        this.productWebService = productWebServiceSW.getProductWebServicePort();
    }

    public List<Product> listAllProducts() {
        List<Product> listProducts = this.productWebService.listAllProducts();

        return listProducts;
    }

    public Product findProductById(int code) {
        Product product = null;

        product = this.productWebService.findProduct(code);

        return product;
    }
}
