namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductName = "Tişört";
            product.UnitPrice = 200 ;
            product.UnitInStock = 100 ;

            Console.WriteLine(product.ProductName);
            ProductManager manager = new ProductManager();

            manager.StockUpdate(product,5);
        }
    }
}
