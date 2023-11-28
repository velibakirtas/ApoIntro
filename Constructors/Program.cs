namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.City);

            Customer customer2 = new Customer("Abdurrahman", "Kütük", "Ankara");
            Console.WriteLine(customer2.LastName); 
        }
    }
}
