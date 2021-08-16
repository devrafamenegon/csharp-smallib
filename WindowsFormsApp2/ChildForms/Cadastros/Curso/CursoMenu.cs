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

namespace Smallib.ChildForms.Cadastros.Curso
{
    public partial class CursoMenu : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog = BIBLIOTECA; Integrated Security = True");
        SqlDataAdapter dados; //uma das classes que auxilia na recuperação de dados
        SqlCommandBuilder cmd; //mostra os códigos SQL
        DataTable datb; //DataTable é quem vai receber os dados do adapter

        //Criando um objeto da classe curso
        Cadastro_Curso curso = new Cadastro_Curso();

        Principal _principal;

        public CursoMenu(Principal principal)
        {
            InitializeComponent();

            //Consultando os cursos no banco de dados
            dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso order by pk_id_curso", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvCurso.DataSource = datb;
            dgvCurso.Refresh();

            if (dgvCurso.Rows.Count == 0)
            {

                labelDtgv.Text = "Nenhum registro encontrado";

            }

            _principal = principal;
        }

        private void radioIdCurso_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void radioNomeCurso_CheckedChanged(object sender, EventArgs e)
        {
            //Liberando o campo de pesquisa
            metroTxtBoxPesquisar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Mostrando os cursos cadastrados no banco na grade
            dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso order by pk_id_curso", conectar);
            datb = new DataTable();
            dados.Fill(datb);

            //Mostrando os cursos na grade
            dgvCurso.DataSource = datb;
            dgvCurso.Refresh();

            if (dgvCurso.Rows.Count == 0)
            {

                labelDtgv.Text = "Nenhum registro encontrado";

            }

            //Limpando as radiobutton
            radioIdCurso.Checked = false;
            radioNomeCurso.Checked = false;
            metroTxtBoxPesquisar.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se foi digitado algo na barra de pesquisa
            if (metroTxtBoxPesquisar.Text != "")
            {
                //Verificando se o radio button de id do curso está selecionado
                if (radioIdCurso.Checked)
                {
                    try
                    {
                        //Consultando os cursos no banco de dados filtrando por id
                        dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso where pk_id_curso Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radio button de nome do curso está selecionado
                else if (radioNomeCurso.Checked)
                {
                    try
                    {
                        //Consultando os cursos no banco de dados filtrando por nome
                        dados = new SqlDataAdapter("select pk_id_curso, nome_curso from Curso where nome_curso Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Mostrando os cursos na grade
                datb = new DataTable();
                dados.Fill(datb);
                dgvCurso.DataSource = datb;

                //Verificando se a grade está vazia
                if (dgvCurso.RowCount == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum curso com este filtro");
                }

            }

            else
            {
                MessageBox.Show("Nenhum dado inserido para pesquisa");
                return;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new CursoNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para edição");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                curso.pk_id_curso = Convert.ToInt32(dgvCurso[0, dgvCurso.CurrentRow.Index].Value.ToString());
                curso.nome_curso = dgvCurso[1, dgvCurso.CurrentRow.Index].Value.ToString();
                
                //Abrindo a tela de edição passando esses dados 
                _principal.OpenChildForm(new CursoEditar(_principal, curso));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                curso.pk_id_curso = Convert.ToInt32(dgvCurso[0, dgvCurso.CurrentRow.Index].Value.ToString());
                curso.nome_curso = dgvCurso[1, dgvCurso.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de exclusão passando esses dados 
                _principal.OpenChildForm(new CursoExcluir(_principal, curso));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para consulta");
                return;
            }
            else
            {
                //Armazenando os dados da linha da célula selecionada
                curso.pk_id_curso = Convert.ToInt32(dgvCurso[0, dgvCurso.CurrentRow.Index].Value.ToString());
                curso.nome_curso = dgvCurso[1, dgvCurso.CurrentRow.Index].Value.ToString();

                //Abrindo a tela de consulta passando esses dados 
                _principal.OpenChildForm(new CursoConsultar(_principal, curso));
            }
        }
    }
}
