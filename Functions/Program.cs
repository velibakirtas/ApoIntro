using System.ComponentModel;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FourTransaction transaction = new FourTransaction();
            //transaction.Add(1, 2);

            //transaction.Add2(3, 4);
            //Console.WriteLine(transaction.Add2(3,4));

            //transaction.Add3(3);
            //transaction.Add3(3,4);

            //Console.WriteLine(transaction.Add4(3, 4, 5, 6, 43, 77, 34, 5, 23, 5, 7, 8, 54));
            Add(3, 4);
        }

        public static void Add(int number1, int number2)
        {
            int sum;
            sum = number1 + number2;
            Console.WriteLine(sum);
        }

        
    }
}
