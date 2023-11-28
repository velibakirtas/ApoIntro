using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBase
{
    internal class CorporateCustomer : Customer 
    { 

        public CorporateCustomer(string customerNumber) : base(customerNumber) {
        }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
