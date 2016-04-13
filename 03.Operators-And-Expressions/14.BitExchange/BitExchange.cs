//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
//(read from the console).

using System;

class BitExchange
{
    static void Main()
    {

        {
            int number = int.Parse(Console.ReadLine());
            int closePasition = 3;
            int farPasition = 24;

            int maskClose = 7 << closePasition;
            int closeBitValue = number & maskClose;
            closeBitValue = closeBitValue >> closePasition;

            int maskFar = 7 << farPasition;
            int farBitValue = number & maskFar;
            farBitValue = farBitValue >> farPasition;

            int invertedMaskClose = ~maskClose;
            number = number & invertedMaskClose;

            int inverterMaskFar = ~maskFar;
            number = number & inverterMaskFar;

            closeBitValue = closeBitValue << farPasition;
            number = number | closeBitValue;

            farBitValue = farBitValue << closePasition;
            number = number | farBitValue;

            Console.WriteLine(number);



            //int number = int.Parse(Console.ReadLine());

            //int position1 = 3;
            //int position2 = 24;

            //int mask1 = 7 << position1;
            //int mask2 = 7 << position2;

            //int getNumbers1 = number & mask1;
            //int getNumbers2 = number & mask2;
            //int change = (number & ~mask1) & ~mask2;

            //int mask3 = (getNumbers1 >> position1) << position2;
            //int mask4 = (getNumbers2 >> position2) << position1;
            //int result = (change | mask3) | mask4;

            //Console.WriteLine(result);
        }
    }

}


