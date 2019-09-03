using System;

namespace Exercicio03
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
            int aux = 0;
            while (numero1 >= numero2)
            {
                aux++;
                numero1 -= numero2;
            }
            Console.WriteLine("A divisão dos dois número é: " + aux);
        }
    }
}
