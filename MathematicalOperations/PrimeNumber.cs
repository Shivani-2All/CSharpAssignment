using System;

namespace PrimeNumber
{
    

     class PrimeNumber
    {

        static void Main()
        {

            int number;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            Boolean IsPrime = true;

            if (number < 1)
                Console.WriteLine("number is need to be greater than 1");
            else if (number == 1)
                Console.WriteLine("1 is neither prime nor composite");
            else
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                
                 }
            if (IsPrime)
                Console.WriteLine("number {0} is Prime" , number);
            else
                Console.WriteLine("number {0} is Composite or not Prime" ,  number);

               
        }


    }
}
