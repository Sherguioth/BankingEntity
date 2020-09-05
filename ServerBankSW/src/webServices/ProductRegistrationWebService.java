package webServices;

import java.util.List;

import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;

import model.IProductRegistrationService;
import model.ProductRegistrationService;

import structural.ProductRegistration;

@Path("webServices/ProductRegistration")
public class ProductRegistrationWebService {

    private IProductRegistrationService productRegistrationService;

    public ProductRegistrationWebService() {
        super();
        this.productRegistrationService = new ProductRegistrationService();
    }

    @GET
    @Produces("application/json")
    @Path("listAllProductRegistrations")
    public List<ProductRegistration> listAllProductRegistrations() {
        return this.productRegistrationService.listAll();
    }

    @POST
    @Consumes("application/json")
    @Produces("application/json")
    @Path("insertProductRegistration")
    public boolean insertProductRegistration(ProductRegistration newRegistration) {
        return this.productRegistrationService.insertProductRegistration(newRegistration);
    }

    @GET
    @Produces("application/json")
    @Path("findProductRegistration")
    public ProductRegistration findProductRegistration(@QueryParam("clientId") int clientId,
                                                                  @QueryParam("productCode") int productCode) {
        return this.productRegistrationService.findProductRegistration(clientId, productCode);
    }

    @PUT
    @Consumes("application/json")
    @Produces("application/json")
    @Path("updateProductRegistration")
    public boolean updateProductRegistration(@QueryParam("clientId") int clientId,
                                             @QueryParam("productCode") int productCode, ProductRegistration update) {
        return this.productRegistrationService.updateProductRegistration(clientId, productCode, update);
    }

    @DELETE
    @Produces("application/json")
    @Path("deleteProductRegistration")
    public boolean deleteProductRegistration(@QueryParam("clientId") int clientId,
                                             @QueryParam("productCode") int productCode) {
        return this.productRegistrationService.deleteProductRegistration(clientId, productCode);
    }
}
