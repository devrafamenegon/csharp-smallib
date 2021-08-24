using Smallib.ChildForms.Cadastros.Autores;
using Smallib.ChildForms.Cadastros.Cidade;
using Smallib.ChildForms.Cadastros.Curso;
using Smallib.ChildForms.Cadastros.Editora;
using Smallib.ChildForms.Cadastros.Genero;
using Smallib.ChildForms.Cadastros.Idioma;
using Smallib.ChildForms.Cadastros.Leitores;
using Smallib.ChildForms.Cadastros.Livros;
using Smallib.ChildForms.Cadastros.Nacionalidade;
using Smallib.ChildForms.Cadastros.Tipo_do_Leitor;
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

        private void btnNacionalidade_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new NacionalidadeMenu(_principal));
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoMenu(_principal));
        }

        private void btnCidade_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CidadeMenu(_principal));
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorMenu(_principal));
        }

        private void btnEditora_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EditoraMenu(_principal));
        }

        private void btnLeitor_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LeitorMenu(_principal));
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LivroMenu(_principal));
        }

        private void btnTipoLeitor_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new TipoMenu(_principal));
        }
    }
}
