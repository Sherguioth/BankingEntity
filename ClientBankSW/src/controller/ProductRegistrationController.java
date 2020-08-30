package controller;

import java.util.Date;
import java.util.GregorianCalendar;
import java.util.List;

import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;

import webservices.ProductRegistration;
import webservices.ProductRegistrationWebService;
import webservices.ProductRegistrationWebServiceSW;

public class ProductRegistrationController {

    private ProductRegistrationWebServiceSW productRegistrationWebServiceSW;
    private ProductRegistrationWebService productRegistrationWebService;

    public ProductRegistrationController() {
        this.productRegistrationWebServiceSW = new ProductRegistrationWebServiceSW();
        this.productRegistrationWebService = productRegistrationWebServiceSW.getProductRegistrationWebServicePort();
    }

    public List<ProductRegistration> listAllProductRegistrations() {
        List<ProductRegistration> listProductsRegistration = this.productRegistrationWebService.listAllProductRegistrationsService();

        return listProductsRegistration;
    }

    public boolean addProductRegistration(int idClient, int productCode, String strProductNumber, String strBalance,
                                          Date registrationDate, Date expirationDate, boolean state) throws Exception {
        if (strProductNumber.isEmpty() || strBalance.isEmpty() || registrationDate == null || expirationDate == null) {
            throw new Exception("Por favor diligenciar todos los campos");
        } else {
            int productNumber = 0;
            double balance = 0;

            try {
                productNumber = Integer.parseInt(strProductNumber);
            } catch (NumberFormatException ex) {
                throw new Exception("N�mero de producto invalido.\nPor favor digite un valor n�merico");
            }
            try {
                balance = Double.parseDouble(strBalance);
            } catch (NumberFormatException ex) {
                throw new Exception("Saldo invalido.\nPor favor digite un valor n�merico");
            }

            GregorianCalendar gDate = new GregorianCalendar();

            gDate.setTime(registrationDate);
            XMLGregorianCalendar xmlRegistrationDate = DatatypeFactory.newInstance().newXMLGregorianCalendar(gDate);
            gDate.setTime(expirationDate);
            XMLGregorianCalendar xmlExpirationDate = DatatypeFactory.newInstance().newXMLGregorianCalendar(gDate);

            ProductRegistration newProductRegistration = new ProductRegistration();
            newProductRegistration.setClientId(idClient);
            newProductRegistration.setProductCode(productCode);
            newProductRegistration.setProductNumber(productNumber);
            newProductRegistration.setBalance(balance);
            newProductRegistration.setRegistratioDate(xmlRegistrationDate);
            newProductRegistration.setExpirationDate(xmlExpirationDate);
            newProductRegistration.setState(state);

            if (this.productRegistrationWebService.insertProductRegistration(newProductRegistration)) {
                return true;
            } else {
                return false;
            }
        }
    }

    public ProductRegistration findProductRegistration(int idClient, String strProductCode) throws Exception {
        ProductRegistration productRegistration = null;
        int productCode = 0;
        try {
            productCode = Integer.parseInt(strProductCode);
        } catch (Exception ex) {
            throw new Exception("Por favor seleccione un producto");
        }

        productRegistration = this.productRegistrationWebService.findProductRegistration(idClient, productCode);

        if (productRegistration != null) {
            return productRegistration;
        } else {
            throw new Exception("No se ha encontrado el registro del producto");
        }
    }

    public boolean updateProductRegistrationint(int idClient, String strProductCode, String strProductNumber,
                                                String strBalance, Date registrationDate, Date expirationDate,
                                                boolean state) throws Exception {

        ProductRegistration productRegistrationToUpdate = null;
        try {
            productRegistrationToUpdate = this.findProductRegistration(idClient, strProductCode);
        } catch (Exception ex) {
            throw ex;
        }

        if (strProductNumber.isEmpty() || strBalance.isEmpty() || registrationDate == null || expirationDate == null) {
            throw new Exception("Por favor diligenciar todos los campos");
        } else {
            int productNumber = 0;
            int productCode = 0;
            double balance = 0;

            try {
                productCode = Integer.parseInt(strProductCode);
            } catch (Exception ex) {
                throw new Exception("Por favor seleccione un producto");
            }

            try {
                productNumber = Integer.parseInt(strProductNumber);
            } catch (NumberFormatException ex) {
                throw new Exception("N�mero de producto invalido.\nPor favor digite un valor n�merico");
            }
            try {
                balance = Double.parseDouble(strBalance);
            } catch (NumberFormatException ex) {
                throw new Exception("Saldo invalido.\nPor favor digite un valor n�merico");
            }

            GregorianCalendar gDate = new GregorianCalendar();

            gDate.setTime(registrationDate);
            XMLGregorianCalendar xmlRegistrationDate = DatatypeFactory.newInstance().newXMLGregorianCalendar(gDate);
            gDate.setTime(expirationDate);
            XMLGregorianCalendar xmlExpirationDate = DatatypeFactory.newInstance().newXMLGregorianCalendar(gDate);

            productRegistrationToUpdate.setClientId(idClient);
            productRegistrationToUpdate.setProductCode(productCode);
            productRegistrationToUpdate.setProductNumber(productNumber);
            productRegistrationToUpdate.setBalance(balance);
            productRegistrationToUpdate.setRegistratioDate(xmlRegistrationDate);
            productRegistrationToUpdate.setExpirationDate(xmlExpirationDate);
            productRegistrationToUpdate.setState(state);

            if (this.productRegistrationWebService.updateProductRegistration(productRegistrationToUpdate.getClientId(),
                                                                              productRegistrationToUpdate.getProductCode(),
                                                                              productRegistrationToUpdate)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
