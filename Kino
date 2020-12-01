using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v kině!");
            Console.WriteLine("Navigujte se v menu pomocí čísel!");
            int[,] sal = new int[10, 15];
            int rLength = 10;
            int cLength = 15;
            int res;
            for (; ; )
            {
                Console.WriteLine("Navigace:");
                Console.WriteLine("1. Zobraz Kinosál:");
                Console.WriteLine("2. Rezervuj místo:");
                Console.WriteLine("3. Konec:");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        for (int i = 0; i < rLength; i++)
                        {
                            for (int j = 0; j < cLength; j++)
                            {
                                if (sal[i, j] == 0)
                                {
                                    Console.Write(string.Format("{0} ", sal[i, j]));
                                }
                                else
                                {
                                    Console.Write(string.Format("{0} ", "X"));
                                }
                            }
                            Console.Write(Environment.NewLine + Environment.NewLine);
                        }
                        Console.WriteLine("Potvrďte pro přesměrování do Menu");
                        Console.ReadLine();
                        break;

                    case "2":
                        for(; ; ) {
                            Console.Write("Vyberte řadu 1-10" + Environment.NewLine);
                            string strRada = Console.ReadLine();
                            if (Int32.TryParse(strRada, out res) && int.Parse(strRada) < 11 && int.Parse(strRada) > 0)
                            {
                                Console.Write("Vyberte sedadlo 1-15" + Environment.NewLine);
                                string strSedadlo = Console.ReadLine();
                                if (Int32.TryParse(strSedadlo, out res) && int.Parse(strSedadlo) < 16 && int.Parse(strSedadlo) > 0)
                                {
                                    int rada = int.Parse(strRada)-1;
                                    int sedadlo = int.Parse(strSedadlo)-1;
                                    if(sal[rada,sedadlo] != 0) {
                                        Console.WriteLine("Vybrané sedadlo je již zabrané, zkuste prosím vybrat jiné sedadlo.");
                                    continue;
                                    } else
                                    {
                                        sal[rada, sedadlo] = 1;
                                        Console.WriteLine("Rezervovali jste sedadlo " + (sedadlo + 1) + " v řadě " + (rada + 1));
                                        break;
                                    }
                                }else if(Int32.TryParse(strSedadlo, out res)) {
                                Console.WriteLine("Vybrali jste hodnotu mimo velikost pole. Zkuste to prosím znovu.");
                                }
                            } else if(Int32.TryParse(strRada, out res))
                            {
                                Console.WriteLine("Vybrali jste hodnotu mimo velikost pole. Zkuste to prosím znovu.");
                            }
                        }
                       
                        break;

                    case "3":
                        Console.WriteLine("Opouštíte program rezervace Kina");
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
