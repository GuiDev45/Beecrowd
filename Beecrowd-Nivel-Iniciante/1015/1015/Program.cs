using System;
using System.Globalization;

namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, 
            p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

            Distancia = Raiz quadrada (x2-x1)² + (y2-y1)²

            Entrada
            O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: 
            x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

            Saída
            Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

            Exemplos de Entrada             Exemplos de Saída
            1.0 7.0                         4.4721
            5.0 9.0                       
            -------------------             -------------------
            -2.5 0.4                        16.1484 
            12.1 7.3
            -------------------             -------------------
            2.5 -0.4                        16.4575
            -12.2 7.0
            */

            double x1, x2, y1, y2, distancia;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x1 - x2, 2.00) + Math.Pow(y1 - y2, 2.00));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
