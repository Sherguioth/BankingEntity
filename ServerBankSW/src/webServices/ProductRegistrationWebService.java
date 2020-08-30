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
    public List<structural.ProductRegistration> listAllProductRegistrationsService() {
        return this.productRegistrationService.listAll();
    }

    @WebMethod
    public boolean insertProductRegistration(@WebParam(name = "arg0") structural.ProductRegistration newRegistration) {
        return this.productRegistrationService.insertProductRegistration(newRegistration);
    }

    @WebMethod
    public structural.ProductRegistration findProductRegistration(@WebParam(name = "arg0") int clientId,
                                                                   @WebParam(name = "arg1") int productCode) {
        return this.productRegistrationService.findProductRegistration(clientId, productCode);
    }

    @WebMethod
    public boolean updateProductRegistration(@WebParam(name = "arg0") int clientId,
                                              @WebParam(name = "arg1") int productCode,
                                              @WebParam(name = "arg2") structural.ProductRegistration update) {
        return this.productRegistrationService.updateProductRegistration(clientId, productCode, update);
    }

    @WebMethod
    public boolean deleteProductRegistration(@WebParam(name = "arg0") int clientId,
                                              @WebParam(name = "arg1") int productCode) {
        return this.productRegistrationService.deleteProductRegistration(clientId, productCode);
    }
}
