using System;

namespace AlphabetPattern
{
     class AlphabetPattern
    {
        static void Main()
        {
            int num;
            Console.Write("(Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            int i, j;

            for (i = 1; i <= num; i++)

            {
                char c = 'A';
                for (j = 1; j <= i; j++)
                {
                    Console.Write(c+ " ");
                    c++;
                }


                Console.WriteLine();
            }
            Console.ReadLine();


        }




    }
}
