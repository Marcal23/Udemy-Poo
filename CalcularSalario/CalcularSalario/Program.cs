using System;

namespace CalcularSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            double porcentagem;

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Funcionario: " + funcionario);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcentagem = Convert.ToDouble(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine();

            Console.Write("Dados atualizados: " + funcionario);

        }
    }
}
