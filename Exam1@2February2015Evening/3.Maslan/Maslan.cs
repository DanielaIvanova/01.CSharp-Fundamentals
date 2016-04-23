using System;
using System.Numerics;

class Maslan
{
    static void Main()
    {
        int transforamationsCount = 0;

        //read input
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        //logic
        while (transforamationsCount < 10 && 9 < n)
        {
            BigInteger oddProduct = 1;

            while (n > 0)
            {
                n /= 10;
                string nString = n.ToString();
                BigInteger oddSum = 0;
                for (int i = 1; i < nString.Length; i += 2)
                {
                    oddSum += nString[i] - '0';
                }
                if (oddSum != 0)
                {
                    oddProduct *= oddSum;
                }
               
            }
            n = oddProduct;
            transforamationsCount++;

        }

        if (transforamationsCount!=10)
        {
            Console.WriteLine(transforamationsCount);      //print result
        }
        else if (transforamationsCount>10)
        {
            throw new Exception("Shuden't happen");
        }
        Console.WriteLine(n);
      
    }
}

