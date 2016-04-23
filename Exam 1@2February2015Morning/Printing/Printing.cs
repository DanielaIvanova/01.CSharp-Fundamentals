using System;

class Printing
{
    static void Main()
    {
        //read input
        int numStudent = int.Parse(Console.ReadLine());
        int sheetsPerStudent = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        int realm = 500;

        //logic
        double result =((numStudent * sheetsPerStudent)/(double) realm) * price;

        //print result
        Console.WriteLine("{0:F2}", result);
    }
}
