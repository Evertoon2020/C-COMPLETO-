using System;
using System.Globalization;

namespace Atividade4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            Console.WriteLine("Digite o Nome Do Funcionario, o Salario e o IRPF: ");
            fun.Nome = Console.ReadLine();
            fun.SalarioB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.Irpf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: " + fun);

            Console.WriteLine("\nDigite a porcentagem do aumento sobre o salario bruto: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.Aumento(porcent);

            Console.WriteLine("Dados atualizados: " + fun);
        }
    }
}
