using Smallib.ChildForms.Cadastros.Genero;
using Smallib.ChildForms.Cadastros.Idioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms
{
    public partial class CadastrosRoot : Form
    {
        private Principal _principal;

        public CadastrosRoot(Principal principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new UsuarioSenhaMaster(_principal));
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroMenu(_principal));
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new IdiomaMenu(_principal));
        }
    }
}
