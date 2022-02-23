using System;

namespace ObterElementosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listar numeros pares");

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            ObterElementosPares(numeros);


        }
        public static void ObterElementosPares(int[] vetor)
        {
            Console.WriteLine("Os numeros pares sao...");
            foreach (var item in vetor)
            {
                if (item % 2 == 0)
                    Console.WriteLine($"{item}");
            }
        }
    }
}
    

