using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        //read input
        string strNum = Console.ReadLine();
        int transCount = 0;


        //logic
        while (strNum.Length > 1 && transCount < 10)
        {


            BigInteger product = 1;

            while (strNum.Length > 0)
            {

                strNum = strNum.Substring(0, strNum.Length - 1);

                int sum = 0;

                for (int i = 0; i < strNum.Length; i += 2)
                {
                    sum += (strNum[i] - '0');
                }


                product *= sum != 0 ? sum : 1;


            }
            transCount++;
            strNum = product.ToString();
        }

        //print result
        if (transCount < 10)
        {
            Console.WriteLine(transCount);
        }
        Console.WriteLine(strNum);
    }
}

