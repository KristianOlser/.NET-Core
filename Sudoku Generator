using System;
using System.Collections.Generic;
using System.Linq;
namespace SudokuGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sudoku = BaseSudoku();

            if (Solver(sudoku))
            {

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(string.Format("{0} ", sudoku[i, j]));
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nemá řešení");
            }
        }

        static public int[,] BaseSudoku()
        {
            int[,] sudoku = new int[9, 9];
            return sudoku;
        }

        static public bool surroundCheck(int[,] sudoku, int line, int arrow, int num)
        {

            for (int i = 0; i < 9; i++)
            {
                if (sudoku[line, i] == num)
                {
                    return false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[i, arrow] == num)
                {
                    return false;
                }
            }
            //Začátek 3x3 kontroly
            int boxlineStart = line - line % 3;
            int boxarrowStart = arrow - arrow % 3;

            for (int r = boxlineStart;
                 r < boxlineStart + 3; r++)
            {
                for (int d = boxarrowStart;
                     d < boxarrowStart + 3; d++)
                {
                    if (sudoku[r, d] == num)
                    {
                        return false;
                    }
                }
            }
            //Konec 3x3 kontroly            


            return true;
        }

        static public bool Solver(int[,] sudoku)
        {
            int line = 0;
            int arrow = 0;
            bool empty = true;
            Random randomizer = new Random();
            for (int l = 0; l < 9; l++)
            {
                for (int a = 0; a < 9; a++)
                {
                    if (sudoku[l, a] == 0)
                    {
                        line = l;
                        arrow = a;
                        empty = false;
                        break;
                    }
                }
                if (!empty)
                {
                    break;
                }
            }
            if (empty)
            {
                return true;
            }
            List<int> randomList = new List<int>();
            int c = 1;
            for (int num = randomizer.Next(1, 10); c <= 9; num = randomizer.Next(1, 10), c++)
            {
                if (!randomList.Contains(num))
                {
                    randomList.Add(num);
                    if (surroundCheck(sudoku, line, arrow, num))
                    {
                        sudoku[line, arrow] = num;
                        if (Solver(sudoku))
                        {
                            return true;
                        }
                        else
                        {
                            sudoku[line, arrow] = 0;
                        }
                    }
                }
                else
                {
                    c--;
                    continue;
                }


            }

            return false;
        }

    }
}
