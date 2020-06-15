using System;

namespace BoletimAluno
{
    class Program
    {
       static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.nota1 = Convert.ToInt32(Console.ReadLine());
            aluno.nota2 = Convert.ToInt32(Console.ReadLine());
            aluno.nota3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("NOTA FINAL = "+aluno.SomaNotas().ToString("F2")+"\n");
            if (aluno.Aprovado())
                Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "+ aluno.NotaRestante().ToString("F2") + " PONTOS");
            }
        }
    }
}
