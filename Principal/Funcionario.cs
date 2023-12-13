using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Funcionario
    {
        private decimal _id;
        private string _cpf;
        private string _nome;
        private string _email;
        private string _cargo;
        private double _salario;
        private DateTime _dataDeAdmissao;
        private DateTime _dataDeDemissao;
   
        public decimal Id { get { return _id; } }
        public string Cpf { get { return _cpf; } }
        public string Nome { get { return _nome; } }

        public string Email { get { return _email;}  set { this._email = value; } }
        public string Cargo { get { return _cargo; } set { this._cargo = value; } }
        public double Salario { get { return _salario; } set { this._salario = value; } }
        public DateTime DataDeAdmissao { get {  return _dataDeAdmissao; } }
        public DateTime DataDeDemissao { get { return _dataDeDemissao; } }

        public Funcionario(decimal id, string cpf, string nome, string email, string cargo, double salario, DateTime dataDeAdmissao)
        {
            _id = id;
            _cpf = cpf;
            _nome = nome;
            _email = email;
            _cargo = cargo;
            _salario = salario;
            _dataDeAdmissao = dataDeAdmissao;
        }
    }
}
