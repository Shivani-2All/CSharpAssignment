using System;


namespace NumberTable
{
    class NumberTable
    {

        static void Main()
        {

            int n;
            Console.WriteLine("Enter any number:");
            n = Convert.ToInt32(Console.ReadLine());

            int Table;
            for (Table = 1; Table <= 10; Table++)
            {
                Console.WriteLine("table of that number you entered:{0}*{1}={2}", n,Table,(n * Table));
            }

            Console.WriteLine("press any key to exit:");

        }

    }
}
