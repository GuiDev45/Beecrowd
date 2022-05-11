using System;

namespace _1096
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
                                            I=1 J=7
                                            I=1 J=6
                                            I=1 J=5
                                            I=3 J=7
                                            I=3 J=6
                                            I=3 J=5
                                            ...
                                            I=9 J=7
                                            I=9 J=6
                                            I=9 J=5
            */

            int I, J;
            I = 1;

            while (I <= 9)
            {
                J = 7;
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                    J--;
                }
                I += 2;
            }
        }
    }
}
