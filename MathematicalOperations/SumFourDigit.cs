using System;

namespace SumFourDigit

{

    class SumFourDigit
    {
         public static void Main()
         {
            
             int n;
             Console.Write("Enter a number: ");
             n = Convert.ToInt32(Console.ReadLine());

             int Sum = 0;
             int rem;

             while(n >0)
             {
                 rem = n % 10;
                 Sum = Sum + rem;
                 n = n / 10;
             }
             Console.Write("Sum is=  " + Sum);

           /* int digit1;
            Console.WriteLine("Enter first digit: ");
            digit1= Convert.ToInt32(Console.ReadLine());

            int digit2;
            Console.WriteLine("Enter first digit: ");
            digit2 = Convert.ToInt32(Console.ReadLine());

            int digit3;
            Console.WriteLine("Enter first digit: ");
            digit3 = Convert.ToInt32(Console.ReadLine());

            int digit4;
            Console.WriteLine("Enter first digit: ");
            digit4 = Convert.ToInt32(Console.ReadLine());

            int Sum;

            //Sum of all 4 digit number

            Sum = digit1 + digit2 + digit3 + digit4;
            Console.WriteLine("sum of all 4 digit number: "+Sum); */


        }
    }

}

