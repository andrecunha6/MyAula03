using System;

namespace percorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, cString;
            char c;
            Console.WriteLine("Digite uma string.");
            s = Console.ReadLine();
            Console.WriteLine("Digite um char.");
            cString = Console.ReadLine();
            c = cString[0];
            foreach (char cAtual in s)
            {
               if (cAtual != c)
               {
                    Console.Write(cAtual);
               }
            }
            Console.WriteLine();
        }
    }
}
