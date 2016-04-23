using System;

class Cube3D
{
    static void Main()
    {
        //read input
        int n = int.Parse(Console.ReadLine());

        //logic
        char[,] cube = new char[2 * n - 1, 2 * n - 1];

        //matrix how to give a sell a value 
        //cube[1, 1] = 'a';!!!!! [y,x] !!!!!!!



        //loop for cube outline
        for (int i = 0; i < n; i++)
        {
            //upper horizontal side
            //Console.SetCursorPosition(i, 0);
            //Console.Write(":");
            cube[0, i] = ':';

            //bottom horizontal side
            //Console.SetCursorPosition(i, n - 1); //(n-1) because start from 0! (to be n rows)
            //Console.Write(":");
            cube[n - 1, i] = ':';

            //left vertical side
            //Console.SetCursorPosition(0, i);
            //Console.Write(":");
            cube[i, 0] = ':';

            //right vertical side
            //Console.SetCursorPosition(n - 1, i);
            //Console.Write(":");
            cube[i, n - 1] = ':';

            //hind bottom horizontal side
            //Console.SetCursorPosition(i + n - 1, 2 * (n - 1));
            //Console.Write(":");
            cube[2 * (n - 1), i + n - 1] = ':';

            //hind right vertical side
            //Console.SetCursorPosition(2 * (n - 1), i + n - 1);
            //Console.Write(":");
            cube[i + n - 1, 2 * (n - 1)] = ':';

            //top right side
            //Console.SetCursorPosition(n - 1 + i, i);
            //Console.Write(":");
            cube[i, n - 1 + i] = ':';

            //bpttom right side
            //Console.SetCursorPosition(n - 1 + i, n - 1 + i);
            //Console.Write(":");
            cube[n - 1 + i, n - 1 + i] = ':';

            //bpttom left side
            //Console.SetCursorPosition(i, n - 1 + i);
            //Console.Write(":");
            cube[n - 1 + i, i] = ':';

        }

        for (int i = 2; i < n; i++)
        {
            //Console.SetCursorPosition(n, i);
            //Console.Write("|");
            //Console.SetCursorPosition(n + 1, i + 1);   ! this is only to see the logic !
            //Console.Write("|");
            //Console.SetCursorPosition(n + 2, i + 2);
            //Console.Write("|");


            //fill right cube side with |
            for (int j = 0; j < n - 2; j++)
            {
                //Console.SetCursorPosition(n + j, i + j);
                //Console.Write("|");
                cube[i + j, n + j] = '|';
            }

            //fill right cue side with -
            for (int j = 0; j < n - 2; j++)
            {
                //Console.SetCursorPosition(i + j, n + j);
                //Console.Write("-");
                cube[n + j, i + j] = '-';
            }
        }

        for (int row = 0; row < 2 * n - 1; row++)
        {
            for (int column = 0; column < 2 * n - 1; column++)
            {
                char symbol = cube[row, column];
                if (symbol!=0)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
