package conn;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Conexion {

    private static Conexion conexion;

    private Connection connection;
    private Statement statement;

    private Conexion() {
        super();
        try {
            Class.forName("org.postgresql.Driver"); 
            
            String url = "jdbc:postgresql://localhost:5432/bank_soa";
            String user = "postgres";
            String password = "postgres";

            connection = DriverManager.getConnection(url, user, password);
            statement = (Statement) connection.createStatement();

            System.out.println("Conexion a la base de datos exitosa");
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    public static Conexion getInstance() {
        if (conexion == null) {
            conexion = new Conexion();
            return conexion;
        }

        return conexion;
    }

    public PreparedStatement getPreparedStatement(String sql) {
        PreparedStatement pStatement = null;

        try {
            pStatement = connection.prepareStatement(sql);
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return pStatement;
    }

    public ResultSet getQuery(PreparedStatement preparedStatement) {
        ResultSet resultSet = null;

        try {
            resultSet = preparedStatement.executeQuery();
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return resultSet;
    }

    public boolean executeQuery(PreparedStatement preparedStatement) {
        boolean execute = false;

        try {
            execute = preparedStatement.execute();
            return true;
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return execute;
    }
}
