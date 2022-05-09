using System;
using System.Globalization;

namespace ExFix
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int cont = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if(depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome, cont, saldo);
            }
            else
            {
                conta = new ContaBancaria(nome, cont);
            }

            Console.Write("\nDados da conta: \n" + conta);

            Console.Write("\n\nEntre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.Write("Dados da conta atualizados: \n" + conta);

            Console.Write("\n\nEntre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: \n" + conta);

        }
    }
}
