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
using Smallib.ChildForms.Devolucoes;

namespace Smallib.ChildForms
{
    public partial class Devolucao : Form
    {
        private Principal _principal;

        Devolucao_Livro Devolucao_Livro = new Devolucao_Livro();

        void checarLinhasDgv()
        {
            if (dgvDevolucao.Rows.Count == 0)
            {
                labelDgv.Text = "Nenhum registro encontrado";
            }

            else
            {
                labelDgv.Text = "";
            }
        }

        void dadosEmprestimo()
        {
            try
            {
                dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, E.fk_id_leitor_emprestimo as fk_id_leitor_emprestimo, E.fk_id_livro_emprestimo as fk_id_livro_emprestimo, Le.nome_leitor as nome_leitor, Li.titulo_livro as titulo_livro, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo  from Emprestimo as E left join Leitor as Le on E.fk_id_leitor_emprestimo = Le.pk_id_leitor left join Livro as Li on E.fk_id_livro_emprestimo = Li.pk_id_livro where E.status_emprestimo = 0 ", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevolucao.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }

            checarLinhasDgv();
        }

        public Devolucao(Principal principal)
        {
            InitializeComponent();
            conectar.Close();

            dadosEmprestimo();
            _principal = principal;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            //Verificando se existe alguma linha da grade selecionada
            if (dgvDevolucao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum empréstimo selecionado");
                return;
            }
            else
            {

                //Armazenando os dados da linha  selecionada
                Devolucao_Livro.pk_id_emprestimo = Convert.ToInt32(dgvDevolucao[0, dgvDevolucao.CurrentRow.Index].Value.ToString());
                Devolucao_Livro.fk_id_leitor_emprestimo = Convert.ToInt32(dgvDevolucao[1, dgvDevolucao.CurrentRow.Index].Value.ToString());
                Devolucao_Livro.fk_id_livro_emprestimo = Convert.ToInt32(dgvDevolucao[2, dgvDevolucao.CurrentRow.Index].Value.ToString());
                Devolucao_Livro.nome_leitor = dgvDevolucao[3, dgvDevolucao.CurrentRow.Index].Value.ToString();
                Devolucao_Livro.titulo_livro = dgvDevolucao[4, dgvDevolucao.CurrentRow.Index].Value.ToString();
                Devolucao_Livro.dt_emprestimo = Convert.ToDateTime(dgvDevolucao[5, dgvDevolucao.CurrentRow.Index].Value.ToString());
                Devolucao_Livro.dt_dev_prev_emprestimo = Convert.ToDateTime(dgvDevolucao[6, dgvDevolucao.CurrentRow.Index].Value.ToString());
                //Abrindo a tela de devolução passando esses dados 
                _principal.OpenChildForm( new DevolucaoForm(_principal, Devolucao_Livro));

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se foi digitado algo na barra de pesquisa
            if (metroTxtBoxPesquisar.Text != "")
            {
                //Verificando se o radio button de id do empréstimo está selecionado
                if (radioIdEmprestimo.Checked)
                {
                    try
                    {
                        //Consultando os empréstimos em andamento no banco de dados filtrando por nome do leitor
                        dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, E.fk_id_leitor_emprestimo as fk_id_leitor_emprestimo, E.fk_id_livro_emprestimo as fk_id_livro_emprestimo, Le.nome_leitor as nome_leitor, Li.titulo_livro as titulo_livro, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo  from Emprestimo as E left join Leitor as Le on E.fk_id_leitor_emprestimo = Le.pk_id_leitor left join Livro as Li on E.fk_id_livro_emprestimo = Li.pk_id_livro where E.status_emprestimo = 0 and E.pk_id_emprestimo Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radio button de nome do leitor está selecionado
                else if (radioNomeLeitor.Checked)
                {
                    try
                    {
                        //Consultando os empréstimos em andamento no banco de dados filtrando por nome do leitor
                        dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, E.fk_id_leitor_emprestimo as fk_id_leitor_emprestimo, E.fk_id_livro_emprestimo as fk_id_livro_emprestimo, Le.nome_leitor as nome_leitor, Li.titulo_livro as titulo_livro, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo  from Emprestimo as E left join Leitor as Le on E.fk_id_leitor_emprestimo = Le.pk_id_leitor left join Livro as Li on E.fk_id_livro_emprestimo = Li.pk_id_livro where E.status_emprestimo = 0 and Le.nome_leitor Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //Verificando se o radio button de nome do livro está selecionado
                else if (radioTituloLivro.Checked)
                {
                    try
                    {
                        //Consultando os empréstimos em andamento no banco de dados filtrando por nome do livro
                        dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, E.fk_id_leitor_emprestimo as fk_id_leitor_emprestimo, E.fk_id_livro_emprestimo as fk_id_livro_emprestimo, Le.nome_leitor as nome_leitor, Li.titulo_livro as titulo_livro, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo  from Emprestimo as E left join Leitor as Le on E.fk_id_leitor_emprestimo = Le.pk_id_leitor left join Livro as Li on E.fk_id_livro_emprestimo = Li.pk_id_livro where E.status_emprestimo = 0 and Li.titulo_livro Like'%" + metroTxtBoxPesquisar.Text + "%'", conectar);
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
                    }
                }

                //se nenhum radioButton for selecionado
                else
                {
                    MessageBox.Show("Nenhuma opção de pesquisa selecionada");
                    return;
                }

                //Mostrando os empréstimos na grade
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevolucao.DataSource = datb;

                checarLinhasDgv();
            }
            else
            {
                MessageBox.Show("Nenhum dado inserido para pesquisa");
                return;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Consultando os empréstimos em andamento
            dadosEmprestimo();

            //Marcando o radio de id do empréstimo
            radioIdEmprestimo.Checked = true;

            //Limpando as radiobutton
            radioNomeLeitor.Checked = false;
            radioTituloLivro.Checked = false;
            metroTxtBoxPesquisar.Text = "";
        }

        private void radioIdEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            dadosEmprestimo();
        }
        private void radioNomeLeitor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, E.fk_id_leitor_emprestimo as fk_id_leitor_emprestimo, E.fk_id_livro_emprestimo as fk_id_livro_emprestimo, Le.nome_leitor as nome_leitor, Li.titulo_livro as titulo_livro, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo  from Emprestimo as E left join Leitor as Le on E.fk_id_leitor_emprestimo = Le.pk_id_leitor left join Livro as Li on E.fk_id_livro_emprestimo = Li.pk_id_livro where E.status_emprestimo = 0 order by nome_leitor", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevolucao.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }

        private void radioTituloLivro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dados = new SqlDataAdapter("select E.pk_id_emprestimo as pk_id_emprestimo, E.fk_id_leitor_emprestimo as fk_id_leitor_emprestimo, E.fk_id_livro_emprestimo as fk_id_livro_emprestimo, Le.nome_leitor as nome_leitor, Li.titulo_livro as titulo_livro, E.dt_emprestimo as dt_emprestimo, E.dt_dev_prev_emprestimo as dt_dev_prev_emprestimo  from Emprestimo as E left join Leitor as Le on E.fk_id_leitor_emprestimo = Le.pk_id_leitor left join Livro as Li on E.fk_id_livro_emprestimo = Li.pk_id_livro where E.status_emprestimo = 0 order by titulo_livro", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvDevolucao.DataSource = datb;
            }
            catch
            {
                MessageBox.Show("Erro ao realizar consulta no banco de dados!!");
            }
        }
    }
}
