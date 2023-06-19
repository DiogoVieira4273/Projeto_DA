using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Sessao
    {
        public int id { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Preco { get; set; }

        public Sessao(DateTime dataHora, decimal preco)
        {
            this.DataHora = dataHora;
            this.Preco = preco;
        }
    }
}