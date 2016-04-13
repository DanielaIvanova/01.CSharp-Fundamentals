//Write a program that reads from the console two integer numbers P and N and prints on the console 
//the value of P's N-th bit.

using System;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        long mask = 1 << position;
        long numberAndMask = number & mask;
        long result = numberAndMask >> position;
        Console.WriteLine(result);
    }
}

