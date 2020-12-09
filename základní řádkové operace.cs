using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Vítejte v programu základní řádkové operace!");
            Console.WriteLine("Navigujte se v menu pomocí čísel.");
            double[,] pole = new double[5,5];
            for (; ; )
            {
                Console.WriteLine("Navigace:");
                Console.WriteLine("1. Zadej hodnoty:");
                Console.WriteLine("2. Vypiš pole:");
                Console.WriteLine("3. Vynásob řádek číslem:");
                Console.WriteLine("4. Vynásob všechny hodnoty číslem:");
                Console.WriteLine("5. Přičti řádek k jinému řádku:");
                Console.WriteLine("6. Konec");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Boolean done = false;
                        for (; ; )
                        {
                            if (done)
                            {
                                break;
                            }
                            Console.WriteLine("1. Vygenerovat Automaticky hodnoty:");
                            Console.WriteLine("1. Manuálně vložit hodnoty:");
                            Boolean random = false;
                            String caseInput = Console.ReadLine();
                            switch (caseInput)
                            {
                                case "1":
                                case "2":
                                    if(caseInput == "1")
                                    {
                                        random = true;
                                    }
                                    for (int i = 0; i < pole.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < pole.GetLength(1); j++)
                                        {
                                            if (random)
                                            {
                                                double a = rand.NextDouble() * (10 - 1) + 1;
                                                a = Math.Round(a, 1);
                                                pole[i, j] = a;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Vložte desetinnou hodnotu pro pozici - řádek: " +(i+1) +" pořadí: "+(j+1));
                                                String strNum = Console.ReadLine();
                                                int n;
                                                if(int.TryParse(strNum, out n))
                                                {
                                                    pole[i, j] = n;
                                                } else if(strNum == "")
                                                {
                                                    pole[i, j] = 0;
                                                }

                                            }
                                        }

                                    }
                                    done = true;
                                    Console.WriteLine("Hodnoty zadány.");
                                    Console.WriteLine("Stiskněte jakékoliv tlačítko pro přesměrování do Menu.");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Zadal jste neplatnou hodnotu. Zkuste to prosím znovu.");
                                    break;

                            }
                            if (done)
                            {
                                break;
                            }

                        }
                        break;

                    case "2":
                        for (int i = 0; i < pole.GetLength(0); i++)
                        {
                            for (int j = 0; j < pole.GetLength(1); j++)
                            {
                                if (pole[i, j] % 1 == 0) 
                                {
                                    Console.Write(string.Format("[ {0} ] ", pole[i, j]));
                                }
                                else
                                {
                                    Console.Write(string.Format("[{0}] ", pole[i, j]));
                                }
                            }
                            Console.Write(Environment.NewLine);
                        }
                        Console.WriteLine("Pole vypsáno.");
                        Console.WriteLine("Stiskněte jakékoliv tlačítko pro přesměrování do Menu.");
                        Console.ReadKey();
                        break;
                    case "3":
                        int line = 0;
                        int linenum;
                        for(; ; )
                        {
                            Console.WriteLine("Zadejte řádek, který si přejete vynásobit");
                            String countLine = Console.ReadLine();
                            int.TryParse(countLine, out line);
                            if (line-1 > pole.GetLength(0) || line-1 < 0    )
                            {
                                Console.WriteLine("Zadaný řádek je neplatný!");
                                continue;
                            }
                            Console.WriteLine("Zadejte číslo, kterým si přejete " + line +". řádek vynásobit");
                            String numLine = Console.ReadLine();
                            if (!int.TryParse(numLine, out linenum))
                            {
                                Console.WriteLine("Zadaný násobek je neplatný!");
                                continue;
                            }
                                for (int i = 0; i < pole.GetLength(1); i++)
                                {
                                pole[line - 1, i] = pole[line - 1, i] * linenum;
                                }
                            break;
                        }          
                        Console.WriteLine(line + ". řádek pole vynásobeno číslem " + linenum);
                        Console.WriteLine("Stiskněte jakékoliv tlačítko pro přesměrování do Menu.");
                        Console.ReadKey();
                        break;
                    case "4":
                        int num;
                        for (; ; )
                        {
                            Console.WriteLine("Zadejte číslo, kterým si přejete matici vynásobit");
                            String numArr = Console.ReadLine();
                            if (!int.TryParse(numArr, out num))
                            {
                                Console.WriteLine("Zadaná hodnota je neplatná!");
                                continue;
                            }
                            for (int i = 0; i < pole.GetLength(0); i++)
                            {
                                for (int j = 0; j < pole.GetLength(1); j++)
                                {
                                    pole[i, j] = pole[i, j] * num;
                                }
                            }
                            Console.WriteLine("Matice byla vynásobena číslem " + num);
                            Console.WriteLine("Stiskněte jakékoliv tlačítko pro přesměrování do Menu.");
                            Console.ReadKey();
                            break;
                        }
                        break;
                    case "5":
                        int firstLine = 0;
                        int secondLine = 0;
                        for(; ; )
                        {
                            Console.WriteLine("Zadejte číslo řádku, který chcete přičíst k jinému.");
                            String addLine = Console.ReadLine();
                            int.TryParse(addLine, out firstLine);
                            if (firstLine - 1 > pole.GetLength(0) || firstLine - 1 < 0)
                            {
                                Console.WriteLine("Zadaný řádek je neplatný!");
                                continue;
                            }
                            Console.WriteLine("Zadejte číslo řádku, ke kterému chcete přičíst "+ firstLine +". řádek");
                            String toLine = Console.ReadLine();
                            int.TryParse(toLine, out secondLine);
                            if (secondLine - 1 > pole.GetLength(0) || secondLine - 1 < 0)
                            {
                                Console.WriteLine("Zadaný řádek je neplatný!");
                                continue;
                            }
                            for(int i = 0; i < pole.GetLength(1); i++)
                            {
                                pole[secondLine-1, i] += pole[firstLine-1, i];
                            }
                            break;

                        }
                        Console.WriteLine("Hodnoty z " + firstLine + ". řádku byly přičteny k "+ secondLine + ". řádku.");
                        Console.WriteLine("Stiskněte jakékoliv tlačítko pro přesměrování do Menu.");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Opouštíte program základní řádkové operace!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Zadal jste neplatnou hodnotu. Zkuste to prosím znovu.");
                        break;

                }
            }
        }
    }
}
