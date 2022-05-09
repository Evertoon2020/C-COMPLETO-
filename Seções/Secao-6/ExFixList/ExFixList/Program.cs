using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExFixList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> listFuncionarios = new List<Funcionarios>();

            for(int i=1;i <= n; i++)
            {
                Console.WriteLine("\nEmplyoee #"+i+":");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listFuncionarios.Add(new Funcionarios(id, nome, salario));
            }

            Console.Write("\nEnter the employee id that will have salary increase : ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionarios aumento = listFuncionarios.Find(x => x.Id == procuraId);
            if(aumento != null)
            {
                Console.Write("Enter the percentage: ");
                double percentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aumento.AumentoSalario(percentagem);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Funcionarios obj in listFuncionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
