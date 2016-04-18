//Write a program that gets two numbers from the console and prints the greater of them.

using System;

class NumberComparer
{
    static void Main()
    {


        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);

        //if(firstNumber>secondNumber)
        //{
        //Console.WriteLine(firstNumber);
        //}
        //else
        //{
        //Console.WriteLine(secondNumber);
        //}
    }
}

