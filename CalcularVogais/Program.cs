using System;
using System.Linq;

namespace CalcularVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto; 
            int i, cv; 
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' }; 
            int total = 0; 


            Console.WriteLine("Digita uma string: ");
            texto = Console.ReadLine(); 

            for (i = 0; i <= texto.Length - 1; i++) 
                for (cv = 0; cv <= 4; cv++) 
                {
                    if (Convert.ToChar(texto.Substring(i, 1)) == vogais[cv])
                    {
                        total++;
                    }

                }
            Console.Write(total); 
            Console.ReadKey();

        }
    }
}