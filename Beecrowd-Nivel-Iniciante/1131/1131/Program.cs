using System;

namespace _1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. 
            Escreva um programa para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. 
            Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. 
            Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, 
            caso contrário deve ser encerrado imprimindo:

            - Quantos GRENAIS fizeram parte da estatística.
            - O número de vitórias do Inter.
            - O número de vitórias do Grêmio.
            - O número de Empates.
            - Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).

            Entrada
            O arquivo de entrada contém 2 valores inteiros, correspondentes aos gols marcados pelo Inter e pelo Grêmio respectivamente. 
            Em seguida háverá um inteiro (1 ou 2), correspondente à repetição do programa.

            Saída
            Após cada leitura dos gols, deve ser impressa a mensagem "Novo grenal (1-sim 2-nao)". 
            Quando o algoritmo for encerrado devem ser mostradas as estatísticas conforme a descrição apresentada acima. 
            Obs: a palavra "Gremio" deve ser impressa sem acento, conforme o exemplo abaixo.
            
            Exemplos de Entrada             Exemplos de Saída
            3 2                             Novo grenal (1-sim 2-nao)
            1                               Novo grenal (1-sim 2-nao)
            2 3                             Novo grenal (1-sim 2-nao)
            1                               3 grenais
            3 1                             Inter:2
            2                               Gremio:1
                                            Empates:0
                                            Inter venceu mais
            */

            int golInter = 0;
            int golGremio = 0;
            int decisao = 0;
            int pontoInter = 0;
            int pontoGremio = 0;
            int pontoGrenal = 0;
            int empate = 0;

            string[] vet = Console.ReadLine().Split(' ');
            golInter = int.Parse(vet[0]);
            golGremio = int.Parse(vet[1]);

            while (decisao != 2)
            {
                if (golInter > golGremio)
                {
                    pontoInter++;
                }
                else
                {
                    pontoGremio++;
                }

                if (golInter == golGremio)
                {
                    empate++;
                }

                pontoGrenal++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                decisao = int.Parse(Console.ReadLine());
                if (decisao != 2)
                {
                    vet = Console.ReadLine().Split(' ');
                    golInter = int.Parse(vet[0]);
                    golGremio = int.Parse(vet[1]);
                }
            }

            Console.WriteLine(pontoGrenal + " grenais");
            Console.WriteLine("Inter:" + pontoInter);
            Console.WriteLine("Gremio:" + pontoGremio);
            Console.WriteLine("Empates:" + empate);

            if (golInter > golGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}
