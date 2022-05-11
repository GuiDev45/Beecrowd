using System;

namespace _1095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

            Entrada
            Não há nenhuma entrada neste problema.

            Saída
            Imprima a sequencia conforme exemplo abaixo
            
            Exemplos de Entrada             Exemplos de Saída
                                            I=1 J=60
                                            I=4 J=55
                                            I=7 J=50
                                            ...
                                            I=? J=0  
            */

            int i = 1, j = 60;

            while (j >= 0)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                i += 3;
                j -= 5;
            }
        }
    }
}
