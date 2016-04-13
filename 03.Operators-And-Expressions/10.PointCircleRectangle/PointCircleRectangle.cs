//Write a program that reads a pair of coordinates x and y and uses an expression to checks for given 
//point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle
//R(top=1, left=-1, width=6, height=2)

using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double circleX = 1;
        double circleY = 1;
        double r = 1.5;
        
        double leftX = -1;
        double rightX = 5;
        double topY = 1;
        double downY = -1;

        bool isInCircle = ((x - circleX) * (x - circleX)) + ((y - circleY) * (y - circleY)) <= (r * r);
        bool isInRectangle = (x >= leftX && x <= rightX) && (y <= topY && y >= downY);

        if (isInCircle)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if (isInRectangle)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }




    }
}

