using System;

namespace ConsoleApp4
{
    class Program
    {

        public static String looper(String input, int hash)
        {
            String output = string.Empty;

            foreach (char ch in input)
                output += hashing(ch, hash);

            return output;
        }
        public static char hashing(char ch, int hash)
        {
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return ((char)((((ch + hash) - d) % 26) + d));
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Zadejte vaše jméno");
            String input = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Zadejte o kolik chcete znaky posunout");
            int hash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Posunuté jméno:");
            Console.WriteLine(looper(input, hash));







        }
    }

}
