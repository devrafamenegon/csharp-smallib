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
    public partial class EmprestimoEditar : Form
    {
        Principal _principal;

        int statusLeitor;
        int statusLivro;
        int comparacao;

        void MenssagensDeErro()
        {
            int idEmp = Convert.ToInt32(txtBoxIdEmprestimo.Text);
            int nomeLeitor = Convert.ToInt32(comboBoxNomeLeitor.SelectedValue);
            int titulo = Convert.ToInt32(comboBoxTituloLivro.SelectedValue);
            string dataEmp = txtBoxDataEmprestimo.Text;
            string dataEmpPrev = txtBoxDevolucaoPrevista.Text;

            statusLeitor = 0;
            statusLivro = 0;

            SqlCommand cmdLeitor = new SqlCommand("SELECT status_leitor FROM Leitor WHERE pk_id_leitor = " + comboBoxNomeLeitor.SelectedValue, conectar);
            SqlDataReader readerLeitor = cmdLeitor.ExecuteReader();

            if (readerLeitor.Read())
            {
                statusLeitor = Convert.ToInt32(readerLeitor.GetValue(0));
            }

            readerLeitor.Close();

            if (statusLeitor == 1)
            {
                MessageBox.Show("O Leitor já tem um livro emprestado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlCommand cmdLivro = new SqlCommand("SELECT status_livro FROM Livro WHERE pk_id_livro = " + comboBoxTituloLivro.SelectedValue, conectar);
            SqlDataReader readerLivro = cmdLivro.ExecuteReader();

            if (readerLivro.Read())
            {
                statusLivro = Convert.ToInt32(readerLivro.GetValue(0));
            }
            readerLivro.Close();

            if (statusLivro == 1)
            {
                MessageBox.Show("O Livro já está emprestado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (txtBoxDataEmprestimo.Text == "" || txtBoxDataEmprestimo.Text == null)
            {
                // muda o status do leitor
                SqlCommand edtClasse = new SqlCommand("UPDATE Leitor SET status_leitor = 1 WHERE pk_id_leitor=" + nomeLeitor, conectar);
                edtClasse.ExecuteNonQuery();
                // muda o status do livro
                SqlCommand edtLivro = new SqlCommand("UPDATE Livro SET status_livro = 1 WHERE pk_id_livro =" + titulo, conectar);
                edtLivro.ExecuteNonQuery();

                MessageBox.Show("A Data de Emprestimo está vazia!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtBoxDevolucaoPrevista.Text == "" || txtBoxDevolucaoPrevista.Text == null)
            {
                // muda o status do leitor
                SqlCommand edtClasse = new SqlCommand("UPDATE Leitor SET status_leitor = 1 WHERE pk_id_leitor=" + nomeLeitor, conectar);
                edtClasse.ExecuteNonQuery();
                // muda o status do livro
                SqlCommand edtLivro = new SqlCommand("UPDATE Livro SET status_livro = 1 WHERE pk_id_livro =" + titulo, conectar);
                edtLivro.ExecuteNonQuery();

                MessageBox.Show("A Data de Devolução Prevista está vazia!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DateTime emp = DateTime.Parse(txtBoxDataEmprestimo.Text);
            DateTime devPrev = DateTime.Parse(txtBoxDevolucaoPrevista.Text);

            comparacao = DateTime.Compare(emp, devPrev);

            if (comparacao >= 0)
            {
                // muda o status do leitor
                SqlCommand edtClasse = new SqlCommand("UPDATE Leitor SET status_leitor = 1 WHERE pk_id_leitor=" + nomeLeitor, conectar);
                edtClasse.ExecuteNonQuery();
                // muda o status do livro
                SqlCommand edtLivro = new SqlCommand("UPDATE Livro SET status_livro = 1 WHERE pk_id_livro =" + titulo, conectar);
                edtLivro.ExecuteNonQuery();

                MessageBox.Show("A Data de Devolução Prevista esta menor ou igual a Data de Emprestimo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public EmprestimoEditar(Principal principal, Emprestimo_Livro emprestimo_livro)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;

            comboBoxNomeLeitor.Enabled = false;

            // Dados ComboBox
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

            txtBoxIdEmprestimo.Text = emprestimo_livro.pk_id_emprestimo.ToString();
            comboBoxNomeLeitor.Text = emprestimo_livro.nome_leitor;
            comboBoxTituloLivro.Text = emprestimo_livro.titulo_livro;

            DateTime emp = emprestimo_livro.dt_emprestimo;
            DateTime devPrev = emprestimo_livro.dt_dev_prev_emprestimo;

            txtBoxDataEmprestimo.Text = emp.ToShortDateString();
            txtBoxDevolucaoPrevista.Text = devPrev.ToShortDateString();

            int idEmp = Convert.ToInt32(txtBoxIdEmprestimo.Text);
            int nomeLeitor = Convert.ToInt32(comboBoxNomeLeitor.SelectedValue);
            int titulo = Convert.ToInt32(comboBoxTituloLivro.SelectedValue);

            conectar.Open();

            // muda o status do leitor
            SqlCommand edtClasse = new SqlCommand("UPDATE Leitor SET status_leitor = 0 WHERE pk_id_leitor=" + nomeLeitor, conectar);
            edtClasse.ExecuteNonQuery();

            // muda o status do livro
            SqlCommand edtLivro = new SqlCommand("UPDATE Livro SET status_livro = 0 WHERE pk_id_livro =" + titulo, conectar);
            edtLivro.ExecuteNonQuery();
            conectar.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EmprestimoMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();

                MenssagensDeErro();

                int idEmp = Convert.ToInt32(txtBoxIdEmprestimo.Text);
                int nomeLeitor = Convert.ToInt32(comboBoxNomeLeitor.SelectedValue);
                int titulo = Convert.ToInt32(comboBoxTituloLivro.SelectedValue);
                string dataEmp = txtBoxDataEmprestimo.Text;
                string dataEmpPrev = txtBoxDevolucaoPrevista.Text;

                if (statusLeitor == 0 && statusLivro == 0 && txtBoxDataEmprestimo.Text != "" && txtBoxDataEmprestimo.Text != null && txtBoxDevolucaoPrevista.Text != "" && txtBoxDevolucaoPrevista.Text != null && comparacao < 0)
                {

                    // edita o emprestimo
                    SqlCommand editar = new SqlCommand("UPDATE Emprestimo SET fk_id_livro_emprestimo = " + titulo + ", fk_id_leitor_emprestimo = " + nomeLeitor + ", dt_emprestimo = '" + dataEmp + "', dt_dev_prev_emprestimo = '" + dataEmpPrev + "' WHERE pk_id_emprestimo =" + idEmp, conectar);
                    editar.ExecuteNonQuery();
                    // muda o status do leitor
                    SqlCommand edtClasse = new SqlCommand("UPDATE Leitor SET status_leitor = 1 WHERE pk_id_leitor=" + nomeLeitor, conectar);
                    edtClasse.ExecuteNonQuery();
                    // muda o status do livro
                    SqlCommand edtLivro = new SqlCommand("UPDATE Livro SET status_livro = 1 WHERE pk_id_livro =" + titulo, conectar);
                    edtLivro.ExecuteNonQuery();

                    MessageBox.Show("Emprestimo realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _principal.OpenChildForm(new EmprestimoMenu(_principal));
                }

                conectar.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:\n" + erro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxDevolucaoPrevista_TextChanged(object sender, EventArgs e)
        {
            txtBoxDevolucaoPrevista.Text = null;
        }
    }
}
