using System;

class DiamondTrolls
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());

        //logic


        //The width of the diamond must be N*2 + 1.
        //The height must be(6 + ((N – 3) / 2) *3).

        int width = 2 * n + 1; //col
        int height = (6 + ((n - 3) / 2) * 3);//row

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (row == 0 && col > n / 2 && col < 3 * n / 2 + 1 ||    //top *
                    row == height - 1 && col == width / 2 || //bottom *
                    row == height - n - 1  // all row with ******* !!!!!
                    )
                {
                    Console.Write('*');
                }
                else if (row - col == height / 3 ||    //botoom left diagonal
                         row - col == -(height - 2) || //top right diagonal
                         row + col == height / 3 ||    //top right diagonal
                         row + col == height + n - 1 //bttom right diagonal
                         )
                {
                    Console.Write('*');
                }
                else if (col == width / 2 && row > 0 && row < height - 1) //vertical line
                {
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('*');
                    //Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write('.');
                }

            }
            Console.WriteLine();
        }


    }
}

