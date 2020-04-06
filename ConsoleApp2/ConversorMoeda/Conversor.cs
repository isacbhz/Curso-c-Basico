using System;

using System.Globalization;

namespace ConversorMoeda
{
    class Conversor
    {
        
        public static double IOF = 0.06;

        public static double Calc(double cotacao, double quantidade)
        {
            return (cotacao * quantidade) + ((cotacao * quantidade) *IOF) ;
        }
    }
}
