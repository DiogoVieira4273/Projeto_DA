using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Funcionario : Pessoa
    {
        public decimal Salario; 
        public string Funcao;

        public Funcionario(string nome, string morada, decimal salario, string funcao) : base(nome, morada)
        {
            this.Salario = salario;
            this.Funcao = funcao;
        }
    }
}
