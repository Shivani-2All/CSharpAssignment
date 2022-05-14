using System;


namespace AreaOfSquare
{
    class AreaOfSquare
    {

        static void Main()
        {
            int Side;
            Console.WriteLine("enter the side of square:");
            Side = Convert.ToInt32(Console.ReadLine());

            int Area = Side * Side;
            Console.WriteLine("area of square is:"+ Area);

               
        
        
        }

    }
}
