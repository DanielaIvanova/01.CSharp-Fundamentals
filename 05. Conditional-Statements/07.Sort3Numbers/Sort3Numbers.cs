//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.


using System;
class Sort3Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a >= b && a > c && b >= c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        else if (a >= b && c >= b && a >= c)
        {
            Console.WriteLine(a + " " + c + " " + b);
        }
        else if (b >= a && b >= c && a >= c)
        {
            Console.WriteLine(b + " " + a + " " + c);
        }
        else if (b >= a && b >= c && c >= a)
        {
            Console.WriteLine(b + " " + c + " " + a);
        }
        else if (c >= a && c >= b && b >= a)
        {
            Console.WriteLine(c + " " + b + " " + a);
        }
        else if (c >= a && c >= b && a >= b)
        {
            Console.WriteLine(c + " " + a + " " + b);
        }
    }
}

