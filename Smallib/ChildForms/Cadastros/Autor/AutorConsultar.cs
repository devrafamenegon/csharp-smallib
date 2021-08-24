using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Smallib.ChildForms.Cadastros.Autores
{
    public partial class AutorConsultar : Form
    {
        Principal _principal;
        public AutorConsultar(Principal principal, Cadastro_Autor cadastro_autores_01)
        {
            InitializeComponent();
            _principal = principal;

            txtBoxIdAutor.Text = cadastro_autores_01.pk_id_autor.ToString();
            txtBoxNomeAutor.Text = cadastro_autores_01.nome_autor;
            txtBoxNacionalidadeAutor.Text = cadastro_autores_01.nacionalidade_autor;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorMenu(_principal));
        }
    }
}
