using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBankSWNet.structural
{
    class Client
    {
        public Client() { }

        public int identificationNumber { get; set; }
        public string documetType { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; }
    }
}
