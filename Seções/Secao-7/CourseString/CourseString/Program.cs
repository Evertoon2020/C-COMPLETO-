using System;

namespace CourseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper(); //Convete para Maiusculo
            string s2 = original.ToLower(); //Converte para Minusculo
            string s3 = original.Trim(); //Apaga  os espacos em brancos antes e depois da string
            int n1 = original.IndexOf("bc"); //Procura o parametro e retorna 1° ocorrência (memoria 0,1,2...)
            int n2 = original.LastIndexOf("bc"); //Procura o parametro e retorna a ultima ocorrência (memoria 0,1,2...)
            string s4 = original.Substring(3); //Recorta a string 
            string s5 = original.Substring(3, 5); //Recorta a string e conta quantos depois do caracter vai parar o corte
            string s6 = original.Replace('a', 'x'); //Substiui o caracter do parametro (de,para)
            string s7 = original.Replace("abc", "xy"); //Substiui a string do parametro (de,para)
            bool b1 = String.IsNullOrEmpty(original); //Teste se está vazio ou nula 
            bool b2 = String.IsNullOrWhiteSpace(original); //Teste se está vazio, nula ou com espaços em branco
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
