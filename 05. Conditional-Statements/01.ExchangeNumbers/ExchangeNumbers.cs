//Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B, separated by a space.

using System;
class ExchangeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = a;

        if (a >= b)
        {
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
        
    }
}


