using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos convidados?");
            int qtdConvidados = Convert.ToInt32(Console.ReadLine());
            string[] nomes = new string[qtdConvidados];
            int[] idades = new int[qtdConvidados];
            int qtdAdultos = 0;

            for (int i = 0; i < qtdConvidados; i++)
            {
                Console.WriteLine("Nome " + (i + 1));
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Idade " + (i + 1));
                idades[i] = Convert.ToInt32(Console.ReadLine());
                if (idades[i] > 17)
                {
                    qtdAdultos++;
                }
            }

            for (int i = 0; i < qtdConvidados; i++)
            {
                Console.WriteLine(nomes[i] + ", " + idades[i] + " ano(s).");
            }
            Console.WriteLine("Quantidade de adultos: " + qtdAdultos);
        }
    }
}
