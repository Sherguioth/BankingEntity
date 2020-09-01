using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBankSWNet.controller
{
    using ProductRegistrationWebService;

    public class ProductRegistrationController
    {
        private static ProductRegistrationController controller = null;
        private ProductRegistrationWebServiceClient productRegistrationWebService;

        private ProductRegistrationController()
        {
            this.productRegistrationWebService = new ProductRegistrationWebServiceClient();
        }

        public static ProductRegistrationController Instance
        {
            get
            {
                if (controller == null)
                    controller = new ProductRegistrationController();

                return controller;
            }
        }

        public productRegistration[] ListAllProductRegistations()
        {
            productRegistration[] productRegistrations;

            try
            {
                productRegistrations = this.productRegistrationWebService.listAllProductRegistrationsService();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return productRegistrations;
        }

        public bool AddProductRegistration(String strClientId, int productCode, String strProductNumber,
                                                String strBalance, DateTime registrationDate, DateTime expirationDate,
                                                bool state)
        {
            if (strClientId.Equals("")||  strProductNumber.Equals("") || strBalance.Equals("") || 
                registrationDate == null || expirationDate == null)
            {
                throw new Exception("Por favor diligenciar todos los campos");
            }
            else
            {
                productRegistration newProductRegistration = new productRegistration();

                int clientId = int.Parse(strClientId);
                int productNumber;
                double balance;

                try
                {
                    productNumber = int.Parse(strProductNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de producto invalido.\nPor favor digite un valor numérico");
                }
                try
                {
                    balance = Double.Parse(strBalance);
                }
                catch (Exception)
                {
                    throw new Exception("Saldo invalido.\nPor favor digite un valor numérico");
                }

                newProductRegistration.clientId = clientId;
                newProductRegistration.productCode = productCode;
                newProductRegistration.productNumber = productNumber;
                newProductRegistration.balance = balance;
                newProductRegistration.registratioDate = registrationDate;
                newProductRegistration.registratioDateSpecified = true;
                newProductRegistration.expirationDate = expirationDate;
                newProductRegistration.expirationDateSpecified = true;
                newProductRegistration.state = state;

                return this.productRegistrationWebService.insertProductRegistration(newProductRegistration);
            }
        }

        public productRegistration FindProductRegistration(String strClientId, String strProductCode)
        {
            productRegistration productRegistration = null;
            int clientId = int.Parse(strClientId);
            int productCode;
            try
            {
                productCode = int.Parse(strProductCode);
            }
            catch (Exception)
            {
                throw new Exception("Por favor seleccione un producto");
            }

            productRegistration = this.productRegistrationWebService.findProductRegistration(clientId, productCode);

            if (productRegistration != null)
            {
                return productRegistration;
            }
            else
            {
                throw new Exception("No se ha encontrado el registro del producto");
            }
        }

        public bool UpdateProductRegistration(String strClientId, String strProductCode, String strProductNumber,
                                                String strBalance, DateTime registrationDate, DateTime expirationDate,
                                                bool state)
        {
            if(strProductNumber.Equals("") || strBalance.Equals("") || registrationDate == null || expirationDate == null)
            {
                throw new Exception("Por favor diligenciar todos los campos");
            }
            else
            {
                productRegistration productRegistrationToUpdate;

                try
                {
                    productRegistrationToUpdate = this.FindProductRegistration(strClientId, strProductCode);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                int clientId = int.Parse(strClientId);
                int productCode;
                int productNumber;
                double balance;

                try
                {
                    productCode = int.Parse(strProductCode);
                }
                catch (Exception)
                {
                    throw new Exception("Por favor seleccione un producto");
                }
                try
                {
                    productNumber = int.Parse(strProductNumber);
                }
                catch (Exception)
                {
                    throw new Exception("Número de producto invalido.\nPor favor digite un valor numérico");
                }
                try
                {
                    balance = Double.Parse(strBalance);
                }
                catch (Exception)
                {
                    throw new Exception("Saldo invalido.\nPor favor digite un valor numérico");
                }

                productRegistrationToUpdate.clientId = clientId;
                productRegistrationToUpdate.productCode = productCode;
                productRegistrationToUpdate.productNumber = productNumber;
                productRegistrationToUpdate.balance = balance;
                productRegistrationToUpdate.registratioDate = registrationDate;
                productRegistrationToUpdate.registratioDateSpecified = true;
                productRegistrationToUpdate.expirationDate = expirationDate;
                productRegistrationToUpdate.expirationDateSpecified = true;
                productRegistrationToUpdate.state = state;

                return this.productRegistrationWebService.updateProductRegistration(clientId, productCode, productRegistrationToUpdate);
            }

        }

        public bool DeleteProductRegistration(String strClientId, String strProductCode)
        {
            productRegistration productRegistrationToDelete;

            try
            {
                productRegistrationToDelete = this.FindProductRegistration(strClientId, strProductCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return this.productRegistrationWebService.deleteProductRegistration(productRegistrationToDelete.clientId, productRegistrationToDelete.productCode);
        }
    }
}
