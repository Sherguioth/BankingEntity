using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBankSWNet.controller
{
    using ProductWebService;

    public class ProductController
    {
        private static ProductController controller = null;
        private ProductWebServiceClient productWebService;

        private ProductController()
        {
            this.productWebService = new ProductWebServiceClient();
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

        public product[] ListAllProducts()
        {
            product[] products;

            try
            {
                products = this.productWebService.listAllProducts();

                return products;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public product FindProduct(String strCode)
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

            product foundProduct = productWebService.findProduct(code);
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
