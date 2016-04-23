using System;

class EncodingSum
{
    static void Main()
    {
        //read input
        int modul = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int result = 0;

        //logic
        for (int i = 0; i < text.Length - 1; i++)
        {
            char symbol = text[i];

            if (symbol == '@')
            {
                break;
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                result *= symbol - '0';
            }
            else if (symbol >= 'A' && symbol <= 'Z')
            {
                result += symbol - 'A';
            }
            else if ('a' <= symbol && symbol <= 'z')
            {
                result += symbol - 'a';
            }
            else
            {
                result %= modul;
            }


        }


        //print result
        Console.WriteLine(result);
    }
}


