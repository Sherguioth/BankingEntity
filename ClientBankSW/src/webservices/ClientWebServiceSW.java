
package webservices;

import java.net.MalformedURLException;
import java.net.URL;

import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.10-b140319.1121
 * Generated source version: 2.2
 *
 */
@WebServiceClient(name = "ClientWebServiceSW", targetNamespace = "http://webServices/",
                  wsdlLocation =
                  "http://localhost:7101/ServerBankSW/ClientWebServiceSW?WSDL#%7Bhttp%3A%2F%2FwebServices%2F%7DClientWebServiceSW")
public class ClientWebServiceSW extends Service {

    private final static URL CLIENTWEBSERVICESW_WSDL_LOCATION;
    private final static WebServiceException CLIENTWEBSERVICESW_EXCEPTION;
    private final static QName CLIENTWEBSERVICESW_QNAME = new QName("http://webServices/", "ClientWebServiceSW");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url =
                new URL("http://localhost:7101/ServerBankSW/ClientWebServiceSW?WSDL#%7Bhttp%3A%2F%2FwebServices%2F%7DClientWebServiceSW");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        CLIENTWEBSERVICESW_WSDL_LOCATION = url;
        CLIENTWEBSERVICESW_EXCEPTION = e;
    }

    public ClientWebServiceSW() {
        super(__getWsdlLocation(), CLIENTWEBSERVICESW_QNAME);
    }

    public ClientWebServiceSW(WebServiceFeature... features) {
        super(__getWsdlLocation(), CLIENTWEBSERVICESW_QNAME, features);
    }

    public ClientWebServiceSW(URL wsdlLocation) {
        super(wsdlLocation, CLIENTWEBSERVICESW_QNAME);
    }

    public ClientWebServiceSW(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, CLIENTWEBSERVICESW_QNAME, features);
    }

    public ClientWebServiceSW(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public ClientWebServiceSW(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     *
     * @return
     *     returns ClientWebService
     */
    @WebEndpoint(name = "ClientWebServicePort")
    public ClientWebService getClientWebServicePort() {
        return super.getPort(new QName("http://webServices/", "ClientWebServicePort"), ClientWebService.class);
    }

    /**
     *
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns ClientWebService
     */
    @WebEndpoint(name = "ClientWebServicePort")
    public ClientWebService getClientWebServicePort(WebServiceFeature... features) {
        return super.getPort(new QName("http://webServices/", "ClientWebServicePort"), ClientWebService.class,
                             features);
    }

    private static URL __getWsdlLocation() {
        if (CLIENTWEBSERVICESW_EXCEPTION != null) {
            throw CLIENTWEBSERVICESW_EXCEPTION;
        }
        return CLIENTWEBSERVICESW_WSDL_LOCATION;
    }

}
