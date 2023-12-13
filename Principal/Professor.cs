using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Professor
    {
        private readonly string _nome;
        private readonly string _materia;
        private double _salario;

        public Professor(string nome, string materia, double salario)
        {
            _nome = nome;
            _materia = materia;
            _salario = salario;
        }
    }
}
