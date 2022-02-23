using System;
using System.Linq;

namespace BuscarElementosFaltantes
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
                int[] vetor2 = new int[] { 1, 2, 5 };
                ObterElementosFaltantes(vetor1, vetor2);

            }
        }

        private static int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {

            var result = vetor1.Except(vetor2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            return result.ToArray();
        }
    }
    }
}
