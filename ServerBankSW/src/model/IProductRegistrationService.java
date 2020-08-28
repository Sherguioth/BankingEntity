package model;

import java.util.List;

import structural.ProductRegistration;

public interface IProductRegistrationService {

    List<ProductRegistration> listAll();

    boolean insertProductoRegistration(ProductRegistration newRegistration);

    ProductRegistration findProductoRegistration(int clientId, int productCode);

    boolean updateProductoRegistration(int clientId, int productCode, ProductRegistration update);

    boolean deleteProductoRegistration(int clientId, int productCode);
}
