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

import model.ClientService;
import model.IClientService;

import structural.Client;

@Path("webServices/Client")
public class ClientWebService {

    private IClientService clientService;

    public ClientWebService() {
        super();
        clientService = new ClientService();
    }

    @GET
    @Produces("application/json")
    @Path("listAllClients")
    public List<Client> listAllClients() {
        return this.clientService.listAll();
    }

    @POST
    @Consumes("application/json")
    @Produces("application/json")
    @Path("insertClient")
    public boolean insertClient(Client newClient) {
        return this.clientService.insertClient(newClient);
    }

    @GET
    @Produces("application/json")
    @Path("findClient")
    public Client findClient(@QueryParam("clientId") int identificationNumber) {
        return this.clientService.findClient(identificationNumber);
    }

    @PUT
    @Consumes("application/json")
    @Produces("application/json")
    @Path("updateClient")
    public boolean updateClient(@QueryParam("clientId") int identificationNumber, Client update) {
        return this.clientService.updateClient(identificationNumber, update);
    }

    @DELETE
    @Produces("application/json")
    @Path("deleteClient")
    public boolean deleteClient(@QueryParam("clientId") int identificationNumber) {
        return this.clientService.deleteClient(identificationNumber);
    }
}
