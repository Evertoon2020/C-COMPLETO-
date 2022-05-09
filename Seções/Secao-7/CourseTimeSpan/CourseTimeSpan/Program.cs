using System;

namespace CourseTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t0 = new TimeSpan(0, 1, 30);// Contrutor de 3 argumentos (hora, minuto e segundo)
            Console.WriteLine(t0);//Imprime o a duração da variavel
            Console.WriteLine(t0.Ticks);//Imprime o a duração da variavel em Tiks "nanosegundos)

            //Demo - construtores
            TimeSpan t1 = new TimeSpan();//Padrão com duração 0
            TimeSpan t2 = new TimeSpan(900000000L);//Com (Ticks como parametrô)
            TimeSpan t3 = new TimeSpan(2, 11, 21);//Com hora, minuto e segundo
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);//Com Dia, hora, minuto e segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);//Com Dia, hora, minuto, segundo e milesegundos
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            //Demo - métodos From
            TimeSpan t6 = TimeSpan.FromDays(1.5);//Referente a unidade Dia 
            TimeSpan t7 = TimeSpan.FromHours(1.5);//Referente a unidade Hora
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);//Referente a unidade Minutos
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);//Referente a unidade Segundos
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);//Referente a unidade Milessegundos
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);//Referente a unidade Ticks
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

            //Propriedades e operações com TimeSpan

            //Demo: MaxValue, MinValue, Zero
            TimeSpan p1 = TimeSpan.MaxValue;//Duração maxima para armazenar
            TimeSpan p2 = TimeSpan.MinValue;//Duração minimo para armazenar
            TimeSpan p3 = TimeSpan.Zero;//Duração zerada
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //Demo - propriedades

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);//Imprime padrão
            Console.WriteLine("Days: " + t.Days);//Imprime quantidade de dias
            Console.WriteLine("Hours: " + t.Hours);//Imprime quantidade de horas
            Console.WriteLine("Minutes: " + t.Minutes);//Imprime quantidade de minutos
            Console.WriteLine("Milliseconds: " + t.Milliseconds);//Imprime quantidade de milessegundos
            Console.WriteLine("Seconds: " + t.Seconds);//Imprime quantidade de segundos
            Console.WriteLine("Ticks: " + t.Ticks);//Imprime quantidade de ticks
            Console.WriteLine("TotalDays: " + t.TotalDays);//Imprime quantidade total de dias em fração
            Console.WriteLine("TotalHours: " + t.TotalHours);//Imprime quantidade de horas em fração
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);//Imprime quantidade total de minutos em fração
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);//Imprime quantidade total de segundos em fração
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);////Imprime quantidade total de Milessegundos em fração

            //Demo - operações
            TimeSpan d1 = new TimeSpan(1, 30, 10);
            TimeSpan d2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = d1.Add(d2);//Soma 
            TimeSpan dif = d1.Subtract(d2);//Subtração
            TimeSpan mult = d2.Multiply(2.0);//Multiplicação
            TimeSpan div = d2.Divide(2.0);//Divisão
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
