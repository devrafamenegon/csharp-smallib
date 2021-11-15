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

namespace Smallib.ChildForms.Cadastros.Autores
{
    public partial class AutorEditar : Form
    {
        string nome_autor;
        int pk_id_autor, fk_id_nacionalidade_autor;

        Principal _principal;

        public AutorEditar(Principal principal, Cadastro_Autor cadastro_autores_01)
        {
            InitializeComponent();
            conectar.Close();
            _principal = principal;

            SqlDataAdapter Nacionalidade = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by nome_nacionalidade", conectar);
            DataTable dtNacionalidade = new DataTable();
            Nacionalidade.Fill(dtNacionalidade);
            comboBoxNacionalidadeAutor.DataSource = dtNacionalidade;
            comboBoxNacionalidadeAutor.ValueMember = "pk_id_nacionalidade";
            comboBoxNacionalidadeAutor.DisplayMember = "nome_nacionalidade";

            txtBoxIdAutor.Text = cadastro_autores_01.pk_id_autor.ToString();
            txtBoxNomeAutor.Text = cadastro_autores_01.nome_autor;
            comboBoxNacionalidadeAutor.Text = cadastro_autores_01.nacionalidade_autor;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome_autor = txtBoxNomeAutor.Text;
            pk_id_autor = Convert.ToInt32(txtBoxIdAutor.Text);
            fk_id_nacionalidade_autor = Convert.ToInt32(comboBoxNacionalidadeAutor.SelectedValue);

            try
            {

                //abrindo a conexão
                conectar.Open();
                //objeto de conexao
                SqlCommand Editar_Autor = new SqlCommand();

                if (txtBoxNomeAutor.Text != null && nome_autor != "" && txtBoxIdAutor.Text != "" && comboBoxNacionalidadeAutor.SelectedIndex != -1)
                {

                    SqlCommand Consulta = new SqlCommand("select * from Autor where nome_autor = '" + nome_autor + "' AND fk_id_nacionalidade_autor = " + fk_id_nacionalidade_autor, conectar);
                    bool resultado = Consulta.ExecuteReader().HasRows;

                    if (resultado == true)
                    {
                        conectar.Close();

                        DialogResult resp = MessageBox.Show("Já existe um Autor registrado com mesmo Nome e Nacionalidade. Deseja duplicar o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (resp == DialogResult.Yes)
                        {
                            conectar.Open();

                            Editar_Autor.CommandText = "update Autor set nome_Autor = '" + txtBoxNomeAutor.Text + "', fk_id_nacionalidade_autor = " + fk_id_nacionalidade_autor + " Where pk_id_autor = " + pk_id_autor;

                            //LOCAL ONDE SERÁ GUARDADO OS DADOS
                            Editar_Autor.Connection = conectar;

                            //EXECUTAR QUERY
                            Editar_Autor.ExecuteNonQuery();

                            MessageBox.Show("Edição efetuada com sucesso");
                            txtBoxIdAutor.Clear();
                            txtBoxNomeAutor.Clear();

                            _principal.OpenChildForm(new AutorMenu(_principal));
                        }
                    }
                    else
                    {
                        conectar.Close();
                        conectar.Open();
                        Editar_Autor.CommandText = "update Autor set nome_Autor = '" + txtBoxNomeAutor.Text + "', fk_id_nacionalidade_autor = " + fk_id_nacionalidade_autor + " Where pk_id_autor = " + pk_id_autor;

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Editar_Autor.Connection = conectar;

                        //EXECUTAR QUERY
                        Editar_Autor.ExecuteNonQuery();

                        MessageBox.Show("Edição efetuada com sucesso");
                        txtBoxIdAutor.Clear();
                        txtBoxNomeAutor.Clear();

                        _principal.OpenChildForm(new AutorMenu(_principal));
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao editar Autor! Preencha todos os campos.");

                }

                conectar.Close();


            }
            catch (SqlException ex)
            {
                //SqlException innerException = ex.InnerException as SqlException;
                if (ex != null && ex.Number == 2627)
                {
                    MessageBox.Show("Nacionalidade já existente!");
                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("NÃO FOI POSSIVEL CONECTAR COM O BANCO DE DADOS!!!" + Convert.ToString(ex.Number));
                }
            }
        }
    }
}
