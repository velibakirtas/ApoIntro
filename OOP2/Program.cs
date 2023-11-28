namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();

            IndividualCustomer individiualCustomer = new IndividualCustomer();
            individiualCustomer.IdentityNumber = "56734592786";
            individiualCustomer.FirstName = "Veli";
            individiualCustomer.LastName = "Bakırtaş";
            individiualCustomer.Id = 3;
            individiualCustomer.CustomerNumber = "89651";

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.TaxNumber = "1111111";
            corporateCustomer.CompanyName = "Akyüz A.Ş.";
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNumber = "5646516";

            Customer corporateCustomer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individiualCustomer);
            customerManager.Add(corporateCustomer);
            customerManager.Add(corporateCustomer2);
        }
    }
}
