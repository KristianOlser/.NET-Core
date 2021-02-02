using System;
using System.Linq;
using System.Text;

namespace vigenere-cipher
{
    class Program
    {

        public static string Hash(String input, String password)
        {
            input = input.ToUpper();
            password = password.ToUpper();
            char[] ch = input.ToCharArray();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(ch);
            int pass = 0;
            String hashabc = string.Empty;
            String letter = string.Empty; ;
            for (int i = 0; i < asciiBytes.Length; i++, pass++)
            {
                if (pass == password.Length) 
                {
                    pass = 0;
                }

                char pch = password[pass];
                int j = (byte)pch - 65 + 1;
            
                int c = asciiBytes[i] + j;

                for (; c > 90;)
                {
                    int variable = c - 90;
                    c = 64 + variable;
                }


                hashabc = hashabc.Insert(i, Encoding.ASCII.GetString(new byte[] { (byte)c }));
            }
           

            return hashabc;
        }
        public static string Unhash(String input, String password)
        {
            input = input.ToUpper();
            password = password.ToUpper();
            char[] ch = input.ToCharArray();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(ch);
            int pass = 0;
            String hashabc = string.Empty;
            String letter = string.Empty; ;
            for (int i = 0; i < asciiBytes.Length; i++, pass++)
            {
                if (pass == password.Length)
                {
                    pass = 0;
                }

                char pch = password[pass];
                int j = (byte)pch - 65 + 1;

                int c = asciiBytes[i] - j;

                for (; c < 65;)
                {
                    int variable = 65 - c;
                    c = 91 - variable;
                }


                hashabc = hashabc.Insert(i, Encoding.ASCII.GetString(new byte[] { (byte)c }));
            }


            return hashabc;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v programu šifrování a dešifrování zpráv");
            Console.WriteLine("Vignerova Šifra");


            for (; ; )
            {
                String output = String.Empty;

                Console.WriteLine("Zvolte vaše šifrovací heslo");
                String password = Console.ReadLine();
                String hashAbc = string.Empty;
                Console.WriteLine("Pomocí '1' a '2' si zvolte zda chcete šifrovat, či dešifrovat.");
                Console.WriteLine("1. Šifrovat");
                Console.WriteLine("2. Dešifrovat");
                String number = Console.ReadLine();
                Console.WriteLine("Vyberte frázi, kterou chcete šifrovat, či dešifrovat");
                String input = Console.ReadLine();
                switch (Int32.Parse(number))
                {
                    case 1:
                        Console.WriteLine("Vaše zašifrovaná zpráva pomocí hesla " + password + ": " + Hash(input, password));
                        break;

                    case 2:
                        Console.WriteLine("Vaše odšifrovaná zpráva pomocí hesla " + password + ": " + Unhash(input, password));
                        break;
                }
                Console.WriteLine("Pro zopakování cyklu stiskněte jakoukoliv klávesu");
                Console.ReadLine();
            }
        }
    }
}
