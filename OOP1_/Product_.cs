using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_
{
    internal class Product_
    {
        public int Id { get; set; }
        public int CategoryId;
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        public void StockUpdate(int quantity)
        {
            Console.WriteLine("Ürün güncellendi" + "Stok adedi: " + (this.UnitInStock + quantity));
        }
    }
}
