using Formulario_Principal.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Principal.Views
{
    public partial class Formulario_Sala : Form
    {
        public Formulario_Sala()
        {
            InitializeComponent();
        }

        private void btnAdicionarSala_Click(object sender, EventArgs e)
        {
            CinemaController.AddSala(tbNome.Text, int.Parse(tbFilas.Text), int.Parse(tbColunas.Text));
        }

        private void btnAlterarSala_Click(object sender, EventArgs e)
        {
            CinemaController.UpdateSala();
        }

        private void btnRemoverSala_Click(object sender, EventArgs e)
        {
            CinemaController.RemoveSala();
        }

        private void btnObterSala_Click(object sender, EventArgs e)
        {
            var sala = CinemaController.GetSalas();
            listBoxSalas.DataSource = sala;
        }
    }
}
