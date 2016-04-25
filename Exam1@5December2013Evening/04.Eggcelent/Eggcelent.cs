using System;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;// row
        int width = 3 * n + 1;// col

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((col > n && col < 2 * n) && (row == 0 || row == height - 1))
                {
                    Console.Write('*');
                }
                else if ((row >= n / 2 && row < 2 * n - n / 2) && (col == 1 || col == width - 2))
                {
                    Console.Write('*');
                }
                else if ((2 * row - col == -(2 * n - 1)) || (2 * row - col == 3 * n - 3))//add diagonals--> row-col -->one diagonal  
                {
                    Console.Write('*');
                }
                else if (2 * row + col == n + 1 || 2 * row + col == 6 * n - 3)//add diagonals-->row+col--> Evlogi explain (29min.video)
                {
                    Console.Write('*');
                }
                else if ((row == n - 1 || row == n) && (col > 1 && col < width - 2) && (row + col) % 2 == 1)
                {
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('@');
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

