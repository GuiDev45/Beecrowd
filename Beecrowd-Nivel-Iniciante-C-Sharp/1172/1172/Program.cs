using System;

namespace _1172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1. Em seguida mostre o vetor X.

            Entrada
            A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.

            Saída
            Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.

            Exemplos de Entrada             Exemplos de Saída
            0                               X[0] = 1
            -5                              X[1] = 1
            63                              X[2] = 63
            0                               X[3] = 1
            ...                             ...
            */

            int[] X = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor < 0 || valor == 0)
                {
                    X[i] = 1;
                }
                else
                {
                    X[i] = valor;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("X" + "[" + i +"]" + " = " + X[i]);
            }

        }
    }
}
