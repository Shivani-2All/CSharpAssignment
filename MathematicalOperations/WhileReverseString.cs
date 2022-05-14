using System;
namespace WhileReverseString
    
{
     class WhileReverseString
     {
        static void Main()
        {
            string value = " ";
            int lenght = 0;
            Console.WriteLine("enter string:");
            value = Console.ReadLine();
            lenght = value.Length - 1;
            string Reverse = " ";
            while (lenght >= 0)
            {
                Reverse = Reverse + value[lenght];
                lenght--;

            }
            Console.WriteLine("rverse string{0}", Reverse);


        }

            


     }

    
}
