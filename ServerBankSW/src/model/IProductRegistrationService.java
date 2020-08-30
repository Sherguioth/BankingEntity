package model;

import java.util.List;

import structural.ProductRegistration;

public interface IProductRegistrationService {

    List<ProductRegistration> listAll();

    boolean insertProductRegistration(ProductRegistration newProductRegistration);

    ProductRegistration findProductRegistration(int clientId, int productCode);

    boolean updateProductRegistration(int clientId, int productCode, ProductRegistration update);

    boolean deleteProductRegistration(int clientId, int productCode);
}
