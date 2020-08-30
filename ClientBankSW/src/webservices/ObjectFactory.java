
package webservices;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each
 * Java content interface and Java element interface
 * generated in the webservices package.
 * <p>An ObjectFactory allows you to programatically
 * construct new instances of the Java representation
 * for XML content. The Java representation of XML
 * content can consist of schema derived interfaces
 * and classes representing the binding of schema
 * type definitions, element declarations and model
 * groups.  Factory methods for each of these are
 * provided in this class.
 *
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _DeleteProductoRegistration_QNAME =
        new QName("http://webServices/", "deleteProductoRegistration");
    private final static QName _ListAllRegistrationServiceResponse_QNAME =
        new QName("http://webServices/", "listAllRegistrationServiceResponse");
    private final static QName _DeleteProductoRegistrationResponse_QNAME =
        new QName("http://webServices/", "deleteProductoRegistrationResponse");
    private final static QName _InsertProductoRegistration_QNAME =
        new QName("http://webServices/", "insertProductoRegistration");
    private final static QName _FindProductoRegistration_QNAME =
        new QName("http://webServices/", "findProductoRegistration");
    private final static QName _ListAllRegistrationService_QNAME =
        new QName("http://webServices/", "listAllRegistrationService");
    private final static QName _InsertProductoRegistrationResponse_QNAME =
        new QName("http://webServices/", "insertProductoRegistrationResponse");
    private final static QName _FindProductoRegistrationResponse_QNAME =
        new QName("http://webServices/", "findProductoRegistrationResponse");
    private final static QName _UpdateProductoRegistrationResponse_QNAME =
        new QName("http://webServices/", "updateProductoRegistrationResponse");
    private final static QName _UpdateProductoRegistration_QNAME =
        new QName("http://webServices/", "updateProductoRegistration");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: webservices
     *
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link FindProductoRegistration }
     *
     */
    public FindProductoRegistration createFindProductoRegistration() {
        return new FindProductoRegistration();
    }

    /**
     * Create an instance of {@link InsertProductoRegistrationResponse }
     *
     */
    public InsertProductoRegistrationResponse createInsertProductoRegistrationResponse() {
        return new InsertProductoRegistrationResponse();
    }

    /**
     * Create an instance of {@link ListAllRegistrationService }
     *
     */
    public ListAllRegistrationService createListAllRegistrationService() {
        return new ListAllRegistrationService();
    }

    /**
     * Create an instance of {@link DeleteProductoRegistration }
     *
     */
    public DeleteProductoRegistration createDeleteProductoRegistration() {
        return new DeleteProductoRegistration();
    }

    /**
     * Create an instance of {@link DeleteProductoRegistrationResponse }
     *
     */
    public DeleteProductoRegistrationResponse createDeleteProductoRegistrationResponse() {
        return new DeleteProductoRegistrationResponse();
    }

    /**
     * Create an instance of {@link ListAllRegistrationServiceResponse }
     *
     */
    public ListAllRegistrationServiceResponse createListAllRegistrationServiceResponse() {
        return new ListAllRegistrationServiceResponse();
    }

    /**
     * Create an instance of {@link InsertProductoRegistration }
     *
     */
    public InsertProductoRegistration createInsertProductoRegistration() {
        return new InsertProductoRegistration();
    }

    /**
     * Create an instance of {@link UpdateProductoRegistrationResponse }
     *
     */
    public UpdateProductoRegistrationResponse createUpdateProductoRegistrationResponse() {
        return new UpdateProductoRegistrationResponse();
    }

    /**
     * Create an instance of {@link UpdateProductoRegistration }
     *
     */
    public UpdateProductoRegistration createUpdateProductoRegistration() {
        return new UpdateProductoRegistration();
    }

    /**
     * Create an instance of {@link FindProductoRegistrationResponse }
     *
     */
    public FindProductoRegistrationResponse createFindProductoRegistrationResponse() {
        return new FindProductoRegistrationResponse();
    }

    /**
     * Create an instance of {@link ProductRegistration }
     *
     */
    public ProductRegistration createProductRegistration() {
        return new ProductRegistration();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link DeleteProductoRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "deleteProductoRegistration")
    public JAXBElement<DeleteProductoRegistration> createDeleteProductoRegistration(DeleteProductoRegistration value) {
        return new JAXBElement<DeleteProductoRegistration>(_DeleteProductoRegistration_QNAME,
                                                           DeleteProductoRegistration.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListAllRegistrationServiceResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "listAllRegistrationServiceResponse")
    public JAXBElement<ListAllRegistrationServiceResponse> createListAllRegistrationServiceResponse(ListAllRegistrationServiceResponse value) {
        return new JAXBElement<ListAllRegistrationServiceResponse>(_ListAllRegistrationServiceResponse_QNAME,
                                                                   ListAllRegistrationServiceResponse.class, null,
                                                                   value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link DeleteProductoRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "deleteProductoRegistrationResponse")
    public JAXBElement<DeleteProductoRegistrationResponse> createDeleteProductoRegistrationResponse(DeleteProductoRegistrationResponse value) {
        return new JAXBElement<DeleteProductoRegistrationResponse>(_DeleteProductoRegistrationResponse_QNAME,
                                                                   DeleteProductoRegistrationResponse.class, null,
                                                                   value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link InsertProductoRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "insertProductoRegistration")
    public JAXBElement<InsertProductoRegistration> createInsertProductoRegistration(InsertProductoRegistration value) {
        return new JAXBElement<InsertProductoRegistration>(_InsertProductoRegistration_QNAME,
                                                           InsertProductoRegistration.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FindProductoRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "findProductoRegistration")
    public JAXBElement<FindProductoRegistration> createFindProductoRegistration(FindProductoRegistration value) {
        return new JAXBElement<FindProductoRegistration>(_FindProductoRegistration_QNAME,
                                                         FindProductoRegistration.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListAllRegistrationService }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "listAllRegistrationService")
    public JAXBElement<ListAllRegistrationService> createListAllRegistrationService(ListAllRegistrationService value) {
        return new JAXBElement<ListAllRegistrationService>(_ListAllRegistrationService_QNAME,
                                                           ListAllRegistrationService.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link InsertProductoRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "insertProductoRegistrationResponse")
    public JAXBElement<InsertProductoRegistrationResponse> createInsertProductoRegistrationResponse(InsertProductoRegistrationResponse value) {
        return new JAXBElement<InsertProductoRegistrationResponse>(_InsertProductoRegistrationResponse_QNAME,
                                                                   InsertProductoRegistrationResponse.class, null,
                                                                   value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FindProductoRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "findProductoRegistrationResponse")
    public JAXBElement<FindProductoRegistrationResponse> createFindProductoRegistrationResponse(FindProductoRegistrationResponse value) {
        return new JAXBElement<FindProductoRegistrationResponse>(_FindProductoRegistrationResponse_QNAME,
                                                                 FindProductoRegistrationResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link UpdateProductoRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "updateProductoRegistrationResponse")
    public JAXBElement<UpdateProductoRegistrationResponse> createUpdateProductoRegistrationResponse(UpdateProductoRegistrationResponse value) {
        return new JAXBElement<UpdateProductoRegistrationResponse>(_UpdateProductoRegistrationResponse_QNAME,
                                                                   UpdateProductoRegistrationResponse.class, null,
                                                                   value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link UpdateProductoRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "updateProductoRegistration")
    public JAXBElement<UpdateProductoRegistration> createUpdateProductoRegistration(UpdateProductoRegistration value) {
        return new JAXBElement<UpdateProductoRegistration>(_UpdateProductoRegistration_QNAME,
                                                           UpdateProductoRegistration.class, null, value);
    }

}
