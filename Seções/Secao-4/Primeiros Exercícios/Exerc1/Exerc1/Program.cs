using System;
using System.Globalization;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine("A(O) " + p1.Nome + " é a(o) mais velha(o) e tem " + p1.Idade +" anos");
            }else if (p2.Idade > p1.Idade)
            {
                Console.WriteLine("A(O) " + p2.Nome + " é a(o) mais velha(o) e tem " + p2.Idade + " anos");
            }else
            {
                Console.WriteLine("A(O) " + p1.Nome + " e a(o) " + p2.Nome + ", tem a mesma idade " +p1.Idade+ " anos");
            }
        }
    }
}
