package model;

import java.util.List;

import structural.Client;

public interface IClientService {

    List<Client> listAll();

    boolean insertClient(Client client);

    Client findClient(int identificationNumber);

    boolean updateClient(int identificationNumber, Client update);

    boolean deleteClient(int identificationNumber);
}
