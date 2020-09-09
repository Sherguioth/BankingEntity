package controller;

import java.util.Date;
import java.util.GregorianCalendar;
import java.util.List;

import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;

import view.Observer;

import webservices.Client;
import webservices.ClientWebService;
import webservices.ClientWebServiceSW;

public class ClientController {

    private ClientWebServiceSW clientWebServiceSW;
    private ClientWebService clientWebService;

    private Observer observer;

    public ClientController() {
        this.clientWebServiceSW = new ClientWebServiceSW();
        clientWebService = clientWebServiceSW.getClientWebServicePort();

        this.observer = Observer.getIstance();
    }

    public List<Client> listAllClients() {
        List<Client> listClients = clientWebService.listAllClients();

        return listClients;
    }

    public boolean addClient(String strIdNumber, String docType, String name, Date birthday, String email,
                             String phoneNumber, String gender) throws Exception {

        if (strIdNumber.isEmpty() || docType.isEmpty() || name.isEmpty() || birthday == null || email.isEmpty() ||
            phoneNumber.isEmpty() || gender.isEmpty()) {
            throw new Exception("Por favor diligenciar correctamente todos los campos");
        } else {
            int identificationNumber = 0;
            try {
                identificationNumber = Integer.parseInt(strIdNumber);
            } catch (NumberFormatException e) {
                System.out.println(e.getCause());
                throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
            }

            GregorianCalendar gDate = new GregorianCalendar();
            gDate.setTime(birthday);
            XMLGregorianCalendar date = DatatypeFactory.newInstance().newXMLGregorianCalendar(gDate);

            Client newClient = new Client();

            newClient.setIdentificationNumber(identificationNumber);
            newClient.setDocumetType(docType);
            newClient.setName(name);
            newClient.setBirthday(date);
            newClient.setEmail(email);
            newClient.setPhoneNumber(phoneNumber);
            newClient.setGender(gender);

            if (this.clientWebService.insertClient(newClient)) {
                observer.setClient(newClient);
                return true;
            } else {
                return false;
            }
        }
    }

    public Client findClientById(String strIdNumber) throws Exception {
        Client client = null;

        if (strIdNumber.isEmpty()) {
            throw new Exception("Por favor ingrese un número de identificación.");
        } else {
            int identificationNumber = 0;
            try {
                identificationNumber = Integer.parseInt(strIdNumber);
            } catch (NumberFormatException e) {
                System.out.println(e.getCause());
                throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
            }

            client = this.clientWebService.findClient(identificationNumber);
            observer.setClient(client);

            if (client != null) {
                return client;
            } else {
                throw new Exception("El cliente con el número de identificación " + identificationNumber +
                                    " no ha sido encontrado");
            }
        }
    }

    public boolean updateClient(String strIdNumber, String docType, String name, Date birthday, String email,
                                String phoneNumber, String gender) throws Exception {

        Client clientToUpdate = null;

        try {
            clientToUpdate = this.findClientById(strIdNumber);
        } catch (Exception ex) {
            throw ex;
        }

        if (strIdNumber.isEmpty() || docType.isEmpty() || name.isEmpty() || birthday == null || email.isEmpty() ||
            phoneNumber.isEmpty() || gender.isEmpty()) {
            throw new Exception("Por favor diligenciar correctamente todos los campos");
        } else {
            int identificationNumber = 0;
            try {
                identificationNumber = Integer.parseInt(strIdNumber);
            } catch (NumberFormatException e) {
                System.out.println(e.getCause());
                throw new Exception("Número de identificación invalido.\nPor favor introducir un valor numérico");
            }

            GregorianCalendar gDate = new GregorianCalendar();
            gDate.setTime(birthday);
            XMLGregorianCalendar date = DatatypeFactory.newInstance().newXMLGregorianCalendar(gDate);

            clientToUpdate.setIdentificationNumber(identificationNumber);
            clientToUpdate.setDocumetType(docType);
            clientToUpdate.setName(name);
            clientToUpdate.setBirthday(date);
            clientToUpdate.setEmail(email);
            clientToUpdate.setPhoneNumber(phoneNumber);
            clientToUpdate.setGender(gender);

            if (this.clientWebService.updateClient(clientToUpdate.getIdentificationNumber(), clientToUpdate)) {
                observer.setClient(clientToUpdate);
                return true;
            } else {
                return false;
            }
        }
    }

    public boolean deleteClient(String strIdNumber) throws Exception {
        Client clientToDelete = null;

        try {
            clientToDelete = this.findClientById(strIdNumber);
        } catch (Exception ex) {
            throw ex;
        }

        if (this.clientWebService.deleteClient(clientToDelete.getIdentificationNumber())) {
            this.observer.setClient(null);
            return true;
        } else {
            return false;
        }
    }
}
