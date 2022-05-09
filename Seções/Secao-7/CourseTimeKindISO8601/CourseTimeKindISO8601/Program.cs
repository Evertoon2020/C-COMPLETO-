using System;

namespace CourseTimeKindISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeKind
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d1);//Imprime d1
            Console.WriteLine("d1 Kind: " + d1.Kind);//Imprime mostrando o Kind mostra se é local ou Utc
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());//Imprime convertendo para Local
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());//Imprime convertendo para Utc
            Console.WriteLine("d2: " + d2);//Imprimei d2
            Console.WriteLine("d2 Kind: " + d2.Kind);//Imprime mostrando o Kind mostra se é local ou Utc
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());//Imprime convertendo para Local
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());//Imprime convertendo para Utc
            Console.WriteLine("d3: " + d3);//Imprimei d3
            Console.WriteLine("d3 Kind: " + d3.Kind);//Imprime mostrando o Kind mostra se é local ou Utc
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());//Imprime convertendo para Local
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());//Imprime convertendo para Utc


            //Padrão ISO 8601
            //https://www.iso.org/iso-8601-date-and-time-format.html
            //https://en.wikipedia.org/wiki/ISO_8601
            //Formato:  yyyy - MM - ddTHH:mm: ssZ (Z indica que a data/ hora está em Utc)

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d4: " + d4);//Imprime d4
            Console.WriteLine("d4 Kind: " + d4.Kind);//Imprime mostrando o Kind mostra se é local ou Utc
            Console.WriteLine("d4 to Local: " + d4.ToLocalTime());//Imprime convertendo para Local
            Console.WriteLine("d4 to Utc: " + d4.ToUniversalTime());//Imprime convertendo para Utc
            Console.WriteLine("d5: " + d5);//Imprime d4
            Console.WriteLine("d5 Kind: " + d5.Kind);//Imprime mostrando o Kind mostra se é local ou Utc
            Console.WriteLine("d5 to Local: " + d5.ToLocalTime());//Imprime convertendo para Local
            Console.WriteLine("d5 to Utc: " + d5.ToUniversalTime());//Imprime convertendo para Utc
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado! forma naõ correta de imprimir 
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));//Forma mais correta de imprimir
        }
    }
}
