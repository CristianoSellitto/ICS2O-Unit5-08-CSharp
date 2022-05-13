// Cristiano
// ICS2O-Unit5-08-CSharp
// May 13 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int originalIntegerOne;
        int integerTwo;
        int integerOne;
        int count;
        string answer;

        Console.Write("Enter the first integer: ");
        while (!int.TryParse(Console.ReadLine(), out originalIntegerOne))
        {
            Console.WriteLine("Error: This isn't an integer.");
            Environment.Exit(0);
        }
        Console.Clear();
        Console.Write("Enter the second integer: ");
        while (!int.TryParse(Console.ReadLine(), out integerTwo))
        {
            Console.WriteLine("Error: This isn't an integer.");
            Environment.Exit(0);
        }
        if (originalIntegerOne < 0)
        {
            integerOne = 0;
        }
        else
        {
            integerOne = originalIntegerOne;
        }
        if (integerOne != 0 && integerTwo > 0)
        {
            for (count = 0; integerOne >= integerTwo; count++)
            {
                integerOne = integerOne - integerTwo;
            }
            answer = Convert.ToString(count) + "r" + Convert.ToString(integerOne);
        }
        else if (integerOne != 0 && integerTwo < 0)
        {
            for (count = 0; integerOne >= integerTwo; count++)
            {
                integerOne = integerOne + integerTwo;
            }
            answer = Convert.ToString(-count) + "r" + Convert.ToString(integerOne);
        }
        else
        {
            answer = "undefined";
        }
        Console.WriteLine("The result of " + originalIntegerOne + " ÷ " + integerTwo + " is " + answer);
        Console.WriteLine("\nFinished.");
    }
}