using System;
using System.Globalization;

namespace _1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
            Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
            Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, 
            o segundo valor tem peso 3 e o terceiro valor tem peso 5.

            Entrada
            O arquivo de entrada contém um valor inteiro N na primeira linha. 
            Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.

            Saída
            Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
            3                               5.7
            6.5 4.3 6.2                     6.3
            5.1 4.2 8.1                     9.3
            8.0 9.0 10.0
            */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double m1 = (v1 * 2) / 10;
                double m2 = (v2 * 3) / 10;
                double m3 = (v3 * 5) / 10;

                double mediaFinal = m1 + m2 + m3;

                Console.WriteLine(mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
