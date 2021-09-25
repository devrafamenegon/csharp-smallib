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

namespace Smallib.ChildForms.Cadastros.Idioma
{
    public partial class IdiomaNovo : Form
    {
        Principal _principal;

        int id;
        string nome_idioma, idstring;

        public IdiomaNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de curso
                conectar.Open();
                SqlCommand obteridcurso = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_idioma'", conectar);
                idstring = Convert.ToString(obteridcurso.ExecuteScalar());
                conectar.Close();

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdIdioma.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdIdioma.Text = id.ToString();
                }
                
            }
            catch
            {
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }

            txtBoxNomeIdioma.Select();

            //Limitando o tamanho do campo nome do curso
            txtBoxNomeIdioma.MaxLength = 30;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new IdiomaMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando o valor digitado no campo de nome para a varíavel nome_idioma
            nome_idioma = txtBoxNomeIdioma.Text;

            //Verificando se o idioma ja existe no banco
            conectar.Open();
            SqlCommand verificar = new SqlCommand("Select * from Idioma where nome_idioma = '" + txtBoxNomeIdioma.Text + "'", conectar);
            bool resultado = verificar.ExecuteReader().HasRows;

            if (resultado == true)
            {
                //Caso ja exista
                conectar.Close();
                MessageBox.Show("Este idioma já existe no banco de dados!!");
            }
            else
            {
                conectar.Close();

                try
                {
                    //abrindo conexão
                    conectar.Open();

                    //objeto da conexão
                    SqlCommand cadastrar_idioma = new SqlCommand();

                    //condicional para realizar o cadastro
                    if (txtBoxNomeIdioma.Text != "")
                    {
                        cadastrar_idioma.CommandText = "INSERT INTO Idioma (nome_idioma) VALUES('" + nome_idioma + "')";

                        //Rodando o comando no banco de dados
                        cadastrar_idioma.Connection = conectar;
                        cadastrar_idioma.ExecuteNonQuery();

                        //MessageBox para informar o usuário que o registro foi bem sucessido
                        if (MessageBox.Show("Idioma criado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            //Limpando o campo
                            txtBoxNomeIdioma.Text = "";

                            //Colocando o foco na textbox de nome do curso
                            txtBoxNomeIdioma.Focus();

                            //Calculando o próximo ID
                            id += 1;
                            txtBoxIdIdioma.Text = id.ToString();
                        }
                    }

                    //Caso o campo nome seja vazío
                    else
                    {
                        MessageBox.Show("Não foi possível criar o idioma, insira valores válidos", "Aviso:", MessageBoxButtons.OK);
                    }
                }

                //Tratamento de erros
                catch (SqlException error)
                {
                    //SqlException innerException = ex.InnerException as SqlException;
                    if (error != null && error.Number == 2627)
                    {
                        MessageBox.Show("Houve uma falha ao realizar o processo. Idioma " + nome_idioma + " já existe!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados. Erro n°" + Convert.ToString(error.Number));
                    }
                }
            }

            conectar.Close();
        }
    }
}
