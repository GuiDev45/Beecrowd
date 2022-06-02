using System;
using System.Globalization;

namespace _1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, 
            de modo que o lado A representa o maior dos 3 lados. A seguir, 
            determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, 
            sempre escrevendo uma mensagem adequada:

            se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
            se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
            se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
            se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
            se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

            Entrada
            A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

            Saída
            Imprima todas as classificações do triângulo especificado na entrada.
            
            Exemplos de Entrada             Exemplos de Saída
            7.0 5.0 7.0                     TRIANGULO ACUTANGULO
                                            TRIANGULO ISOSCELES                  
            -------------------             -------------------
            6.0 6.0 10.0                    TRIANGULO OBTUSANGULO
                                            TRIANGULO ISOSCELES
            -------------------             -------------------
            6.0 6.0 6.0                     TRIANGULO ACUTANGULO
                                            TRIANGULO EQUILATERO
            -------------------             -------------------
            5.0 7.0 2.0                     NAO FORMA TRIANGULO
            -------------------             -------------------
            6.0 8.0 10.0                    TRIANGULO RETANGULO
            */

            double A = 0.0, B = 0.0, C = 0.0;

            string[] vet = Console.ReadLine().Split(' ');

            double num1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double num2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double num3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (Math.Max(num1, num2) > num3)
            {
                A = Math.Max(num1, num2);
                if (A > Math.Max(num2, num3))
                {
                    B = Math.Max(num2, num3);
                    C = Math.Min(num2, num3);
                }
                else
                {
                    B = Math.Max(num1, num3);
                    C = Math.Min(num1, num3);
                }
            }
            else
            {
                A = num3;
                B = Math.Max(num1, num2);
                C = Math.Min(num1, num2);
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
