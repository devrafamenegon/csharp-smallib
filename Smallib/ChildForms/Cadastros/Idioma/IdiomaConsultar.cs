using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms.Cadastros.Idioma
{
    public partial class IdiomaConsultar : Form
    {
        Principal _principal;
        public IdiomaConsultar(Principal principal, Cadastro_Idioma cadastro_idioma_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdIdioma.Text = cadastro_idioma_01.pk_id_idioma.ToString();
            txtBoxNomeIdioma.Text = cadastro_idioma_01.nome_idioma;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new IdiomaMenu(_principal));
        }
    }
}
