using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class FourTransaction
    {
        // iş yapan metotlar
        public void Add(int number1,int number2)
        {
            int sum;
            sum = number1 + number2;
            Console.WriteLine(sum);
        }
        // veri döndüren metotlar
        public int Add2(int number1,int number2)
        {
            return number2 + number1;
        }
        // default parametreli metotlar
        public void Add3(int number1, int number2=0)
        {
            
            Console.WriteLine(number1 + number2);
        }
        //çoklu parametreli metotlar
        public int Add4(params int[] numbers)
        {
            int counter = 0;
            foreach (var item in numbers)
            {
                counter += item;
            }
            return counter;

        }
    }
}
