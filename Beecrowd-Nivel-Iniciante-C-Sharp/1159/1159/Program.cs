using System;

namespace _1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*O programa deve ler um valor inteiro X indefinidas vezes. 
            (O programa irá parar quando o valor de X for igual a 0). 
            Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X , 
            se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, 
            enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.

            Entrada
            O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

            Saída
            Imprima a saida conforme a explicação acima e o exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
            4                               40
            11                              80
            0     
            */

            int X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                int cont = 0;
                int soma = X;
                int total = X;
                if (X % 2 == 0)
                {
                    while (cont < 4)
                    {
                        soma += 2;
                        total += soma;
                        cont++;
                    }
                    Console.WriteLine(total);
                }
                else if (X % 2 != 0)
                {
                    soma += 1;
                    total += 1;
                    while (cont < 4)
                    {
                        soma += 2;
                        total += soma;
                        cont++;
                    }
                    Console.WriteLine(total);
                }

                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
