using System;

namespace PatternInCSharp
{
     class PatternInCSharp
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
                    Console.Write(j+ " ");
                    
                }
                
 
                Console.WriteLine();

               
            }
                Console.ReadLine();
        
        
        }
    }
}
