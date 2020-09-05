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

import model.IProductService;
import model.ProductService;

import structural.Product;

@Path("webServices/Product")
public class ProductWebService {

    private IProductService productService;

    public ProductWebService() {
        super();
        this.productService = new ProductService();
    }

    @GET
    @Produces("application/json")
    @Path("listAllProducts")
    public List<Product> listAllProducts() {
        return this.productService.listAll();
    }

    @POST
    @Consumes("application/json")
    @Produces("application/json")
    @Path("insertProduct")
    public boolean insertProduct(Product newProduct) {
        return this.productService.insertProduct(newProduct);
    }

    @GET
    @Produces("application/json")
    @Path("findProduct")
    public Product findProduct(@QueryParam("code") int code) {
        return this.productService.findProduct(code);
    }

    @PUT
    @Consumes("application/json")
    @Produces("application/json")
    @Path("updateProduct")
    public boolean updateProduct(@QueryParam("code") int code, Product update) {
        return this.productService.updateProduct(code, update);
    }

    @DELETE
    @Produces("application/json")
    @Path("deleteProduct")
    public boolean deleteProduct(@QueryParam("code") int code) {
        return this.productService.deleteProduct(code);
    }
}
