using System;
using System.Globalization;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            float media;
            
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f1.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f2.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.Salario + f2.Salario)/2;

            Console.WriteLine("Salário médio: R$" + media);
        }
    }
}
