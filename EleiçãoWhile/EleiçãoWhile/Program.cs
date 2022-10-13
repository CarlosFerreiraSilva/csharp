using System;

namespace EleiçãoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições 2022");
            Console.WriteLine("");
            int qtdCand26 = 0;
            int qtdcand44 = 0;
            int qtd56 = 0;
            int qtdnulo = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Qual o seu nome?");
                Console.WriteLine("");
                string nome = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Vote em um dos candidatos a seguir");
                Console.WriteLine("26 - João");
                Console.WriteLine("44 - Maria");
                Console.WriteLine("56 - Tablet");
                Console.WriteLine("0 - Nulo");
                Console.WriteLine("");
                int MeuVoto = Convert.ToInt32(Console.ReadLine());

                if (MeuVoto == 26) { qtdCand26 = qtdCand26 + 1; }
                else if (MeuVoto == 44) { qtdcand44 = qtdcand44 + 1; }
                else if (MeuVoto == 56) { qtd56 = qtd56 + 1; }
                else qtdnulo = qtdnulo + 1;

                Console.WriteLine("Deseja continuar [sim|não]");
                string resposta = Console.ReadLine();

                //if (resposta == "sim") { continuar = true; }
                //else continuar = false;

                if (resposta == "sim" ? continuar == true : continuar == false) ;


            }
        }
    }
}
