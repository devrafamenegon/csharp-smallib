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

namespace Smallib.ChildForms.Cadastros.Nacionalidade
{
    public partial class NacionalidadeNovo : Form
    {
        int pk_id_nacionalidade, numeroDoId, id;
        string nome_nacionalidade, idstring;

        Principal _principal;

        public NacionalidadeNovo(Principal principal)
        {
            InitializeComponent();
            _principal = principal;

            try
            {
                //Consultando o ultimo auto incremento de nacionalidade
                conectar.Open();
                SqlCommand obteridcid = new SqlCommand("select last_value from sys.identity_columns where name = 'pk_id_nacionalidade'", conectar);
                idstring = Convert.ToString(obteridcid.ExecuteScalar());

                //Verificando se o valor retornado é nulo
                if (idstring == "")
                {
                    id = 1;
                    txtBoxIdNacionalidade.Text = id.ToString();
                }
                else
                {
                    //Calculando o próximo ID
                    id = Convert.ToInt32(idstring);
                    id = (id + 1);
                    txtBoxIdNacionalidade.Text = id.ToString();
                }
                conectar.Close();
            }
            catch
            {
                conectar.Close();
                MessageBox.Show("Erro ao consultar ID no banco de dados!!");
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _principal.OpenChildForm(new NacionalidadeMenu(_principal));
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome_nacionalidade = txtBoxNomeNacionalidade.Text;

            try
            {
                //Verificando se o genero ja existe no banco
                conectar.Open();
                SqlCommand verificar = new SqlCommand("Select * from Nacionalidade where nome_nacionalidade = '" + nome_nacionalidade + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    //Caso ja exista
                    conectar.Close();
                    MessageBox.Show("Esta nacionalidade já existe no banco de dados!!");
                }

                else
                {
                    //Caso não exista
                    conectar.Close();

                    //Código do insert ou alteração aqui

                    //abrindo a conexão
                    conectar.Open();
                    //objeto de conexao
                    SqlCommand Cadastro_Nacionalidade = new SqlCommand();

                    if (nome_nacionalidade != "")
                    {

                        Cadastro_Nacionalidade.CommandText = "INSERT INTO Nacionalidade (nome_nacionalidade) VALUES('" + nome_nacionalidade + "')";

                        //LOCAL ONDE SERÁ GUARDADO OS DADOS
                        Cadastro_Nacionalidade.Connection = conectar;

                        //EXECUTAR QUERY
                        Cadastro_Nacionalidade.ExecuteNonQuery();

                        MessageBox.Show("Cadastro efetuado com sucesso");

                        //Calculando o próximo ID
                        id += 1;
                        txtBoxIdNacionalidade.Text = id.ToString();
                        txtBoxNomeNacionalidade.Clear();
                        conectar.Close();
                    }

                    else
                    {
                        MessageBox.Show("Erro ao criar Nacionalidade, preencha todos os campos!");
                    }

                    //FECHAR CONEXÃO
                    conectar.Close();
                }
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
