namespace LoopsAndArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] credits = new string[] { "İhtiyaç Kredisi", "Araç Kredisi", "Konut Kredisi" };
            // Console.WriteLine(credits[0]);

            //for loop
            int i = 0;
            //for (; ; i++)
            //{
            //    if (i<5) {
            //        continue;
            //        Console.WriteLine(i);
                    
                    
            //    }
            //    if (i == 20)
            //    {
            //        break;
            //    }
                
            //foreach loop
            //foreach (string s in credits)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }

            // while
            int j = 0;
            while (true)
            {
                j++;
                if (j == 4)
                {
                    continue;
                }
                Console.WriteLine(j);
                
                
                if (j == 7)
                {
                    break;
                }
            }

         }
     }
}

