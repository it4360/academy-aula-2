using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número:");
            string numeroStr1 = Console.ReadLine();

            Console.WriteLine("Digite o 2º número:");
            string numeroStr2 = Console.ReadLine();
            
            int numero1 = Convert.ToInt32(numeroStr1);
            int numero2 = Convert.ToInt32(numeroStr2);
            int opcao = 0;

            do
            {
                Console.WriteLine("Selecione uma operação aritmética");
                Console.WriteLine("Soma: 1");
                Console.WriteLine("Subtração: 2");
                Console.WriteLine("Multiplicação: 3");
                Console.WriteLine("Divisão: 4");
                Console.WriteLine("Sua opção:");
                string opcaoStr = Console.ReadLine();
                opcao = Convert.ToInt32(opcaoStr);
            }
            while (opcao < 1 || opcao > 4);


            switch (opcao)
            {
                case 1:
                    Console.WriteLine("A soma dos dois números é " + (numero1 + numero2));
                    break;
                case 2:
                    Console.WriteLine("A subtração dos dois números é " + (numero1 - numero2));
                    break;
                case 3:
                    Console.WriteLine("A multiplicação dos dois números é " + (numero1 * numero2));
                    break;
                case 4:
                    Console.WriteLine("A divisão dos dois números é " + (numero1 / numero2));
                    break;
            }
        }
    }
}
