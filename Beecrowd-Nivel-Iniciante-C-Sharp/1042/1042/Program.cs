using System;

namespace _1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

            Entrada
            A entrada contem três números inteiros.

            Saída
            Imprima a saída conforme foi especificado.
            
            Exemplos de Entrada             Exemplos de Saída
            7 21 -14                        -14
                                            7
                                            21

                                            7
                                            21
                                            -14                  
            -------------------             -------------------
            -14 21 7                        -14
                                            7
                                            21

                                            -14
                                            21
                                            7
            */

            string[] vet = Console.ReadLine().Split(' ');

            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            int menor = 0, medio = 0, maior = 0;

            if (num1 < num2 && num1 < num3 && num2 < num3)
            {
                menor = num1;
                medio = num2;
                maior = num3;
            }
            else if (num1 < num2 && num1 < num3 && num2 > num3)
            {
                menor = num1;
                medio = num3;
                maior = num2;
            }
            else if (num1 > num2 && num1 < num3 && num2 < num3)
            {
                menor = num2;
                medio = num1;
                maior = num3;
            }
            else if (num1 > num2 && num1 > num3 && num2 < num3)
            {
                menor = num2;
                medio = num3;
                maior = num1;
            }
            else if (num1 > num2 && num1 > num3 && num2 > num3)
            {
                menor = num3;
                medio = num2;
                maior = num1;
            }
            else
            {
                menor = num3;
                medio = num1;
                maior = num2;
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);

            Console.WriteLine();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
