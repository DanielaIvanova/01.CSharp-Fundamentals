//Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….


using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long previousNumber = -1;
        long firstNumber = 1;
        long sum =0;

        for (int i = 0; i < n; i++)
        {
            sum = (previousNumber + firstNumber);
            if (i!=(n-1))
            {
                Console.Write(sum +", ");
            }
            else
            {
                Console.Write(sum);
            }

            previousNumber = firstNumber;
            firstNumber = sum;
        }

        Console.WriteLine();
    }
}

