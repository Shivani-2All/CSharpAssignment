using System;

namespace AreaOfSquare
{ 
     class AreaOfSquare
    {
        static void Main()
        {
            int Side;
            Console.WriteLine("Please enter the side of square:");
             Side = Convert.ToInt32(Console.ReadLine());

            int Area = Side*Side;
            Console.WriteLine("Area of square:" + Area);
            // Area = Convert.ToInt32(Console.ReadLine());


        }
    }
}
