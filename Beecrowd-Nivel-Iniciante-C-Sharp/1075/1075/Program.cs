using System;

namespace _1075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.

            Entrada
            A entrada contém um valor inteiro N (N < 10000).

            Saída
            Imprima todos valores que quando divididos por N dão resto = 2, um por linha.
            
            Exemplos de Entrada             Exemplos de Saída
            13                              2
                                            15
                                            28
                                            41
                                            ...
            */

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
