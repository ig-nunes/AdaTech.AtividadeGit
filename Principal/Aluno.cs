using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Aluno
    {
        private string nome;
        private string cpf;
        private string matricula;
        private double mediaNotas;
        private DateTime nascimento;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        public double MediaNotas
        {
            get { return mediaNotas; }
            set { mediaNotas = value; }
        }

        public Aluno(string nome, string cpf, string matricula, double mediaNotas, DateTime nascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.matricula = matricula;
            this.mediaNotas = mediaNotas;
            this.nascimento = nascimento;
        }

        public string CalcularSituacao()
        {
            if (mediaNotas >= 7.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

    }
}
