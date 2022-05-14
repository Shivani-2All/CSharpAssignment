using System;
namespace AlphaSameLinePattern
{
     class AlphaSameLinePattern
    {
        static void Main()
        {
            int num;
            Console.Write("(Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            int i, j,k;
            Char c = 'A';
           
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= num ; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(c+" ");
                    
                }
                c++;
                Console.WriteLine("");
            }
           

               


        }



    }
}
