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
    public partial class Formulario_Cinema : Form
    {
        public Formulario_Cinema()
        {
            InitializeComponent();
        }

        private void btnAlterarCinema_Click(object sender, EventArgs e)
        {
            var cinema = (Cinema)listBoxCinema.SelectedItem;
            CinemaController.UpdateCinema(cinema);
        }

        private void btnRemoverCinema_Click(object sender, EventArgs e)
        {
            var cinema = (Cinema)listBoxCinema.SelectedItem;
            CinemaController.RemoveCinema(cinema);
        }
    }
}