using System;

namespace _1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.

            Entrada
            O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.

            Saída
            Imprima a soma de todos os valores não divisíveis por 13 entre os dois valores lidos na entrada, inclusive ambos se for o caso.
            
            Exemplos de Entrada             Exemplos de Saída
            100                             13954
            200
            */

            int soma = 0;
            int maior, menor;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X >= Y)
            {
                maior = X;
                menor = Y;
            }
            else
            {
                maior = Y;
                menor = X;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
