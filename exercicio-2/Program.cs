using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int atual = 1;
            int ultimo = 0;
            int aux = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(atual);
                aux = atual;
                atual += ultimo;
                ultimo = aux;
            }
        }
    }
}
