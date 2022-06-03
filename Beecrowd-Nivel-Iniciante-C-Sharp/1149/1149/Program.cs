using System;

namespace _1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para ler um valor A e um valor N. Imprimir a soma de A + i para cada i com os valores (0 <= i <= N-1). 
            Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.

            Entrada
            A entrada contém somente valores inteiros, podendo ser positivos ou negativos. Todos os valores estão na mesma linha.

            Saída
            A saída contém apenas um valor inteiro.
            
            Exemplos de Entrada             Exemplos de Saída
            3 2                             7
            -------------------             -------------------
            3 -1 0 -2 2                     7
            */

            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int cont = 1;

            while (n <= 0)
            {
                cont++;
                n = int.Parse(vet[cont]);

            }

            int soma = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                soma = soma + (a + i);

            }
            Console.WriteLine(soma);
        }
    }
}
