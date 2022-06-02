using System;

namespace _1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

            Entrada
            O arquivo de entrada contém 5 valores inteiros quaisquer.

            Saída
            Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.
            
            Exemplos de Entrada             Exemplos de Saída
            7                               3 valores pares
            -5
            6
            -4
            12
            */

            int valorInteiro = 0;

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (num2 % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (num3 % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (num4 % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            if (num5 % 2 == 0)
            {
                valorInteiro = valorInteiro + 1;
            }

            Console.WriteLine(valorInteiro + " valores pares");
        }
    }
}
