using System;
using System.Globalization;

namespace Ex4Fix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação da moeda: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quanto da moeda você quer receber? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.CalculaMoeda(cotacao, valor);

            Console.WriteLine("Valor a ser pago na moeda local é: R$" + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
