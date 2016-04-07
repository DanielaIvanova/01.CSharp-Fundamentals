//Write a program that safely compares two floating-point numbers(double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b
//because of the nature of the floating-point arithmetic.Therefore, we assume two numbers are equal 
//if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {

        Console.WriteLine("Enter the first number:");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double number2 = double.Parse(Console.ReadLine());
        double deduction = number1 - number2;
        deduction = Math.Abs(deduction);
        Console.WriteLine(deduction);
        if (deduction < 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }


    }
}
