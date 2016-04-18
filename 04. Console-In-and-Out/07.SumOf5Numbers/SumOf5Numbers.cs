//Write a program that reads 5 integer numbers from the console and prints their sum.

using System;
class SumOf5Numbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int sum = a + b + c + d + f;
        Console.WriteLine(sum);
    }
}

