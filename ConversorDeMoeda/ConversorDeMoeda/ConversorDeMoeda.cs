using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
   public class ConversorDeMoeda
    {
        public static double IOF = 6;
        public static double DolarParaReal(double cotacao, double quantia)
        {
            return (cotacao * quantia * (IOF/100)) + cotacao * quantia ;
        }

    }
}
