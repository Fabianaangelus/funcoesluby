using System;

namespace CalcularPremio
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Calcular Prêmio");
            Console.WriteLine("Digite o valor do premio...");
            double valorPremio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ditite o tipo...");
            string tipo = Console.ReadLine();
            Console.WriteLine("Digite o valor fator");
           // Console.ReadKey();

            string valorFatorInformado = Console.ReadLine();

            double _fatorValor = 0;
            if (!string.IsNullOrEmpty(valorFatorInformado))
                _fatorValor = Convert.ToDouble(valorFatorInformado);

            double resultado = CalcularPremio(valorPremio, tipo, _fatorValor);

            Console.WriteLine($"Valor do premio é : {resultado.ToString()}");

            Console.ReadKey();

        }
       

        public static double CalcularPremio(double valorPremio, string tipo, double valorFator)
        {
            double fator = 0;
            switch (tipo)
            {

                case "basic":
                    fator = 1;
                    break;
                case "vip":
                    fator = 1.2;
                    break;
                case "premium":
                    fator = 1.5;
                    break;
                case "deluxe":
                    fator = 1.8;
                    break;
                case "sprecial":
                    fator = 2;
                    break;
                default:
                    break;
            }

            if (valorFator > 0)
                fator = valorFator;

            return valorPremio + fator;
        }

    }
}


