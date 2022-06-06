using System;

namespace _1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

            Entrada
            A entrada contém um valor inteiro N (0 < N < 13).

            Saída
            A saída contém um valor inteiro, correspondente ao fatorial de N.
            
            Exemplos de Entrada             Exemplos de Saída
            4                               24
            */

            int N = int.Parse(Console.ReadLine());
            double fatorial;
            int cont;

            fatorial = N;
            cont = N;

            for (int i = 1; i < cont; i++)
            {
                N--;
                fatorial *= N;
            }

            Console.WriteLine(fatorial);
        }
    }
}
