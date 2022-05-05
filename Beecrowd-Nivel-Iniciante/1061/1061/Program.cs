using System;

namespace _1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pedrinho está organizando um evento em sua Universidade. 
            O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
            O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

            Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

            Entrada
            Como entrada, na primeira linha vai haver a descrição “Dia”, 
            seguido de um espaço e o dia do mês no qual o evento vai começar. 
            Na linha seguinte, será informado o momento no qual o evento vai iniciar, 
            no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, 
            indicando o término do evento.

            Saída
            Na saída, deve ser apresentada a duração do evento, no seguinte formato:

            W dia(s)
            X hora(s)
            Y minuto(s)
            Z segundo(s)

            Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.
            
            Exemplos de Entrada             Exemplos de Saída
            Dia 5                           3 dia(s)
            08 : 12 : 23                    22 hora(s)          
            -------------------             -------------------
            Dia 9                           1 minuto(s)
            06 : 13 : 23                    0 segundo(s)     
            */

            int W, X, Y, Z, resto, diaInicio, diaFinal, inicial, final, duracao;

            string[] dia = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(dia[1]);

            string[] horas = Console.ReadLine().Split(':');
            int horaInicial = int.Parse(horas[0]);
            int minutoInicial = int.Parse(horas[1]);
            int segundoInicial = int.Parse(horas[2]);

            inicial = (int)(diaInicio - 1) * 24 * 60 * 60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;

            dia = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(dia[1]);

            horas = Console.ReadLine().Split(':');
            int horaFinal = int.Parse(horas[0]);
            int minutoFinal = int.Parse(horas[1]);
            int segundoFinal = int.Parse(horas[2]);

            final = (int)(diaFinal - 1) * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;

            duracao = final - inicial;

            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);

            X = resto / (60 * 60);
            resto = resto % (60 * 60);

            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }
    }
}
