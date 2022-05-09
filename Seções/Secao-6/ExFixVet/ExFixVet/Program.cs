using System;

namespace ExFixVet
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospedagem[] hosp = new Hospedagem[10];

            Console.Write("Quantos quartos serão reservados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\n"+i + "° Hospede: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                hosp[quarto] = new Hospedagem (nome, email);
            }

            Console.WriteLine("\nQuartos Reservados:");

            for (int i = 0; i < 10; i++)
            {
                if(hosp[i] != null){
                    Console.WriteLine(i + ": " + hosp[i]);
                }
            }
        }
    }
}
