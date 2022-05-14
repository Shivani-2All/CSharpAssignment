using System;
using System.Linq;


namespace DuplicateLetters
{
    class MyClass
    {
        static void Main()
        {
            //Input
            Console.WriteLine("Please enter your word");
            string value = Console.ReadLine().ToUpper();
            //string value = "google";
            //Output
            //g has occured 2 times
            //o has occured 2 times

            int counter = 0;
            string isLetterExist = string.Empty;
            for (int i = 0; i < value.Length; i++)//g o o g l e

            {
                if (isLetterExist.Contains(value[i]))
                {
                    continue;
                }
                for (int j = 0; j < value.Length; j++)//google 
                {
                    if (value[i] == value[j])
                    {
                        counter++;
                    }
                }

            }


        }
    }
}







            
       

           




