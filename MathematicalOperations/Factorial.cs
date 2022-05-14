using System;


namespace Factorial
{
    class Factorial
    {

        static void Main()
        {
            int number;
            Console.WriteLine("enter any number:");
            number = Convert.ToInt32(Console.ReadLine());

            int Fact = 1;

            int i;

            for (i = 1; i <= number; i++)
            {
                Fact = Fact * i;
            }
                Console.WriteLine("factorial of " +    number   +   "  is = " +    Fact);

            
            


        }
    }
}
