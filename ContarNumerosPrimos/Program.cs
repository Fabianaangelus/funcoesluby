using System;

namespace ContarNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contar numeros primos : Entre com o valor diferente de 1 e 2...");

            ContarNumerosPrimos(Convert.ToInt32(Console.ReadLine()));

            Console.ReadKey();



        }

        public static void ContarNumerosPrimos(int numero)
        {
            if (numero == 1 || numero == 2)
            {
                Console.WriteLine("Numero invalido, digite um valor diferente de 1 ou 2");

                Console.ReadKey();
            }
            else
            {
                int numeroInteiro;
                for (int i = 3; i <= numero; i++)
                {
                    if ((i / 1 == i) && (i / i == 1))
                    {
                        if (!int.TryParse((i / 2.0).ToString(), out numeroInteiro))
                            Console.WriteLine($"Os numeros primos sao: {i.ToString()}");
                    }
                }
            }
        }
    }
}
        
    

