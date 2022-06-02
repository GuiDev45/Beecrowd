using System;
using System.Globalization;

namespace _1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos 
            (desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

            Entrada
            Seis valores, negativos e/ou positivos.

            Saída
            Imprima uma mensagem dizendo quantos valores positivos foram lidos.
            
            Exemplos de Entrada             Exemplos de Saída
            7                               4 valores positivos
            -5
            6
            -3.4
            4.6
            12
            */

            int valorPositivo = 0;

            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            double num6 = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            if (num1 > 0.0)
            {
                valorPositivo += 1;
            }

            if (num2 > 0.0)
            {
                valorPositivo += 1;
            }

            if (num3 > 0.0)
            {
                valorPositivo += 1;
            }

            if (num4 > 0.0)
            {
                valorPositivo += 1;
            }

            if (num5 > 0.0)
            {
                valorPositivo += 1;
            }

            if (num6 > 0.0)
            {
                valorPositivo += 1;
            }

            Console.WriteLine(valorPositivo + " valores positivos");
        }
    }
}
