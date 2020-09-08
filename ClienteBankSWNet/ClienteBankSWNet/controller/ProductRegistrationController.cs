using ClienteBankSWNet.structural;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBankSWNet.controller
{
    public class ProductRegistrationController
    {
        private static ProductRegistrationController controller = null;
        private static HttpClient httpClient;

        private ProductRegistrationController(){ }

        private void InstanceHttpClient()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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

        public ProductRegistration[] ListAllProductRegistations()
        {
            ProductRegistration[] productRegistrations;

            try
            {
                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "ProductRegistration/listAllProductRegistrations");
                HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress).Result;
                HttpContent httpContent = response.Content;

                productRegistrations = JsonConvert.DeserializeObject<ProductRegistration[]>(httpContent.ReadAsStringAsync().Result.ToString());
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

                ProductRegistration newProductRegistration = new ProductRegistration
                {
                    clientId = clientId,
                    productCode = productCode,
                    productNumber = productNumber,
                    balance = balance,
                    registrationDate = registrationDate.ToString("yyyy-MM-dd"),
                    expirationDate = expirationDate.ToString("yyyy-MM-dd"),
                    state = state
                };

                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "ProductRegistration/insertProductRegistration");
                string strJson = JsonConvert.SerializeObject(newProductRegistration);
                HttpContent httpContent = new StringContent(strJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync(httpClient.BaseAddress, httpContent).Result;
                httpClient = null;

                return response.IsSuccessStatusCode;
            }
        }

        public ProductRegistration FindProductRegistration(String strClientId, String strProductCode)
        {
            ProductRegistration productRegistration = null;
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

            InstanceHttpClient();
            httpClient.BaseAddress = new Uri(GeneralController.URL + "ProductRegistration/findProductRegistration?productCode="+strProductCode+"&clientId="+strClientId);
            HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress).Result;
            HttpContent httpContent = response.Content;

            productRegistration = JsonConvert.DeserializeObject<ProductRegistration>(httpContent.ReadAsStringAsync().Result.ToString());

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
                ProductRegistration productRegistrationToUpdate;

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
                productRegistrationToUpdate.registrationDate = registrationDate.ToString("yyyy-MM-dd");
                productRegistrationToUpdate.expirationDate = expirationDate.ToString("yyyy-MM-dd");
                productRegistrationToUpdate.state = state;

                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "ProductRegistration/updateProductRegistration?productCode=" + strProductCode + "&clientId=" + strClientId);
                string strJson = JsonConvert.SerializeObject(productRegistrationToUpdate);
                HttpContent httpContent = new StringContent(strJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PutAsync(httpClient.BaseAddress, httpContent).Result;
                httpClient = null;

                return response.IsSuccessStatusCode;
            }

        }

        public bool DeleteProductRegistration(String strClientId, String strProductCode)
        {
            ProductRegistration productRegistrationToDelete;

            try
            {
                productRegistrationToDelete = this.FindProductRegistration(strClientId, strProductCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            InstanceHttpClient();
            httpClient.BaseAddress = new Uri(GeneralController.URL + "ProductRegistration/deleteProductRegistration?productCode=" + strProductCode + "&clientId=" + strClientId);
            HttpResponseMessage response = httpClient.DeleteAsync(httpClient.BaseAddress).Result;
            httpClient = null;

            return response.IsSuccessStatusCode;
        }
    }
}
