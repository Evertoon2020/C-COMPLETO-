using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome Completo:");
            string nome = Console.ReadLine();
            Console.WriteLine($"{nome} quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nome} entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"{nome} entre com seu último nome, idade e altura (mesma linha separando por espaço):");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = (vet[0]);
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}\n{quarto}\n{preco.ToString("F2", CultureInfo.InvariantCulture)}\n{sobrenome}\n{idade}\n{altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
