using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void StockUpdate(Product product,int quantity)
        {
            Console.WriteLine("Ürün güncellendi" + "Stok adedi: " + (product.UnitInStock + quantity));
        }
    }
}
