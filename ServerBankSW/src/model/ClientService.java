package model;

import java.util.ArrayList;
import java.util.List;

import structural.Client;

public class ClientService implements IClientService{

    private List<Client> DB;

    public ClientService() {
        super();
        this.DB = new ArrayList<>();
    }

    public List<Client> listAll() {
        return this.DB;
    }

    public boolean insertClient(Client newClient) {
        Client client = this.findClient(newClient.getIdentificationNumber());

        if (client != null) {
            return false;
        }

        this.DB.add(newClient);
        return true;
    }

    public Client findClient(int identificationNumber) {
        for (Client client : this.DB) {
            if (client.getIdentificationNumber() == identificationNumber) {
                return client;
            }
        }

        return null;
    }

    public boolean updateClient(int identificationNumber, Client update){
        Client client = this.findClient(identificationNumber);
        int posClient = this.DB.indexOf(client);
        if (posClient >= 0) {
            this.DB.set(posClient,
                        new Client(identificationNumber, update.getName(), update.getBirthday(), update.getEmail(),
                                   update.getPhoneNumber(), update.getBalance()));
            return true;
        }

        return false;
    }

    public boolean deleteClient(int identificationNumber){
        Client client = this.findClient(identificationNumber);
        if (client == null) {
            return false;
        } else {
            this.DB.remove(client);
            return true;
        }
    }
}
