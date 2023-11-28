using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuiz
{
    internal class ProductManager
    {
        public void UpdateName(Product product, string productName)
        {
            product.ProductName = productName;

        }

        public void UpdateNumber(int number)
        {
            number = 55;
            Console.WriteLine(number);

        }

        public int UpdateNumber2(int number)
        {
             number = 55;
            return number;

        }
    }
}
