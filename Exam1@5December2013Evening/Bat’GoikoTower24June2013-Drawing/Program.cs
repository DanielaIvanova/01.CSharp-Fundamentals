using System;

class Program
{
    static void Main()
    {
        int n = 5;//int.Parse(Console.ReadLine());
        int width = 2 * n;    //col
        int height = n;  //row

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {

                if (row + col == width / 2 - 1) //left diagonal

                //if (row == 0 && col == width / 2 - 1 ||
                //    row == 1 && col == width / 2 - 2 ||
                //    row == 2 && col == width / 2 - 3 ||
                //    row == 3 && col == width / 2 - 4 ||
                //    row == 4 && col == width / 2 - 5)
                {

                    Console.Write('/');


                }
                else if (row - col == -width + height)   //right diagonal
                {
                    // Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('\\');
                    // Console.ForegroundColor = ConsoleColor.Gray;

                }
                else if (row == 1 && col > width / 2 - 1 - row && col < width - height + row)//||//->first row -
                    row == 3 && col > width / 2 - 1 - row && col < width - height + row ||// -> third row
                    row == 6 && col > width / 2 - 1 - row && col < width - height + row)

                //(row==1&&col>width/2-col+1&&col<width-height+row||//   - on first row
                // row==3 && col > width / 2 - col + 1 && col < width - height + row)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('-');
                    Console.ForegroundColor = ConsoleColor.Gray;
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
