using System;

namespace NumericalSameLinePattern
{
     class NumericalSameLinePattern
    {
        static void Main()
        {
            int num;
            Console.Write("(Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            int i, j;

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }


                Console.WriteLine();
            }
            Console.ReadLine();


        }



    }
}
