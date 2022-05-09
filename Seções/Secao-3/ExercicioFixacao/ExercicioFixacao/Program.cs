using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;


            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é R$ {preco1:F2}\n{produto2}, cujo preço é R$ {preco2:F2}\n\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n\nMedida com oito casas decimais: {preco3:F8}\nArredondando (três casas decimais): {preco3:F3}\nSeparador decimal invariant culture: {preco3.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
