using System;

namespace _1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

            Entrada
            A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
            Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).

            Saída
            Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.
            
            Exemplos de Entrada             Exemplos de Saída
            4                               2 in
            14                              2 out
            123
            10
            -25          
            */

            int X = 0, contIn = 0, contOut = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
