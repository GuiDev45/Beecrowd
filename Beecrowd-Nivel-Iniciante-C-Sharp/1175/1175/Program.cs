using System;

namespace _1175
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um vetor N[20]. 
            Troque a seguir, o primeiro elemento com o último, o segundo elemento com o penúltimo, etc., até trocar o 10º com o 11º. 
            Mostre o vetor modificado.

            Entrada
            A entrada contém 20 valores inteiros, positivos ou negativos.

            Saída
            Para cada posição do vetor N, escreva "N[i] = Y", onde i é a posição do vetor e Y é o valor armazenado naquela posição.
            
            Exemplos de Entrada             Exemplos de Saída
            0                               N[0] = 230
            -5                              N[1] = 63
            ...                             ...
            63                              N[18] = -5
            230                             N[19] = 0
            */

            int[] N = new int[20];

            int cont = 0;

            for (int i = 0; i < 20; i++)
            {
                int Y = int.Parse(Console.ReadLine());
                N[i] = Y;
            }
            
            for (int i = 0; i < 20 / 2; i++)
            {
                cont = N[i];
                N[i] = N[20 - 1 - i];
                N[20 - 1 - i] = cont;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }

        }
    }
}
