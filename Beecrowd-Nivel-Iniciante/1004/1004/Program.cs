﻿using System;

namespace _1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
            A seguir mostre a variável PROD com mensagem correspondente.   

            Entrada
            O arquivo de entrada contém 2 valores inteiros.

            Saída
            Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, 
            com um espaço em branco antes e depois da igualdade. Não esqueça de imprimir o fim de linha após o produto, 
            caso contrário seu programa apresentará a mensagem: “Presentation Error”.

            Exemplos de Entrada             Exemplos de Saída
            3                               PROD = 27
            9
            -------------------             -------------------
            -30                             PROD = -300
            10
            -------------------             -------------------
            0                               PROD = 0
            9
            */

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
