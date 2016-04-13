//Write a program that reads an integer from the console, uses an expression to check 
//if given integer is odd or even, and prints "even NUMBER" or "odd NUMBER", 
//where you should print the input number's value instead of NUMBER.

using System;

class OddOrEven
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        // if (n % 2 == 0)
        // {
        //     Console.WriteLine("even" + " " + n);
        // }
        // else
        // {
        //     Console.WriteLine("odd" + " " + n);
        // }

        int n = int.Parse(Console.ReadLine());
        if ((n & 1) == 0)
        {
            Console.WriteLine("even " + n);

        }
        else
        {
            Console.WriteLine("odd " + n);
        }


    }
}

