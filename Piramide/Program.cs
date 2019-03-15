using System;

//Exercicio 3
//Declarar variaveis
//pedir numero de linhas ao user
//mostrar piramide

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            string nLinhasString;
            int nLinhas;
            Console.WriteLine("inserir numero de linhas");
            nLinhasString = Console.ReadLine();
            nLinhas = Convert.ToInt32(nLinhasString);
            for (int i = 0; i < nLinhas; ++i)
            {
                int numEspaco, numAst;
                numEspaco = nLinhas-i-1;
                numAst = i*2+1;
                for (int j = 0; j<numEspaco; j++)
                {
                    Console.Write(" ");
                }
                for (int j=0; j<numAst; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
