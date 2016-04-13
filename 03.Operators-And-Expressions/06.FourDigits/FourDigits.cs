//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs 
//the following:

//Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
//Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
//Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
//Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.


using System;

class FourDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberD = (number % 10);
        int numberC = (number / 10)%10;
        int numberB = (number/100)%10;
        int numberA = (number/1000)%10;
        int numerSum = numberA + numberB + numberC + numberD;

        Console.WriteLine(numerSum);
        Console.WriteLine("{0}{1}{2}{3}", numberD, numberC, numberB, numberA);
        Console.WriteLine("{0}{1}{2}{3}", numberD, numberA, numberB, numberC);
        Console.WriteLine("{0}{1}{2}{3}", numberA, numberC, numberB, numberD);




    }
}

