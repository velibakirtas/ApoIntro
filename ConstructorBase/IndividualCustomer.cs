using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBase
{
    internal class IndividualCustomer : Customer
    {
        public IndividualCustomer(string customerNumber,string firstName) : base(customerNumber)
        {
        }

        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
