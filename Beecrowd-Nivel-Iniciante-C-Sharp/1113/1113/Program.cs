using System;

namespace _1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. 
            Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.

            Entrada
            A entrada contém vários casos de teste. 
            Cada caso contém dois valores inteiros X e Y. 
            A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.

            Saída
            Para cada caso de teste imprima “Crescente”, 
            caso os valores tenham sido digitados na ordem crescente, 
            caso contrário imprima a mensagem “Decrescente”.
            
            Exemplos de Entrada             Exemplos de Saída
            5 4                             Decrescente
            7 2                             Decrescente
            3 8                             Crescente
            2 2
            */

            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                valores = Console.ReadLine().Split(' ');

                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
            }
        }
    }
}
