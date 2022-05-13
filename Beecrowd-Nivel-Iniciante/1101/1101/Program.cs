using System;

namespace _1101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). 
            Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

            Entrada
            O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

            Saída
            Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
            5 2                             2 3 4 5 Sum=14
            6 3                             3 4 5 6 Sum=18
            5 0
            */

            int maior, menor, soma;

            string[] vet = Console.ReadLine().Split(' ');

            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            while (M > 0 && N > 0)
            {
                soma = 0;
                maior = 0;
                menor = 0;

                if (M >= N)
                {
                    maior = M;
                    menor = N;
                }
                else
                {
                    maior = N;
                    menor = M;
                }

                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }

                Console.WriteLine("Sum=" + soma);

                vet = Console.ReadLine().Split(' ');

                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
            }
        }
    }
}
