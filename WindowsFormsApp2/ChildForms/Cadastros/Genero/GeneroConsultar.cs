using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallib.ChildForms.Cadastros.Genero
{
    public partial class GeneroConsultar : Form
    {
        Principal _principal;
        public GeneroConsultar(Principal principal, Cadastro_Genero cadastro_genero_01)
        {
            InitializeComponent();
            _principal = principal;

            //Passando os valores da instancia da classe para os campos de texto do forms
            txtBoxIdGenero.Text = cadastro_genero_01.pk_id_genero.ToString();
            txtBoxNomeGenero.Text = cadastro_genero_01.nome_genero;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroMenu(_principal));
        }
    }
}
