using System;

namespace _1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, 
            quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

            Entrada
            O arquivo de entrada contém 5 valores inteiros quaisquer.

            Saída
            Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.
            
            Exemplos de Entrada             Exemplos de Saída
            -5                              3 valor(es) par(es)
            0                               2 valor(es) impar(es)
            -3                              1 valor(es) positivo(s)
            -4                              3 valor(es) negativo(s)
            12
            */

            int valorPar = 0;
            int valorImpar = 0;
            int valorPositivo = 0;
            int valorNegativo = 0;

            for (int i = 1; i <= 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    valorPar++;
                }
                else
                {
                    valorImpar++;
                }

                if (num > 0)
                {
                    valorPositivo++;
                }
                else if (num < 0)
                {
                    valorNegativo++;
                }
            }

            Console.WriteLine(valorPar + " valor(es) par(es)");
            Console.WriteLine(valorImpar + " valor(es) impar(es)");
            Console.WriteLine(valorPositivo + " valor(es) positivo(s)");
            Console.WriteLine(valorNegativo + " valor(es) negativo(s)");

        }
    }
}
