namespace OOP1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductName = "Tişört";
            product.UnitPrice = 200;
            product.UnitInStock = 100;
            product.StockUpdate(100);

            Product_ product_ = new Product_();
            product.ProductName = "Pantolon";
            product.UnitPrice = 200;
            product.UnitInStock = 120;
            product.StockUpdate(100);
        }

    class Product
        {
            public int Id { get; set; }
            public int CategoryId;
            public string ProductName { get; set; }
            public double UnitPrice { get; set; }
            public int UnitInStock { get; set; }

            public void StockUpdate( int quantity)
            {
                Console.WriteLine("Ürün güncellendi" + "Stok adedi: " + (this.UnitInStock + quantity));
            }
        }
    }
}
