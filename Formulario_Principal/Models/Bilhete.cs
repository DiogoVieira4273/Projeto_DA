using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Bilhete
    {
        public int id {  get; set; }
        public string Lugar { get; set; }
        public bool Estado { get; set; }

        public Bilhete(string lugar)
        {
            this.Lugar = lugar;
        }
    }
}