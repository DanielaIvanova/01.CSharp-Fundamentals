//Write a program that, depending on the first line of the input, reads an int, double or string variable.

//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.

//Print the result at the console. Use switch statement.


using System;

class IntDoubleString
{
    static void Main()
    {
        string option = Console.ReadLine();

        switch (option)
        {
            case "integer":
                int firstOption = int.Parse(Console.ReadLine());
                Console.WriteLine(firstOption + 1);
                break;
            case "real":
                double secondOption = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", (secondOption + 1));
                break;
            case "text":
                string thirdOption = Console.ReadLine();
                Console.WriteLine(thirdOption +'*');
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

