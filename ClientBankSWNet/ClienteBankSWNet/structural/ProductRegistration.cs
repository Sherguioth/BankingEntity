using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBankSWNet.structural
{
    public class ProductRegistration
    {
        public ProductRegistration() { }

        public int clientId { get; set; }
        public int productCode { get; set; }
        public int productNumber { get; set; }
        public double balance { get; set; }
        public string registrationDate { get; set; }
        public string expirationDate { get; set; }
        public bool state { get; set; }
    }
}
