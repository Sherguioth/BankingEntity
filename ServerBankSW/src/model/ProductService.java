package model;

import conn.Conexion;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import structural.Product;

public class ProductService implements IProductService {

    private final Conexion conn;

    public ProductService() {
        this.conn = Conexion.getInstance();
    }

    @Override
    public List<Product> listAll() {
        List<Product> productList = new ArrayList<>();

        String sql = "SELECT code, name, \"desc\", type_product, state FROM public.products;";

        PreparedStatement statement = conn.getPreparedStatement(sql);
        ResultSet rs = conn.getQuery(statement);

        try {
            while (rs.next()) {
                Product product = new Product();

                product.setCode(rs.getInt(1));
                product.setName(rs.getString(2));
                product.setDesc(rs.getString(3));
                product.setTypeProduct(rs.getString(4));
                product.setSate(rs.getBoolean(5));

                productList.add(product);
            }
        } catch (SQLException ex) {
            Logger.getLogger(ProductService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return productList;
    }

    @Override
    public boolean insertProduct(Product newProduct) {
        String sql = "INSERT INTO public.products(code, name, \"desc\", type_product, state) VALUES (?, ?, ?, ?, ?);";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, newProduct.getCode());
            statement.setString(2, newProduct.getName());
            statement.setString(3, newProduct.getDesc());
            statement.setString(4, newProduct.getTypeProduct());
            statement.setBoolean(5, newProduct.getSate());

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ProductService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }

    @Override
    public Product findProduct(int code) {
        String sql = "SELECT code, name, \"desc\", type_product, state FROM public.products WHERE code = ?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, code);
            ResultSet rs = conn.getQuery(statement);

            while (rs.next()) {
                Product product = new Product();

                product.setCode(rs.getInt(1));
                product.setName(rs.getString(2));
                product.setDesc(rs.getString(3));
                product.setTypeProduct(rs.getString(4));
                product.setSate(rs.getBoolean(5));

                return product;
            }
        } catch (SQLException ex) {
            Logger.getLogger(ProductService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return null;
    }

    @Override
    public boolean updateProduct(int code, Product update) {
        String sql = "UPDATE public.products SET code=?, name=?, \"desc\"=?, type_product=?, state=? WHERE code=?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, update.getCode());
            statement.setString(2, update.getName());
            statement.setString(3, update.getDesc());
            statement.setString(4, update.getTypeProduct());
            statement.setBoolean(5, update.getSate());

            statement.setInt(1, code);

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ProductService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }

    @Override
    public boolean deleteProduct(int code) {
        String sql = "DELETE FROM public.products WHERE code=?;";

        PreparedStatement statement = conn.getPreparedStatement(sql);

        try {
            statement.setInt(1, code);

            return conn.executeQuery(statement);
        } catch (SQLException ex) {
            Logger.getLogger(ProductService.class.getName()).log(Level.SEVERE, null, ex);
        }

        return false;
    }
}
