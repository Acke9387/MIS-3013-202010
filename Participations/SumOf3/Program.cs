using System;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)
        {
            double num1, num2, num3, sum;
            
            //double val1;
            //double val2;
            //double val3;
            string message3 = "Please enter your third number >>";

            Console.WriteLine("Please enter your first number >>");
            string input = Console.ReadLine();
            num1 = Convert.ToDouble(input);

            Console.WriteLine("Please enter your second number >>");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(message3);
            num3 = Convert.ToDouble(Console.ReadLine());

            sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of all 3 numbers is {sum.ToString("N3")}.");

            double luckyNum;
            luckyNum = sum * LUCKY_NUMBER;

            Console.WriteLine($"Your lucky # is {luckyNum.ToString("N3")}.");

        }
    }
}
