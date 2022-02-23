using System;

namespace CalcularDiferencaData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular dias : entre com a data inicio yyyy-MM-dd");

            DateTime dataInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Entre com a data fim yyyy-MM-dd");

            DateTime dataFim = Convert.ToDateTime(Console.ReadLine());
            var dias = CalcularData(dataInicio, dataFim);

            Console.WriteLine($"a diferenca entre as datas são de {dias} dias...");

        }
        public static double CalcularData(DateTime dataInicio, DateTime dataFim)
        {
             
            var dias = dataFim.Subtract(dataInicio).TotalDays;

            return dias;

        }
    }
}
    

