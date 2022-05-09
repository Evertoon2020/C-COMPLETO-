using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4Fix
{
    class ConversorDeMoeda
    {
        public static double Iof = 6;

        public static double CalculaMoeda( double cotacao, double valor)
        {
            double resultado = cotacao * valor;
            return resultado + ((resultado / 100) * Iof);
        }
    }
}
