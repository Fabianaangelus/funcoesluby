using System;

namespace ExercicioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            

            {
                Console.WriteLine("Digite um valor maior que 1...");
                double resultado = CalcularFatorial(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Valor fatorial é: {resultado.ToString()}");
                Console.ReadKey();

            }
        }

        private static double CalcularFatorial(int numero)
        {
            double resultado = 1;
            while (numero != 1)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }
            return resultado;
        }
    }
}
    

