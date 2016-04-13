//Using bitwise operators, write a program that uses an expression to find the value of the bit
//at index 3 of an unsigned integer read from the console.
//The bits are counted from right to left, starting from bit 0.
//The result of the expression should be either 1 or 0. Print it on the console.


using System;

class ThirdBit
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int nAndMask = number & mask;
        int bit = nAndMask >> position;
        Console.WriteLine(bit);


        //int x = int.Parse(Console.ReadLine());
        //int n = 3;
        //
        //if ((x & (1 << n)) != 0)
        //{
        //    Console.WriteLine("1");
        //}
        //else
        //{
        //    Console.WriteLine("0");
        //}

    }
}

