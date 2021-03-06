using System;

namespace _1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida. 
            Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE). 
            No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN NULL), pois por definição zero é par, 
            seu programa deverá imprimir apenas NULL.

            Entrada
            A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o número de casos de teste. 
            Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).

            Saída
            Para cada caso, imprima uma mensagem correspondente, de acordo com o exemplo abaixo. 
            Todas as letras deverão ser maiúsculas e sempre deverá haver um espaço entre duas palavras impressas na mesma linha.
            
            Exemplos de Entrada             Exemplos de Saída
            4                               ODD NEGATIVE
            -5                              NULL
            0                               ODD POSITIVE
            3                               EVEN NEGATIVE
            -4
            */

            int N = int.Parse(Console.ReadLine());

            for (int e = 0; e < N; e++)
            {
                int X = int.Parse(Console.ReadLine());
                if (X == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (X < 0)
                {
                    if (X % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                else
                {
                    if (X % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
            }
        }
    }
}
