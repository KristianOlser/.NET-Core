using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pole = new int[2, 4];
            Random rand = new Random();

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = rand.Next(1, 10);
                }

            }
            Console.WriteLine("Vypsané Pole klasicky:");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", pole[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine("Vypsané Pole transpozičně:");
            for (int i = 0; i < pole.GetLength(1); i++)
            {
                for (int j = 0; j < pole.GetLength(0); j++)
                {
                    Console.Write(string.Format("{0} ", pole[j, i]));
                }
                Console.Write(Environment.NewLine);
            }
        }


    }
}
