
package webservices;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for findProductoRegistrationResponse complex type.
 *
 * <p>The following schema fragment specifies the expected content contained within this class.
 *
 * <pre>
 * &lt;complexType name="findProductoRegistrationResponse">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="return" type="{http://webServices/}productRegistration" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 *
 *
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "findProductoRegistrationResponse", propOrder = { "_return" })
public class FindProductoRegistrationResponse {

    @XmlElement(name = "return")
    protected ProductRegistration _return;

    /**
     * Gets the value of the return property.
     *
     * @return
     *     possible object is
     *     {@link ProductRegistration }
     *
     */
    public ProductRegistration getReturn() {
        return _return;
    }

    /**
     * Sets the value of the return property.
     *
     * @param value
     *     allowed object is
     *     {@link ProductRegistration }
     *
     */
    public void setReturn(ProductRegistration value) {
        this._return = value;
    }

}
