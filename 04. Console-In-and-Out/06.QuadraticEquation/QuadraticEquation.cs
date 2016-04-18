//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).
//Output

//If two different real roots exist, print them on two separate lines
//Print the smaller root on the first line
//If only one real root exists, print it on the only output line
//If no real root exists, print the string "no real roots"
//The roots, should they exist, must be printed with precision exactly two digits after the floating point

//Constraints

//The input will always consist of valid real numbers in the range[-1000, 1000] and will follow the described format



using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;
        double discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0)
        {

            x1 = (-b + Math.Sqrt(discriminant)) / (double)(2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (double)(2 * a);
            if (x1 < x2)
            {
                Console.WriteLine("{0:F2}", x1);
                Console.WriteLine("{0:F2}", x2);
            }
            else
            {
                Console.WriteLine("{0:F2}", x2);
                Console.WriteLine("{0:F2}", x1);
            }

        }

        if (discriminant == 0)
        {
            x1 = -b / (double)(2 * a);
            Console.WriteLine("{0:F2}", x1);
        }

        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }



    }
}

