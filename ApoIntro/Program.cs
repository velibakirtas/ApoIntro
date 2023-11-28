namespace ApoIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "veli";

            bool boolData = true;
            //if (boolData == true)
            //{
            //    Console.WriteLine("if bloğu çalıştı");

            //}
            //else if (true)
            //{
            //    Console.WriteLine("else if çalıştı");
            //}
            //else
            //{
            //    Console.WriteLine("else bloğu çalıştı");
            //}

            int i = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("i: " + i + ", j: " + j);
                i =+ j;
                

            }
        }
    }
}
