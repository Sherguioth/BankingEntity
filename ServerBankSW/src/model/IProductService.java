package model;

import java.util.List;

import structural.Product;

public interface IProductService {

    List<Product> listAll();

    boolean insertProduct(Product newProduct);

    Product findProduct(int code);

    boolean updateProduct(int code, Product update);

    boolean deleteProduct(int code);
}
