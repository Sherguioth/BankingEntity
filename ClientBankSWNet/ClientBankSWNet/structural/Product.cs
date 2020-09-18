using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBankSWNet.structural
{
    class Product
    {
        public Product() { }

        public int code { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string productType { get; set; }
        public bool state { get; set; }
    }
}
