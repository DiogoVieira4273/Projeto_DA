using Formulario_Principal.Controller;
using Formulario_Principal.Models;
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
    public partial class Formulario_Atendimento : Form
    {
        public Formulario_Atendimento()
        {
            InitializeComponent();
        }

        private void btnObterBilhete_Click(object sender, EventArgs e)
        {
            var bilhete = CinemaController.GetBilhetes();
            listBoxBilhetes.DataSource = bilhete;

            if (bilhete == null)
            {
                listBoxBilhetes.SelectedIndex = 0;
            }
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

        private void btnObterFuncionarios_Click(object sender, EventArgs e)
        {
            var funcionario = CinemaController.GetFuncionarios();
            listBoxFuncionario.DataSource = funcionario;

            if (funcionario == null)
            {
                listBoxFuncionario.SelectedIndex = 0;
            }
        }

        private void btnObterFilme_Click(object sender, EventArgs e)
        {
            var filme = CinemaController.GetFilmes();
            listBoxFilmes.DataSource = filme;

            if (filme == null)
            {
                listBoxFilmes.SelectedIndex = 0;
            }
        }

        private void btnObterCliente_Click(object sender, EventArgs e)
        {
            var cliente = CinemaController.GetClientes();
            listBoxClientes.DataSource = cliente;

            if (cliente == null)
            {
                listBoxClientes.SelectedIndex = 0;
            }
        }
    }
}