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

namespace Smallib.ChildForms.Cadastros.Livros
{
    public partial class LivroConsultar : Form
    {
        int status_livro;
        string pk_id_livro;

        Principal _principal;
        public LivroConsultar(Principal principal, Cadastro_Livro cadastro_livro_01)
        {
            InitializeComponent();
            _principal = principal;

            txtBoxIdLivro.Text = cadastro_livro_01.pk_id_livro.ToString();
            txtBoxTituloLeitor.Text = cadastro_livro_01.titulo_livro;
            txtDataTombLivro.Text = cadastro_livro_01.tombo_livro;
            txtBoxEditoraLivro.Text = cadastro_livro_01.editora_livro;
            txtBoxAutorLivro.Text = cadastro_livro_01.autor_livro;
            txtBoxGeneroLivro.Text = cadastro_livro_01.genero_livro;
            txtBoxIdiomaLivro.Text = cadastro_livro_01.idioma_livro;
            txtBoxUltEmprLivro.Text = cadastro_livro_01.ultemprest_livro;
            txtUltLeitorLivro.Text = cadastro_livro_01.ultleitor_livro;

            if (status_livro == 0)
            {
                txtBoxStatusLivro.Text = "Disponível";
            }
            else
            {
                txtBoxStatusLivro.Text = "Indisponível";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LivroMenu(_principal));
        }
    }
}
