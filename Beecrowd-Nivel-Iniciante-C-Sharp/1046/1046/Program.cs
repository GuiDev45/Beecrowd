using System;

namespace _1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
            sabendo que o mesmo pode começar em um dia e terminar em outro, 
            tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Entrada
            A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

            Saída
            Apresente a duração do jogo conforme exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
            16 2                            O JOGO DUROU 10 HORA(S)                  
            -------------------             -------------------
            0 0                             O JOGO DUROU 24 HORA(S)
            -------------------             -------------------
            2 16                     	    O JOGO DUROU 14 HORA(S)
            */

            string[] horario = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(horario[0]);
            int horaFinal = int.Parse(horario[1]);
            int calculoHoraInicial, calculoHoraFinal, calculoTempoEvento = 0;

            if (horaFinal < horaInicial)
            {
                calculoHoraInicial = 24 - horaInicial;
                calculoHoraFinal = horaFinal;
                calculoTempoEvento = calculoHoraInicial + calculoHoraFinal;
            }

            if (horaFinal == horaInicial)
            {
                calculoTempoEvento = 24;
            }

            if (horaFinal > horaInicial)
            {
                calculoHoraInicial = 24 - horaInicial;
                calculoHoraFinal = horaFinal - 24;
                calculoTempoEvento = calculoHoraInicial + calculoHoraFinal;
            }

            Console.WriteLine("O JOGO DUROU " + calculoTempoEvento + " HORA(S)");
        }
    }
}
