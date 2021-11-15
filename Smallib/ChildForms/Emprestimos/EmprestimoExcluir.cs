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
    public partial class EmprestimoExcluir : Form
    {
        Principal _principal;
        public EmprestimoExcluir(Principal principal, Emprestimo_Livro emprestimo_livro)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;

            conectar.Open();

            SqlDataAdapter Leitor = new SqlDataAdapter("select pk_id_leitor, nome_leitor from Leitor order by nome_leitor", conectar);
            DataTable dtLeitor = new DataTable();
            Leitor.Fill(dtLeitor);
            comboBoxNomeLeitor.DataSource = dtLeitor;
            comboBoxNomeLeitor.ValueMember = "pk_id_leitor";
            comboBoxNomeLeitor.DisplayMember = "nome_leitor";

            SqlDataAdapter Livro = new SqlDataAdapter("select pk_id_livro, titulo_livro from Livro order by titulo_livro", conectar);
            DataTable dtLivro = new DataTable();
            Livro.Fill(dtLivro);
            comboBoxTituloLivro.DataSource = dtLivro;
            comboBoxTituloLivro.ValueMember = "pk_id_livro";
            comboBoxTituloLivro.DisplayMember = "titulo_livro";

            conectar.Close();

            DateTime emp = emprestimo_livro.dt_emprestimo;
            DateTime devPrev = emprestimo_livro.dt_dev_prev_emprestimo;
            DateTime dev;

            if (emprestimo_livro.dt_devolucao_emprestimo.ToShortDateString().ToString() != "01/01/0001")
            {
                dev = emprestimo_livro.dt_devolucao_emprestimo;
                txtBoxDataDevolucao.Text = dev.ToShortDateString();
            }
            else
            {
                txtBoxDataDevolucao.Text = "N/A";
            }

            txtBoxIdEmprestimo.Text = emprestimo_livro.pk_id_emprestimo.ToString();
            comboBoxNomeLeitor.Text = emprestimo_livro.nome_leitor;
            comboBoxTituloLivro.Text = emprestimo_livro.titulo_livro;
            txtBoxDataEmprestimo.Text = emp.ToShortDateString();
            txtBoxDevolucaoPrevista.Text = devPrev.ToShortDateString();
            txtBoxStatusEmprestimo.Text = emprestimo_livro.status_emprestimo.ToString();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EmprestimoMenu(_principal));
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxIdEmprestimo.Text);
            int nomeLeitor = Convert.ToInt32(comboBoxNomeLeitor.SelectedValue);
            int titulo = Convert.ToInt32(comboBoxTituloLivro.SelectedValue);

            try
            {
                conectar.Open();

                var excluirResp = MessageBox.Show("Tem certeza que deseja excluir o empréstimo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (excluirResp == DialogResult.Yes)
                {
                    SqlCommand excluir = new SqlCommand("DELETE FROM Emprestimo WHERE pk_id_emprestimo = " + id, conectar);
                    excluir.ExecuteNonQuery();

                    // muda o status do leitor e do livro
                    SqlCommand edtLeitor = new SqlCommand("UPDATE Leitor SET status_leitor = 0 WHERE pk_id_leitor=" + nomeLeitor + "; UPDATE Livro SET status_livro = 0 WHERE pk_id_livro =" + titulo, conectar);
                    edtLeitor.ExecuteNonQuery();

                    MessageBox.Show("Excluido com sucesso!");

                    _principal.OpenChildForm(new EmprestimoMenu(_principal));
                }

                conectar.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:\n" + erro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
