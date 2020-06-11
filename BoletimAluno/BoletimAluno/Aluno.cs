using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimAluno
{
    public class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double SomaNotas()
        {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado()
        {
            if (SomaNotas() >= 60)
                return true;
            else
                return false;
        }
        public double NotaRestante()
        {
            if (Aprovado())
                return 0.0;
            else
                return 60 - SomaNotas();
        }
    }
}
