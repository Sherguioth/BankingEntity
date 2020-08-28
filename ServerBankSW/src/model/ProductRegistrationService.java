package model;

import conn.Conexion;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import structural.ProductRegistration;

public class ProductRegistrationService implements IProductRegistrationService {

    private final Conexion conn;

    public ProductRegistrationService() {
        super();
        this.conn = Conexion.getInstance();
    }

    @Override
    public List<ProductRegistration> listAll() {
        List<ProductRegistration> registrationProductList = new ArrayList<>();

        String sql =
            "SELECT client_id, product_code, registration_date, balance, product_number, expiration_date, state " +
            "FROM public.products_registration;";

        PreparedStatement statement = conn.getPreparedStatement(sql);
        ResultSet rs = conn.getQuery(statement);

        try {
            while (rs.next()) {
                ProductRegistration registration = new ProductRegistration();

                registration.setClientId(rs.getInt(1));
                registration.setProductCode(rs.getInt(2));
                registration.setRegistratioDate(rs.getDate(3));
                registration.setBalance(rs.getDouble(4));
                registration.setProductNumber(rs.getInt(5));
                registration.setExpirationDate(rs.getDate(6));
                registration.setState(rs.getBoolean(7));

                registrationProductList.add(registration);
            }
        } catch (SQLException ex) {
            Logger.getLogger(ProductRegistration.class.getName()).log(Level.SEVERE, null, ex);
        }

        return registrationProductList;
    }

    @Override
    public boolean insertProductoRegistration(ProductRegistration newRegistration) {
        String sql =
            "INSERT INTO public.products_registration(client_id, product_code, registration_date, balance, product_number, expiration_date, state) " +
            "VALUES (?, ?, ?, ?, ?, ?, ?);";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, newRegistration.getClientId());
            statement.setInt(2, newRegistration.getProductCode());
            statement.setDate(3, newRegistration.getRegistratioDate());
            statement.setDouble(4, newRegistration.getBalance());
            statement.setInt(5, newRegistration.getProductNumber());
            statement.setDate(6, newRegistration.getExpirationDate());
            statement.setBoolean(7, newRegistration.getState());

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ProductRegistrationService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }

    @Override
    public ProductRegistration findProductoRegistration(int clientId, int productCode) {
        String sql =
            "SELECT client_id, product_code, registration_date, balance, product_number, expiration_date, state " +
            "FROM public.products_registration WHERE client_id = ? OR product_code = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, clientId);
            statement.setInt(2, productCode);

            ResultSet rs = conn.getQuery(statement);

            while (rs.next()) {
                ProductRegistration registration = new ProductRegistration();

                registration.setClientId(rs.getInt(1));
                registration.setProductCode(rs.getInt(2));
                registration.setRegistratioDate(rs.getDate(3));
                registration.setBalance(rs.getDouble(4));
                registration.setProductNumber(rs.getInt(5));
                registration.setExpirationDate(rs.getDate(6));
                registration.setState(rs.getBoolean(7));

                return registration;
            }
        } catch (SQLException ex) {
            Logger.getLogger(ProductRegistrationService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return null;
    }

    @Override
    public boolean updateProductoRegistration(int clientId, int productCode, ProductRegistration update) {
        String sql =
            "UPDATE public.products_registration SET client_id=?, product_code=?, registration_date=?, balance=?, product_number=?, expiration_date=?, state=? " +
            "WHERE client_id = ? AND product_code = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, update.getClientId());
            statement.setInt(2, update.getProductCode());
            statement.setDate(3, update.getRegistratioDate());
            statement.setDouble(4, update.getBalance());
            statement.setInt(5, update.getProductNumber());
            statement.setDate(6, update.getExpirationDate());
            statement.setBoolean(7, update.getState());

            statement.setInt(8, clientId);
            statement.setInt(9, productCode);

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ProductRegistrationService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }

    @Override
    public boolean deleteProductoRegistration(int clientId, int productCode) {
        String sql = "DELETE FROM public.products_registration WHERE client_id = ? AND product_code = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, clientId);
            statement.setInt(2, productCode);

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ProductRegistrationService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }
}
