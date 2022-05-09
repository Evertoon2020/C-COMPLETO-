using System;
using System.Globalization;

namespace CourseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representação interna
            DateTime d0 = DateTime.Now; //Devolve o instate atual do sistema
            Console.WriteLine(d0);
            Console.WriteLine(d0.Ticks); //imprime com o nanosegundos dia 1 a mes 1 e ano 1 da era 

            //Instanciação
            DateTime d1 = new DateTime(2000, 8, 15); //Define a data com a instanciação
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); //Define a data e hora e segundo com a instanciação
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275); ////Define a data e hora, segundo e milessegundos com a instanciação (porém está com formato padrão, por isso não vai sair o milesegundos)
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //Demo - Now, UtcNow, Today
            DateTime d4 = DateTime.Now; // Define o data e horario Atual da Maquina
            DateTime d5 = DateTime.UtcNow; //Define o data e horario Atual do GMT
            DateTime d6 = DateTime.Today; //Define da data de Hoje com horas zeradas
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            //Demo - Parse
            DateTime d7 = DateTime.Parse("2000-08-15"); //Convete para o formato do parametro data
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58"); //Convete para o formato do parametro data e hora
            DateTime d9 = DateTime.Parse("15/08/2000"); //Convete para o formato do parametro data
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58"); //Convete para o formato do parametro data e hora
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            //Demo - ParseExact
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
                                               CultureInfo.InvariantCulture); //Conveter para o formato exato data
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
                                               CultureInfo.InvariantCulture); //Conveter para o formato exato data e hora
            Console.WriteLine(d11);
            Console.WriteLine(d12);


            //Propriedades e operações com DateTime

            //Demo
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);//Imprime da Data da variavel
            Console.WriteLine("1) Date: " + d.Date);//Imprime somente a data
            Console.WriteLine("2) Day: " + d.Day);////Imprime somente o dia 
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);//Imprime somente dia da Semana
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);//Imprime somente dia do Ano
            Console.WriteLine("5) Hour: " + d.Hour);//Imprime somente a Hora
            Console.WriteLine("6) Kind: " + d.Kind);//Imprime somente o tipo local ou universal (padrão local)
            Console.WriteLine("7) Millisecond: " + d.Millisecond);//Imprime somente a milessegudos
            Console.WriteLine("8) Minute: " + d.Minute);//Imprime somente o Minuto
            Console.WriteLine("9) Month: " + d.Month);//Imprime somente o Mês
            Console.WriteLine("10) Second: " + d.Second);//Imprime somente o Segundo
            Console.WriteLine("11) Ticks: " + d.Ticks);//Imprime somente o Ticks
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);//Imprime somente o Horario
            Console.WriteLine("13) Year: " + d.Year);//Imprime somente o Ano

            //Formatação (DateTime -> string)
            DateTime e = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = e.ToLongDateString();//Converte a data de forma longa = cabeçalho 
            string s2 = e.ToLongTimeString();//Converte a hora de forma longa = Hora, minuto e segundo
            string s3 = e.ToShortDateString();//Converte a data de forma resumida = dd/mm/aaaa
            string s4 = e.ToShortTimeString();//Converte a hora de forma resumida = hh:mm
            string s5 = e.ToString();//Converte formato padrão = dd/mm/aaaa hh:mm:ss
            string s6 = e.ToString("yyyy-MM-dd HH:mm:ss");//Converte no formato definido manualmente
            string s7 = e.ToString("yyyy-MM-dd HH:mm:ss.fff");//Converte no formato definido manualmente
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //Operações com Datetime
            DateTime f = new DateTime(2021, 1, 15, 13, 45, 58);
            DateTime g = new DateTime(1997, 1, 15, 13, 45, 58);

            DateTime y = f.Add(timeSpan);//Adiciona timeSpan 
            DateTime y = f.AddDays(1);//Adiciona Dia
            DateTime y = f.AddHours(1);//Adiciona Hora
            DateTime y = f.AddMilliseconds(1);//Adiciona Milessegundo
            DateTime y = f.AddMinutes(1);//Adiciona Minutos
            DateTime y = f.AddMonths(1);//Adiciona Mês
            DateTime y = f.AddSeconds(1);////Adiciona Segundos
            DateTime y = f.AddTicks(9000000000L);//Adiciona Ticks
            DateTime y = f.AddYears(1);//Adiciona Ano

            DateTime y = f.Subtract(timeSpan);//Subtrai pelo time Span
            TimeSpan y = f.Subtract(dateTime);//Subtrai pelo dateTime
        }
    }
}
