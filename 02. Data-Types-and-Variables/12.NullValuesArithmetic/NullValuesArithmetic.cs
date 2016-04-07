
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? age = null;
        Console.WriteLine(age);

        double? number = null;
        Console.WriteLine(number);

        age = 5;
        Console.WriteLine(age);
        number = 15;
        Console.WriteLine(number);

        age = age + null;
        Console.WriteLine(age);
        number = number + null;
        Console.WriteLine(number);

        age = age + 5 * 100;
        Console.WriteLine(age);
        number = age + 3 * 100;
        Console.WriteLine(number);

    


    }
}

