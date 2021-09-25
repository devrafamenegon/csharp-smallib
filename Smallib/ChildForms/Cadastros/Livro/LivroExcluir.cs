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
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Livros
{
    public partial class LivroExcluir : Form
    {
        int status_livro;
        string pk_id_livro;

        Principal _principal;

        public LivroExcluir(Principal principal, Cadastro_Livro cadastro_livro_01)
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

        private void btnSim_Click(object sender, EventArgs e)
        {
            pk_id_livro = txtBoxIdLivro.Text;


            try
            {
                //abrindo a conexão
                conectar.Open();
                //objeto de conexao
                SqlCommand Excluir_Livro = new SqlCommand();

                if (pk_id_livro != "0")
                {



                    DialogResult resp = MessageBox.Show("Tem certeza de que deseja excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {

                        Excluir_Livro.CommandText = "delete from Livro where pk_id_livro = " + txtBoxIdLivro.Text;

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Excluir_Livro.Connection = conectar;

                        //EXECUTAR QUERY
                        Excluir_Livro.ExecuteNonQuery();

                        MessageBox.Show("Exclusão efetuada com sucesso");


                        _principal.OpenChildForm(new LivroMenu(_principal));

                    }
                }

                //FECHAR CONEXÃO
                conectar.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CONECTAR COM O BANCO DE DADOS!!!" + Convert.ToString(ex));
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LivroMenu(_principal));
        }
    }
}
