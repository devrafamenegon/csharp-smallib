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
    public partial class AutorMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe cidade
        Cadastro_Autor autores = new Cadastro_Autor();

        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvAutor.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosAutores()
        {
            try
            {
                conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by pk_id_autor", conectar);
                datb = new DataTable();
                dados.Fill(datb);

                dgvAutor.DataSource = datb;
                dgvAutor.Refresh();

                checarLinhasDgv();
            }

            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        public AutorMenu(Principal principal)
        {
            InitializeComponent();
            dadosAutores();

            _principal = principal;
        }

        private void radioIdAutor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeAutor_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvAutor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                autores.pk_id_autor = Convert.ToInt32(dgvAutor[0, dgvAutor.CurrentRow.Index].Value.ToString());
                autores.nome_autor = dgvAutor[1, dgvAutor.CurrentRow.Index].Value.ToString();
                autores.nacionalidade_autor = dgvAutor[2, dgvAutor.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new AutorEditar(_principal, autores));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvAutor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                autores.pk_id_autor = Convert.ToInt32(dgvAutor[0, dgvAutor.CurrentRow.Index].Value.ToString());
                autores.nome_autor = dgvAutor[1, dgvAutor.CurrentRow.Index].Value.ToString();
                autores.nacionalidade_autor = dgvAutor[2, dgvAutor.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new AutorExcluir(_principal, autores));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvAutor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                autores.pk_id_autor = Convert.ToInt32(dgvAutor[0, dgvAutor.CurrentRow.Index].Value.ToString());
                autores.nome_autor = dgvAutor[1, dgvAutor.CurrentRow.Index].Value.ToString();
                autores.nacionalidade_autor = dgvAutor[2, dgvAutor.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new AutorConsultar(_principal, autores));
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            labelDgv.Text = "";

            if (radioIdAutor.Checked)
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade where pk_id_autor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_autor", conectar);

            }

            else if (radioNomeAutor.Checked)
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade where nome_autor Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_autor", conectar);
            }

            else if (radioNacionalidadeAutor.Checked)
            {
                dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade where Nacionalidade.nome_nacionalidade Like'%" + metroTxtBoxPesquisar.Text + "%' order by pk_id_autor", conectar);
            }

            //Mostrando os cursos na grade
            datb = new DataTable();
            dados.Fill(datb);
            dgvAutor.DataSource = datb;

            //Verificando se a grade está vazia
            checarLinhasDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrando os cursos cadastrados no banco na grade
            dados = new SqlDataAdapter("select Autor.pk_id_autor, Autor.nome_autor, Nacionalidade.nome_nacionalidade from Autor inner join Nacionalidade on Autor.fk_id_nacionalidade_autor = Nacionalidade.pk_id_nacionalidade order by pk_id_autor", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvAutor.DataSource = datb;
            dgvAutor.Refresh();

            checarLinhasDgv();

            //Limpando as radiobutton
            radioIdAutor.Checked = false;
            radioNomeAutor.Checked = false;
            metroTxtBoxPesquisar.Clear();
        }
    }
}
