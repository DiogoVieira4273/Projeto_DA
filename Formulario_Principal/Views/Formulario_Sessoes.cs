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
    public partial class Formulario_Sessoes : Form
    {
        public Formulario_Sessoes()
        {
            InitializeComponent();
        }

        private void btnAdicionarSessao_Click(object sender, EventArgs e)
        {
            CinemaController.AddSessao(DateTime.Now, 10.00,2);
        }

        private void btnAlterarSessao_Click(object sender, EventArgs e)
        {
            CinemaController.UpdateSessao();
        }

        private void btnRemoverSessao_Click(object sender, EventArgs e)
        {
            CinemaController.RemoveSessao();
        }

        private void btnObterSessao_Click(object sender, EventArgs e)
        {
            var sessao = CinemaController.GetSessoes();
            listBoxSessao.DataSource = sessao;
        }
    }
}
