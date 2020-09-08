using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBankSWNet.controller
{
    using ClienteBankSWNet.structural;
    using Newtonsoft.Json;
    using ProductWebService;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class ProductController
    {
        private static ProductController controller = null;

        private static HttpClient httpClient;

        private ProductController()
        {
        }

        private void InstanceHttpClient()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static ProductController Instance
        {
            get
            {
                if (controller == null)
                    controller = new ProductController();

                return controller;
            }
        }

        public Product[] ListAllProducts()
        {
            Product[] products;

            try
            {
                InstanceHttpClient();
                httpClient.BaseAddress = new Uri(GeneralController.URL + "Product/listAllProducts");
                HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress).Result;
                HttpContent httpContent = response.Content;


                products = JsonConvert.DeserializeObject<Product[]>(httpContent.ReadAsStringAsync().Result.ToString());

                return products;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Product FindProduct(String strCode)
        {
            int code;
            try
            {
                code = Int32.Parse(strCode);
            }
            catch(Exception)
            {
                throw new Exception("Código de producto invalido");
            }

            InstanceHttpClient();
            httpClient.BaseAddress = new Uri(GeneralController.URL + "Product/Product/findProduct?code="+strCode);
            HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress).Result;
            HttpContent httpContent = response.Content;

            Product foundProduct = JsonConvert.DeserializeObject<Product>(httpContent.ReadAsStringAsync().Result.ToString());
            if (foundProduct == null)
            {
                return foundProduct;
            }
            else
            {
                throw new Exception("Producto número "+strCode+"No se ha encontrado");
            }
        }
    }
}
