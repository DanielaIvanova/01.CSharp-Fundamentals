//We are given an integer number N (read from the console), a bit value v (read from the console as well) 
//(v = 0 or 1) and a position P (read from the console). Write a sequence of operators 
//(a few lines of C# code) that modifies N to hold the value v at the position P from the binary 
//representation of N while preserving all other bits in N. Print the resulting number on the console.


using System;

class ModifyBit
{
    static void Main()
    {

        ulong number = ulong.Parse(Console.ReadLine());
        int pasition = int.Parse(Console.ReadLine());
        int bit = int.Parse(Console.ReadLine());

        if (bit == 0)
        {
            ulong mask = (ulong)~(1 << pasition);
            ulong resoltZezo = number & mask;
            Console.WriteLine(resoltZezo);
        }
        else
        {
            ulong mask1 = (ulong)1 << pasition;
            ulong rezoltOne = number | mask1;
            Console.WriteLine(rezoltOne);
        }


    }
}

