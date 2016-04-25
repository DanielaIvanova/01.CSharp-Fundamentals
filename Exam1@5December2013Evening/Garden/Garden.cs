using System;


class Garden
{
    static void Main()
    {
        //read input


        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumerArea = int.Parse(Console.ReadLine());

        int patatoSeeds = int.Parse(Console.ReadLine());
        int patatoArea = int.Parse(Console.ReadLine());

        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beansSeeds = int.Parse(Console.ReadLine());

        //logic
        int availableArea = 250;
        double tomato = 0.5;
        double cucumber = 0.4;
        double patato = 0.25;
        double carrot = 0.6;
        double cabbage = 0.3;
        double beans = 0.4;

        double result = tomatoSeeds * tomato + cucumberSeeds * cucumber +patatoSeeds * patato +carrotSeeds * carrot +cabbageSeeds * cabbage + beansSeeds * beans;

        Console.WriteLine("Total costs:{0:F2}", result);

        int totalArea = tomatoArea + cucumerArea + patatoArea + carrotArea + cabbageArea;
        if (totalArea == availableArea)
        {
            Console.WriteLine("No area for beans");

        }
        else if (totalArea < availableArea)
        {
            Console.WriteLine("Beans area: {0}", availableArea - totalArea);
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }



    }

}
