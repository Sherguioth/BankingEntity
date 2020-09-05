package structural;

import java.sql.Date;

import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "ProductRegistration")
public class ProductRegistration {

    private int clientId;
    private int productCode;
    private Date registratioDate;
    private double balance;
    private int productNumber;
    private Date expirationDate;
    private boolean state;

    public ProductRegistration() {
        super();
    }

    public ProductRegistration(int clientId, int productCode, Date registratioDate, double balance, int productNumber,
                                Date expirationDate, boolean state) {
        super();
        this.clientId = clientId;
        this.productCode = productCode;
        this.registratioDate = registratioDate;
        this.balance = balance;
        this.productNumber = productNumber;
        this.expirationDate = expirationDate;
        this.state = state;
    }

    public int getClientId() {
        return clientId;
    }

    public void setClientId(int clientId) {
        this.clientId = clientId;
    }

    public int getProductCode() {
        return productCode;
    }

    public void setProductCode(int productCode) {
        this.productCode = productCode;
    }

    public Date getRegistratioDate() {
        return registratioDate;
    }

    public void setRegistratioDate(Date registratioDate) {
        this.registratioDate = registratioDate;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public int getProductNumber() {
        return productNumber;
    }

    public void setProductNumber(int productNumber) {
        this.productNumber = productNumber;
    }

    public Date getExpirationDate() {
        return expirationDate;
    }

    public void setExpirationDate(Date expirationDate) {
        this.expirationDate = expirationDate;
    }

    public boolean getState() {
        return state;
    }

    public void setState(boolean state) {
        this.state = state;
    }

    @Override
    public String toString() {
        return "RegistrationProduct{" + "clientId=" + clientId + ", productCode=" + productCode + ", registratioDate=" +
               registratioDate + ", balance=" + balance + ", productNumber=" + productNumber + ", expirationDate=" +
               expirationDate + ", state=" + state + '}';
    }
}
