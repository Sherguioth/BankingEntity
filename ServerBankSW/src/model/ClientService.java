package model;

import conn.Conexion;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import structural.Client;

public class ClientService implements IClientService {

    private final Conexion conn;

    public ClientService() {
        conn = Conexion.getInstance();
    }

    @Override
    public List<Client> listAll() {
        List<Client> clientList = new ArrayList<>();

        String sql =
            "SELECT identification_number, document_type, name, birthday, email, phone_number, gender " +
            "FROM public.clients;";

        PreparedStatement statement = conn.getPreparedStatement(sql);
        ResultSet rs = conn.getQuery(statement);

        try {
            while (rs.next()) {
                Client client = new Client();

                client.setIdentificationNumber(rs.getInt(1));
                client.setDocumetType(rs.getString(2));
                client.setName(rs.getString(3));
                client.setBirthday(rs.getDate(4));
                client.setEmail(rs.getString(5));
                client.setPhoneNumber(rs.getString(6));
                client.setGender(rs.getString(7));

                clientList.add(client);
            }
        } catch (SQLException ex) {
            Logger.getLogger(ClientService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return clientList;
    }

    @Override
    public boolean insertClient(Client newClient) {
        String sql =
            "INSERT INTO public.clients(identification_number, document_type, name, birthday, email, phone_number, gender)" +
            " VALUES (?, ?, ?, ?, ?, ?, ?);";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, newClient.getIdentificationNumber());
            statement.setString(2, newClient.getDocumetType());
            statement.setString(3, newClient.getName());
            statement.setDate(4, newClient.getBirthday());
            statement.setString(5, newClient.getEmail());
            statement.setString(6, newClient.getPhoneNumber());
            statement.setString(7, newClient.getGender());

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ClientService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }

    @Override
    public Client findClient(int identificationNumber) {
        String sql =
            "SELECT identification_number, document_type, name, birthday, email, phone_number, gender " +
            "FROM public.clients  WHERE identification_number = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, identificationNumber);
            ResultSet rs = conn.getQuery(statement);

            while (rs.next()) {
                Client client = new Client();

                client.setIdentificationNumber(rs.getInt(1));
                client.setDocumetType(rs.getString(2));
                client.setName(rs.getString(3));
                client.setBirthday(rs.getDate(4));
                client.setEmail(rs.getString(5));
                client.setPhoneNumber(rs.getString(6));
                client.setGender(rs.getString(7));

                return client;
            }

        } catch (SQLException ex) {
            Logger.getLogger(ClientService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return null;
    }

    @Override
    public boolean updateClient(int identificationNumber, Client update) {
        String sql =
            "UPDATE public.clients SET identification_number=?, document_type=?, name=?, " +
            "birthday=?, email=?, phone_number=?, gender=? WHERE identification_number = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, update.getIdentificationNumber());
            statement.setString(2, update.getDocumetType());
            statement.setString(3, update.getName());
            statement.setDate(4, update.getBirthday());
            statement.setString(5, update.getEmail());
            statement.setString(6, update.getPhoneNumber());
            statement.setString(7, update.getGender());

            statement.setInt(8, identificationNumber);

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ClientService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }

    @Override
    public boolean deleteClient(int identificationNumber) {
        String sql = "DELETE FROM public.clients WHERE identification_number = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, identificationNumber);

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ClientService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }
}
