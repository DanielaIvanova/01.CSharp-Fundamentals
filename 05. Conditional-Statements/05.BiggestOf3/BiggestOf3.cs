﻿//Write a program that finds the biggest of three numbers that are read from the console.

using System;

class BiggestOf3
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if(a>b&&a>c)
        {
            Console.WriteLine(a);
        }
        else if(b>a&&b>c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

