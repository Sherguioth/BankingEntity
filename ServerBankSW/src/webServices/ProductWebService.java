package webServices;

import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

import model.IProductService;
import model.ProductService;

import structural.Product;

@WebService(serviceName = "ProductWebServiceSW")
public class ProductWebService {

    private IProductService productService;

    public ProductWebService() {
        super();
        this.productService = new ProductService();
    }

    @WebMethod
    public List<Product> listAllProducts() {
        return this.productService.listAll();
    }

    @WebMethod
    public boolean insertProduct(@WebParam(name = "arg0") Product newProduct) {
        return this.productService.insertProduct(newProduct);
    }

    @WebMethod
    public Product findProduct(@WebParam(name = "arg0") int code) {
        return this.productService.findProduct(code);
    }

    @WebMethod
    public boolean updateProduct(@WebParam(name = "arg0") int code, @WebParam(name = "arg1") Product update) {
        return this.updateProduct(code, update);
    }

    @WebMethod
    public boolean deleteProduct(@WebParam(name = "arg0") int code) {
        return this.deleteProduct(code);
    }
}
