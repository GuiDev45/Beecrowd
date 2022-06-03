using System;

namespace _1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

            Entrada
            O arquivo de entrada contém um número inteiro positivo N.

            Saída
            Imprima a saída conforme o exemplo fornecido.
            
            Exemplos de Entrada             Exemplos de Saída
            5                               1 1 1
                                            2 4 8
                                            3 9 27
                                            4 16 64
                                            5 25 125
            */

            int m1, m2;

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                m1 = (int)Math.Pow(i, 2);
                m2 = m1 * i;
                Console.Write(i + " ");
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
            }
        }
    }
}
