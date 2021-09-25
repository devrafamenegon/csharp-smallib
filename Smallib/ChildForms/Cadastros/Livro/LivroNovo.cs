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
using System.Globalization;
using static Smallib.Program;

namespace Smallib.ChildForms.Cadastros.Livros
{
    public partial class LivroNovo : Form
    {
        int id, pk_id_livro, fk_id_editora_livro, fk_id_autor_livro, fk_id_genero_livro, fk_id_idioma_livro;
        string titulo_livro, tombo_livro, idstring;

        Principal _principal;

        public LivroNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            SqlDataAdapter Editora = new SqlDataAdapter("select pk_id_editora, nome_editora from Editora order by nome_editora", conectar);
            DataTable dtEditora = new DataTable();
            Editora.Fill(dtEditora);
            comboBoxEditoraLivro.DataSource = dtEditora;
            comboBoxEditoraLivro.ValueMember = "pk_id_editora";
            comboBoxEditoraLivro.DisplayMember = "nome_editora";

            comboBoxEditoraLivro.SelectedIndex = -1;

            SqlDataAdapter Autor = new SqlDataAdapter("select pk_id_autor, nome_autor from Autor order by nome_autor", conectar);
            DataTable dtAutor = new DataTable();
            Autor.Fill(dtAutor);
            comboBoxAutorLivro.DataSource = dtAutor;
            comboBoxAutorLivro.ValueMember = "pk_id_autor";
            comboBoxAutorLivro.DisplayMember = "nome_autor";

            comboBoxAutorLivro.SelectedIndex = -1;

            SqlDataAdapter Genero = new SqlDataAdapter("select pk_id_genero, nome_genero from Genero order by nome_genero", conectar);
            DataTable dtGenero = new DataTable();
            Genero.Fill(dtGenero);
            comboBoxGeneroLivro.DataSource = dtGenero;
            comboBoxGeneroLivro.ValueMember = "pk_id_genero";
            comboBoxGeneroLivro.DisplayMember = "nome_genero";

            comboBoxGeneroLivro.SelectedIndex = -1;

            SqlDataAdapter Idioma = new SqlDataAdapter("select pk_id_idioma, nome_idioma from Idioma order by nome_idioma", conectar);
            DataTable dtIdioma = new DataTable();
            Idioma.Fill(dtIdioma);
            comboBoxIdiomaLivro.DataSource = dtIdioma;
            comboBoxIdiomaLivro.ValueMember = "pk_id_idioma";
            comboBoxIdiomaLivro.DisplayMember = "nome_idioma";

            comboBoxIdiomaLivro.SelectedIndex = -1;

            conectar.Close();
            try
            {
                //Consultando o ultimo auto incremento de curso
                conectar.Open();
                SqlCommand obteridcid = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_livro'", conectar);
                string idstring = Convert.ToString(obteridcid.ExecuteScalar());

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdLivro.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdLivro.Text = id.ToString();
                }
                conectar.Close();
            }
            catch (Exception ex)
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!! \n" + ex);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new LivroMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            titulo_livro = txtBoxTituloLivro.Text;
            tombo_livro = txtBoxDataTomboLivro.Text;
            pk_id_livro = Convert.ToInt32(txtBoxIdLivro.Text);
            fk_id_editora_livro = Convert.ToInt32(comboBoxEditoraLivro.SelectedValue);
            fk_id_autor_livro = Convert.ToInt32(comboBoxAutorLivro.SelectedValue);
            fk_id_genero_livro = Convert.ToInt32(comboBoxGeneroLivro.SelectedValue);
            fk_id_idioma_livro = Convert.ToInt32(comboBoxIdiomaLivro.SelectedValue);


            try
            {

                //abrindo a conexão
                conectar.Open();
                //objeto de conexao
                SqlCommand Cadastro_Livro = new SqlCommand();

                DateTime d;

                bool chValidity = DateTime.TryParseExact(tombo_livro, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);

                if (chValidity)
                {

                    if (pk_id_livro != 0 && txtBoxTituloLivro.Text != "" && txtBoxDataTomboLivro.Text != "  /  /" && comboBoxEditoraLivro.SelectedIndex != -1 && comboBoxAutorLivro.SelectedIndex != -1 && comboBoxGeneroLivro.SelectedIndex != -1 && comboBoxIdiomaLivro.SelectedIndex != -1)
                    {
                        conectar.Close();
                        conectar.Open();

                        Cadastro_Livro.CommandText = "INSERT INTO Livro (titulo_livro, tombo_livro, fk_id_editora_livro, fk_id_autor_livro, fk_id_genero_livro, fk_id_idioma_livro, status_livro) VALUES('" + titulo_livro + "', '" + tombo_livro + "', " + fk_id_editora_livro + ", " + fk_id_autor_livro + ", " + fk_id_genero_livro + ", " + fk_id_idioma_livro + ", 0)";

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Cadastro_Livro.Connection = conectar;
                        //EXECUTAR QUERY
                        Cadastro_Livro.ExecuteNonQuery();

                        MessageBox.Show("Cadastro efetuado com sucesso");

                        conectar.Close();

                        id += 1;
                        txtBoxIdLivro.Text = id.ToString();
                        conectar.Close();
                        txtBoxTituloLivro.Clear();
                        txtBoxDataTomboLivro.Clear();
                        comboBoxEditoraLivro.SelectedIndex = -1;
                        comboBoxAutorLivro.SelectedIndex = -1;
                        comboBoxGeneroLivro.SelectedIndex = -1;
                        comboBoxIdiomaLivro.SelectedIndex = -1;
                    }

                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Livro, preencha todos os campos!");
                    }

                    //FECHAR CONEXÃO
                    conectar.Close();
                }

                else if (pk_id_livro == 0 || txtBoxTituloLivro.Text == "" || txtBoxDataTomboLivro.Text == "  /  /" || comboBoxEditoraLivro.SelectedIndex == -1 || comboBoxAutorLivro.SelectedIndex == -1 || comboBoxGeneroLivro.SelectedIndex == -1 || comboBoxIdiomaLivro.SelectedIndex == -1)
                {
                    MessageBox.Show("Erro ao cadastrar Livro, preencha todos os campos!");
                    conectar.Close();
                }

                else
                {
                    MessageBox.Show("Preencha a data em formato correto DD/MM/AAAA!");
                    conectar.Close();
                }
            }

            catch (SqlException ex)
            {
                SqlException innerException = ex.InnerException as SqlException;
                if (ex != null && ex.Number == 241)
                {
                    MessageBox.Show("Preencha a data em formato correto DD/MM/AAAA!");
                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("NÃO FOI POSSIVEL CONECTAR COM O BANCO DE DADOS!!!" + ex.Number + Convert.ToString(ex));
                    conectar.Close();
                }
            }
        }
    }
}
