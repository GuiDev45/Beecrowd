using System;

namespace _1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. 
            Para cada ponto escrever o quadrante a que ele pertence. 
            O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

            Entrada
            A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.

            Saída
            Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.
            
            Exemplos de Entrada             Exemplos de Saída
            2 2                             primeiro
            3 -2                            quarto
            -8 -1                           terceiro
            -7 1                            segundo
            0 2
            */

            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
            }
        }
    }
}
