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
    public partial class Formulario_Bilhetes : Form
    {
        public Formulario_Bilhetes()
        {
            InitializeComponent();
        }

        private void btnAdicionarBilhete_Click(object sender, EventArgs e)
        {
            CinemaController.AddBilhete(tbLugar.Text);
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
    }
}