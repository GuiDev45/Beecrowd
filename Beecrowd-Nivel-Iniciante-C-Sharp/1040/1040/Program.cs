using System;
using System.Globalization;

namespace _1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. 
            Calcule a média com pesos 2, 3, 4 e 1, respectivamente, 
            para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". 
            Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". 
            Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". 
            Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

            No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. 
            Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. 
            Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). 
            e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", 
            (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) 
            apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.

            Entrada
            A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

            Saída
            Todas as respostas devem ser apresentadas com uma casa decimal. 
            As mensagens devem ser impressas conforme a descrição do problema. 
            Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".
            
            Exemplos de Entrada             Exemplos de Saída
            2.0 4.0 7.5 8.0                 Media: 5.4
            6.4                             Aluno em exame.
                                            Nota do exame: 6.4
                                            Aluno aprovado.
                                            Media final: 5.9                
            -------------------             -------------------
            2.0 6.5 4.0 9.0                 Media: 4.8
                                            Aluno reprovado.
            -------------------             -------------------
            9.0 4.0 8.5 9.0                 Media: 7.3
                                            Aluno aprovado.
            
            */

            double N1, N2, N3, N4, media, nota, mediaFinal;

            string[] vet = Console.ReadLine().Split(' ');

            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = ((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / 10.0;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + nota.ToString("F1", CultureInfo.InvariantCulture));

                mediaFinal = (media + nota) / 2.0;

                if (mediaFinal < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            else
            {
                Console.WriteLine("Aluno aprovado.");
            }
        }
    }
}
