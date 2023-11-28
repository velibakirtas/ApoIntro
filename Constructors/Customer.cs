using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Customer
    {
        //public Customer()
        //{
        //    this.FirstName = "belirsiz";
        //    this.LastName = "belirsiz";
        //    this.City = "belirsiz";
        //}


        public Customer(string firstName, string lastName,string City) {
            this.FirstName = firstName;
            this.LastName = lastName;   
            this.City = City;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
