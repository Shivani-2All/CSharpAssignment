using System;


namespace ArmstrongNumber
{
     class ArmstrongNumber
    {
        static void Main()
        {
            int num;//153
            Console.WriteLine("enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            int temp = num;//153-->15-->1
            int Sum = 0;
            int rem;
            while (num > 0)
            {
                rem = num % 10;  // 3-->5-->1
                Sum = Sum + rem * rem * rem;//0+3*3*3=27+5^3=125+27=152+1^3=153
                num = num / 10;//15-->1
            }


                if (temp==Sum)//153==153
                {
                    Console.WriteLine("number is Armstrong:");
                }

                else

                    Console.WriteLine("number is not Armstrong:");
                     
                
            
            
            
        }

        
        
     }


}

