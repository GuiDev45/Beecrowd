using System;
using System.Globalization;

namespace _1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. 
            Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

            Entrada
            A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. 
            Pelo menos um destes números será positivo.

            Saída
            O primeiro valor de saída é a quantidade de valores positivos. 
            A próxima linha deve mostrar a média dos valores positivos digitados.
            
            Exemplos de Entrada             Exemplos de Saída
            7                               4 valores positivos
            -5                              7.4
            6
            -3.4
            4.6
            12
            */

            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            double somaValor = 0.0;

            if (num1 >= 0.0)
            {
                cont += 1;
                somaValor += num1;
            }

            if (num2 >= 0.0)
            {
                cont += 1;
                somaValor += num2;
            }

            if (num3 >= 0.0)
            {
                cont += 1;
                somaValor += num3;
            }

            if (num4 >= 0.0)
            {
                cont += 1;
                somaValor += num4;
            }

            if (num5 >= 0.0)
            {
                cont += 1;
                somaValor += num5;
            }

            if (num6 >= 0.0)
            {
                cont += 1;
                somaValor += num6;
            }

            double media = somaValor / cont;

            Console.WriteLine(cont + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
