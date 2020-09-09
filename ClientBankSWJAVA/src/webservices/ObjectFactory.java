
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

    private final static QName _DeleteProductRegistrationResponse_QNAME =
        new QName("http://webServices/", "deleteProductRegistrationResponse");
    private final static QName _FindProductRegistrationResponse_QNAME =
        new QName("http://webServices/", "findProductRegistrationResponse");
    private final static QName _InsertProductRegistrationResponse_QNAME =
        new QName("http://webServices/", "insertProductRegistrationResponse");
    private final static QName _ListAllProductRegistrationsServiceResponse_QNAME =
        new QName("http://webServices/", "listAllProductRegistrationsServiceResponse");
    private final static QName _UpdateProductRegistrationResponse_QNAME =
        new QName("http://webServices/", "updateProductRegistrationResponse");
    private final static QName _DeleteProductRegistration_QNAME =
        new QName("http://webServices/", "deleteProductRegistration");
    private final static QName _InsertProductRegistration_QNAME =
        new QName("http://webServices/", "insertProductRegistration");
    private final static QName _FindProductRegistration_QNAME =
        new QName("http://webServices/", "findProductRegistration");
    private final static QName _ListAllProductRegistrationsService_QNAME =
        new QName("http://webServices/", "listAllProductRegistrationsService");
    private final static QName _UpdateProductRegistration_QNAME =
        new QName("http://webServices/", "updateProductRegistration");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: webservices
     *
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ListAllProductRegistrationsServiceResponse }
     *
     */
    public ListAllProductRegistrationsServiceResponse createListAllProductRegistrationsServiceResponse() {
        return new ListAllProductRegistrationsServiceResponse();
    }

    /**
     * Create an instance of {@link UpdateProductRegistrationResponse }
     *
     */
    public UpdateProductRegistrationResponse createUpdateProductRegistrationResponse() {
        return new UpdateProductRegistrationResponse();
    }

    /**
     * Create an instance of {@link DeleteProductRegistrationResponse }
     *
     */
    public DeleteProductRegistrationResponse createDeleteProductRegistrationResponse() {
        return new DeleteProductRegistrationResponse();
    }

    /**
     * Create an instance of {@link FindProductRegistrationResponse }
     *
     */
    public FindProductRegistrationResponse createFindProductRegistrationResponse() {
        return new FindProductRegistrationResponse();
    }

    /**
     * Create an instance of {@link InsertProductRegistrationResponse }
     *
     */
    public InsertProductRegistrationResponse createInsertProductRegistrationResponse() {
        return new InsertProductRegistrationResponse();
    }

    /**
     * Create an instance of {@link ListAllProductRegistrationsService }
     *
     */
    public ListAllProductRegistrationsService createListAllProductRegistrationsService() {
        return new ListAllProductRegistrationsService();
    }

    /**
     * Create an instance of {@link UpdateProductRegistration }
     *
     */
    public UpdateProductRegistration createUpdateProductRegistration() {
        return new UpdateProductRegistration();
    }

    /**
     * Create an instance of {@link DeleteProductRegistration }
     *
     */
    public DeleteProductRegistration createDeleteProductRegistration() {
        return new DeleteProductRegistration();
    }

    /**
     * Create an instance of {@link FindProductRegistration }
     *
     */
    public FindProductRegistration createFindProductRegistration() {
        return new FindProductRegistration();
    }

    /**
     * Create an instance of {@link InsertProductRegistration }
     *
     */
    public InsertProductRegistration createInsertProductRegistration() {
        return new InsertProductRegistration();
    }

    /**
     * Create an instance of {@link ProductRegistration }
     *
     */
    public ProductRegistration createProductRegistration() {
        return new ProductRegistration();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link DeleteProductRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "deleteProductRegistrationResponse")
    public JAXBElement<DeleteProductRegistrationResponse> createDeleteProductRegistrationResponse(DeleteProductRegistrationResponse value) {
        return new JAXBElement<DeleteProductRegistrationResponse>(_DeleteProductRegistrationResponse_QNAME,
                                                                  DeleteProductRegistrationResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FindProductRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "findProductRegistrationResponse")
    public JAXBElement<FindProductRegistrationResponse> createFindProductRegistrationResponse(FindProductRegistrationResponse value) {
        return new JAXBElement<FindProductRegistrationResponse>(_FindProductRegistrationResponse_QNAME,
                                                                FindProductRegistrationResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link InsertProductRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "insertProductRegistrationResponse")
    public JAXBElement<InsertProductRegistrationResponse> createInsertProductRegistrationResponse(InsertProductRegistrationResponse value) {
        return new JAXBElement<InsertProductRegistrationResponse>(_InsertProductRegistrationResponse_QNAME,
                                                                  InsertProductRegistrationResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListAllProductRegistrationsServiceResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "listAllProductRegistrationsServiceResponse")
    public JAXBElement<ListAllProductRegistrationsServiceResponse> createListAllProductRegistrationsServiceResponse(ListAllProductRegistrationsServiceResponse value) {
        return new JAXBElement<ListAllProductRegistrationsServiceResponse>(_ListAllProductRegistrationsServiceResponse_QNAME,
                                                                           ListAllProductRegistrationsServiceResponse.class,
                                                                           null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link UpdateProductRegistrationResponse }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "updateProductRegistrationResponse")
    public JAXBElement<UpdateProductRegistrationResponse> createUpdateProductRegistrationResponse(UpdateProductRegistrationResponse value) {
        return new JAXBElement<UpdateProductRegistrationResponse>(_UpdateProductRegistrationResponse_QNAME,
                                                                  UpdateProductRegistrationResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link DeleteProductRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "deleteProductRegistration")
    public JAXBElement<DeleteProductRegistration> createDeleteProductRegistration(DeleteProductRegistration value) {
        return new JAXBElement<DeleteProductRegistration>(_DeleteProductRegistration_QNAME,
                                                          DeleteProductRegistration.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link InsertProductRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "insertProductRegistration")
    public JAXBElement<InsertProductRegistration> createInsertProductRegistration(InsertProductRegistration value) {
        return new JAXBElement<InsertProductRegistration>(_InsertProductRegistration_QNAME,
                                                          InsertProductRegistration.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FindProductRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "findProductRegistration")
    public JAXBElement<FindProductRegistration> createFindProductRegistration(FindProductRegistration value) {
        return new JAXBElement<FindProductRegistration>(_FindProductRegistration_QNAME, FindProductRegistration.class,
                                                        null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListAllProductRegistrationsService }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "listAllProductRegistrationsService")
    public JAXBElement<ListAllProductRegistrationsService> createListAllProductRegistrationsService(ListAllProductRegistrationsService value) {
        return new JAXBElement<ListAllProductRegistrationsService>(_ListAllProductRegistrationsService_QNAME,
                                                                   ListAllProductRegistrationsService.class, null,
                                                                   value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link UpdateProductRegistration }{@code >}}
     *
     */
    @XmlElementDecl(namespace = "http://webServices/", name = "updateProductRegistration")
    public JAXBElement<UpdateProductRegistration> createUpdateProductRegistration(UpdateProductRegistration value) {
        return new JAXBElement<UpdateProductRegistration>(_UpdateProductRegistration_QNAME,
                                                          UpdateProductRegistration.class, null, value);
    }

}
