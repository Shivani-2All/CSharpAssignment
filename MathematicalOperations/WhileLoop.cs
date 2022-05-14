using System;
namespace MathematicalOperations
{
    class WhileLoop
    {
        static void Main()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i value is :" + i);
                i++;

                int j = 0;
                while (j < 3)
                {
                    Console.WriteLine("j value is :" + j);
                    j++;
                }
            }
        }
    }
}
