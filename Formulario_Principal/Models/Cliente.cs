using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Cliente : Pessoa
    {
        public int NumeroFiscal;

        public Cliente(string nome, string morada, int numeroFiscal) : base(nome,morada) 
        {
            this.NumeroFiscal = numeroFiscal;
        }
    }
}