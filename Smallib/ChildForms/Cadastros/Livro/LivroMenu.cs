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
    public partial class LivroMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe livro
        Cadastro_Livro livro = new Cadastro_Livro();

        Principal _principal;

        public LivroMenu(Principal principal)
        {
            InitializeComponent();

            //Consultando os livross no banco de dados           // Olha os dados ai
            dados = new SqlDataAdapter("select pk_id_livro, titulo_livro from Livro order by pk_id_livro", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os livros na grade
            dgvLivro.DataSource = datb;
            dgvLivro.Refresh();

            if (dgvLivro.Rows.Count == 0)
            {

                labelDgv.Text = "Nenhum registro encontrado";

            }

            _principal = principal;
        }

        private void radioIdLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioEditoraLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioGeneroLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioAutorLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioIdiomaLivro_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LivroNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLivro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada // Falta dados


                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new LivroEditar(_principal, livro));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLivro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada


                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new LivroExcluir(_principal, livro));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvLivro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada


                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new LivroConsultar(_principal, livro));
            }
        }
    }
}
