using System;


namespace Calculator
{
     class Calculator
    {
        static void Main()
        {
            int num1;
            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2;

            Console.Write("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);






        }
    }
}
