package webServices;

import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

import model.IProductRegistrationService;
import model.ProductRegistrationService;

@WebService(serviceName = "ProductRegistrationWebServiceSW")
public class ProductRegistrationWebService {

    private IProductRegistrationService productRegistrationService;

    public ProductRegistrationWebService() {
        super();
        this.productRegistrationService = new ProductRegistrationService();
    }

    @WebMethod
    public List<structural.ProductRegistration> listAllRegistrationService() {
        return this.productRegistrationService.listAll();
    }

    @WebMethod
    public boolean insertProductoRegistration(@WebParam(name = "arg0") structural.ProductRegistration newRegistration) {
        return this.productRegistrationService.insertProductoRegistration(newRegistration);
    }

    @WebMethod
    public structural.ProductRegistration findProductoRegistration(@WebParam(name = "arg0") int clientId,
                                                                   @WebParam(name = "arg1") int productCode) {
        return this.productRegistrationService.findProductoRegistration(clientId, productCode);
    }

    @WebMethod
    public boolean updateProductoRegistration(@WebParam(name = "arg0") int clientId,
                                              @WebParam(name = "arg1") int productCode,
                                              @WebParam(name = "arg2") structural.ProductRegistration update) {
        return this.productRegistrationService.updateProductoRegistration(clientId, productCode, update);
    }

    @WebMethod
    public boolean deleteProductoRegistration(@WebParam(name = "arg0") int clientId,
                                              @WebParam(name = "arg1") int productCode) {
        return this.productRegistrationService.deleteProductoRegistration(clientId, productCode);
    }
}
