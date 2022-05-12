using System;

namespace _1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

            Entrada
            A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.

            Saída
            Imprima a soma de todos valores ímpares entre X e Y.
            
            Exemplos de Entrada             Exemplos de Saída
            7                               0
            4 5                             11
            13 10                           5
            6 4                             0
            3 3                             0
            3 5                             0
            3 4                             12
            3 8
            */

            int X, Y, soma, maior, menor;
            string[] vet;

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X > Y)
                {
                    maior = X;
                    menor = Y;
                }
                else
                {
                    maior = Y;
                    menor = X;
                }

                soma = 0;
                menor += 1;
                for (int c = menor; c < maior; c++)
                {
                    if (c % 2 != 0)
                    {
                        soma += c;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
