using System;


namespace SwapTwoNumbers
{
    
   class SwapTwoNumbers
    {
        static void Main()
        {
            int a ;
            Console.WriteLine("Please enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.WriteLine("Please enter the value of b:");
            b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a= " + a + " b= " + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After swap a= " + a + " b= " + b);





        }


    }
}
