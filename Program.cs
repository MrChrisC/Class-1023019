using System;

namespace Week_1_Chris_10232019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nThis is from Cleveland.");
            // Console.WriteLine("This is from Cleveland");

            string str1, str2;
                        str1 = "Hello World";
                        str2 = "Christopher";
            Console.WriteLine(str1 +" from " + str2);

            int num1, num2, num3;
            num1 = 27;
            num2 = 55;
            num3 = num1 * num2;
            
           //Tried this break to add a line to the final outcome
           Console.WriteLine( "\nThe product of " + num1 + " and "+ num2+ " is "+ num3);
        }
    }
}
