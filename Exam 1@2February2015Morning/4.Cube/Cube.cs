using System;

class Cube
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());

        //logic
        int fieldSize = 2 * n - 1;
        int mid = n - 1;

        char empty = ' ';
        char top = '/';
        char side = 'X';
        char edge = ':';

        for (int row = 0; row < fieldSize; row++)
        {
            for (int col = 0; col < fieldSize; col++)
            {
                if (col == 0 && row >= mid ||  //bottom left side
                    col == mid && row >= mid ||//bottom right side
                    col == fieldSize - 1 && row <= mid ||//top right vertical
                    row == mid && col <= mid ||//middle horizontal
                    row == fieldSize - 1 && col <= mid ||//bpttom horizontal
                    row == 0 && col >= mid ||//top horizontal
                    row + col == mid ||//left diagonal
                    row + col == fieldSize - 1 + mid || //right-bottom diagonal
                    col + row == fieldSize - 1 && row <= mid//middle diagonal
                    )
                {
                    Console.Write(edge);
                }
                else if (col > mid && row + col <= fieldSize - 1 + mid && col + row >= fieldSize - 1)
                {
                    Console.Write(side);
                }
                else if (row < mid && row + col > mid)
                {
                    Console.Write(top);
                }
                else
                {
                    Console.Write(empty);
                }
            }
            Console.WriteLine();
        }


    }
}

