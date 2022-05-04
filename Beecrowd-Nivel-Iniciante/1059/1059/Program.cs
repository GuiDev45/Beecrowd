using System;

namespace _1059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que mostre os números pares entre 1 e 100, inclusive.

            Entrada
            Neste problema extremamente simples de repetição não há entrada.

            Saída
            Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada linha.

            Exemplos de Entrada             Exemplos de Saída
                                            2
                                            4
                                            6
                                            ...
                                            100                              
            */

            int num = 0;

            for (int i = 0; i <= 100; i++)
            {
                num++;
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
