namespace OOP3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            
        }

        class Customer:ICustomer
        {
            public int Id { get; set; }
            public string CustomerNumber { get; set; }

            public void Add()
            {
                Console.WriteLine(this.CustomerNumber + " sisteme eklendi"); 
            }

        }

        class CorporateCustomer:Customer
        {
            public string CompanyName { get; set; }
            public string TaxNumber { get; set; }


        }

        class IndividualCustomer:Customer
        {
            public string IdentityNumber { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        interface ICustomer
        {
            void Add();
        }
    }
}
