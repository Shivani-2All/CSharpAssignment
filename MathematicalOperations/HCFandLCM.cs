
 using System;

namespace HCFandLCM
{
    internal class HCFandLCM
    {

        static void Main()
        {
            int num1;
            Console.WriteLine("enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2;
            Console.WriteLine("enter first number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            int HCF, LCM;

            int a, b;
            a = num1;//15-->10--->5
            b = num2;//10--->5--->0
            int temp;

            while (b != 0)//agter b =0;  condition false:
            {
                temp = b;//10-->5-->0
                b = a % b;//15%10=5--->10%5=0
                a = temp;//10-->5
            }
            HCF = a;//a=5
            LCM = num1 * num2 / HCF;//15*10/5=30
            Console.WriteLine("Highest common facror:" + HCF);
            Console.WriteLine("Lowest common multiple:" + LCM);

        }
    }
}




