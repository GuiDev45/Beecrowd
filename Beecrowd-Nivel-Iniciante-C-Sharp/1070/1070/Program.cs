using System;

namespace _1070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro X. 
            Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.

            Entrada
            A entrada será um valor inteiro positivo.

            Saída
            A saída será uma sequência de seis números ímpares.
            
            Exemplos de Entrada             Exemplos de Saída
            8                               9
                                            11
                                            13
                                            15
                                            17
                                            19
            */

            int x = int.Parse(Console.ReadLine());
            int cont = x;

            if (x % 2 == 0)
            {
                cont++;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
            }
            else
            {
                Console.WriteLine(x);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
                cont += 2;
                Console.WriteLine(cont);
            }
        }
    }
}
