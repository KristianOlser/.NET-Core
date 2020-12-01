using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            string num;
            Console.WriteLine("Vítejte v programu magického čtverce");
            for (; ; )
            {
                Console.WriteLine("Zadejte prosím liché číslo");
                num = Console.ReadLine();
                if (Int32.TryParse(num, out res) && int.Parse(num) % 2 != 0)
                {
                   int n = int.Parse(num);
                    generateSquare(n);
                } else
                {
                    Console.WriteLine("Nezadali jste liché číslo. " + Environment.NewLine + "Zkuste to prosím znovu.");
                }
                
            }
         

        }
        static void generateSquare(int n)
        {
            int[,] ctverec = new int[n, n];

            int i = n / 2;
            int j = n - 1;

            for (int num = 1; num <= n * n;)
            {
                if (i == -1 && j == n)
                {
                    j = n - 2;
                    i = 0;
                }
                else
                {                  
                    if (j == n)
                        j = 0;

                    if (i < 0)
                        i = n - 1;
                }

                if (ctverec[i, j] != 0)
                {
                    j -= 2;
                    i++;
                    continue;
                }
                else
                    ctverec[i, j] = num++;
                j++;
                i--;
            }

            Console.WriteLine("Magický čtverec pro hodnotu " + n
                              + ":");
            Console.WriteLine("Součet každého řádku, či sloupce"
                              + n * (n * n + 1) / 2 + ":" + Environment.NewLine);

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(ctverec[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Program dokončen");
        }
    }
}
