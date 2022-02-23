using System;
using System.Linq;

namespace BuscarPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] {
                                            "John Doe",
                                            "Jane Doe",
                                            "Alice Jones",
                                            "Bobby Louis",
                                            "Lisa Romero"};
            Console.WriteLine("Faça uma busca");
            BuscarPessoa(vetor, "John Doe");

        }
        public static string[] BuscarPessoa(string[] vetor, string nome)
        {
            var ret = vetor.Where(p => p == nome).FirstOrDefault();

            Console.WriteLine($"{ret}");
            return new string[] { ret };
        }
    }
}

