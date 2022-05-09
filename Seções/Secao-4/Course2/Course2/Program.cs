using System;
using System.Globalization;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade Estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados dos Produto:" + p);

            Console.Write("\nDigite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " +p);

            Console.Write("\nDigite o número de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
