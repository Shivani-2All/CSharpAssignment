using System;

namespace LeftStarTrian
{
     class LeftStarTriangle
    {
        static void Main()
        {
            int num;
            Console.Write("(Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            int i, j,k;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }


    }
}

