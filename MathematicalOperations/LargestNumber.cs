using System;

namespace LargestNumber
{
     class LargestNumber
    {

        static void Main()
        {
            int num1;
            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());


            int num2;
            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            int num3;
            Console.WriteLine("Please enter your third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            int num4;
            Console.WriteLine("Please enter your third number");
            num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1> num4)
                Console.WriteLine("num1 is the largest number");

            else if (num2 > num3 && num2 > num4)
                Console.WriteLine("num2 is the largest number");

            else if (num3 > num4)
                Console.WriteLine("num3 is the largest number");

            else
                Console.WriteLine("num4 is the largest number");



        }

    }
}
