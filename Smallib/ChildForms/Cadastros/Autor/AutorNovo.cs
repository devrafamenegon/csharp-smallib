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
    public partial class AutorNovo : Form
    {
        int pk_id_autor, fk_id_nacionalidade_autor, id;
        string nome_autor, idstring;


        Principal _principal;


        public AutorNovo(Principal principal)
        {
            InitializeComponent();
            conectar.Close();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de curso
                conectar.Open();
                SqlCommand obteridcurso = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_autor'", conectar);
                idstring = Convert.ToString(obteridcurso.ExecuteScalar());

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdAutor.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdAutor.Text = id.ToString();
                }
                conectar.Close();
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }

            txtBoxNomeAutor.Select();

            //Limitando o tamanho do campo nome do curso
            txtBoxNomeAutor.MaxLength = 50;

            SqlDataAdapter Nacionalidade = new SqlDataAdapter("select pk_id_nacionalidade, nome_nacionalidade from Nacionalidade order by nome_nacionalidade", conectar);
            DataTable dtNacionalidade = new DataTable();
            Nacionalidade.Fill(dtNacionalidade);
            comboBoxNacionalidadeAutor.DataSource = dtNacionalidade;
            comboBoxNacionalidadeAutor.ValueMember = "pk_id_nacionalidade";
            comboBoxNacionalidadeAutor.DisplayMember = "nome_nacionalidade";

            comboBoxNacionalidadeAutor.SelectedIndex = -1;
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
                SqlCommand Cadastro_Autor = new SqlCommand();

                if (pk_id_autor != 0 && nome_autor != "" & comboBoxNacionalidadeAutor.SelectedIndex != -1)
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
                            Cadastro_Autor.CommandText = "INSERT INTO Autor (nome_autor, fk_id_nacionalidade_autor) VALUES('" + nome_autor + "', " + fk_id_nacionalidade_autor + ")";

                            //LOCAL ONDE SERÁ GUARDADO OS DADOS
                            Cadastro_Autor.Connection = conectar;
                            //EXECUTAR QUERY
                            Cadastro_Autor.ExecuteNonQuery();

                            MessageBox.Show("Cadastro efetuado com sucesso");
                        }

                    }

                    else
                    {
                        conectar.Close();
                        conectar.Open();

                        Cadastro_Autor.CommandText = "INSERT INTO Autor (nome_autor, fk_id_nacionalidade_autor) VALUES('" + nome_autor + "', " + fk_id_nacionalidade_autor + ")";

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Cadastro_Autor.Connection = conectar;
                        //EXECUTAR QUERY
                        Cadastro_Autor.ExecuteNonQuery();

                        MessageBox.Show("Cadastro efetuado com sucesso");
                    }

                    conectar.Close();
                   
                    txtBoxNomeAutor.Clear();
                    comboBoxNacionalidadeAutor.SelectedIndex = -1;
                }

                else
                {
                    MessageBox.Show("Erro ao cadastrar Autor, preencha todos os campos!");
                }

                //FECHAR CONEXÃO
                conectar.Close();

                //Limpando o campo
                txtBoxNomeAutor.Text = "";
                comboBoxNacionalidadeAutor.SelectedIndex = -1;

                //Colocando o foco na textbox de nome do curso
                txtBoxNomeAutor.Focus();

                //Calculando o próximo ID
                id += 1;
                txtBoxIdAutor.Text = id.ToString();
            }

            catch (SqlException ex)
            {
                /*//SqlException innerException = ex.InnerException as SqlException;
                if (ex != null && ex.Number == 2627)
                {
                    MessageBox.Show("Nacionalidade já existente!");
                    conectar.Close();
                }
                else
                {*/
                MessageBox.Show("NÃO FOI POSSIVEL CONECTAR COM O BANCO DE DADOS!!!" + ex.Number + Convert.ToString(ex));
                conectar.Close();
                //}
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new AutorMenu(_principal));
        }

    }
}
