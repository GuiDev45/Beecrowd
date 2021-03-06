using System;

namespace _1145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia dois valores X e Y. 
            A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

            Entrada
            O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

            Saída
            Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, 
            conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.
            
            Exemplos de Entrada             Exemplos de Saída
            3 99                            1 2 3
                                            4 5 6
                                            7 8 9
                                            10 11 12
                                            ...
                                            97 98 99
            */

            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            int cont = 1;

            if (X >= 1 && X <= 20)
            {
                if (Y > X)
                {
                    while (Y >= cont)
                    {
                        for (int i = 1; i <= X; i++)
                        {
                            if (cont <= Y && i < X)
                            {
                                Console.Write(cont + " ");
                                cont++;
                            }
                            else if (cont <= Y && i == X)
                            {
                                Console.WriteLine(cont);
                                cont++;
                            }
                        }
                    }
                }
            }
        }
    }
}
