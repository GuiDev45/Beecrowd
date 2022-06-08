using System;

namespace _1164
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Na matemática, 
            um número perfeito é um número inteiro para o qual a soma de todos os seus divisores positivos próprios (excluindo ele mesmo) é igual ao próprio número. 
            Por exemplo o número 6 é perfeito, pois 1+2+3 é igual a 6. Sua tarefa é escrever um programa que imprima se um determinado número é perfeito ou não.

            Entrada
            A entrada contém vários casos de teste. 
            A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 20), indicando o número de casos de teste da entrada. 
            Cada uma das N linhas seguintes contém um valor inteiro X (1 ≤ X ≤ 108), que pode ser ou não, um número perfeito.

            Saída
            Para cada caso de teste de entrada, imprima a mensagem “X eh perfeito” ou “X nao eh perfeito”, de acordo com a especificação fornecida.

            Exemplos de Entrada             Exemplos de Saída
            3                               6 eh perfeito
            6                               5 nao eh perfeito
            5                               28 eh perfeito
            28
            */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int soma = 0;

                int X = int.Parse(Console.ReadLine());
                for (int j = 1; j < X; j++)
                {
                    if (X % j == 0)
                    {
                        soma += j;
                    }
                }

                if (soma == X)
                {
                    Console.WriteLine(X + " eh perfeito");
                }
                else
                {
                    Console.WriteLine(X + " nao eh perfeito");
                }
            }
        }
    }
}