using System;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, quantia;
            Console.Write("Qual é a cotação do dolar: ");
            cotacao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar: ");
            quantia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais = "+ConversorDeMoeda.DolarParaReal(cotacao,quantia).ToString("F2"));
        }
    }
}
