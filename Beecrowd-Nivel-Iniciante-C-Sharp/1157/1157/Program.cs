using System;

namespace _1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um número inteiro N e calcular todos os seus divisores.

            Entrada
            O arquivo de entrada contém um valor inteiro.

            Saída
            Escreva todos os divisores positivos de N, um valor por linha.
            
            Exemplos de Entrada             Exemplos de Saída
            6                               1
                                            2
                                            3
                                            6
            */

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
