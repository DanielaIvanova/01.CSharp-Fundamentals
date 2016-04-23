using System;

class Money
{
    static void Main()
    {
        //read input
        int nStudents = int.Parse(Console.ReadLine());
        int sSheets = int.Parse(Console.ReadLine());
        double pPrice = double.Parse(Console.ReadLine());
        int realm = 400;

        //logic
        double result;
        result = ((nStudents * sSheets) /(double)(realm)) * pPrice;


        //print result
        Console.WriteLine("{0:F3}",result);
    }
}

