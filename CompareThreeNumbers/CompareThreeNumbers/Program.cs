using System;
using static System.Console;

namespace CompareThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString;
            int num1, num2, num3;

            WriteLine("Enter an integer");
            numberString = Console.ReadLine();
            num1 = Convert.ToInt32(numberString);
            WriteLine("Enter an integer");
            numberString = Console.ReadLine();
            num2 = Convert.ToInt32(numberString);
            WriteLine("Enter an integer");
            numberString = Console.ReadLine();
            num3 = Convert.ToInt32(numberString);

            if (num1 == num2)
                if (num1 == num3)
                    WriteLine("All three numbers are equal");
                else
                    WriteLine("First two numbers are equal");
            else if (num1 == num3)
                WriteLine("First and last are equal");
            else if (num2 == num3)
                WriteLine("Last two are equal");
            else
                WriteLine("No two numbers are equal");
            ReadLine();
        }
    }
}
