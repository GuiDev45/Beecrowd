using System;

namespace _1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
            Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
            Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

            Entrada
            O arquivo de entrada contém um valor inteiro.

            Saída
            Imprima a saída conforme exemplo fornecido.

            Exemplos de Entrada             Exemplos de Saída
            400                             1 ano(s)
                                            1 mes(es)
                                            5 dia(s)                       
            -------------------             -------------------
            800                             2 ano(s)
                                            2 mes(es)
                                            10 dia(s) 
            -------------------             -------------------
            30                              0 ano(s)
                                            1 mes(es)
                                            0 dia(s)
            */

            int ano = 365;
            int mes = 30;

            int idade = int.Parse(Console.ReadLine());

            int quociente = idade / ano;
            Console.WriteLine(quociente + " ano(s)");
            int resto = idade % ano;

            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto = resto % mes;

            Console.WriteLine(resto + " dia(s)");
        }
    }
}
