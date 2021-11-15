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

namespace Smallib.ChildForms
{
    public partial class EmprestimoMenu : Form
    {
        Emprestimo_Livro Emprestimo_Livro = new Emprestimo_Livro();
        Principal _principal;

        void checarLinhasDgv()
        {
            if (dgvEmprestimo.Rows.Count == 0)
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
                //select com os inner joins para trazer os nomes das cidades e dos tipos
                dados = new SqlDataAdapter("select pk_id_emprestimo, Leitor.nome_leitor, Livro.titulo_livro, " +
                                           "dt_emprestimo, dt_dev_prev_emprestimo, dt_devolucao_emprestimo, status_emprestimo " +
                                           "from Emprestimo " +
                                           "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                           "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                           "ORDER BY pk_id_emprestimo", conectar);
                datb = new DataTable();
                dados.Fill(datb);
                dgvEmprestimo.DataSource = datb;
            }

            catch
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void armazenarDadosDasCelulas()
        {
            Emprestimo_Livro.pk_id_emprestimo = Convert.ToInt32(dgvEmprestimo[0, dgvEmprestimo.CurrentRow.Index].Value.ToString());
            Emprestimo_Livro.nome_leitor = dgvEmprestimo[1, dgvEmprestimo.CurrentRow.Index].Value.ToString();
            Emprestimo_Livro.titulo_livro = dgvEmprestimo[2, dgvEmprestimo.CurrentRow.Index].Value.ToString();
            Emprestimo_Livro.dt_emprestimo = Convert.ToDateTime(dgvEmprestimo[3, dgvEmprestimo.CurrentRow.Index].Value.ToString());
            Emprestimo_Livro.dt_dev_prev_emprestimo = Convert.ToDateTime(dgvEmprestimo[4, dgvEmprestimo.CurrentRow.Index].Value.ToString());
            Emprestimo_Livro.status_emprestimo = Convert.ToInt32(dgvEmprestimo[6, dgvEmprestimo.CurrentRow.Index].Value.ToString());
        }

        public EmprestimoMenu(Principal principal)
        {
            InitializeComponent();
            conectar.Close();

            dadosEmprestimo();
            checarLinhasDgv();

            _principal = principal;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            radioIdEmprestimo.Checked = true;
            radioNomeLeitor.Checked = false;
            radioTituloLivro.Checked = false;

            metroTxtBoxPesquisar.Text = "";

            dadosEmprestimo();
            checarLinhasDgv();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioIdEmprestimo.Checked || radioNomeLeitor.Checked || radioTituloLivro.Checked)
                {
                    if (radioIdEmprestimo.Checked)
                    {
                        dados = new SqlDataAdapter("select pk_id_emprestimo, Leitor.nome_leitor, Livro.titulo_livro, " +
                                           "dt_emprestimo, dt_dev_prev_emprestimo, dt_devolucao_emprestimo, status_emprestimo " +
                                           "from Emprestimo " +
                                           "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                           "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                           "where pk_id_emprestimo Like '%" + metroTxtBoxPesquisar.Text + "%'" +
                                           "ORDER BY pk_id_emprestimo", conectar);
                    }
                    if (radioNomeLeitor.Checked)
                    {
                        dados = new SqlDataAdapter("select pk_id_emprestimo, Leitor.nome_leitor, Livro.titulo_livro, " +
                                           "dt_emprestimo, dt_dev_prev_emprestimo, dt_devolucao_emprestimo, status_emprestimo " +
                                           "from Emprestimo " +
                                           "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                           "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                           "where Leitor.nome_leitor Like '%" + metroTxtBoxPesquisar.Text + "%'" +
                                           "ORDER BY Leitor.nome_leitor", conectar);
                    }
                    if (radioTituloLivro.Checked)
                    {
                        dados = new SqlDataAdapter("select pk_id_emprestimo, Leitor.nome_leitor, Livro.titulo_livro, " +
                                           "dt_emprestimo, dt_dev_prev_emprestimo, dt_devolucao_emprestimo, status_emprestimo " +
                                           "from Emprestimo " +
                                           "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                           "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                           "where Livro.titulo_livro Like '%" + metroTxtBoxPesquisar.Text + "%'" +
                                           "ORDER BY Livro.titulo_livro", conectar);
                    }

                    datb = new DataTable();
                    dados.Fill(datb);
                    dgvEmprestimo.DataSource = datb;

                    checarLinhasDgv();
                }
                else
                {
                    MessageBox.Show("Nada selecionado para pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados!\n" + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EmprestimoNovo(_principal));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            conectar.Open();

            armazenarDadosDasCelulas();

            SqlCommand status = new SqlCommand("SELECT pk_id_emprestimo, status_emprestimo FROM Emprestimo WHERE pk_id_emprestimo = '" + Emprestimo_Livro.pk_id_emprestimo + "' AND status_emprestimo = 1", conectar);
            SqlDataReader reader = status.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            reader.Close();
            conectar.Close();

            if (table.Rows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("O empréstimo escolhido já foi devolvido!", "Aviso!", MessageBoxButtons.OK);
            }

            else if (dgvEmprestimo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada!", "Aviso!");
            }

            else
            {
                armazenarDadosDasCelulas();

                _principal.OpenChildForm(new EmprestimoEditar(_principal, Emprestimo_Livro));
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conectar.Open();

            SqlCommand status = new SqlCommand("SELECT pk_id_emprestimo, dt_devolucao_emprestimo FROM Emprestimo WHERE pk_id_emprestimo = '" + Emprestimo_Livro.pk_id_emprestimo + "' AND dt_devolucao_emprestimo is null", conectar);
            SqlDataReader reader = status.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            reader.Close();
            conectar.Close();

            if (table.Rows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("O empréstimo escolhido ainda não foi devolvido!", "Aviso!", MessageBoxButtons.OK);
            }

            else if (dgvEmprestimo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha selecionada!", "Aviso!");
            }
            else
            {
                armazenarDadosDasCelulas();
                //Emprestimo_Livro.dt_devolucao_emprestimo = Convert.ToDateTime(dgvEmprestimo[5, dgvEmprestimo.CurrentRow.Index].Value.ToString());

                _principal.OpenChildForm(new EmprestimoExcluir(_principal, Emprestimo_Livro));
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            armazenarDadosDasCelulas();

            if(dgvEmprestimo[5, dgvEmprestimo.CurrentRow.Index].Value.ToString() != "")
            {
                Emprestimo_Livro.dt_devolucao_emprestimo = Convert.ToDateTime(dgvEmprestimo[5, dgvEmprestimo.CurrentRow.Index].Value.ToString());
            }

            _principal.OpenChildForm(new EmprestimoConsultar(_principal, Emprestimo_Livro));
        }

        private void radioIdEmprestimo_CheckedChanged(object sender, EventArgs e)
        {
            dadosEmprestimo();
        }

        private void radioNomeLeitor_CheckedChanged(object sender, EventArgs e)
        {
            //select com os inner joins para trazer os nomes das cidades e dos tipos
            dados = new SqlDataAdapter("select pk_id_emprestimo, Leitor.nome_leitor, Livro.titulo_livro, " +
                                       "dt_emprestimo, dt_dev_prev_emprestimo, dt_devolucao_emprestimo, status_emprestimo " +
                                       "from Emprestimo " +
                                       "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                       "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                       "ORDER BY Leitor.nome_leitor", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvEmprestimo.DataSource = datb;
        }

        private void radioTituloLivro_CheckedChanged(object sender, EventArgs e)
        {
            //select com os inner joins para trazer os nomes das cidades e dos tipos
            dados = new SqlDataAdapter("select pk_id_emprestimo, Leitor.nome_leitor, Livro.titulo_livro, " +
                                       "dt_emprestimo, dt_dev_prev_emprestimo, dt_devolucao_emprestimo, status_emprestimo " +
                                       "from Emprestimo " +
                                       "INNER JOIN Leitor ON Leitor.pk_id_leitor = Emprestimo.fk_id_leitor_emprestimo " +
                                       "INNER JOIN Livro ON Livro.pk_id_livro = Emprestimo.fk_id_livro_emprestimo " +
                                       "ORDER BY Livro.titulo_livro", conectar);
            datb = new DataTable();
            dados.Fill(datb);
            dgvEmprestimo.DataSource = datb;
        }
    }
}
