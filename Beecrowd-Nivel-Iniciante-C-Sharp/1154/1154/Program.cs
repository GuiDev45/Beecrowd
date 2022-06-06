using System;
using System.Globalization;

namespace _1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. 
            O último dado, que não entrará nos cálculos, contém o valor de idade negativa. 
            Calcular e imprimir a idade média deste grupo de indivíduos.

            Entrada
            A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

            Saída
            A saída contém um valor correspondente à média de idade dos indivíduos.
            A média deve ser impressa com dois dígitos após o ponto decimal.
            
            Exemplos de Entrada             Exemplos de Saída
            34                              39.25
            56
            44
            23
            -2
            */

            double idade = 0.0, media = 0.0, soma = 0.0;
            int cont = 0;

            idade = double.Parse(Console.ReadLine());

            while (idade > 0)
            {
                soma += idade;
                cont++;
                idade = double.Parse(Console.ReadLine());
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
