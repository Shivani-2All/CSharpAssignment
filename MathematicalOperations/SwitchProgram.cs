using System;

namespace ArithmeticOperations
{
     class SwitchProgram
    {
        int Add(int num1, int num2)
        {
            return num1 + num2;
        
        }
        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Division(int num1, int num2)
        {
            return num1 / num2;

        }
        static void Main()
        {
           
            int num1;
            Console.WriteLine("Please enter first number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2;
            Console.WriteLine("Please enter second number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Arithmetic Operations are:");
            Console.WriteLine("1.Addition:");
            Console.WriteLine("2.Subtraction:");
            Console.WriteLine("3.multiplication:");
            Console.WriteLine("4.Division:");
            int userChoice ;
            Console.WriteLine("Please enter your choice :");
            userChoice = Convert.ToInt32(Console.ReadLine());

            var obj = new SwitchProgram();
            int result = 0;

            switch (userChoice)
            {
              case 1:
                result = obj.Add(num1, num2);
               Console.WriteLine("Result of the Addition is:" + result);
               break;


                case 2:
                    result = SwitchProgram.Subtraction(num1, num2);
               Console.WriteLine($"Result of Subtraction is:" + SwitchProgram.Subtraction(num1,num2));
                break;


                case 3:
                    result = obj.Multiply(num1, num2);
                    Console.WriteLine($"Result of multiplication is:{obj.Multiply(num1,num2)}");
                  break;
                    
                case 4:
                    result = SwitchProgram.Division(num1, num2);
                    Console.WriteLine("Result of Division is:{0}",SwitchProgram.Division(num1,num2));
                    break;


                default:
                    Console.WriteLine("invalid choice ");
                    break;


                   

            }
           




}
    }
}
