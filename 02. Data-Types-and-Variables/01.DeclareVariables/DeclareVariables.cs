﻿
//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it.
//Try to compile the code.

using System;

    class Program
    {
        static void Main()
        {
            ushort number1 = 52130;
            sbyte number2 = -115;
            int number3 = 4825923;
            byte number4 = 97;
            short number5 = -10000;
        Console.WriteLine("{0};\n{1};\n{2};\n{3};\n{4}",number1,number2,number3,number4,number5);
        }
    }
