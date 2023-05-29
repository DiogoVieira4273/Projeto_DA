using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Funcionario : Pessoa
    {
        decimal Salario;
        string Funcao;

        public Funcionario(string nome, string moorada, decimal salario, string funcao) : base(nome, moorada)
        {
            this.Salario = salario;
            this.Funcao = funcao;
        }
    }
}
