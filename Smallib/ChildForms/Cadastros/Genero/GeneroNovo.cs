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

namespace Smallib.ChildForms.Cadastros.Genero
{
    public partial class GeneroNovo : Form
    {
        string nome_genero, idstring;
        int pk_id_genero, id;

        Principal _principal;
        public GeneroNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de curso
                conectar.Open();
                SqlCommand obteridcurso = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_genero'", conectar);
                idstring = Convert.ToString(obteridcurso.ExecuteScalar());

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdGenero.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdGenero.Text = id.ToString();
                }
                conectar.Close();
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }
            txtBoxNomeGenero.Select();

            //Limitando o tamanho do campo nome do gênero
            txtBoxNomeGenero.MaxLength = 30;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new GeneroMenu(_principal));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Passando o valor digitado no campo de nome para a varíavel nome_genero
            nome_genero = txtBoxNomeGenero.Text;
            pk_id_genero = Convert.ToInt32(txtBoxIdGenero.Text);

            //Verificando se o genero ja existe no banco
            conectar.Open();
            SqlCommand verificar = new SqlCommand("Select * from Genero where nome_genero = '" + txtBoxNomeGenero.Text + "'", conectar);
            bool resultado = verificar.ExecuteReader().HasRows;

            conectar.Close();

            if (resultado == true)
            {
                MessageBox.Show("Este gênero já existe no banco de dados!!");
            }

            else
            {
                try
                {
                    conectar.Open();

                    //objeto da conexão
                    SqlCommand cadastrar_genero = new SqlCommand();

                    //condicional para realizar o cadastro
                    if (txtBoxNomeGenero.Text != "")
                    {
                        cadastrar_genero.CommandText = "INSERT INTO Genero (nome_genero) VALUES('" + nome_genero + "')";
                        
                        //Rodando o comando no banco de dados
                        cadastrar_genero.Connection = conectar;
                        cadastrar_genero.ExecuteNonQuery();

                        //MessageBox para informar o usuário que o registro foi bem sucessido
                        if (MessageBox.Show("Gênero criado com sucesso!", "Aviso:", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            //Limpando o campo
                            txtBoxNomeGenero.Text = "";

                            //Colocando o foco na textbox de nome do curso
                            txtBoxNomeGenero.Focus();

                            //Calculando o próximo ID
                            id += 1;
                            txtBoxIdGenero.Text = id.ToString();
                        }
                    }

                    //Caso o campo nome seja vazío
                    else
                    {
                        MessageBox.Show("Não foi possível criar o gênero, insira valores válidos", "Aviso:", MessageBoxButtons.OK);
                    }
                }

                //Tratamento de erros
                catch (SqlException error)
                {
                    //SqlException innerException = ex.InnerException as SqlException;
                    if (error != null && error.Number == 2627)
                    {
                        MessageBox.Show("Houve uma falha ao realizar o processo. Gênero " + nome_genero + " já existe!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível estabelecer conexão com o banco de dados." + Convert.ToString(error.Number));
                    }
                }

                conectar.Close();
            }
        }
    }
}
