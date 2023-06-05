using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Bilhete
    {
        public int id;
        public string Lugar;
        public bool Estado;

        public Bilhete(string lugar)
        {
            this.Lugar = lugar;
        }


    }
}
