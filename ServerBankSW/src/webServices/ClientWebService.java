package webServices;

import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

import model.ClientService;
import model.IClientService;

import structural.Client;

@WebService(serviceName = "ClientWebServiceSW")
public class ClientWebService {

    private IClientService clientService;

    public ClientWebService() {
        super();
        clientService = new ClientService();
    }

    @WebMethod
    public List<Client> listAllClients() {
        return this.clientService.listAll();
    }

    @WebMethod
    public boolean insertClient(@WebParam(name = "arg0") Client newClient) {
        return this.clientService.insertClient(newClient);
    }

    @WebMethod
    public Client findClient(@WebParam(name = "arg0") int identificationNumber) {
        return this.clientService.findClient(identificationNumber);
    }

    @WebMethod
    public boolean updateClient(@WebParam(name = "arg0") int identificationNumber,
                                @WebParam(name = "arg1") Client update) {
        return this.clientService.updateClient(identificationNumber, update);
    }

    @WebMethod
    public boolean deleteClient(@WebParam(name = "arg0") int identificationNumber) {
        return this.clientService.deleteClient(identificationNumber);
    }
}
