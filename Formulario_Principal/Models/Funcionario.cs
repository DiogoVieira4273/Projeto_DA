using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Funcao { get; set; }

        public Funcionario(string nome, string morada, decimal salario, string funcao) : base(nome, morada)
        {
            this.Salario = salario;
            this.Funcao = funcao;
        }
    }
}