//Write a program that reads an integer N (which will always be less than 100 or equal) and uses an 
//expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive



using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool prime = true;

        if (number < 2)
        {
            prime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
        }

        if (prime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}