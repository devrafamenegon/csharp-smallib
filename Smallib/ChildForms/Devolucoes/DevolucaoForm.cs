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

namespace Smallib.ChildForms.Devolucoes
{
    public partial class DevolucaoForm : Form
    {
        Principal _principal;
        int idemprestimo, idleitor, idlivro;

        public DevolucaoForm(Principal principal, Devolucao_Livro devolucao_Livro)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;

            DateTime dataHoraAtual = DateTime.Now;
            txtBoxDataDevolucao.Text = dataHoraAtual.ToShortDateString();

            idemprestimo = devolucao_Livro.pk_id_emprestimo;
            txtBoxIdEmprestimo.Text = devolucao_Livro.pk_id_emprestimo.ToString();
            txtBoxDataEmprestimo.Text = devolucao_Livro.dt_emprestimo.ToShortDateString();
            txtBoxDevolucaoPrevista.Text = devolucao_Livro.dt_dev_prev_emprestimo.ToShortDateString();
            comboBoxNomeLeitor.Text = devolucao_Livro.nome_leitor;
            comboBoxTituloLivro.Text = devolucao_Livro.titulo_livro;
            idleitor = devolucao_Livro.fk_id_leitor_emprestimo;
            idlivro = devolucao_Livro.fk_id_livro_emprestimo;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new Devolucao(_principal));
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            DateTime time;
            if (DateTime.TryParse(txtBoxDataDevolucao.Text, out time))
            {
                DateTime data = Convert.ToDateTime(txtBoxDataEmprestimo.Text);
                DateTime datadevempr = Convert.ToDateTime(txtBoxDataDevolucao.Text);
                int result = DateTime.Compare(data, datadevempr);

                if (result <= 0)
                {
                    //Messagebox para selecionar se deseja realmente realizar a devolução
                    DialogResult resp = MessageBox.Show("Tem certeza que deseja realizar a devolução do livro?", "Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resp == DialogResult.Yes)
                    {
                        //Devolver livro
                        try
                        {
                            conectar.Open();
                            SqlCommand alteraremprestimo = new SqlCommand("update Emprestimo set dt_devolucao_emprestimo=(@dtdevemprestimo), status_emprestimo=1 where pk_id_emprestimo=(@idemprestimo)", conectar);
                            alteraremprestimo.Parameters.Add(new SqlParameter("@dtdevemprestimo", datadevempr));
                            alteraremprestimo.Parameters.Add(new SqlParameter("@idemprestimo", idemprestimo));
                            alteraremprestimo.ExecuteNonQuery();
                            conectar.Close();
                        }
                        catch(Exception error)
                        {
                            conectar.Close();
                            MessageBox.Show($"Erro ao alterar dados do empréstimo!! {error}");
                            return;
                        }

                        try
                        {

                            conectar.Open();
                            SqlCommand alterarsttleitor = new SqlCommand("update Leitor set status_leitor = 0 where pk_id_leitor=(@idleitor)", conectar);
                            alterarsttleitor.Parameters.Add(new SqlParameter("@idleitor", idleitor));
                            alterarsttleitor.ExecuteNonQuery();
                            conectar.Close();
                        }
                        catch (Exception error)
                        {
                            conectar.Close();
                            MessageBox.Show($"Erro ao alterar dados do leitor!! {error}");
                            return;
                        }

                        try
                        {
                            conectar.Open();
                            SqlCommand alterarlivro = new SqlCommand("update Livro set status_livro=0, ultemprest_livro=(@ultemp_livro), ultleitor_livro=(@ultleitor_livro) where pk_id_livro=(@idlivro)", conectar);
                            alterarlivro.Parameters.Add(new SqlParameter("@ultemp_livro", data));
                            alterarlivro.Parameters.Add(new SqlParameter("@ultleitor_livro", idleitor));
                            alterarlivro.Parameters.Add(new SqlParameter("@idlivro", idlivro));
                            alterarlivro.ExecuteNonQuery();
                            conectar.Close();
                        }
                        catch (Exception error)
                        {
                            conectar.Close();
                            MessageBox.Show($"Erro ao alterar dados do livro!! {error}");
                            return;
                        }

                        MessageBox.Show("Devolução realizada com sucesso!!", "Devolvido");

                        _principal.OpenChildForm(new Devolucao(_principal));
                    }
                }
                else
                {
                    MessageBox.Show("A data de devolução não pode ser menor que a data do empréstimo");
                }
            }
            else
            {
                MessageBox.Show("Digite uma data de devolução válida!!");
            }
        }
    }
}
