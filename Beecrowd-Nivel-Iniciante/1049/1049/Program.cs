using System;

namespace _1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

            Vertebrado - Ave - Carnívoro = Águia
            Vertebrado - Ave - Onivoro = Pomba
            Vertebrado - Mamífero - Onivoro = Homem
            Vertebrado - Mamífero - Herbívoro = Vaca
            Invertebrado - Inseto - Hematofago = Pulga
            Invertebrado - Inseto - Herbívoro = Lagarta
            Invertebrado - Anelídeo - Hematofago = Sanguessuga
            Invertebrado - Anelídeo - Onivoro = Minhoca

            Entrada
            A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

            Saída
            Imprima o nome do animal correspondente à entrada fornecida.
            
            Exemplos de Entrada             Exemplos de Saída
            vertebrado                      homem
            mamifero
            onivoro                         
               
            -------------------             -------------------
            vertebrado                      aguia
            ave
            carnivoro
            -------------------             -------------------
            invertebrado                    minhoca
            anelideo
            onivoro
            */

            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }

            if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }

            if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }

            if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}
