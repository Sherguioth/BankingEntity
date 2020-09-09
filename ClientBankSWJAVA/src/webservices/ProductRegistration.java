
package webservices;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.datatype.XMLGregorianCalendar;


/**
 * <p>Java class for productRegistration complex type.
 *
 * <p>The following schema fragment specifies the expected content contained within this class.
 *
 * <pre>
 * &lt;complexType name="productRegistration">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="balance" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *         &lt;element name="clientId" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="expirationDate" type="{http://www.w3.org/2001/XMLSchema}date" minOccurs="0"/>
 *         &lt;element name="productCode" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="productNumber" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="registratioDate" type="{http://www.w3.org/2001/XMLSchema}date" minOccurs="0"/>
 *         &lt;element name="state" type="{http://www.w3.org/2001/XMLSchema}boolean"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 *
 *
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "productRegistration", propOrder = {
         "balance", "clientId", "expirationDate", "productCode", "productNumber", "registratioDate", "state"
    })
public class ProductRegistration {

    protected double balance;
    protected int clientId;
    @XmlSchemaType(name = "date")
    protected XMLGregorianCalendar expirationDate;
    protected int productCode;
    protected int productNumber;
    @XmlSchemaType(name = "date")
    protected XMLGregorianCalendar registratioDate;
    protected boolean state;

    /**
     * Gets the value of the balance property.
     *
     */
    public double getBalance() {
        return balance;
    }

    /**
     * Sets the value of the balance property.
     *
     */
    public void setBalance(double value) {
        this.balance = value;
    }

    /**
     * Gets the value of the clientId property.
     *
     */
    public int getClientId() {
        return clientId;
    }

    /**
     * Sets the value of the clientId property.
     *
     */
    public void setClientId(int value) {
        this.clientId = value;
    }

    /**
     * Gets the value of the expirationDate property.
     *
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *
     */
    public XMLGregorianCalendar getExpirationDate() {
        return expirationDate;
    }

    /**
     * Sets the value of the expirationDate property.
     *
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *
     */
    public void setExpirationDate(XMLGregorianCalendar value) {
        this.expirationDate = value;
    }

    /**
     * Gets the value of the productCode property.
     *
     */
    public int getProductCode() {
        return productCode;
    }

    /**
     * Sets the value of the productCode property.
     *
     */
    public void setProductCode(int value) {
        this.productCode = value;
    }

    /**
     * Gets the value of the productNumber property.
     *
     */
    public int getProductNumber() {
        return productNumber;
    }

    /**
     * Sets the value of the productNumber property.
     *
     */
    public void setProductNumber(int value) {
        this.productNumber = value;
    }

    /**
     * Gets the value of the registratioDate property.
     *
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *
     */
    public XMLGregorianCalendar getRegistratioDate() {
        return registratioDate;
    }

    /**
     * Sets the value of the registratioDate property.
     *
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *
     */
    public void setRegistratioDate(XMLGregorianCalendar value) {
        this.registratioDate = value;
    }

    /**
     * Gets the value of the state property.
     *
     */
    public boolean isState() {
        return state;
    }

    /**
     * Sets the value of the state property.
     *
     */
    public void setState(boolean value) {
        this.state = value;
    }

}
