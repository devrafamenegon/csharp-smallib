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
    public partial class EmprestimoNovo : Form
    {
        Principal _principal;
        int id;
        int statusLeitor;
        int statusLivro;
        int comparacao;

        void MostrarNomeLeitor()
        {
            try
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand("SELECT pk_id_leitor, nome_leitor FROM Leitor ORDER BY nome_leitor", conectar);
                SqlDataReader reader = cmd.ExecuteReader(); // retorna os dados da consulta
                DataTable table = new DataTable(); // estrutura da tabela do banco de dados
                table.Load(reader); // carrega os dados na tabela
                DataRow row = table.NewRow(); // Representa uma linha de dados
                row["nome_leitor"] = "";
                table.Rows.InsertAt(row, 0); // insere uma nova linha na coleção no local especificado

                comboBoxNomeLeitor.DisplayMember = "nome_leitor";
                comboBoxNomeLeitor.ValueMember = "pk_id_leitor";
                comboBoxNomeLeitor.DataSource = table;

                reader.Close();
                reader.Dispose();
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar banco de dados! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conectar.Close();
            }
        }

        void MostrarNomeLivro()
        {
            try
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand("SELECT pk_id_livro, titulo_livro FROM Livro ORDER BY titulo_livro", conectar);
                SqlDataReader reader = cmd.ExecuteReader(); // retorna os dados da consulta
                DataTable table = new DataTable(); // estrutura da tabela do banco de dados
                table.Load(reader); // carrega os dados na tabela
                DataRow row = table.NewRow(); // Representa uma linha de dados
                row["titulo_livro"] = "";
                table.Rows.InsertAt(row, 0); // insere uma nova linha na coleção no local especificado

                comboBoxTituloLivro.DisplayMember = "titulo_livro";
                comboBoxTituloLivro.ValueMember = "pk_id_livro";
                comboBoxTituloLivro.DataSource = table;

                reader.Close();
                reader.Dispose();
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar banco de dados! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conectar.Close();
            }
        }

        void ChecarTipoLeitor()
        {
            try
            {
                conectar.Open();
                var id = comboBoxNomeLeitor.SelectedValue;
                SqlCommand cmd = new SqlCommand("select Tipo.nome_tipo, Leitor.classe_leitor from Tipo" +
                                                " inner join Leitor on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo" +
                                                " where Tipo.nome_tipo = 'Aluno' and Leitor.pk_id_leitor = " + Convert.ToInt16(id), conectar);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                reader.Close();

                if (table.Rows.Count >= 1)
                {
                    txtBoxClasseLeitor.Enabled = false;
                }
                else
                {
                    txtBoxClasseLeitor.Text = null;
                    txtBoxClasseLeitor.Enabled = false;
                }

                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar banco de dados! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conectar.Close();
            }
        }

        void MensagensDeErro()
        {
            conectar.Close();
            conectar.Open();

            statusLeitor = 0;
            statusLivro = 0;

            SqlCommand cmdLeitor = new SqlCommand("SELECT status_leitor FROM Leitor WHERE pk_id_leitor = " + comboBoxNomeLeitor.SelectedValue, conectar);
            SqlDataReader readerLeitor = cmdLeitor.ExecuteReader();

            if (readerLeitor.Read())
            {
                statusLeitor = Convert.ToInt32(readerLeitor.GetValue(0));
            }

            if (statusLeitor == 1)
            {
                MessageBox.Show("O Leitor já tem um livro emprestado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            readerLeitor.Close();

            SqlCommand cmdLivro = new SqlCommand("SELECT status_livro FROM Livro WHERE pk_id_livro = " + comboBoxTituloLivro.SelectedValue, conectar);
            SqlDataReader readerLivro = cmdLivro.ExecuteReader();

            if (readerLivro.Read())
            {
                statusLivro = Convert.ToInt32(readerLivro.GetValue(0));
            }

            if (statusLivro == 1)
            {
                MessageBox.Show("O Livro já está emprestado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            readerLivro.Close();

            if (txtBoxDataEmprestimo.Text == "" || txtBoxDataEmprestimo.Text == null)
            {
                MessageBox.Show("A Data de Emprestimo está vazia!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBoxNomeLeitor.Text == "" || comboBoxNomeLeitor.Text == null)
            {
                MessageBox.Show("O nome do leitor está vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (comboBoxTituloLivro.Text == "" || comboBoxTituloLivro.Text == null)
            {
                MessageBox.Show("O nome do livro está vazio!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtBoxDevolucaoPrevista.Text == "" || txtBoxDevolucaoPrevista.Text == null)
            {
                MessageBox.Show("A Data de Emprestimo está vazia!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DateTime emp = DateTime.Parse(txtBoxDataEmprestimo.Text); 
            DateTime devPrev = DateTime.Parse(txtBoxDevolucaoPrevista.Text);

            comparacao = DateTime.Compare(emp, devPrev);

            if (comparacao >= 0)
            {
                MessageBox.Show("A Data de Devolução Prevista esta menor ou igual a Data de Emprestimo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            conectar.Close();
        }

        public EmprestimoNovo(Principal principal)
        {
            InitializeComponent();
            conectar.Close();

            _principal = principal;

            DateTime hoje = DateTime.Today;
            DateTime emp_prev = hoje.AddDays(7);
            txtBoxDataEmprestimo.Text = hoje.ToString("dd/MM/yyyy");
            txtBoxDevolucaoPrevista.Text = emp_prev.ToString("dd/MM/yyyy");

            MostrarNomeLeitor();
            MostrarNomeLivro();

            SqlDataReader reader = null;
            try
            {
                decimal resultado;
                conectar.Open();

                SqlCommand calcularid = new SqlCommand("SELECT case when count(*) = 0 then 0 else ident_current('Emprestimo') end from Emprestimo", conectar);
                reader = calcularid.ExecuteReader();

                if (reader.Read())
                {
                    resultado = reader.GetDecimal(0) + 1;
                    string idstring = resultado.ToString();
                    txtBoxIdEmprestimo.Text = idstring;
                    id = Int32.Parse(idstring);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao consultar dados no banco de dados!");
                conectar.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conectar != null)
                {
                    conectar.Close();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try // Verificar se o leitor tem um livro emprestado
            {
                conectar.Close();

                conectar.Open();
                MensagensDeErro();

                int nomeLeitor = Convert.ToInt32(comboBoxNomeLeitor.SelectedValue);
                int titulo = Convert.ToInt32(comboBoxTituloLivro.SelectedValue);
                string dataEmp = txtBoxDataEmprestimo.Text;
                string dataEmpPrev = txtBoxDevolucaoPrevista.Text;
                string classe = txtBoxClasseLeitor.Text;
                int idgenero = 0;

                conectar.Open();

                SqlCommand buscarGeneroLivro = new SqlCommand("select fk_id_genero_livro from Livro where pk_id_livro = " + titulo, conectar);
                SqlDataReader generoLivro = buscarGeneroLivro.ExecuteReader();

                while (generoLivro.Read())
                {
                    var objgenero = generoLivro.GetValue(0);
                    idgenero =Convert.ToInt32(objgenero);
                }

                conectar.Close();

                if (statusLeitor == 0 && statusLivro == 0 && txtBoxDataEmprestimo.Text != "" && txtBoxDataEmprestimo.Text != null && comboBoxTituloLivro.Text != "" && comboBoxTituloLivro.Text != null && comparacao < 0 && comboBoxNomeLeitor.Text != "" && comboBoxTituloLivro.Text != "")
                {
                    SqlCommand comando = new SqlCommand("INSERT INTO Emprestimo(fk_id_leitor_emprestimo," +
                    " fk_id_livro_emprestimo, fk_id_genero_emprestimo, dt_emprestimo, dt_dev_prev_emprestimo, status_emprestimo)" +
                    " VALUES (" + nomeLeitor + "," + titulo + ", " + idgenero + ", '" + dataEmp + "','" + dataEmpPrev + "', 0)", conectar);
                    
                    conectar.Open();
                    SqlDataReader salvar = comando.ExecuteReader();
                    salvar.Close();

                    SqlCommand edtClasse = new SqlCommand("UPDATE Leitor SET classe_leitor ='" + classe + "', status_leitor = 1 WHERE pk_id_leitor=" + nomeLeitor, conectar);
                    edtClasse.ExecuteNonQuery();

                    SqlCommand edtLivro = new SqlCommand("UPDATE Livro SET status_livro = 1 WHERE pk_id_livro =" + titulo, conectar);
                    edtLivro.ExecuteNonQuery();

                    MessageBox.Show("Emprestimo realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id += 1;
                    txtBoxIdEmprestimo.Text = id.ToString();

                    comboBoxNomeLeitor.SelectedIndex = 0;
                    comboBoxTituloLivro.SelectedIndex = 0;
                    txtBoxClasseLeitor.Text = null;
                    comboBoxTituloLivro.Focus();
                }

                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conectar.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new EmprestimoMenu(_principal));
        }

        private void comboBoxNomeLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            conectar.Close();
            ChecarTipoLeitor();

            try
            {
                conectar.Open();

                var id = comboBoxNomeLeitor.SelectedValue;
                SqlCommand cmd = new SqlCommand("select Tipo.nome_tipo, Leitor.classe_leitor from Tipo" +
                                                " inner join Leitor on Leitor.fk_id_tipo_leitor = Tipo.pk_id_tipo" +
                                                " where Tipo.nome_tipo = 'Aluno' and Leitor.pk_id_leitor = " + Convert.ToInt16(id), conectar); // Comando Sql
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // Mostra a classe do leitor
                {
                    while (reader.Read())
                    {
                        txtBoxClasseLeitor.Text = reader.GetString(1);
                    }
                }

                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar banco de dados! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
