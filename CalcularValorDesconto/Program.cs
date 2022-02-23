using System;

namespace CalcularValorDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            double percentual = 0;
            double valor_final; 

            Console.WriteLine("Insira valor desejado");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do desconto a ser aplicado");
            percentual = Convert.ToDouble( Console.ReadLine());

            var valorPercentual = percentual / 100.0;

            valor_final = valor - (valorPercentual * valor);
            
            Console.WriteLine( valor_final);

        }
    }
}
