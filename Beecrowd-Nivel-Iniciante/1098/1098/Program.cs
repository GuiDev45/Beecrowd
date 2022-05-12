using System;
using System.Globalization;

namespace _1098
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

            Entrada
            Não há nenhuma entrada neste problema.

            Saída
            Imprima a sequencia conforme exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
                                            I=0 J=1
                                            I=0 J=2
                                            I=0 J=3
                                            I=0.2 J=1.2
                                            I=0.2 J=2.2
                                            I=0.2 J=3.2
                                            .....
                                            I=2 J=?
                                            I=2 J=?
                                            I=2 J=? 
            */

            double i = 0.0;

            while (i <= 2.0)
            {
                double j = i + 1.0;
                if (i == 0.0 || i == 1.0)
                {
                    for (int e = 0; e < 3; e++)
                    {
                        Console.WriteLine("I=" + i.ToString(CultureInfo.InvariantCulture) + " J=" + j.ToString(CultureInfo.InvariantCulture));
                        j++;
                    }
                }
                else
                {
                    for (int e = 0; e < 3; e++)
                    {
                        if (i > 1.9)
                        {
                            Console.WriteLine("I=2 J=" + j.ToString(CultureInfo.InvariantCulture));
                            j++;
                        }
                        else
                        {
                            Console.WriteLine("I=" + i.ToString("F1", CultureInfo.InvariantCulture) + " J=" + j.ToString("F1", CultureInfo.InvariantCulture));
                            j++;
                        }
                    }
                }
                i += 0.2;
            }
        }
    }
}
