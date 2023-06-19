using Formulario_Principal.Controller;
using Formulario_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formulario_Principal.Models;

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
            CinemaController.AddSessao(DateTime.Now, decimal.Parse(tbPreco.Text));
        }

        private void btnAlterarSessao_Click(object sender, EventArgs e)
        {
            var sessao = (Sessao)listBoxSessao.SelectedItem;
            CinemaController.UpdateSessao(sessao);
        }

        private void btnRemoverSessao_Click(object sender, EventArgs e)
        {
            var sessao = (Sessao)listBoxSessao.SelectedItem;
            CinemaController.RemoveSessao(sessao);
        }

        private void btnObterSessao_Click(object sender, EventArgs e)
        {
            var sessao = CinemaController.GetSessoes();
            listBoxSessao.DataSource = sessao;

            if (sessao == null)
            {
                listBoxSessao.SelectedIndex = 0;
            }
        }
    }
}