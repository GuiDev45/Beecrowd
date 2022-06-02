using System;

namespace _1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

            Entrada
            O arquivo de entrada contém um número inteiro positivo N.

            Saída
            Imprima a saída conforme o exemplo fornecido.
            
            Exemplos de Entrada             Exemplos de Saída
            7                               1 2 3 PUM
                                            5 6 7 PUM
                                            9 10 11 PUM
                                            13 14 15 PUM
                                            17 18 19 PUM
                                            21 22 23 PUM
                                            25 26 27 PUM
            */

            int N = int.Parse(Console.ReadLine());

            int cont = 0;
            int linhas = N * 4;

            for (int i = 1; i <= linhas; i++)
            {
                cont++;
                if (cont % 4 != 0)
                {
                    Console.Write(cont + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                }
            }
        }
    }
}
