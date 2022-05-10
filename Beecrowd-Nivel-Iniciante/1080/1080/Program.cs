using System;

namespace _1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

            Entrada
            O arquivo de entrada contém 100 números inteiros, positivos e distintos.

            Saída
            Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
            2                               34565
            113                             4
            45
            34565
            6
            ...
            8
            */

            int maior = 0, posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
