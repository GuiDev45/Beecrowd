using System;
using System.Globalization;

namespace _1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda 
            para organizar os experimentos de um laboratório o qual ela é responsável. 
            Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.

            Este laboratório em especial utiliza três tipos de cobaias: 
            sapos, ratos e coelhos. Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, 
            o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.

            Entrada
            A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. 
            Cada caso de teste contém um inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas
             e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).

            Saída
            Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, 
            sendo que o percentual deve ser apresentado com dois dígitos após o ponto.
            
            Exemplos de Entrada             Exemplos de Saída
            10                              Total: 92 cobaias
            10 C                            Total de coelhos: 29
            6 R                             Total de ratos: 40
            15 S                            Total de sapos: 23
            5 C                             Percentual de coelhos: 31.52 %
            14 R                            Percentual de ratos: 43.48 %
            9 C                             Percentual de sapos: 25.00 %
            6 R
            8 S
            5 C
            14 R
            */

            int rato = 0;
            int sapo = 0;
            int coelho = 0;
            int total = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int Quantia = int.Parse(vet[0]);
                char Tipo = char.Parse(vet[1]);

                total += Quantia;

                if (Tipo == 'R')
                {
                    rato += Quantia;
                }
                else if (Tipo == 'S')
                {
                    sapo += Quantia;
                }
                else
                {
                    coelho += Quantia;
                }
            }

            double porcentagemRato = (rato * 100.00) / total;
            double porcentagemSapo = (sapo * 100.00) / total;
            double porcentagemCoelho = (coelho * 100.00) / total;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
