using System;

namespace CalcularRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
       
            Console.WriteLine("Digite a largura e altura do retângulo: ");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine());
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}
