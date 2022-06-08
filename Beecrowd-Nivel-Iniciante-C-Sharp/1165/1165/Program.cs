using System;

namespace _1165
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo. 
            Por exemplo, o número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.

            Entrada
            A entrada contém vários casos de teste. 
            A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100), indicando o número de casos de teste da entrada. 
            Cada uma das N linhas seguintes contém um valor inteiro X (1 < X ≤ 107), que pode ser ou não, um número primo.

            Saída
            Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”, de acordo com a especificação fornecida.

            Exemplos de Entrada             Exemplos de Saída
            3                               8 nao eh primo
            8                               51 nao eh primo
            51                              7 eh primo
            7
            */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                int cont = 0;
                for (int c = 2; c < X; c++)
                {
                    if (X % c == 0 && cont == 0)
                    {
                        Console.WriteLine(X + " nao eh primo");
                        cont++;
                    }
                }

                if (cont == 0)
                {
                    Console.WriteLine(X + " eh primo");
                }

            }
        }
    }
}
